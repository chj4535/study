using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace box_add_elete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 콤보박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_add_Click(object sender, EventArgs e)
        {
            if (cb_list.Text == "")
            {
                return;
            }
            cb_list.Items.Add(cb_list.Text);
            lb_msg.Text = string.Format("콤보 박스 항목 추가 {0}", cb_list.Text);
            cb_list.Text = string.Empty;
        }

        private void cb_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg;
            if (cb_list.SelectedIndex == -1)
            {
                msg = string.Format("콤보 박스 선택 항목이 없습니다.");
            }
            else
            {
                string str = cb_list.SelectedItem as string;
                msg = string.Format("콤보 박스 선택 항목 변경, 인덱스 : {0} Text : {1}", cb_list.SelectedItem,str);
            }
            lb_msg.Text = msg;
        }
        private void cb_del_Click(object sender, EventArgs e)
        {
            string msg;
            if (cb_list.SelectedIndex == -1)
            {
                return;
            }
            string str = cb_list.SelectedItem as string;
            msg = string.Format("콤보 박스 선택 항목 삭제, 인덱스 : {0} Text : {1}", cb_list.SelectedItem, str);
            cb_list.Items.RemoveAt(cb_list.SelectedIndex);
            lb_msg.Text = msg;
            cb_list.Text = string.Empty;
        }


        /// <summary>
        /// 체크리스트박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clb_add_Click(object sender, EventArgs e)
        {
            if (clb_text.Text == "")
            {
                return;
            }
            clb1.Items.Add(clb_text.Text);
            lb_msg.Text = string.Format("체크 리스트 박스 항목 추가 {0}", clb_text.Text);
            clb_text.Text = string.Empty;
        }

        private void clb_del_Click(object sender, EventArgs e)
        {
            string msg;
            if (clb1.SelectedIndex == -1)
            {
                return;
            }
            string str = clb1.SelectedItem as string;
            msg = string.Format("체크 리스트 박스 선택 항목 삭제, 인덱스 : {0} Text : {1}", cb_list.SelectedItem, str);
            clb1.Items.RemoveAt(clb1.SelectedIndex);
            lb_msg.Text = msg;
        }

        private void clb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg;
            if (clb1.SelectedIndex == -1)
            {
                msg = string.Format("체크 리스트 박스 선택 항목이 없습니다.");
            }
            else
            {
                string str = clb1.SelectedItem as string;
                msg = string.Format("체크 리스트 박스 선택 항목 변경, 인덱스 : {0} Text : {1}", clb1.SelectedItem, str);
            }
            lb_msg.Text = msg;
        }
        /// <summary>
        /// 리스트박스
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_add_Click(object sender, EventArgs e)
        {
            if (lb_text.Text == "")
            {
                return;
            }
            lb1.Items.Add(lb_text.Text);
            lb_msg.Text = string.Format("리스트 박스 항목 추가 {0}", lb_text.Text);
            lb_text.Text = string.Empty;
        }

        private void lb_del_Click(object sender, EventArgs e)
        {
            string msg;
            if (lb1.SelectedIndex == -1)
            {
                return;
            }
            string str = lb1.SelectedItem as string;
            msg = string.Format("리스트 박스 선택 항목 삭제, 인덱스 : {0} Text : {1}", lb1.SelectedItem, str);
            lb1.Items.RemoveAt(lb1.SelectedIndex);
            lb_msg.Text = msg;
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg;
            if (lb1.SelectedIndex == -1)
            {
                msg = string.Format("리스트 박스 선택 항목이 없습니다.");
            }
            else
            {
                string str = lb1.SelectedItem as string;
                msg = string.Format("리스트 박스 선택 항목 변경, 인덱스 : {0} Text : {1}", lb1.SelectedItem, str);
            }
            lb_msg.Text = msg;
        }
        /// <summary>
        /// 요약
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_smy_Click(object sender, EventArgs e)
        {
            string str;
            lb2.Items.Clear();

            str = string.Format("콤보 박스 항목 개수:{0}", cb_list.Items.Count);
            lb2.Items.Add(str);
            str = string.Format("콤보 박스 선택 항목:{0}", cb_list.SelectedIndex);
            lb2.Items.Add(str);

            str = string.Format("체크 리스트 박스 항목 개수:{0}", clb1.Items.Count);
            lb2.Items.Add(str);
            str = string.Format("체크 리스트 박스 선택 항목:{0}", clb1.SelectedIndex);
            lb2.Items.Add(str);


            str = string.Format("리스트 박스 항목 개수:{0}", lb1.Items.Count);
            lb2.Items.Add(str);
            str = string.Format("리스트 박스 선택 항목:{0}", lb1.SelectedIndex);
            lb2.Items.Add(str);

            str = string.Format("체크 리스트 박스 체크 상태 목록");
            lb2.Items.Add(str);
            foreach(object obj in clb1.CheckedItems)
            {
                lb2.Items.Add(obj);
            }
        }
    }
}
