using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOSE5; //PROJECT NAME WHERE FORMULAS.CS is available

namespace LAB5
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
            label4.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formulas f = new Formulas();
            int receipt = 0;
            int price=0;
            receipt = f.CounterBillNo();
            string Itm = comboBox1.Text.ToString();
            switch (Itm)
            {
                case "TEA":
                    price = f.totalamount(Convert.ToInt32(label4.Text), 10);
                    break;
                case "BISCUITS":
                    price = f.totalamount(Convert.ToInt32(label4.Text), 20);
                    break;
                case "CHIPS":
                    price = f.totalamount(Convert.ToInt32(label4.Text), 20);
                    break;
                case "JUICE":
                    price = f.totalamount(Convert.ToInt32(label4.Text), 20);
                    break;
                case "MILK BOX":
                    price = f.totalamount(Convert.ToInt32(label4.Text), 40);
                    break;
                case "WATER BOTTLE":
                    price = f.totalamount(Convert.ToInt32(label4.Text), 30);
                    break;
                case "NOODLES":
                    price = f.totalamount(Convert.ToInt32(label4.Text), 50);
                    break;
                default:
                    MessageBox.Show("No item selected");
                    price=0;
                    break;
            }

            if (price == 0)
                MessageBox.Show("No item selected", "Error");
            else
            {
                MessageBox.Show("Your final price is: " + price + "PKR", "Done");
                MessageBox.Show("Your receipt number is: " + receipt);
            }
            
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formulas f1 = new Formulas();
            int num = Convert.ToInt32(label4.Text);
            num = f1.CounterInc(num);
            label4.Text = Convert.ToString(num);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formulas f2 = new Formulas();
            label4.Text = Convert.ToString(f2.CounterDec(Convert.ToInt32(label4.Text)));
        }
    }
}
