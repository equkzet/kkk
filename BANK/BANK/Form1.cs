using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BANK
{
    public partial class Form1 : Form
    {
        string namename = "IVANOV IVAN";
        string numbercard = "2200100030004000";
        string datecard = "12/30";
        string codecard = "393";
        string namename2 = "PETROV PETR";
        string numbercard2 = "2202308210603379";
        string datecard2 = "04/29";
        string codecard2 = "934";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == numbercard) && (textBox2.Text == datecard) && (textBox3.Text == codecard)&&(textBox4.Text == namename))
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
            else if ((textBox1.Text == numbercard2)&&(textBox2.Text == datecard2) &&(textBox3.Text == codecard2)&&(textBox4.Text == namename2))
            {
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
            }
            else if ((textBox1.Text != numbercard)&&(textBox2.Text == datecard) && (textBox3.Text == codecard) && (textBox4.Text == namename))
            {
                label6.Text = "Неверно введен номер карты";
            }
            else if ((textBox1.Text != numbercard2) && (textBox2.Text == datecard2) && (textBox3.Text == codecard2) && (textBox4.Text == namename2))
            {
                label6.Text = "Неверно введен номер карты";
            }
            else if ((textBox1.Text == numbercard) && (textBox2.Text != datecard) && (textBox3.Text == codecard) && (textBox4.Text == namename))
            {
                label6.Text = "Неверно введен срок карты";
            }
            else if ((textBox1.Text == numbercard2) && (textBox2.Text != datecard2) && (textBox3.Text == codecard2) && (textBox4.Text == namename2))
            {
                label6.Text = "Неверно введен срок карты";
            }
            else if ((textBox1.Text == numbercard) && (textBox2.Text == datecard) && (textBox3.Text != codecard) && (textBox4.Text == namename))
            {
                label6.Text = "Неверно введен код карты";
            }
            else if ((textBox1.Text == numbercard2) && (textBox2.Text == datecard2) && (textBox3.Text != codecard2) && (textBox4.Text == namename2))
            {
                label6.Text = "Неверно введен код карты";
            }
            else if ((textBox1.Text == numbercard) && (textBox2.Text == datecard) && (textBox3.Text == codecard) && (textBox4.Text != namename))
            {
                label6.Text = "Неверно введено имя держателя";
            }
            else if ((textBox1.Text == numbercard2) && (textBox2.Text == datecard2) && (textBox3.Text == codecard2) && (textBox4.Text != namename2))
            {
                label6.Text = "Неверно введено имя держателя";
            }
            else
            {
                label6.Text = "Неверно введены данные";
            }
        }
    }
}
