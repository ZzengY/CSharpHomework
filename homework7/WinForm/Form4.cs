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
    public partial class Form4 : Form
    {
        int n = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            Form1 f1 = (Form1)this.Owner;
            string s0 = textBox1.Text;
            List<Order> or = new List<Order>();
            foreach (Order i in f1.Zz.order)
            {
                switch (n)
                {
                    case 0:
                        if (s0 == i.orderNumber)
                        {
                            break;
                        }
                        a++;
                        break;
                    case 1:
                        if (s0 == i.clientName)
                        {
                            break;
                        }
                        a++;
                        break;
                    case 2:
                        foreach(OrderDetails o in i.orderdetails)
                        if (s0 == o.productName)
                        {
                            break;
                        }
                        a++;
                        break;
                    case 3:
                        foreach (OrderDetails o in i.orderdetails)
                            if (s0 == o.productNumber)
                            {
                            break;
                        }
                        a++;
                        break;
                    case 4:
                        foreach (OrderDetails o in i.orderdetails)
                            if (Convert.ToDouble(s0) == o.productPrice)
                            {
                            break;
                        }
                        a++;
                        break;
                    
                    default:
                        break;
                }
                if (a<f1.Zz.order.Count)
                {
                    or.Add(f1.Zz.order[a]);
                }
                else
                {
                    MessageBox.Show("DO NOT FIND!");
                }
                f1.Bin(or);
                f1.Show();
                this.Close();
            }
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
