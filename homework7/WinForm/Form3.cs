using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using homework7;

namespace WinForm
{
    public partial class Form3 : Form
    {
        int n=0;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            Form1 f1 = (Form1)this.Owner;
            string s0 = textBox1.Text;
            string s1 = textBox2.Text;
            foreach(Order i in f1.Zz.order)
            {
                if (s0 == i.orderNumber)
                {
                    break;
                }
                a++;
            }
            if (f1.Zz.order.Contains(f1.Zz.order[a]))
            {
                switch (n)
                {
                    case 0:
                        f1.Zz.order[a].orderNumber = s1;
                        break;
                    case 1:
                        f1.Zz.order[a].clientName = s1;
                        break;
                    case 2:
                        f1.Zz.order[a].orderdetails[0].productName = s1;
                        break;
                    case 3:
                        f1.Zz.order[a].orderdetails[0].productNumber = s1;
                        break;
                    case 4:
                        try
                        {
                            f1.Zz.order[a].orderdetails[0].productPrice = Convert.ToDouble(s1); 
                        }
                        catch (Exception) {
                            MessageBox.Show("ERROR!");
                        }
                        break;
                    default:
                        break;

                }
            }
            f1.Bin(f1.Zz.order);
            f1.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    n = 0;
                    break;
                case 1:
                    n = 1;
                    break;
                case 2:
                    n = 2;
                    break;
                case 3:
                    n = 3;
                    break;
                case 4:
                    n = 4;
                    break;
                case 5:
                    n = 5;
                    break;
                default:
                    break;

            }
            
        }
    }
}
