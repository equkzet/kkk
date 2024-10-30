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
    public partial class Form2 : Form
    {
        string namename3 = "IVANOV IVAN";
        string numbercard3 = "2200 1000 3000 4000";
        string datecard3 = "12/30";
        string codecard3 = "393";
        public Form2()
        {
            InitializeComponent();
            textBox1.UseSystemPasswordChar = true;
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = numbercard3;
            textBox2.Text = datecard3;
            textBox3.Text = codecard3;
            textBox4.Text = namename3;
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
