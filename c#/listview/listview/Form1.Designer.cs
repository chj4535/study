namespace listview
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
            this.lv = new System.Windows.Forms.ListView();
            this.lv_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lb_ID = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_age = new System.Windows.Forms.Label();
            this.numupdown = new System.Windows.Forms.NumericUpDown();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.lb_ID2 = new System.Windows.Forms.Label();
            this.tb_ID2 = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv_ID,
            this.lv_name,
            this.lv_age});
            this.lv.Font = new System.Drawing.Font("굴림", 12F);
            this.lv.FullRowSelect = true;
            this.lv.Location = new System.Drawing.Point(13, 13);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(269, 411);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
            // 
            // lv_ID
            // 
            this.lv_ID.Text = "아이디";
            this.lv_ID.Width = 100;
            // 
            // lv_name
            // 
            this.lv_name.Text = "이름";
            this.lv_name.Width = 100;
            // 
            // lv_age
            // 
            this.lv_age.Text = "나이";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_ID.Location = new System.Drawing.Point(303, 20);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(71, 16);
            this.lb_ID.TabIndex = 1;
            this.lb_ID.Text = "아이디 : ";
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("굴림", 12F);
            this.tb_ID.Location = new System.Drawing.Point(380, 14);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(134, 26);
            this.tb_ID.TabIndex = 2;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_name.Location = new System.Drawing.Point(303, 61);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(55, 16);
            this.lb_name.TabIndex = 4;
            this.lb_name.Text = "이름 : ";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("굴림", 12F);
            this.tb_name.Location = new System.Drawing.Point(380, 55);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(134, 26);
            this.tb_name.TabIndex = 5;
            // 
            // lb_age
            // 
            this.lb_age.AutoSize = true;
            this.lb_age.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_age.Location = new System.Drawing.Point(303, 102);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(55, 16);
            this.lb_age.TabIndex = 6;
            this.lb_age.Text = "나이 : ";
            // 
            // numupdown
            // 
            this.numupdown.Font = new System.Drawing.Font("굴림", 12F);
            this.numupdown.Location = new System.Drawing.Point(380, 99);
            this.numupdown.Name = "numupdown";
            this.numupdown.Size = new System.Drawing.Size(134, 26);
            this.numupdown.TabIndex = 8;
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("굴림", 12F);
            this.btn_del.Location = new System.Drawing.Point(318, 159);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(87, 23);
            this.btn_del.TabIndex = 9;
            this.btn_del.Text = "삭제";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Font = new System.Drawing.Font("굴림", 12F);
            this.btn_modify.Location = new System.Drawing.Point(426, 159);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(87, 23);
            this.btn_modify.TabIndex = 9;
            this.btn_modify.Text = "수정";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // lb_ID2
            // 
            this.lb_ID2.AutoSize = true;
            this.lb_ID2.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_ID2.Location = new System.Drawing.Point(303, 220);
            this.lb_ID2.Name = "lb_ID2";
            this.lb_ID2.Size = new System.Drawing.Size(71, 16);
            this.lb_ID2.TabIndex = 1;
            this.lb_ID2.Text = "아이디 : ";
            // 
            // tb_ID2
            // 
            this.tb_ID2.Font = new System.Drawing.Font("굴림", 12F);
            this.tb_ID2.Location = new System.Drawing.Point(380, 214);
            this.tb_ID2.Name = "tb_ID2";
            this.tb_ID2.Size = new System.Drawing.Size(134, 26);
            this.tb_ID2.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("굴림", 12F);
            this.btn_add.Location = new System.Drawing.Point(534, 14);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(87, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "추가";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("굴림", 12F);
            this.btn_search.Location = new System.Drawing.Point(534, 214);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(87, 23);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 438);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.numupdown);
            this.Controls.Add(this.lb_age);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tb_ID2);
            this.Controls.Add(this.lb_ID2);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.lv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader lv_ID;
        private System.Windows.Forms.ColumnHeader lv_name;
        private System.Windows.Forms.ColumnHeader lv_age;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.NumericUpDown numupdown;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Label lb_ID2;
        private System.Windows.Forms.TextBox tb_ID2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_search;
    }
}

