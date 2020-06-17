namespace 综合项目
{
    partial class chakanshangpingjiage
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
            this.dataGridViewGoods = new System.Windows.Forms.DataGridView();
            this.GoodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGoods
            // 
            this.dataGridViewGoods.AllowUserToAddRows = false;
            this.dataGridViewGoods.AllowUserToDeleteRows = false;
            this.dataGridViewGoods.AllowUserToResizeColumns = false;
            this.dataGridViewGoods.AllowUserToResizeRows = false;
            this.dataGridViewGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GoodID,
            this.GoodType,
            this.GoodName,
            this.GoodPrice});
            this.dataGridViewGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGoods.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGoods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewGoods.Name = "dataGridViewGoods";
            this.dataGridViewGoods.ReadOnly = true;
            this.dataGridViewGoods.RowHeadersVisible = false;
            this.dataGridViewGoods.RowTemplate.Height = 27;
            this.dataGridViewGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGoods.Size = new System.Drawing.Size(601, 406);
            this.dataGridViewGoods.TabIndex = 1;
            // 
            // GoodID
            // 
            this.GoodID.DataPropertyName = "GoodID";
            this.GoodID.HeaderText = "商品编号";
            this.GoodID.Name = "GoodID";
            this.GoodID.ReadOnly = true;
            // 
            // GoodType
            // 
            this.GoodType.DataPropertyName = "GoodType";
            this.GoodType.HeaderText = "商品种类";
            this.GoodType.Name = "GoodType";
            this.GoodType.ReadOnly = true;
            // 
            // GoodName
            // 
            this.GoodName.DataPropertyName = "GoodName";
            this.GoodName.HeaderText = "商品名称";
            this.GoodName.Name = "GoodName";
            this.GoodName.ReadOnly = true;
            // 
            // GoodPrice
            // 
            this.GoodPrice.DataPropertyName = "GoodPrice";
            this.GoodPrice.HeaderText = "商品价格";
            this.GoodPrice.Name = "GoodPrice";
            this.GoodPrice.ReadOnly = true;
            // 
            // chakanshangpingjiage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 406);
            this.Controls.Add(this.dataGridViewGoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "chakanshangpingjiage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看商品价格";
            this.Load += new System.EventHandler(this.chakanshangpingjiage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodPrice;
    }
}