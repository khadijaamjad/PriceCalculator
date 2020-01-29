using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOSE5;

namespace LAB5
{
    
    public partial class SignUp : Form
    {
        public static string[,] Users=new string[3000,2];
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = 0;
            if(textBox2.Text.ToString()==textBox3.Text.ToString())
            {
                Formulas f = new Formulas();
               n= f.PassDecode(textBox2.Text.ToString());
               Users[n, 0] = textBox1.Text.ToString();
               Users[n, 1] = textBox2.Text.ToString();
               MessageBox.Show("Account successfully created!","success");
            }
            else
            {
                MessageBox.Show("Password does not match","Unsuccesful");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login LO = new Login();
            LO.Show();
        }
    }
}
