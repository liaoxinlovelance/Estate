using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 综合项目
{
    public partial class loupanxinxi : Form
    {
        public loupanxinxi()
        {
            InitializeComponent();
        }

        

        private void loupanxinxi_Load(object sender, EventArgs e)
        {
            dataGridViewLou.AutoGenerateColumns = false;
            string select = string.Format("select * from LouPan");
            dataGridViewLou.DataSource = DBHelper.Select(select);
       
        }

        private void btncha_Click(object sender, EventArgs e)
        {

            string select = string.Format("select * from LouPan where LouUser like'%{0}%' ", textname.Text);
            dataGridViewLou.DataSource = DBHelper.Select(select);
        }
    }
}
