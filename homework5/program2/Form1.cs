using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {           
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(10, 200, 310, 100, -Math.PI / 2);
        }
        private Graphics graphics;
        int b,c,k;       
        double per1,per2 ;
        Pen s;


        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            double x2 = x0 + leng * k *Math.Cos(th);
            

            drawLine(x0, y0, x1, y1);
            drawLine(x0, y0, x2, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th+b * Math.PI / 180);          
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th-c * Math.PI / 180);
            drawCayleyTree(n - 1, x2, y1, per1 * leng, th + b * Math.PI / 180);
            drawCayleyTree(n - 1, x2, y1, per2 * leng, th - c * Math.PI / 180);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
                 s,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception i)
            {
                Console.WriteLine("input error:" + i.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                c = Convert.ToInt32(textBox4.Text);
            }
            catch (Exception i)
            {
                Console.WriteLine("input error:" + i.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1 = (ComboBox)sender;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    s = Pens.Blue;
                    break;                 
                case 1:
                    s = Pens.Pink;
                    break;
                case 2:
                    s = Pens.Yellow;
                    break;
                case 3:
                    s = Pens.Green;
                    break;
                case 4:
                    s = Pens.Black;
                    break;
                default:
                    s = Pens.Gold;
                    break;

            }
            MessageBox.Show(comboBox1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                k = Convert.ToInt32(textBox3.Text);
            }
            catch (Exception i)
            {
                Console.WriteLine("input error:" + i.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                per1 = Convert.ToDouble(textBox2.Text);
            }
            catch (Exception i)
            {
                Console.WriteLine("input error:" + i.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                per2 = Convert.ToDouble(textBox5.Text);
            }catch(Exception i)
            {
                Console.WriteLine("input error:" + i.Message);
            }
        }
    }
}

