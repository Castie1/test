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
using Newtonsoft.Json;
using WindowsFormsApplication1;

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
            string a = "http://dle.ru/User_Authorization.php";
            string b = "nam=" + textBox1.Text + "&pass=" + textBox2.Text;
            post pos = new post();
            string login = pos.postquery(a, b);

            Message mess = JsonConvert.DeserializeObject<Message>(login);
            textBox3.Text = "Код ошибки: " + mess.code + "\r\n" + "Cообщение: " + mess.msg + "\r\n";
            if (mess.code == "1")
            {
                textBox3.Text += mess.pic;
                pictureBox1.Load(mess.pic);
            }

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
