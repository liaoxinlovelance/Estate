using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 综合项目
{
    public partial class chakanloupan : Form
    {
        public chakanloupan()
        {
            InitializeComponent();
        }

        

        private void loupanxinxi_Load(object sender, EventArgs e)
        {

            jiazai();
        }

        private void jiazai()
        {
            string sql = string.Format(@"

SELECT [lfID]
      ,[LouID]
      ,[LouPrice]
      ,[LouZhang]
      ,[loupantype]
  FROM [dbo].[LouPan]




");
            DataTable dt = DBHelper.Select(sql);
            this.dataGridViewLou.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string box1 = this.comboBox1.Text;
            string box2 = this.comboBox2.Text;
//            string sql = string.Format(@"
//
//
//SELECT [lfID]
//      ,[LouID]
//      ,[LouPrice]
//      ,[LouZhang]
//      ,[loupantype]
//  FROM [dbo].[LouPan]
//where [loupantype]like'%{0}%' and [LouZhang]like'%{1}%'
//",box1 ,box2 );

            //DataTable dt = DBHelper.Select(sql);
            //this.dataGridViewLou.DataSource = dt;
            //创建参数列表
            SqlParameter[] parm = new SqlParameter[] { 
            new SqlParameter("@loupantype",box1),
            new SqlParameter("@LouZhang",box2)
            };
            this.dataGridViewLou.DataSource = DBHelper.SelectPrc("Pro_chakanloupan",parm);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            楼房ADD add=new 楼房ADD();
            add.Show();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.dataGridViewLou.SelectedRows[0].Cells["lfID"].Value.ToString());
            string sql = string.Format(@"

DELETE FROM [dbo].[LouPan]
      WHERE lfID={0}

",num);
            if (DBHelper.Execute(sql))
            {
                MessageBox.Show("删除成功！");
                jiazai();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jiazai();
        }

       
    }
}
