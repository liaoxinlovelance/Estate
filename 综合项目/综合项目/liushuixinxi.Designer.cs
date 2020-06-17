namespace 综合项目
{
    partial class liushuixinxi
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
            this.dataGridViewLiu = new System.Windows.Forms.DataGridView();
            this.yhname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xiaofeijinge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xiaofeiType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xiaofeiDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLiu
            // 
            this.dataGridViewLiu.AllowUserToAddRows = false;
            this.dataGridViewLiu.AllowUserToDeleteRows = false;
            this.dataGridViewLiu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLiu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLiu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yhname,
            this.xiaofeijinge,
            this.xiaofeiType,
            this.xiaofeiDate});
            this.dataGridViewLiu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLiu.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLiu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewLiu.Name = "dataGridViewLiu";
            this.dataGridViewLiu.ReadOnly = true;
            this.dataGridViewLiu.RowHeadersVisible = false;
            this.dataGridViewLiu.RowTemplate.Height = 27;
            this.dataGridViewLiu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLiu.Size = new System.Drawing.Size(593, 403);
            this.dataGridViewLiu.TabIndex = 1;
           // this.dataGridViewLiu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLiu_CellContentClick);
            // 
            // yhname
            // 
            this.yhname.DataPropertyName = "yhname";
            this.yhname.HeaderText = "用户名";
            this.yhname.Name = "yhname";
            this.yhname.ReadOnly = true;
            // 
            // xiaofeijinge
            // 
            this.xiaofeijinge.DataPropertyName = "xiaofeijinge";
            this.xiaofeijinge.HeaderText = "消费金额";
            this.xiaofeijinge.Name = "xiaofeijinge";
            this.xiaofeijinge.ReadOnly = true;
            // 
            // xiaofeiType
            // 
            this.xiaofeiType.DataPropertyName = "xiaofeiType";
            this.xiaofeiType.HeaderText = "消费种类";
            this.xiaofeiType.Name = "xiaofeiType";
            this.xiaofeiType.ReadOnly = true;
            // 
            // xiaofeiDate
            // 
            this.xiaofeiDate.DataPropertyName = "xiaofeiDate";
            this.xiaofeiDate.HeaderText = "消费日期";
            this.xiaofeiDate.Name = "xiaofeiDate";
            this.xiaofeiDate.ReadOnly = true;
            // 
            // liushuixinxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 403);
            this.Controls.Add(this.dataGridViewLiu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "liushuixinxi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "流水信息";
            this.Load += new System.EventHandler(this.liushuixinxi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLiu;
        private System.Windows.Forms.DataGridViewTextBoxColumn yhname;
        private System.Windows.Forms.DataGridViewTextBoxColumn xiaofeijinge;
        private System.Windows.Forms.DataGridViewTextBoxColumn xiaofeiType;
        private System.Windows.Forms.DataGridViewTextBoxColumn xiaofeiDate;
    }
}