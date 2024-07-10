using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient;
        private static IPAddress remoteIPAddress;
        private static int remotePort;
        private static int localPort;
        private static UTF8Encoding objUtf8;
        private static string strCryptoKey = "!i~6ox1i@]t2K'y$";
        private static string strCryptoIV = "!~x7Oq{6+q1@#VI$";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            objUtf8 = new UTF8Encoding();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            btn_OK_Reset.Enabled = !string.IsNullOrEmpty(tb_LocalPort.Text) &&
                                   !string.IsNullOrEmpty(tb_RemotePort.Text) &&
                                   !string.IsNullOrEmpty(tb_RemoteIP.Text) &&
                                   !string.IsNullOrEmpty(tb_Name.Text);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            try
            {
                localPort = Convert.ToInt32(tb_LocalPort.Text);

                remotePort = Convert.ToInt32(tb_RemotePort.Text);

                if (remotePort <= 0 || remotePort > 65535 || localPort <= 0 || localPort > 65535)
                {
                    MessageBox.Show($"Port is invalid");
                    return;
                }

                remoteIPAddress = IPAddress.Parse(tb_RemoteIP.Text);

                new Thread(Receiver).Start();

                tb_LocalPort.ReadOnly = true;
                tb_RemotePort.ReadOnly = true;
                tb_RemoteIP.ReadOnly = true;
                tb_Name.ReadOnly = true;

                btn_OK_Reset.Text = "Reset";
                btn_OK_Reset.Click -= btn_OK_Click;
                btn_OK_Reset.Click += btn_Reset_Click;

                tb_Message.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            btn_OK_Reset.Text = "Ok";
            btn_OK_Reset.Click -= btn_Reset_Click;
            btn_OK_Reset.Click += btn_OK_Click;

            tb_Message.Text = string.Empty;
            tb_Message.ReadOnly = true;

            tb_LocalPort.ReadOnly = false;
            tb_RemotePort.ReadOnly = false;
            tb_RemoteIP.ReadOnly = false;
            tb_Name.ReadOnly = false;

            tb_LocalPort.Text = string.Empty;
            tb_RemotePort.Text = string.Empty;
            tb_Name.Text = string.Empty;
            tb_Chat.Text = string.Empty;
        }

        private void Send(string message, string name)
        {
            using (UdpClient sender = new UdpClient())
            {
                IPEndPoint endPoint = new IPEndPoint(remoteIPAddress, remotePort);
                try
                {
                    byte[] bytes = EncryptData($"{name}: {message}");
                    sender.Send(bytes, bytes.Length, endPoint);

                    Invoke(new Action(() => tb_Chat.AppendText(name + ": " + message + Environment.NewLine)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending UDP message: {ex.Message}");
                }
            }
        }

        private void Receiver()
        {
            IPEndPoint endPoint = new IPEndPoint(remoteIPAddress, localPort);
            udpClient = new UdpClient(endPoint);
            while (true)
            {
                try
                {
                    byte[] bytes = udpClient.Receive(ref endPoint);
                    string message = DecryptData(bytes);
                    Invoke(new Action(() => tb_Chat.AppendText(message + Environment.NewLine)));
                }
                catch (Exception ex)
                {
                    Invoke(new Action(() => MessageBox.Show($"Error receiving UDP message: {ex.Message}")));
                    this.Close();
                }
            }
        }

        static byte[] EncryptData(string strDataGram)
        {
            byte[] bCipherText = null;
            try
            {
                RijndaelManaged RijndaelProvider = new RijndaelManaged
                {
                    Key = objUtf8.GetBytes(strCryptoKey),
                    IV = objUtf8.GetBytes(strCryptoIV)
                };

                ICryptoTransform rijndaelEncrypt = RijndaelProvider.CreateEncryptor();
			
                byte[] bClearText = objUtf8.GetBytes(strDataGram);
                using (MemoryStream objMs = new MemoryStream())
                {
                    using (CryptoStream objCs = new CryptoStream(objMs, rijndaelEncrypt, CryptoStreamMode.Write))
                    {
                        objCs.Write(bClearText, 0, bClearText.Length);
                        objCs.FlushFinalBlock();

                        bCipherText = objMs.ToArray();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return bCipherText;
        }

        /// <summary>
        /// The DecryptData method will decrypt the given file using the DES algorithm
        /// </summary>
        /// <param name="bCipherText"></param>
        /// <returns>string</returns>
        static string DecryptData(byte[] bCipherText)
        {
            string sEncoded = "";

            try
            {
                RijndaelManaged RijndaelProvider = new RijndaelManaged
                {
                    Key = objUtf8.GetBytes(strCryptoKey),
                    IV = objUtf8.GetBytes(strCryptoIV)
                };

                ICryptoTransform rijndaelDecrypt = RijndaelProvider.CreateDecryptor();

                using (MemoryStream objMs = new MemoryStream(bCipherText, 0, bCipherText.Length))
                {
                    using (CryptoStream objCs = new CryptoStream(objMs, rijndaelDecrypt, CryptoStreamMode.Read))
                    {
                        using (StreamReader objSr = new StreamReader(objCs))
                        {
                            sEncoded = objSr.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return sEncoded;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            udpClient?.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            btn_Send.Enabled = !string.IsNullOrEmpty(tb_Message.Text);
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Send(tb_Message.Text, tb_Name.Text);
            tb_Message.Text = string.Empty;
        }
    }
}
