﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Message
        {
            public string code { get; set; }
            public string msg { get; set; }
            public string pic { get; set; }
            public string fullname { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox3.Text = post.
            /*WebResponse result = null;
            WebRequest req = null;
            Stream newStream = null;
            Stream ReceiveStream = null;
            StreamReader sr = null;


            try
            {
                // Url запрашиваемого методом POST скрипта
                req = WebRequest.Create("http://dle.ru/User_Authorization.php");
                req.Method = "POST";
                req.Timeout = 120000;
                req.ContentType = "application/x-www-form-urlencoded";

                byte[] SomeBytes = null;

                SomeBytes = Encoding.GetEncoding(1251).GetBytes("nam=" + textBox1.Text + "&pass=" + textBox2.Text);// передача параметров
                req.ContentLength = SomeBytes.Length;
                newStream = req.GetRequestStream();
                newStream.Write(SomeBytes, 0, SomeBytes.Length);
                newStream.Close();

                // считываем результат работы
                result = req.GetResponse();
                ReceiveStream = result.GetResponseStream();
                Encoding encode = Encoding.GetEncoding(1251);
                sr = new StreamReader(ReceiveStream, encode);

                char[] read = new char[256];
                int count = sr.Read(read, 0, 256);
                string strOut = string.Empty;
                while (count > 0)
                {
                    String str = new String(read, 0, count);
                    strOut += str;
                    count = sr.Read(read, 0, 256);
                }

                Message mess = JsonConvert.DeserializeObject<Message>(strOut);
                textBox3.Text = "Код ошибки: " + mess.code + "\r\n" + "Cообщение: " + mess.msg  + "\r\n";
                if (mess.code == "1")
                {
                    textBox3.Text += mess.pic;
                    pictureBox1.Load(mess.pic);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("ОШИБКА: не загруженно");
            }

            finally
            {
                if (newStream != null)
                    newStream.Close();
                if (ReceiveStream != null)
                    ReceiveStream.Close();

                if (sr != null)
                    sr.Close();

                if (result != null)
                    result.Close();
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }  
    }
}
