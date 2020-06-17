namespace 综合项目
{
    partial class jiaofeichongzhi
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
            this.textchong = new System.Windows.Forms.TextBox();
            this.btnqu = new System.Windows.Forms.Button();
            this.btnque = new System.Windows.Forms.Button();
            this.lblti = new System.Windows.Forms.Label();
            this.lblchong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textchong
            // 
            this.textchong.Location = new System.Drawing.Point(247, 125);
            this.textchong.Margin = new System.Windows.Forms.Padding(4);
            this.textchong.Name = "textchong";
            this.textchong.Size = new System.Drawing.Size(161, 25);
            this.textchong.TabIndex = 7;
            // 
            // btnqu
            // 
            this.btnqu.Location = new System.Drawing.Point(345, 268);
            this.btnqu.Margin = new System.Windows.Forms.Padding(4);
            this.btnqu.Name = "btnqu";
            this.btnqu.Size = new System.Drawing.Size(100, 29);
            this.btnqu.TabIndex = 5;
            this.btnqu.Text = "取消";
            this.btnqu.UseVisualStyleBackColor = true;
            this.btnqu.Click += new System.EventHandler(this.btnqu_Click);
            // 
            // btnque
            // 
            this.btnque.Location = new System.Drawing.Point(141, 268);
            this.btnque.Margin = new System.Windows.Forms.Padding(4);
            this.btnque.Name = "btnque";
            this.btnque.Size = new System.Drawing.Size(100, 29);
            this.btnque.TabIndex = 6;
            this.btnque.Text = "确认充值";
            this.btnque.UseVisualStyleBackColor = true;
            this.btnque.Click += new System.EventHandler(this.btnque_Click);
            // 
            // lblti
            // 
            this.lblti.AutoSize = true;
            this.lblti.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblti.Location = new System.Drawing.Point(433, 137);
            this.lblti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblti.Name = "lblti";
            this.lblti.Size = new System.Drawing.Size(111, 13);
            this.lblti.TabIndex = 3;
            this.lblti.Text = "以人民币元为单位";
            // 
            // lblchong
            // 
            this.lblchong.AutoSize = true;
            this.lblchong.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblchong.Location = new System.Drawing.Point(64, 127);
            this.lblchong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblchong.Name = "lblchong";
            this.lblchong.Size = new System.Drawing.Size(152, 18);
            this.lblchong.TabIndex = 4;
            this.lblchong.Text = "请输入充值金额：";
            // 
            // jiaofeichongzhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 377);
            this.Controls.Add(this.textchong);
            this.Controls.Add(this.btnqu);
            this.Controls.Add(this.btnque);
            this.Controls.Add(this.lblti);
            this.Controls.Add(this.lblchong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "jiaofeichongzhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "缴费充值";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textchong;
        private System.Windows.Forms.Button btnqu;
        private System.Windows.Forms.Button btnque;
        private System.Windows.Forms.Label lblti;
        private System.Windows.Forms.Label lblchong;
    }
}