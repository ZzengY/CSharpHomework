using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using homework10;

namespace WinForm
{
    public partial class Form1 : Form
    {
        OrderService orderService = new OrderService();
        public Form1()
        {
            InitializeComponent();           
            orderBindingSource.DataSource = orderService.GetAllOrders();
        }

        private void 创建订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(null);           
            f2.ShowDialog();            
            queryOrder();
           

        }

        private void 删除订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orderBindingSource.Current != null)
            {
                Order order = (Order)orderBindingSource.Current;
                orderService.DeleteOrder(order.Id);
                queryOrder();
                
            }
            else
            {
                MessageBox.Show("No Order is selected!");
            }
        }

        private void 修改订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orderBindingSource.Current != null)
            {
                Form3 f3 = new Form3((Order)orderBindingSource.Current);                
                f3.ShowDialog();                
                queryOrder();
                
            }
            else
            {
                MessageBox.Show("No Order is selected!");
            }
        }

        private void 查询订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            queryOrder();
            
        }
        private void queryOrder()
        {
            switch (comboBox1.SelectedIndex)
            {

                case 1:
                    orderBindingSource.DataSource =
                      orderService.GetOrder(textBox1.Text);
                    break;
                case 2:
                    orderBindingSource.DataSource =
                      orderService.QueryByCustormer(textBox1.Text);
                    break;
                case 3:
                    orderBindingSource.DataSource =
                      orderService.QueryByGoods(textBox1.Text);
                    break;
                default:
                    orderBindingSource.DataSource = orderService.GetAllOrders();
                    break;
            }
            orderBindingSource.ResetBindings(false);
            bindingSource1.ResetBindings(false);
        }

    }
}
