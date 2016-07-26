using System;
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

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebResponse result = null;
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

           
                int otv = int.Parse(strOut);
                if (otv == 1)
                {
                    MessageBox.Show(strOut);
                    Form1 form = new Form1();
                    this.Close();
                    form.Show();
                    //this.Close();
                }
                else if (otv == 0)
                {
                    MessageBox.Show("No");
                }
                //MessageBox.Show(strOut);

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
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
