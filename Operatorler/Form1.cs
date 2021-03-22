using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operatorler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text;
            text = textBox1.Text;
            if (text=="KURTLAR VADİSİ FİLİSTİN")
            {
                webBrowser1.Navigate("https://www.youtube.com/watch?v=B9MFDx_2Ets");
                textBox1.Clear();
                textBox1.Focus();

            }
            else if (text == "AŞK SANA BENZER")
            {
                webBrowser1.Navigate("https://www.youtube.com/watch?v=J0FFr-TSrxI&t=2s");
                textBox1.Clear();
                textBox1.Focus();
            }
            else if (text == "SADECE SEN")
            {
                webBrowser1.Navigate("https://www.youtube.com/watch?v=7c3WQ8gF0QI");
                textBox1.Clear();
                textBox1.Focus();
            }
            else if (text == "GÜNEŞİ GÖRDÜM")
            {
                webBrowser1.Navigate("https://www.youtube.com/watch?v=3ZipkW5ZgQY&t=1957s");
                textBox1.Clear();
                textBox1.Focus();
            }
            else if (text == "AŞK SANA BENZER")
            {
                webBrowser1.Navigate("https://www.youtube.com/watch?v=J0FFr-TSrxI&t=2s");
                textBox1.Clear();
                textBox1.Focus();
            }
            else if (text == "NEFES - VATAN SAĞOLSUN")
            {
                webBrowser1.Navigate("https://www.youtube.com/watch?v=Avwzh9ZK2l0");
                textBox1.Clear();
                textBox1.Focus();
            }

        }
    }
}































































