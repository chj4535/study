using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            reset();
        }

        private void reset()
        {
            btn_del.Enabled = false;
            btn_open.Enabled = false;
            btn_close.Enabled = false;
            tb_parents.Enabled = false;
            btn_add3.Enabled = false;
            btn_add4.Enabled = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lb.Items.Clear();
            TreeNode node = tv.SelectedNode;
            if (node == null)
            {
                tb_parents.Text = string.Empty;
                tb_parents.Tag = tv.TopNode;
                btn_del.Enabled = false;
                btn_open.Enabled = false;
                btn_close.Enabled = false;
                return;
            }

            tb_parents.Text = node.Text;
            tb_parents.Tag = node;
            btn_del.Enabled = true;
            btn_open.Enabled = true;
            btn_close.Enabled = true;
            foreach (TreeNode snode in node.Nodes)
            {
                lb.Items.Add(snode);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_child.Text == "")
            {
                MessageBox.Show("err1 : 공백은 자식으로 만들 수 없습니다.");
                return;
            }
            TreeNode node = tb_parents.Tag as TreeNode;
            if (node == null)
            {
                foreach(TreeNode snode in tv.Nodes)
                {
                    if(snode.Text == tb_child.Text)
                    {
                        MessageBox.Show("err2 : 중복된 자식입니다.");
                        return;
                    }
                }
                tv.Nodes.Insert(0, tb_child.Text);
                lb.Items.Insert(0,tv.Nodes[0]);
            }
            else
            {
                foreach (TreeNode snode in node.Nodes)
                {
                    if (snode.Text == tb_child.Text)
                    {
                        MessageBox.Show("err3 : 중복된 자식입니다.");
                        return;
                    }
                }
                node.Nodes.Insert(0, tb_child.Text);
                lb.Items.Insert(0,node.Nodes[0]);
                node.Expand();
            }
            
            tb_child.Text = string.Empty;
        }

        private void btn_add2_Click(object sender, EventArgs e)
        {
            if (tb_child.Text == "")
            {
                MessageBox.Show("err4 : 공백은 자식으로 만들 수 없습니다.");
                return;
            }
            TreeNode node = tb_parents.Tag as TreeNode;
            if (node == null)
            {
                foreach (TreeNode snode in tv.Nodes)
                {
                    if (snode.Text == tb_child.Text)
                    {
                        MessageBox.Show("err5 : 중복된 자식입니다.");
                        return;
                    }
                }
                tv.Nodes.Add(tb_child.Text);
                lb.Items.Add(tv.Nodes[tv.Nodes.Count-1]);
            }
            else
            {
                foreach (TreeNode snode in node.Nodes)
                {
                    if (snode.Text == tb_child.Text)
                    {
                        MessageBox.Show("err6 : 중복된 자식입니다.");
                        return;
                    }
                }
                node.Nodes.Add(tb_child.Text);
                lb.Items.Add(node.Nodes[node.Nodes.Count - 1]);
                node.Expand();
            }

            tb_child.Text = string.Empty;

        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb.SelectedIndex != -1)
            {
                btn_add3.Enabled = true;
                btn_add4.Enabled = true;
            }
        }

        private void btn_add3_Click(object sender, EventArgs e)
        {
            if (tb_child.Text == "")
            {
                MessageBox.Show("err7 : 공백은 자식으로 만들 수 없습니다.");
                return;
            }
            TreeNode tn = lb.SelectedItem as TreeNode;
            TreeNode pn = tn.Parent;
            pn.Nodes.Insert(tn.Index, tb_child.Text);
            lb.Items.Insert(tn.Index-1, pn.Nodes[tn.Index-1]);
            tb_child.Text = string.Empty;
            
        }

        private void btn_add4_Click(object sender, EventArgs e)
        {
            if (tb_child.Text == "")
            {
                MessageBox.Show("err8 : 공백은 자식으로 만들 수 없습니다.");
                return;
            }
            TreeNode tn = lb.SelectedItem as TreeNode;
            TreeNode pn = tn.Parent;
            pn.Nodes.Insert(tn.Index+1, tb_child.Text);
            lb.Items.Insert(tn.Index+1, pn.Nodes[tn.Index+1]);
            tb_child.Text = string.Empty;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            tv.ExpandAll();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            tv.CollapseAll();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            tv.SelectedNode.Remove();
            tb_parents.Tag = null;
            tb_parents.Text = string.Empty;
            if (tv.Nodes.Count > 0)
            {
                if (tv.SelectedNode.IsSelected == true)
                {
                    tv.Select();
                }
            }
            else
            {
                reset();
            }

        }
    }
}
