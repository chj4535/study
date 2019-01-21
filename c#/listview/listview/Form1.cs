using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class Form1 : Form
    {
        bool selected;
     
        public Form1()
        {
            InitializeComponent();
            reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string id = tb_ID.Text;
            foreach (ListViewItem lvi2 in lv.Items)
            {
                if (id == lvi2.SubItems[0].Text)
                {
                    MessageBox.Show("중복된 id입니다!");
                    return;
                }
            }
            string name = tb_name.Text;
            decimal age = numupdown.Value;
            if(id=="" || name=="" || age == 0)
            {
                return;
            }
            string[] strs = new string[] { id, name, age.ToString() };
            ListViewItem lvi = new ListViewItem(strs);
            lv.Items.Add(lvi);

            reset();
        }

        private void reset()
        {
            tb_ID.Text="";
            tb_name.Text="";
            numupdown.Value=0;
            btn_modify.Enabled = btn_del.Enabled = false;
        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = lv.SelectedItems.Count > 0;
            btn_modify.Enabled = btn_del.Enabled = selected;

            if (selected == false)
            {
                reset();
                return;
            }

            ListViewItem lvi = lv.SelectedItems[0];
            tb_ID.Text = lvi.SubItems[0].Text;
            tb_name.Text = lvi.SubItems[1].Text;
            numupdown.Value = decimal.Parse(lvi.SubItems[2].Text);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = lv.SelectedItems[0];
            lv.Items.Remove(lvi);
            reset();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {

            ListViewItem lvi = lv.SelectedItems[0];
            string name = tb_name.Text;
            string id = tb_ID.Text;
            decimal age = numupdown.Value;
            lvi.SubItems[0].Text = id;
            lvi.SubItems[1].Text = name;
            lvi.SubItems[2].Text = age.ToString();
            reset();
            lv.SelectedItems.Clear();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            lv.SelectedItems.Clear();
            string id = tb_ID2.Text;
            foreach(ListViewItem lvi in lv.Items)
            {
                if (id == lvi.SubItems[0].Text)
                {
                    /*
                    tb_ID.Text = id;
                    tb_name.Text = lvi.SubItems[1].Text;
                    numupdown.Value = decimal.Parse(lvi.SubItems[2].Text);
                    lvi.Selected = true;
                    btn_del.Enabled = btn_modify.Enabled = true;
                    return;
                    */
                    //lv.FocusedItem = lvi;
                    lvi.Selected = true;//선택하고
                    lv.Select();//선택된거 활성화
                    return;

                }
            }
            MessageBox.Show("존재하지 않는 ID입니다.");
        }
    }
}
