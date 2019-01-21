namespace infomaker
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.check_car = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.check_house = new System.Windows.Forms.CheckBox();
            this.groupBox_gender = new System.Windows.Forms.GroupBox();
            this.radioButton_woman = new System.Windows.Forms.RadioButton();
            this.radioButton_man = new System.Windows.Forms.RadioButton();
            this.groupBox_bloodtype = new System.Windows.Forms.GroupBox();
            this.radioButton_typeAB = new System.Windows.Forms.RadioButton();
            this.radioButton_typeO = new System.Windows.Forms.RadioButton();
            this.radioButton_typeB = new System.Windows.Forms.RadioButton();
            this.radioButton_typeA = new System.Windows.Forms.RadioButton();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lb_have = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            this.lb_bloodtype = new System.Windows.Forms.Label();
            this.groupBox_gender.SuspendLayout();
            this.groupBox_bloodtype.SuspendLayout();
            this.SuspendLayout();
            // 
            // check_car
            // 
            this.check_car.AutoSize = true;
            this.check_car.Location = new System.Drawing.Point(23, 51);
            this.check_car.Name = "check_car";
            this.check_car.Size = new System.Drawing.Size(60, 16);
            this.check_car.TabIndex = 0;
            this.check_car.Text = "자동차";
            this.check_car.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "소유";
            // 
            // check_house
            // 
            this.check_house.AutoSize = true;
            this.check_house.Location = new System.Drawing.Point(98, 51);
            this.check_house.Name = "check_house";
            this.check_house.Size = new System.Drawing.Size(36, 16);
            this.check_house.TabIndex = 2;
            this.check_house.Text = "집";
            this.check_house.UseVisualStyleBackColor = true;
            // 
            // groupBox_gender
            // 
            this.groupBox_gender.Controls.Add(this.radioButton_woman);
            this.groupBox_gender.Controls.Add(this.radioButton_man);
            this.groupBox_gender.Location = new System.Drawing.Point(12, 97);
            this.groupBox_gender.Name = "groupBox_gender";
            this.groupBox_gender.Size = new System.Drawing.Size(152, 55);
            this.groupBox_gender.TabIndex = 3;
            this.groupBox_gender.TabStop = false;
            this.groupBox_gender.Text = "성별";
            // 
            // radioButton_woman
            // 
            this.radioButton_woman.AutoSize = true;
            this.radioButton_woman.Location = new System.Drawing.Point(94, 23);
            this.radioButton_woman.Name = "radioButton_woman";
            this.radioButton_woman.Size = new System.Drawing.Size(35, 16);
            this.radioButton_woman.TabIndex = 1;
            this.radioButton_woman.TabStop = true;
            this.radioButton_woman.Text = "여";
            this.radioButton_woman.UseVisualStyleBackColor = true;
            // 
            // radioButton_man
            // 
            this.radioButton_man.AutoSize = true;
            this.radioButton_man.Location = new System.Drawing.Point(26, 23);
            this.radioButton_man.Name = "radioButton_man";
            this.radioButton_man.Size = new System.Drawing.Size(35, 16);
            this.radioButton_man.TabIndex = 0;
            this.radioButton_man.TabStop = true;
            this.radioButton_man.Text = "남";
            this.radioButton_man.UseVisualStyleBackColor = true;
            // 
            // groupBox_bloodtype
            // 
            this.groupBox_bloodtype.Controls.Add(this.radioButton_typeAB);
            this.groupBox_bloodtype.Controls.Add(this.radioButton_typeO);
            this.groupBox_bloodtype.Controls.Add(this.radioButton_typeB);
            this.groupBox_bloodtype.Controls.Add(this.radioButton_typeA);
            this.groupBox_bloodtype.Location = new System.Drawing.Point(14, 174);
            this.groupBox_bloodtype.Name = "groupBox_bloodtype";
            this.groupBox_bloodtype.Size = new System.Drawing.Size(244, 66);
            this.groupBox_bloodtype.TabIndex = 4;
            this.groupBox_bloodtype.TabStop = false;
            this.groupBox_bloodtype.Text = "혈액형";
            // 
            // radioButton_typeAB
            // 
            this.radioButton_typeAB.AutoSize = true;
            this.radioButton_typeAB.Location = new System.Drawing.Point(172, 31);
            this.radioButton_typeAB.Name = "radioButton_typeAB";
            this.radioButton_typeAB.Size = new System.Drawing.Size(51, 16);
            this.radioButton_typeAB.TabIndex = 3;
            this.radioButton_typeAB.TabStop = true;
            this.radioButton_typeAB.Text = "AB형";
            this.radioButton_typeAB.UseVisualStyleBackColor = true;
            // 
            // radioButton_typeO
            // 
            this.radioButton_typeO.AutoSize = true;
            this.radioButton_typeO.Location = new System.Drawing.Point(24, 31);
            this.radioButton_typeO.Name = "radioButton_typeO";
            this.radioButton_typeO.Size = new System.Drawing.Size(44, 16);
            this.radioButton_typeO.TabIndex = 2;
            this.radioButton_typeO.TabStop = true;
            this.radioButton_typeO.Text = "O형";
            this.radioButton_typeO.UseVisualStyleBackColor = true;
            // 
            // radioButton_typeB
            // 
            this.radioButton_typeB.AutoSize = true;
            this.radioButton_typeB.Location = new System.Drawing.Point(74, 31);
            this.radioButton_typeB.Name = "radioButton_typeB";
            this.radioButton_typeB.Size = new System.Drawing.Size(43, 16);
            this.radioButton_typeB.TabIndex = 1;
            this.radioButton_typeB.TabStop = true;
            this.radioButton_typeB.Text = "B형";
            this.radioButton_typeB.UseVisualStyleBackColor = true;
            // 
            // radioButton_typeA
            // 
            this.radioButton_typeA.AutoSize = true;
            this.radioButton_typeA.Location = new System.Drawing.Point(123, 31);
            this.radioButton_typeA.Name = "radioButton_typeA";
            this.radioButton_typeA.Size = new System.Drawing.Size(43, 16);
            this.radioButton_typeA.TabIndex = 0;
            this.radioButton_typeA.TabStop = true;
            this.radioButton_typeA.Text = "A형";
            this.radioButton_typeA.UseVisualStyleBackColor = true;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(288, 29);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 23);
            this.btn_check.TabIndex = 5;
            this.btn_check.Text = "확인";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(398, 28);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "초기화";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lb_have
            // 
            this.lb_have.AutoSize = true;
            this.lb_have.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_have.Location = new System.Drawing.Point(307, 81);
            this.lb_have.Name = "lb_have";
            this.lb_have.Size = new System.Drawing.Size(55, 16);
            this.lb_have.TabIndex = 7;
            this.lb_have.Text = "소유 : ";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_gender.Location = new System.Drawing.Point(307, 136);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(55, 16);
            this.lb_gender.TabIndex = 8;
            this.lb_gender.Text = "성별 : ";
            // 
            // lb_bloodtype
            // 
            this.lb_bloodtype.AutoSize = true;
            this.lb_bloodtype.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_bloodtype.Location = new System.Drawing.Point(307, 194);
            this.lb_bloodtype.Name = "lb_bloodtype";
            this.lb_bloodtype.Size = new System.Drawing.Size(71, 16);
            this.lb_bloodtype.TabIndex = 9;
            this.lb_bloodtype.Text = "혈액형 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 261);
            this.Controls.Add(this.lb_bloodtype);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.lb_have);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.groupBox_bloodtype);
            this.Controls.Add(this.groupBox_gender);
            this.Controls.Add(this.check_house);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_car);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_gender.ResumeLayout(false);
            this.groupBox_gender.PerformLayout();
            this.groupBox_bloodtype.ResumeLayout(false);
            this.groupBox_bloodtype.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check_car;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check_house;
        private System.Windows.Forms.GroupBox groupBox_gender;
        private System.Windows.Forms.RadioButton radioButton_woman;
        private System.Windows.Forms.RadioButton radioButton_man;
        private System.Windows.Forms.GroupBox groupBox_bloodtype;
        private System.Windows.Forms.RadioButton radioButton_typeAB;
        private System.Windows.Forms.RadioButton radioButton_typeO;
        private System.Windows.Forms.RadioButton radioButton_typeB;
        private System.Windows.Forms.RadioButton radioButton_typeA;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lb_have;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.Label lb_bloodtype;
    }
}

