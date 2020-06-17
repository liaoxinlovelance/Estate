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
    public partial class loupan : Form
    {
        public loupan()
        {
            InitializeComponent();
        }

        private void loupan_Load(object sender, EventArgs e)
        {
            SelectList();
            
        }
        private void SelectList()
        {
            string sql = string.Format(@"
SELECT [LouID]
      
      ,[LouUser]
      ,[fanwuleixing]
  FROM [dbo].[LouPan]


");
            DataTable dt = DBHelper.Select(sql);
            this.dgv_loupanweihu.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmguanliyuanmain Form8 = new Frmguanliyuanmain();
            Form8.Show();
        }

        private void btn_cha_Click(object sender, EventArgs e)
        {
            string name = this.tbx_cha.Text;

            string sql = string.Format(@"SELECT [LouID]
      
      ,[LouUser]
      ,[fanwuleixing]
  FROM [dbo].[LouPan]
                                  where [LouUser] like '%{0}%'", name);
            this.dgv_loupanweihu.DataSource = DBHelper.Select(sql);
        }

        
    }
}
