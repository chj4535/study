using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int btn_num;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_num++;
            Button btn = new Button();
            btn.Margin = new Padding(10, 8, 0, 0);
            btn.Text = btn_num.ToString();
            btn.Click += new EventHandler(Btn_Click);
            flp.Controls.Add(btn);

            Label lb = new Label();
            lb.Tag = 0;
            lb.Margin = new Padding(90, 13, 0, 0);
            lb.Size = new Size(10, 10);
            lb.Text = lb.Tag.ToString();
            flp.Controls.Add(lb);

            btn.Tag = lb;
            la_btn_num.Text = btn_num.ToString();
            
        }

        void Btn_Click(object sender, EventArgs e)
        {
      
            Button btn = sender as Button;
            Label lb = btn.Tag as Label;
            int clickcount = (int)lb.Tag;
            clickcount++;
            lb.Text = clickcount.ToString();
            lb.Tag = clickcount;
        }

        private void flp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void la_btn_clicknum_Click(object sender, EventArgs e)
        {

        }
    }
}
