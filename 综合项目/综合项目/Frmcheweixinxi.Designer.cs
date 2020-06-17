namespace 综合项目
{
    partial class Frmcheweixinxi
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
            this.tbx_cha = new System.Windows.Forms.TextBox();
            this.lbl_cha = new System.Windows.Forms.Label();
            this.btn_cha = new System.Windows.Forms.Button();
            this.dgv_cheweixinxiweihu = new System.Windows.Forms.DataGridView();
            this.CheID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheZhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctms_cheweixinxiweihu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cheweixinxiweihu)).BeginInit();
            this.ctms_cheweixinxiweihu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_cha
            // 
            this.tbx_cha.Location = new System.Drawing.Point(99, 12);
            this.tbx_cha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_cha.Name = "tbx_cha";
            this.tbx_cha.Size = new System.Drawing.Size(128, 25);
            this.tbx_cha.TabIndex = 16;
            // 
            // lbl_cha
            // 
            this.lbl_cha.AutoSize = true;
            this.lbl_cha.Location = new System.Drawing.Point(11, 16);
            this.lbl_cha.Name = "lbl_cha";
            this.lbl_cha.Size = new System.Drawing.Size(82, 15);
            this.lbl_cha.TabIndex = 15;
            this.lbl_cha.Text = "输入业主名";
            // 
            // btn_cha
            // 
            this.btn_cha.Location = new System.Drawing.Point(451, 10);
            this.btn_cha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cha.Name = "btn_cha";
            this.btn_cha.Size = new System.Drawing.Size(75, 26);
            this.btn_cha.TabIndex = 14;
            this.btn_cha.Text = "查询";
            this.btn_cha.UseVisualStyleBackColor = true;
            this.btn_cha.Click += new System.EventHandler(this.btn_cha_Click);
            // 
            // dgv_cheweixinxiweihu
            // 
            this.dgv_cheweixinxiweihu.AllowUserToAddRows = false;
            this.dgv_cheweixinxiweihu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cheweixinxiweihu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cheweixinxiweihu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheID,
            this.ChePrice,
            this.CheZhang,
            this.CheUser});
            this.dgv_cheweixinxiweihu.Location = new System.Drawing.Point(4, 60);
            this.dgv_cheweixinxiweihu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_cheweixinxiweihu.Name = "dgv_cheweixinxiweihu";
            this.dgv_cheweixinxiweihu.RowHeadersVisible = false;
            this.dgv_cheweixinxiweihu.RowTemplate.Height = 27;
            this.dgv_cheweixinxiweihu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cheweixinxiweihu.Size = new System.Drawing.Size(597, 370);
            this.dgv_cheweixinxiweihu.TabIndex = 13;
            // 
            // CheID
            // 
            this.CheID.DataPropertyName = "CheID";
            this.CheID.HeaderText = "车位编号";
            this.CheID.Name = "CheID";
            // 
            // ChePrice
            // 
            this.ChePrice.DataPropertyName = "ChePrice";
            this.ChePrice.HeaderText = "收费价格";
            this.ChePrice.Name = "ChePrice";
            // 
            // CheZhang
            // 
            this.CheZhang.DataPropertyName = "CheZhang";
            this.CheZhang.HeaderText = "使用状态";
            this.CheZhang.Name = "CheZhang";
            // 
            // CheUser
            // 
            this.CheUser.DataPropertyName = "CheUser";
            this.CheUser.HeaderText = "使用用户";
            this.CheUser.Name = "CheUser";
            // 
            // ctms_cheweixinxiweihu
            // 
            this.ctms_cheweixinxiweihu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.ctms_cheweixinxiweihu.Name = "ctms_cheweixinxiweihu";
            this.ctms_cheweixinxiweihu.Size = new System.Drawing.Size(109, 76);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.添加ToolStripMenuItem.Text = "添加";
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.修改ToolStripMenuItem.Text = "修改";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // Frmcheweixinxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(608, 435);
            this.Controls.Add(this.tbx_cha);
            this.Controls.Add(this.lbl_cha);
            this.Controls.Add(this.btn_cha);
            this.Controls.Add(this.dgv_cheweixinxiweihu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmcheweixinxi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "车位信息维护";
            this.Load += new System.EventHandler(this.Frmcheweixinxi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cheweixinxiweihu)).EndInit();
            this.ctms_cheweixinxiweihu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_cha;
        private System.Windows.Forms.Label lbl_cha;
        private System.Windows.Forms.Button btn_cha;
        private System.Windows.Forms.DataGridView dgv_cheweixinxiweihu;
        private System.Windows.Forms.ContextMenuStrip ctms_cheweixinxiweihu;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheZhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheUser;
    }
}