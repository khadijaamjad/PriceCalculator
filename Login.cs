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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formulas f = new Formulas();
            int n = 0;
            n= f.PassDecode(textBox2.Text.ToString());
            if (SignUp.Users[n, 0] == textBox1.Text.ToString() && SignUp.Users[n, 1] == textBox2.Text.ToString())
            {
                Shop s = new Shop();
                s.Show();
            }
            else
            {
                MessageBox.Show("Invalid login", "Error");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
