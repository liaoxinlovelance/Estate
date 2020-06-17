#region 老版


//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace 综合项目
//{
//    public partial class Frmcheweixinxi : Form
//    {
//        public Frmcheweixinxi()
//        {
//            InitializeComponent();
//        }

//        private void Frmcheweixinxi_Load(object sender, EventArgs e)
//        {
//            jiazai();

//        }

//        private void jiazai()
//        {
//            string sql = string.Format(@"
//SELECT [CheID]
//      ,[ChePrice]
//      ,[CheZhang]
//      ,[CheUser]
//  FROM [dbo].[Cheweixinxi]
//
//
//");
//            DataTable dt = DBHelper.Select(sql);

//            this.dgv_cheweixinxiweihu.DataSource = dt;

//        }




//        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            int count = this.dgv_cheweixinxiweihu.SelectedRows.Count;
//            if (count > 0)
//            {
//                string name = this.dgv_cheweixinxiweihu.SelectedRows[0].Cells["LoupanName"].Value.ToString();
//                string sql = string.Format(@"
//DELETE FROM [dbo].[Cheweixinxi]
//      
//
// where LoupanName='{0}'", name);
//                if (DBHelper.Execute(sql))
//                {
//                    MessageBox.Show("删除成功！");

//                }
//                else
//                {
//                    MessageBox.Show("删除失败！");
//                }
//            }
//            else
//            {
//                MessageBox.Show("请选中要删除的数据行！");
//            }
//        }

//        private void btn_cha_Click(object sender, EventArgs e)
//        {
//            string name = this.tbx_cha.Text;
//            string sql = string.Format(@"
//SELECT [CheID]
//      ,[ChePrice]
//      ,[CheZhang]
//      ,[CheUser]
//  FROM [dbo].[Cheweixinxi]
//where CheUser='{0}'
//
//", name);
//            DataTable dt = DBHelper.Select(sql);

//            this.dgv_cheweixinxiweihu.DataSource = dt;
//        }
//    }
//}
#endregion
#region 新版操作人 周文韬
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
    public partial class Frmcheweixinxi : Form
    {
        public Frmcheweixinxi()
        {
            InitializeComponent();
        }

        private void Frmcheweixinxi_Load(object sender, EventArgs e)
        {
            jiazai();

        }

        private void jiazai()
        {
            //            string sql = string.Format(@"
            //SELECT [CheID]
            //      ,[ChePrice]
            //      ,[CheZhang]
            //      ,[CheUser]
            //  FROM [dbo].[Cheweixinxi]
            //
            //
            //");
            DataTable dt = DBHelper.GetDataTable("P_chewei");

            this.dgv_cheweixinxiweihu.DataSource = dt;

        }




        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = this.dgv_cheweixinxiweihu.SelectedRows.Count;
            if (count > 0)
            {
                string id = this.dgv_cheweixinxiweihu.SelectedRows[0].Cells["CheIDs"].Value.ToString();
                //                string sql = string.Format(@"
                //DELETE FROM [dbo].[Cheweixinxi]
                //      
                //
                // where LoupanName='{0}'", name);
                List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@id",id),

            };
                SqlParameter[] parm = list.ToArray();
                string procname = "P_cheweishan";
                if (DBHelper.ExecutenonQuery(procname, parm))
                {
                    MessageBox.Show("删除成功！");

                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            else
            {
                MessageBox.Show("请选中要删除的数据行！");
            }
        }

        private void btn_cha_Click(object sender, EventArgs e)
        {
            string name = this.tbx_cha.Text;
            //            string sql = string.Format(@"
            //SELECT [CheID]
            //      ,[ChePrice]
            //      ,[CheZhang]
            //      ,[CheUser]
            //  FROM [dbo].[Cheweixinxi]
            //where CheUser='{0}'
            //
            //", name);
            List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@name",name),

            };
            SqlParameter[] parm = list.ToArray();
            string procname = "P_cheweiy";
            DataTable dt = DBHelper.Select(procname, parm);

            this.dgv_cheweixinxiweihu.DataSource = dt;
        }

        private void dgv_cheweixinxiweihu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

#endregion