using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void yazarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
           // this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

                button1.Enabled = true;
                button2.Enabled = true;
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Düzenle";
            button2.Text = "Sil";
         
            

            listBox1.Items.Add("asdasd");
            listBox1.Items.Add("asdasd");
            listBox1.Items.Add("asdasd");
            listBox1.Items.Add("asdasd");
            listBox1.Items.Add(Form2.gidenBilgi);
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            MessageBox.Show("silmek istediğinize emin misiniz");
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
