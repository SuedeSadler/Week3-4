using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (First_Name.Text == "")
            {
                MessageBox.Show("Please enter a First name");
                
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please enter a surname");
                
            }
            else if (int.TryParse(textBox3.Text, out num) == false)
            {
                MessageBox.Show("Please eneter a valid number");
            }
            else if (!Regex.IsMatch(textBox4.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Please enter a valid email");
            }
            else
            {
                listBox1.Items.Add("Student Name: " + First_Name.Text + " " + textBox2.Text) ;
                listBox1.Items.Add("Student Phone Number: " + textBox3.Text);
                listBox1.Items.Add("Student Email: " + textBox4.Text);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            
            if (f2.ShowDialog() == DialogResult.OK)
            {
                if (f2.radioButton1.Checked == true)
                    button2.Text = f2.radioButton1.Text;
                else if (f2.radioButton2.Checked == true)
                    button2.Text = f2.radioButton2.Text;
                else if (f2.radioButton3.Checked == true)
                    button2.Text = f2.radioButton3.Text;
                else if (f2.radioButton4.Checked == true)
                    button2.Text = f2.radioButton4.Text;

            }
            else
            {
                    button2.Text = "Meeting Aim";
            }
        }

        private void Dont_click_Click(object sender, EventArgs e)
        {

        }
    }
}
