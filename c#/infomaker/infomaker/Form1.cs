using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infomaker
{
    public partial class Form1 : Form
    {
        string have = "소유 : ";
        string bloodtype = "혈액형 : ";
        string gender = "성별 : ";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            check_car.Checked = false;
            check_house.Checked = false;
            radioButton_woman.Checked = false;
            radioButton_man.Checked = false;
            radioButton_typeA.Checked = false;
            radioButton_typeAB.Checked = false;
            radioButton_typeB.Checked = false;
            radioButton_typeO.Checked = false;
            have = "소유 : ";
            bloodtype = "혈액형 : ";
            gender = "성별 : ";
            lb_have.Text = have;
            lb_gender.Text = gender;
            lb_bloodtype.Text = bloodtype;
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            have = "소유 : ";
            bloodtype = "혈액형 : ";
            gender = "성별 : ";
            if (check_car.Checked == true) have += "자동차 ";
            if (check_house.Checked == true) have += "집";

            if (radioButton_man.Checked == true) gender += "남";
            else if (radioButton_woman.Checked == true) gender += "여";

            if (radioButton_typeO.Checked == true) bloodtype += "0형";
            else if (radioButton_typeA.Checked == true) bloodtype += "A형";
            else if (radioButton_typeB.Checked == true) bloodtype += "B형";
            else if (radioButton_typeAB.Checked == true) bloodtype += "AB형";
            lb_have.Text = have;
            lb_gender.Text = gender;
            lb_bloodtype.Text = bloodtype;
        }
    }
}
