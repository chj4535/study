namespace box_add_elete
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
            this.cb_list = new System.Windows.Forms.ComboBox();
            this.cb_add = new System.Windows.Forms.Button();
            this.cb_del = new System.Windows.Forms.Button();
            this.clb_text = new System.Windows.Forms.TextBox();
            this.clb_add = new System.Windows.Forms.Button();
            this.clb_del = new System.Windows.Forms.Button();
            this.clb1 = new System.Windows.Forms.CheckedListBox();
            this.lb_text = new System.Windows.Forms.TextBox();
            this.lb_add = new System.Windows.Forms.Button();
            this.lb_del = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb_smy = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.lb_msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_list
            // 
            this.cb_list.Font = new System.Drawing.Font("굴림", 12F);
            this.cb_list.FormattingEnabled = true;
            this.cb_list.ItemHeight = 16;
            this.cb_list.Location = new System.Drawing.Point(12, 22);
            this.cb_list.Name = "cb_list";
            this.cb_list.Size = new System.Drawing.Size(220, 24);
            this.cb_list.TabIndex = 0;
            this.cb_list.SelectedIndexChanged += new System.EventHandler(this.cb_list_SelectedIndexChanged);
            // 
            // cb_add
            // 
            this.cb_add.Location = new System.Drawing.Point(249, 24);
            this.cb_add.Name = "cb_add";
            this.cb_add.Size = new System.Drawing.Size(75, 23);
            this.cb_add.TabIndex = 1;
            this.cb_add.Text = "추가";
            this.cb_add.UseVisualStyleBackColor = true;
            this.cb_add.Click += new System.EventHandler(this.cb_add_Click);
            // 
            // cb_del
            // 
            this.cb_del.Location = new System.Drawing.Point(249, 55);
            this.cb_del.Name = "cb_del";
            this.cb_del.Size = new System.Drawing.Size(75, 23);
            this.cb_del.TabIndex = 2;
            this.cb_del.Text = "삭제";
            this.cb_del.UseVisualStyleBackColor = true;
            this.cb_del.Click += new System.EventHandler(this.cb_del_Click);
            // 
            // clb_text
            // 
            this.clb_text.Font = new System.Drawing.Font("굴림", 12F);
            this.clb_text.Location = new System.Drawing.Point(370, 18);
            this.clb_text.Name = "clb_text";
            this.clb_text.Size = new System.Drawing.Size(220, 26);
            this.clb_text.TabIndex = 3;
            // 
            // clb_add
            // 
            this.clb_add.Location = new System.Drawing.Point(604, 18);
            this.clb_add.Name = "clb_add";
            this.clb_add.Size = new System.Drawing.Size(75, 23);
            this.clb_add.TabIndex = 4;
            this.clb_add.Text = "추가\r\n";
            this.clb_add.UseVisualStyleBackColor = true;
            this.clb_add.Click += new System.EventHandler(this.clb_add_Click);
            // 
            // clb_del
            // 
            this.clb_del.Location = new System.Drawing.Point(604, 55);
            this.clb_del.Name = "clb_del";
            this.clb_del.Size = new System.Drawing.Size(75, 23);
            this.clb_del.TabIndex = 5;
            this.clb_del.Text = "삭제";
            this.clb_del.UseVisualStyleBackColor = true;
            this.clb_del.Click += new System.EventHandler(this.clb_del_Click);
            // 
            // clb1
            // 
            this.clb1.Font = new System.Drawing.Font("굴림", 12F);
            this.clb1.FormattingEnabled = true;
            this.clb1.Location = new System.Drawing.Point(370, 55);
            this.clb1.Name = "clb1";
            this.clb1.Size = new System.Drawing.Size(220, 172);
            this.clb1.TabIndex = 6;
            this.clb1.SelectedIndexChanged += new System.EventHandler(this.clb1_SelectedIndexChanged);
            // 
            // lb_text
            // 
            this.lb_text.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_text.Location = new System.Drawing.Point(12, 251);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(220, 26);
            this.lb_text.TabIndex = 7;
            // 
            // lb_add
            // 
            this.lb_add.Location = new System.Drawing.Point(249, 251);
            this.lb_add.Name = "lb_add";
            this.lb_add.Size = new System.Drawing.Size(75, 23);
            this.lb_add.TabIndex = 8;
            this.lb_add.Text = "추가";
            this.lb_add.UseVisualStyleBackColor = true;
            this.lb_add.Click += new System.EventHandler(this.lb_add_Click);
            // 
            // lb_del
            // 
            this.lb_del.Location = new System.Drawing.Point(249, 290);
            this.lb_del.Name = "lb_del";
            this.lb_del.Size = new System.Drawing.Size(75, 23);
            this.lb_del.TabIndex = 9;
            this.lb_del.Text = "삭제";
            this.lb_del.UseVisualStyleBackColor = true;
            this.lb_del.Click += new System.EventHandler(this.lb_del_Click);
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("굴림", 12F);
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 16;
            this.lb1.Location = new System.Drawing.Point(12, 290);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(220, 196);
            this.lb1.TabIndex = 10;
            this.lb1.SelectedIndexChanged += new System.EventHandler(this.lb1_SelectedIndexChanged);
            // 
            // lb_smy
            // 
            this.lb_smy.Location = new System.Drawing.Point(370, 251);
            this.lb_smy.Name = "lb_smy";
            this.lb_smy.Size = new System.Drawing.Size(75, 23);
            this.lb_smy.TabIndex = 11;
            this.lb_smy.Text = "요약";
            this.lb_smy.UseVisualStyleBackColor = true;
            this.lb_smy.Click += new System.EventHandler(this.lb_smy_Click);
            // 
            // lb2
            // 
            this.lb2.Font = new System.Drawing.Font("굴림", 12F);
            this.lb2.FormattingEnabled = true;
            this.lb2.ItemHeight = 16;
            this.lb2.Location = new System.Drawing.Point(370, 287);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(309, 196);
            this.lb2.TabIndex = 12;
            // 
            // lb_msg
            // 
            this.lb_msg.AutoSize = true;
            this.lb_msg.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_msg.Location = new System.Drawing.Point(12, 519);
            this.lb_msg.Name = "lb_msg";
            this.lb_msg.Size = new System.Drawing.Size(55, 16);
            this.lb_msg.TabIndex = 13;
            this.lb_msg.Text = "[msg]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 558);
            this.Controls.Add(this.lb_msg);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb_smy);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lb_del);
            this.Controls.Add(this.lb_add);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.clb1);
            this.Controls.Add(this.clb_del);
            this.Controls.Add(this.clb_add);
            this.Controls.Add(this.clb_text);
            this.Controls.Add(this.cb_del);
            this.Controls.Add(this.cb_add);
            this.Controls.Add(this.cb_list);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_list;
        private System.Windows.Forms.Button cb_add;
        private System.Windows.Forms.Button cb_del;
        private System.Windows.Forms.TextBox clb_text;
        private System.Windows.Forms.Button clb_add;
        private System.Windows.Forms.Button clb_del;
        private System.Windows.Forms.CheckedListBox clb1;
        private System.Windows.Forms.TextBox lb_text;
        private System.Windows.Forms.Button lb_add;
        private System.Windows.Forms.Button lb_del;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Button lb_smy;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Label lb_msg;
    }
}

