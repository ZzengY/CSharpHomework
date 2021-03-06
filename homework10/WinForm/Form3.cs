﻿using System;
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
    public partial class Form3 : Form
    {
        OrderService orderService = new OrderService();

        public Order CurrentOrder { get; set; }
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Order order) : this()
        {
            if (order == null)
            {

                CurrentOrder = new Order();
            }
            else
            {
                CurrentOrder = order;
            }
            orderBindingSource.DataSource = CurrentOrder;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            orderService.ModifyOrder(CurrentOrder);
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
   
