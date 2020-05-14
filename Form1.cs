using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
       
        
        public Form1()
        {
            InitializeComponent();
            textBox2.Width = 210;
            textBox1.Width = 210;
            textBox3.Width = 210;
            textBox1.PasswordChar = '*';
            textBox3.PasswordChar = '*';
            textBox1.MaxLength = 15;
            textBox3.MaxLength = 15;
            textBox2.MaxLength = 15;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
            {
                MessageBox.Show("Enter your data");
                return;
            }
            if (textBox1.Text != textBox3.Text)
            {
                textBox1.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
                MessageBox.Show("Your passwords do not match");
                return;

            }
            if (textBox1.Text == textBox3.Text)
            {
                MessageBox.Show("Congratulations, you joined us succesfully!" +
                    "Please join this link and write me to pm:https://vk.com/playtonboy");
             
            }
        }
    
        private void BtnClose_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }

            else
            {
                textBox1.PasswordChar ='*';
                textBox3.PasswordChar = '*';
            }
        }
    }



}
