namespace 综合项目
{
    partial class loupanxinxiweihu
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
            this.dgv_loupanweihu = new System.Windows.Forms.DataGridView();
            this.LouID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LouPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LouZhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yhname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loupantype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbx_cha = new System.Windows.Forms.TextBox();
            this.lbl_cha = new System.Windows.Forms.Label();
            this.btn_cha = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loupanweihu)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.LouPrice,
            this.LouZhang,
            this.yhname,
            this.loupantype});
            this.dgv_loupanweihu.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_loupanweihu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_loupanweihu.Location = new System.Drawing.Point(0, 0);
            this.dgv_loupanweihu.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_loupanweihu.Name = "dgv_loupanweihu";
            this.dgv_loupanweihu.ReadOnly = true;
            this.dgv_loupanweihu.RowHeadersVisible = false;
            this.dgv_loupanweihu.RowTemplate.Height = 27;
            this.dgv_loupanweihu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_loupanweihu.Size = new System.Drawing.Size(620, 235);
            this.dgv_loupanweihu.TabIndex = 13;
            this.dgv_loupanweihu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_loupanweihu_CellContentClick);
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
            this.LouPrice.HeaderText = "价格";
            this.LouPrice.Name = "LouPrice";
            this.LouPrice.ReadOnly = true;
            // 
            // LouZhang
            // 
            this.LouZhang.DataPropertyName = "LouZhang";
            this.LouZhang.HeaderText = "住房状态";
            this.LouZhang.Name = "LouZhang";
            this.LouZhang.ReadOnly = true;
            // 
            // yhname
            // 
            this.yhname.DataPropertyName = "yhname";
            this.yhname.HeaderText = "住户";
            this.yhname.Name = "yhname";
            this.yhname.ReadOnly = true;
            // 
            // loupantype
            // 
            this.loupantype.DataPropertyName = "loupantype";
            this.loupantype.HeaderText = "房屋类型";
            this.loupantype.Name = "loupantype";
            this.loupantype.ReadOnly = true;
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
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // tbx_cha
            // 
            this.tbx_cha.Location = new System.Drawing.Point(110, 254);
            this.tbx_cha.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_cha.Name = "tbx_cha";
            this.tbx_cha.Size = new System.Drawing.Size(136, 25);
            this.tbx_cha.TabIndex = 12;
            // 
            // lbl_cha
            // 
            this.lbl_cha.AutoSize = true;
            this.lbl_cha.Location = new System.Drawing.Point(31, 259);
            this.lbl_cha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cha.Name = "lbl_cha";
            this.lbl_cha.Size = new System.Drawing.Size(82, 15);
            this.lbl_cha.TabIndex = 11;
            this.lbl_cha.Text = "输入业主名";
            // 
            // btn_cha
            // 
            this.btn_cha.Location = new System.Drawing.Point(255, 256);
            this.btn_cha.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cha.Name = "btn_cha";
            this.btn_cha.Size = new System.Drawing.Size(56, 21);
            this.btn_cha.TabIndex = 10;
            this.btn_cha.Text = "查询";
            this.btn_cha.UseVisualStyleBackColor = true;
            this.btn_cha.Click += new System.EventHandler(this.btn_cha_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 25);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "楼盘号";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 94);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 25);
            this.textBox2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "价格";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 19);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 25);
            this.textBox3.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "住房状态";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "住户";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "房屋类型";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(96, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 19);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "拥有";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 424);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(175, 10);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 19);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "出租";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(250, 11);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 19);
            this.radioButton3.TabIndex = 25;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "闲置";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(189, 6);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(73, 19);
            this.radioButton4.TabIndex = 27;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "商品房";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(96, 7);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(73, 19);
            this.radioButton5.TabIndex = 26;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "廉租房";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(209, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "（用户名不在此处修改）";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Location = new System.Drawing.Point(228, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 34);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Location = new System.Drawing.Point(228, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 26);
            this.panel2.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(33, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 135);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "更改内容：";
            // 
            // loupanxinxiweihu
            // 
            this.AcceptButton = this.btn_cha;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(620, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_loupanweihu);
            this.Controls.Add(this.tbx_cha);
            this.Controls.Add(this.lbl_cha);
            this.Controls.Add(this.btn_cha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loupanxinxiweihu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "楼盘信息维护";
            this.Load += new System.EventHandler(this.loupan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loupanweihu)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_loupanweihu;
        private System.Windows.Forms.TextBox tbx_cha;
        private System.Windows.Forms.Label lbl_cha;
        private System.Windows.Forms.Button btn_cha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LouID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LouPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn LouZhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn yhname;
        private System.Windows.Forms.DataGridViewTextBoxColumn loupantype;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}