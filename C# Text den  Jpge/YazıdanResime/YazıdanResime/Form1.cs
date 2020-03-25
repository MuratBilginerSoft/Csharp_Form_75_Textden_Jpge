using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YazıdanResime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       


        public static Bitmap convert_To_Image(string text, string fontName, int fontSize)
        {
            Bitmap b = new Bitmap(1, 1);
            Graphics g = Graphics.FromImage(b);
            Font f = new Font(fontName, fontSize);
            SizeF sf = g.MeasureString(text, f);
            b = new Bitmap(b, (int)sf.Width, (int)sf.Height);
            g = Graphics.FromImage(b);
            g.DrawString(text, f, Brushes.DarkSlateGray, 0, 0);
            f.Dispose();
            g.Flush();
            g.Dispose();
            return b;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = convert_To_Image(textBox1.Text, "Impact", 32);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";

            sfd.Title = "Kayıt";

            sfd.FileName = "resim";

            DialogResult sonuç = sfd.ShowDialog();

            if (sonuç == DialogResult.OK)
            {
                pictureBox1.Image.Save(sfd.FileName);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = convert_To_Image(textBox1.Text, "DejaVu Serif", 32);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = convert_To_Image(textBox1.Text, "Consolas", 32);  
        }

        private void button5_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = convert_To_Image(textBox1.Text, "Comic Sans MS", 32);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = convert_To_Image(textBox1.Text, "Candara", 32);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = convert_To_Image(textBox1.Text, "Trebuchet MS", 32);
        }

        private void button8_Click(object sender, EventArgs e)
        {


            pictureBox1.Image = convert_To_Image(textBox1.Text, "Webdings", 32);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
