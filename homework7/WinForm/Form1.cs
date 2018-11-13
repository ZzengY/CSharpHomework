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
        public partial class Form1 : Form
        {
            public OrderService Zz = new OrderService();
            public Form1()
            {
                InitializeComponent();          
                Zz.Import(@"..\..\a.xml");
                orderBindingSource.DataSource = Zz.order;
        }
           

            private void 创建订单ToolStripMenuItem_Click(object sender, EventArgs e)
            {            
               Form2 f2= new Form2();
               f2.Owner = this;
               f2.Show();
               
        }

        private void 修改订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.Show();
        }
            private void 查询订单ToolStripMenuItem_Click(object sender, EventArgs e)
            {
            Form4 f4 = new Form4();
            f4.Owner = this;
            f4.Show();
        }

        private void 删除订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Owner = this;
            f5.Show();
        }
    }
    }
