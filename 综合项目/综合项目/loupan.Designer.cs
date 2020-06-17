namespace 综合项目
{
    partial class loupan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_loupanweihu = new System.Windows.Forms.DataGridView();
            this.tbx_cha = new System.Windows.Forms.TextBox();
            this.lbl_cha = new System.Windows.Forms.Label();
            this.btn_cha = new System.Windows.Forms.Button();
            this.LouID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LouUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fanwuleixing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loupanweihu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_loupanweihu
            // 
            this.dgv_loupanweihu.AllowUserToAddRows = false;
            this.dgv_loupanweihu.AllowUserToDeleteRows = false;
            this.dgv_loupanweihu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_loupanweihu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loupanweihu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LouID,
            this.LouUser,
            this.fanwuleixing});
            this.dgv_loupanweihu.Location = new System.Drawing.Point(-2, 47);
            this.dgv_loupanweihu.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_loupanweihu.Name = "dgv_loupanweihu";
            this.dgv_loupanweihu.RowHeadersVisible = false;
            this.dgv_loupanweihu.RowTemplate.Height = 27;
            this.dgv_loupanweihu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_loupanweihu.Size = new System.Drawing.Size(578, 313);
            this.dgv_loupanweihu.TabIndex = 13;
            // 
            // tbx_cha
            // 
            this.tbx_cha.Location = new System.Drawing.Point(83, 10);
            this.tbx_cha.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_cha.Name = "tbx_cha";
            this.tbx_cha.Size = new System.Drawing.Size(97, 21);
            this.tbx_cha.TabIndex = 12;
            // 
            // lbl_cha
            // 
            this.lbl_cha.AutoSize = true;
            this.lbl_cha.Location = new System.Drawing.Point(17, 12);
            this.lbl_cha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cha.Name = "lbl_cha";
            this.lbl_cha.Size = new System.Drawing.Size(65, 12);
            this.lbl_cha.TabIndex = 11;
            this.lbl_cha.Text = "输入业主名";
            // 
            // btn_cha
            // 
            this.btn_cha.Location = new System.Drawing.Point(345, 12);
            this.btn_cha.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cha.Name = "btn_cha";
            this.btn_cha.Size = new System.Drawing.Size(56, 21);
            this.btn_cha.TabIndex = 10;
            this.btn_cha.Text = "查询";
            this.btn_cha.UseVisualStyleBackColor = true;
            this.btn_cha.Click += new System.EventHandler(this.btn_cha_Click);
            // 
            // LouID
            // 
            this.LouID.DataPropertyName = "LouID";
            this.LouID.HeaderText = "楼盘号";
            this.LouID.Name = "LouID";
            // 
            // LouUser
            // 
            this.LouUser.DataPropertyName = "LouUser";
            this.LouUser.HeaderText = "住户";
            this.LouUser.Name = "LouUser";
            // 
            // fanwuleixing
            // 
            this.fanwuleixing.DataPropertyName = "fanwuleixing";
            this.fanwuleixing.HeaderText = "房屋类型";
            this.fanwuleixing.Name = "fanwuleixing";
            // 
            // loupan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(574, 361);
            this.Controls.Add(this.dgv_loupanweihu);
            this.Controls.Add(this.tbx_cha);
            this.Controls.Add(this.lbl_cha);
            this.Controls.Add(this.btn_cha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "loupan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "楼盘信息维护";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.loupan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loupanweihu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_loupanweihu;
        private System.Windows.Forms.TextBox tbx_cha;
        private System.Windows.Forms.Label lbl_cha;
        private System.Windows.Forms.Button btn_cha;
        private System.Windows.Forms.DataGridViewTextBoxColumn LouID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LouUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn fanwuleixing;

    }
}