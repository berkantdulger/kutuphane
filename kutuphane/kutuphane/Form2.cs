using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class Form2 : Form
    {
        public static string gidenBilgi = "";
        public Form2()
        {
            InitializeComponent();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Kitap Adı";
            label2.Text = "Yazar Adı";
            label3.Text = "Sayfa Sayısı";

            button1.Text = "Ekle";
            button2.Text = "İptal";


        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

           Form1 form1 = new Form1();
            form1.Owner = this;
            form1.Show();
            this.Hide();
            gidenBilgi = textBox1.Text;
            
        }
    }
}
