using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK
{
    public partial class Form3 : Form
    {
        string namename4 = "PETROV PETR";
        string numbercard4 = "2202 3082 1060 3379";
        string datecard4 = "04/29";
        string codecard4 = "964";
        public Form3()
        {
            InitializeComponent();
            textBox1.UseSystemPasswordChar = true;
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = false;
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = numbercard4;
            textBox2.Text = datecard4;
            textBox3.Text = codecard4;
            textBox4.Text = namename4;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }

}
