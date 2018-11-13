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
    public partial class Form2 : Form
    {
        
        public double allprice;
        public double proprice;
        public OrderService Zz = new OrderService();
        public Form2()
        {
            InitializeComponent();
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;
            string s0 = textBox1.Text;
            string s1 = textBox2.Text;
            string s2 = textBox4.Text;
            string s5 = textBox3.Text;
            string s3 = textBox5.Text;
            string s4 = textBox6.Text;
            if ((!Zz.phoExam(s5))||(!Zz.oExam(s0)))
            {
                MessageBox.Show("Please check your input!");
                return;
            }
           
            try
            {                        
                proprice = Convert.ToDouble(s4);
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
                return;
            }            
            OrderDetails a = new OrderDetails(s2,s3,proprice);
            OrderDetails[] z = new OrderDetails[] { a};
            Zz.AddOrder(s0, s1,s5, z);
            Zz.calOrderPri();            
            Zz.order.AddRange(f1.Zz.order);
            f1.Bin(Zz.order);
            f1.Show();
            Zz.Export(Zz.order, "a.xml");
            this.Close();
        }

      

       
    }
}
