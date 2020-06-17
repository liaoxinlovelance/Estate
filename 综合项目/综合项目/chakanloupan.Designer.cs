namespace 综合项目
{
    partial class chakanloupan
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewLou = new System.Windows.Forms.DataGridView();
            this.lfID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LouID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LouPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LouZhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loupantype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLou)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewLou
            // 
            this.dataGridViewLou.AllowUserToAddRows = false;
            this.dataGridViewLou.AllowUserToDeleteRows = false;
            this.dataGridViewLou.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLou.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLou.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lfID,
            this.LouID,
            this.LouPrice,
            this.LouZhang,
            this.loupantype});
            this.dataGridViewLou.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewLou.Location = new System.Drawing.Point(11, 75);
            this.dataGridViewLou.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewLou.Name = "dataGridViewLou";
            this.dataGridViewLou.ReadOnly = true;
            this.dataGridViewLou.RowHeadersVisible = false;
            this.dataGridViewLou.RowTemplate.Height = 27;
            this.dataGridViewLou.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLou.Size = new System.Drawing.Size(734, 415);
            this.dataGridViewLou.TabIndex = 1;
            // 
            // lfID
            // 
            this.lfID.DataPropertyName = "lfID";
            this.lfID.HeaderText = "楼房编号";
            this.lfID.Name = "lfID";
            this.lfID.ReadOnly = true;
            // 
            // LouID
            // 
            this.LouID.DataPropertyName = "LouID";
            this.LouID.HeaderText = "楼盘号";
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
            // loupantype
            // 
            this.loupantype.DataPropertyName = "loupantype";
            this.loupantype.HeaderText = "楼盘类型";
            this.loupantype.Name = "loupantype";
            this.loupantype.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "楼房类型：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "商品房",
            "廉租房"});
            this.comboBox1.Location = new System.Drawing.Point(77, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "拥有",
            "出租",
            "闲置"});
            this.comboBox2.Location = new System.Drawing.Point(270, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "楼房状态：";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 12F);
            this.button2.Location = new System.Drawing.Point(579, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "添加楼房";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 12F);
            this.button3.Location = new System.Drawing.Point(660, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 58);
            this.button3.TabIndex = 10;
            this.button3.Text = "刷新";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chakanloupan
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(771, 501);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLou);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "chakanloupan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看楼盘";
            this.Load += new System.EventHandler(this.loupanxinxi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLou)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLou;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lfID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LouID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LouPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn LouZhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn loupantype;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

    }
}