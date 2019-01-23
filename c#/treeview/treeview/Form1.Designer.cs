namespace treeview
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
            this.tv = new System.Windows.Forms.TreeView();
            this.lb_parents = new System.Windows.Forms.Label();
            this.tb_parents = new System.Windows.Forms.TextBox();
            this.lb_child = new System.Windows.Forms.Label();
            this.tb_child = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_add2 = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.ListBox();
            this.btn_add3 = new System.Windows.Forms.Button();
            this.btn_add4 = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.Font = new System.Drawing.Font("굴림", 12F);
            this.tv.Location = new System.Drawing.Point(13, 13);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(318, 510);
            this.tv.TabIndex = 0;
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lb_parents
            // 
            this.lb_parents.AutoSize = true;
            this.lb_parents.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_parents.Location = new System.Drawing.Point(347, 23);
            this.lb_parents.Name = "lb_parents";
            this.lb_parents.Size = new System.Drawing.Size(55, 16);
            this.lb_parents.TabIndex = 1;
            this.lb_parents.Text = "부모 : ";
            // 
            // tb_parents
            // 
            this.tb_parents.Font = new System.Drawing.Font("굴림", 12F);
            this.tb_parents.Location = new System.Drawing.Point(408, 18);
            this.tb_parents.Name = "tb_parents";
            this.tb_parents.Size = new System.Drawing.Size(210, 26);
            this.tb_parents.TabIndex = 2;
            // 
            // lb_child
            // 
            this.lb_child.AutoSize = true;
            this.lb_child.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_child.Location = new System.Drawing.Point(347, 67);
            this.lb_child.Name = "lb_child";
            this.lb_child.Size = new System.Drawing.Size(55, 16);
            this.lb_child.TabIndex = 1;
            this.lb_child.Text = "자식 : ";
            // 
            // tb_child
            // 
            this.tb_child.Font = new System.Drawing.Font("굴림", 12F);
            this.tb_child.Location = new System.Drawing.Point(408, 62);
            this.tb_child.Name = "tb_child";
            this.tb_child.Size = new System.Drawing.Size(210, 26);
            this.tb_child.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("굴림", 12F);
            this.btn_add.Location = new System.Drawing.Point(350, 116);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(268, 30);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "첫번째 자식으로 추가";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_add2
            // 
            this.btn_add2.Font = new System.Drawing.Font("굴림", 12F);
            this.btn_add2.Location = new System.Drawing.Point(350, 169);
            this.btn_add2.Name = "btn_add2";
            this.btn_add2.Size = new System.Drawing.Size(268, 30);
            this.btn_add2.TabIndex = 3;
            this.btn_add2.Text = "마지막 자식으로 추가";
            this.btn_add2.UseVisualStyleBackColor = true;
            this.btn_add2.Click += new System.EventHandler(this.btn_add2_Click);
            // 
            // lb
            // 
            this.lb.Font = new System.Drawing.Font("굴림", 12F);
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 16;
            this.lb.Location = new System.Drawing.Point(350, 223);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(268, 196);
            this.lb.TabIndex = 4;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // btn_add3
            // 
            this.btn_add3.Font = new System.Drawing.Font("굴림", 12F);
            this.btn_add3.Location = new System.Drawing.Point(350, 439);
            this.btn_add3.Name = "btn_add3";
            this.btn_add3.Size = new System.Drawing.Size(268, 30);
            this.btn_add3.TabIndex = 3;
            this.btn_add3.Text = "이전 자식으로 추가";
            this.btn_add3.UseVisualStyleBackColor = true;
            this.btn_add3.Click += new System.EventHandler(this.btn_add3_Click);
            // 
            // btn_add4
            // 
            this.btn_add4.Font = new System.Drawing.Font("굴림", 12F);
            this.btn_add4.Location = new System.Drawing.Point(350, 493);
            this.btn_add4.Name = "btn_add4";
            this.btn_add4.Size = new System.Drawing.Size(268, 30);
            this.btn_add4.TabIndex = 3;
            this.btn_add4.Text = "다음 자식으로 추가";
            this.btn_add4.UseVisualStyleBackColor = true;
            this.btn_add4.Click += new System.EventHandler(this.btn_add4_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("굴림", 12F);
            this.btn_del.Location = new System.Drawing.Point(350, 548);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(268, 30);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "삭제";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_open
            // 
            this.btn_open.Font = new System.Drawing.Font("굴림", 12F);
            this.btn_open.Location = new System.Drawing.Point(13, 548);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(139, 30);
            this.btn_open.TabIndex = 3;
            this.btn_open.Text = "펼치기";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("굴림", 12F);
            this.btn_close.Location = new System.Drawing.Point(192, 548);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(139, 30);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "축소하기";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 592);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btn_add2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add4);
            this.Controls.Add(this.btn_add3);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_child);
            this.Controls.Add(this.lb_child);
            this.Controls.Add(this.tb_parents);
            this.Controls.Add(this.lb_parents);
            this.Controls.Add(this.tv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.Label lb_parents;
        private System.Windows.Forms.TextBox tb_parents;
        private System.Windows.Forms.Label lb_child;
        private System.Windows.Forms.TextBox tb_child;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_add2;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Button btn_add3;
        private System.Windows.Forms.Button btn_add4;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_close;
    }
}

