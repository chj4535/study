namespace WindowsFormsApplication2
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
            this.la_btn_num_text = new System.Windows.Forms.Label();
            this.la_btn_num = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.la_btn_txt = new System.Windows.Forms.Label();
            this.la_btn_clicknum = new System.Windows.Forms.Label();
            this.flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // la_btn_num_text
            // 
            this.la_btn_num_text.AutoSize = true;
            this.la_btn_num_text.Font = new System.Drawing.Font("굴림", 14F);
            this.la_btn_num_text.Location = new System.Drawing.Point(23, 37);
            this.la_btn_num_text.Name = "la_btn_num_text";
            this.la_btn_num_text.Size = new System.Drawing.Size(91, 19);
            this.la_btn_num_text.TabIndex = 0;
            this.la_btn_num_text.Text = "버튼 개수";
            // 
            // la_btn_num
            // 
            this.la_btn_num.AutoSize = true;
            this.la_btn_num.Font = new System.Drawing.Font("굴림", 15F);
            this.la_btn_num.Location = new System.Drawing.Point(137, 37);
            this.la_btn_num.Name = "la_btn_num";
            this.la_btn_num.Size = new System.Drawing.Size(20, 20);
            this.la_btn_num.TabIndex = 1;
            this.la_btn_num.Text = "0";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_add.Location = new System.Drawing.Point(186, 32);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 29);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "추가";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // flp
            // 
            this.flp.Controls.Add(this.la_btn_txt);
            this.flp.Controls.Add(this.la_btn_clicknum);
            this.flp.Location = new System.Drawing.Point(27, 109);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(247, 187);
            this.flp.TabIndex = 0;
            this.flp.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_Paint);
            // 
            // la_btn_txt
            // 
            this.la_btn_txt.AutoSize = true;
            this.la_btn_txt.Font = new System.Drawing.Font("굴림", 15F);
            this.la_btn_txt.Location = new System.Drawing.Point(30, 5);
            this.la_btn_txt.Margin = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.la_btn_txt.Name = "la_btn_txt";
            this.la_btn_txt.Size = new System.Drawing.Size(49, 20);
            this.la_btn_txt.TabIndex = 0;
            this.la_btn_txt.Text = "버튼";
            this.la_btn_txt.Click += new System.EventHandler(this.label1_Click);
            // 
            // la_btn_clicknum
            // 
            this.la_btn_clicknum.AutoSize = true;
            this.la_btn_clicknum.Font = new System.Drawing.Font("굴림", 15F);
            this.la_btn_clicknum.Location = new System.Drawing.Point(139, 5);
            this.la_btn_clicknum.Margin = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.la_btn_clicknum.Name = "la_btn_clicknum";
            this.la_btn_clicknum.Size = new System.Drawing.Size(76, 20);
            this.la_btn_clicknum.TabIndex = 1;
            this.la_btn_clicknum.Text = "클릭 수";
            this.la_btn_clicknum.Click += new System.EventHandler(this.la_btn_clicknum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 327);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.la_btn_num);
            this.Controls.Add(this.la_btn_num_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flp.ResumeLayout(false);
            this.flp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label la_btn_num_text;
        private System.Windows.Forms.Label la_btn_num;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Label la_btn_txt;
        private System.Windows.Forms.Label la_btn_clicknum;
    }
}

