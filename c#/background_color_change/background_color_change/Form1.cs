using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace background_color_change
{
    public partial class Form1 : Form
    {
        bool toggle;                              
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetBackColor();
        }

        private void SetBackColor()
        {
            if (toggle)
            {
                BackColor = Color.Blue;
            }
            else
            {
                BackColor = Color.Black;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            toggle = !toggle;
            SetBackColor();
        }
    }
}
