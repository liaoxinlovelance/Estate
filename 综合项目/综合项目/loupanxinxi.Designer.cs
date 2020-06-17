namespace 综合项目
{
    partial class loupanxinxi
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
            this.dataGridViewLou = new System.Windows.Forms.DataGridView();
            this.LouID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LouPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LouZhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LouUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncha = new System.Windows.Forms.Button();
            this.textname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLou)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLou
            // 
            this.dataGridViewLou.AllowUserToAddRows = false;
            this.dataGridViewLou.AllowUserToDeleteRows = false;
            this.dataGridViewLou.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLou.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLou.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLou.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LouID,
            this.LouPrice,
            this.LouZhang,
            this.LouUser});
            this.dataGridViewLou.Location = new System.Drawing.Point(0, 88);
            this.dataGridViewLou.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewLou.Name = "dataGridViewLou";
            this.dataGridViewLou.ReadOnly = true;
            this.dataGridViewLou.RowHeadersVisible = false;
            this.dataGridViewLou.RowTemplate.Height = 27;
            this.dataGridViewLou.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLou.Size = new System.Drawing.Size(607, 262);
            this.dataGridViewLou.TabIndex = 1;
            // 
            // LouID
            // 
            this.LouID.DataPropertyName = "LouID";
            this.LouID.HeaderText = "楼盘编号";
            this.LouID.Name = "LouID";
            this.LouID.ReadOnly = true;
            // 
            // LouPrice
            // 
            this.LouPrice.DataPropertyName = "LouPrice";
            this.LouPrice.HeaderText = "楼盘价格";
            this.LouPrice.Name = "LouPrice";
            this.LouPrice.ReadOnly = true;
            // 
            // LouZhang
            // 
            this.LouZhang.DataPropertyName = "LouZhang";
            this.LouZhang.HeaderText = "楼房状态";
            this.LouZhang.Name = "LouZhang";
            this.LouZhang.ReadOnly = true;
            // 
            // LouUser
            // 
            this.LouUser.DataPropertyName = "LouUser";
            this.LouUser.HeaderText = "使用者";
            this.LouUser.Name = "LouUser";
            this.LouUser.ReadOnly = true;
            // 
            // btncha
            // 
            this.btncha.Location = new System.Drawing.Point(450, 32);
            this.btncha.Name = "btncha";
            this.btncha.Size = new System.Drawing.Size(75, 23);
            this.btncha.TabIndex = 7;
            this.btncha.Text = "查询";
            this.btncha.UseVisualStyleBackColor = true;
            this.btncha.Click += new System.EventHandler(this.btncha_Click);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(215, 30);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(174, 25);
            this.textname.TabIndex = 6;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(62, 36);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(97, 15);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "请输入用户名";
            // 
            // loupanxinxi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(607, 350);
            this.Controls.Add(this.btncha);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.dataGridViewLou);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "loupanxinxi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "楼盘信息";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.loupanxinxi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLou)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLou;
        private System.Windows.Forms.DataGridViewTextBoxColumn LouID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LouPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn LouZhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn LouUser;
        private System.Windows.Forms.Button btncha;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label lblname;

    }
}