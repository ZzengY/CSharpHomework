using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    //接收两个数字，然后计算它们的积
    public class program2 : Form
    {
        TextBox txt1 = new TextBox();
        TextBox txt2 = new TextBox();
        Button btn = new Button();
        Label lbl = new Label();


        public void init()
        {
            this.Controls.Add(txt1);
            this.Controls.Add(txt2);
            this.Controls.Add(btn);
            this.Controls.Add(lbl);
            txt1.Dock = System.Windows.Forms.DockStyle.Left;
            txt2.Dock = System.Windows.Forms.DockStyle.Right;
            btn.Location = new Point(160, 130);
            lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            btn.Text = "求积";
            lbl.Text = "result";
            this.Size = new Size(400, 320);
            btn.Click += new System.EventHandler(this.button1_Click);

        }
        public void button1_Click(object sender, EventArgs e)
        {
            string s1 = txt1.Text;
            string s2 = txt2.Text;
            double d1 = Double.Parse(s1);
            double d2 = Double.Parse(s2);
            double pro = d1 * d2;
            lbl.Text = "The product of two numbers:" + pro;
        }
        public static void Main()
        {
            program2 f = new program2();
            f.Text = "program2";
            f.init();
            Application.Run(f);
        }

    }
}
