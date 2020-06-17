namespace 综合项目
{
    partial class shimingxinxi
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
            this.dataGridViewShi = new System.Windows.Forms.DataGridView();
            this.yhname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yhmenhao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShi
            // 
            this.dataGridViewShi.AllowUserToAddRows = false;
            this.dataGridViewShi.AllowUserToDeleteRows = false;
            this.dataGridViewShi.AllowUserToResizeColumns = false;
            this.dataGridViewShi.AllowUserToResizeRows = false;
            this.dataGridViewShi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yhname,
            this.yhmenhao,
            this.phone});
            this.dataGridViewShi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShi.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewShi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewShi.Name = "dataGridViewShi";
            this.dataGridViewShi.ReadOnly = true;
            this.dataGridViewShi.RowHeadersVisible = false;
            this.dataGridViewShi.RowTemplate.Height = 27;
            this.dataGridViewShi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShi.Size = new System.Drawing.Size(507, 392);
            this.dataGridViewShi.TabIndex = 1;
            this.dataGridViewShi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShi_CellContentClick);
            // 
            // yhname
            // 
            this.yhname.DataPropertyName = "yhname";
            this.yhname.HeaderText = "姓名";
            this.yhname.Name = "yhname";
            this.yhname.ReadOnly = true;
            // 
            // yhmenhao
            // 
            this.yhmenhao.DataPropertyName = "yhmenhao";
            this.yhmenhao.HeaderText = "楼房编号";
            this.yhmenhao.Name = "yhmenhao";
            this.yhmenhao.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "电话";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // shimingxinxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 392);
            this.Controls.Add(this.dataGridViewShi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "shimingxinxi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实名信息";
            this.Load += new System.EventHandler(this.shimingxinxi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yhname;
        private System.Windows.Forms.DataGridViewTextBoxColumn yhmenhao;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
    }
}