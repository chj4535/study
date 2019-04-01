using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_explorer
{
    public delegate void login_result_Handler(string user_name,EventArgs e);

    public partial class Login_form : Form
    {
        public event login_result_Handler loginEventHandler;
        public Login_form()
        {
            InitializeComponent();
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            LoginHandler loginHandler = new LoginHandler();
            if (IdPwcheck()) // id , pw  모두 입력 됐으면
            {
                if (loginHandler.LoginCheck(user_id_textbox.Text, user_pw_textbox.Text))
                {
                    string user_id = user_id_textbox.Text;
                    loginEventHandler(user_id,e);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("올바르지 않는 정보입니다!", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    user_id_textbox.Clear();
                    user_pw_textbox.Clear();
                }
            }
        }

        private bool IdPwcheck()
        {
            if (String.IsNullOrEmpty(user_id_textbox.Text))
            {
                MessageBox.Show("아이디를 입력해 주세요!", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                user_id_textbox.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(user_pw_textbox.Text))
            {
                MessageBox.Show("비밀번호를 입력해 주세요!", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                user_pw_textbox.Focus();
                return false;
            }
            return true;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
