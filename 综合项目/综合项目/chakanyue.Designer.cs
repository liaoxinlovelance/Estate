namespace 综合项目
{
    partial class chakanyue
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
            this.dataGridViewYu = new System.Windows.Forms.DataGridView();
            this.yhname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewYu
            // 
            this.dataGridViewYu.AllowUserToAddRows = false;
            this.dataGridViewYu.AllowUserToDeleteRows = false;
            this.dataGridViewYu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewYu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yhname,
            this.Yue});
            this.dataGridViewYu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewYu.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewYu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewYu.Name = "dataGridViewYu";
            this.dataGridViewYu.ReadOnly = true;
            this.dataGridViewYu.RowHeadersVisible = false;
            this.dataGridViewYu.RowTemplate.Height = 27;
            this.dataGridViewYu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewYu.Size = new System.Drawing.Size(660, 405);
            this.dataGridViewYu.TabIndex = 1;
            // 
            // yhname
            // 
            this.yhname.DataPropertyName = "yhname";
            this.yhname.HeaderText = "用户名";
            this.yhname.Name = "yhname";
            this.yhname.ReadOnly = true;
            // 
            // Yue
            // 
            this.Yue.DataPropertyName = "Yue";
            this.Yue.HeaderText = "账户余额";
            this.Yue.Name = "Yue";
            this.Yue.ReadOnly = true;
            // 
            // chakanyue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 405);
            this.Controls.Add(this.dataGridViewYu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "chakanyue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看余额";
            this.Load += new System.EventHandler(this.chakanyue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewYu;
        private System.Windows.Forms.DataGridViewTextBoxColumn yhname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yue;
    }
}