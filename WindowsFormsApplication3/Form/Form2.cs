using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication3.Controllers;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_controller temp = new user_controller();
            if (radioButton1.Checked == true)
            {
                temp.register(textBox1.Text, textBox2.Text, textBox3.Text ,textBox4.Text, Convert.ToInt32(textBox5.Text),
                    Convert.ToInt32(textBox6.Text), "male", Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text));
            }

            else if (radioButton2.Checked == true)
            {
                temp.register(textBox1.Text, textBox2.Text, textBox3.Text , textBox4.Text, Convert.ToInt32(textBox5.Text),
                    Convert.ToInt32(textBox6.Text), "female", Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text));
            }
                //string username, string password, string name,
            //int age,int weight,string gender, int height,int target
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
        }
    }
}
