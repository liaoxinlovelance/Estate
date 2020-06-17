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
//    public partial class tianjiakahao : Form
//    {
//        public tianjiakahao()
//        {
//            InitializeComponent();
//        }
         
//        private void button1_Click(object sender, EventArgs e)
//        {
//            if (this.textBox1.Text!="")
//            {
//                  string box1 = this.textBox1.Text;
//            string sql = string.Format(@"
//
//INSERT INTO [dbo].[Userchong]
//           ([chongzhiID]
//          )
//     VALUES
//           ('{0}'
//           )
//
//
//",box1 );
//            if (DBHelper .Execute(sql ))
//            {
//                MessageBox.Show("添加成功！");
//            }
//            }
//            else
//            {
//                MessageBox.Show("不能为空！");
//            }
//        }
//    }
//}
#endregion
#region 新版 操作人周文韬
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
    public partial class tianjiakahao : Form
    {
        public tianjiakahao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                string box1 = this.textBox1.Text;
                //            string sql = string.Format(@"
                //
                //INSERT INTO [dbo].[Userchong]
                //           ([chongzhiID]
                //          )
                //     VALUES
                //           ('{0}'
                //           )
                //
                //
                //",box1 );
                List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@id",box1)
            };
                SqlParameter[] parm = list.ToArray();
                string procname = "P_tianjiakh";
                if (DBHelper.ExecutenonQuery(procname, parm))
                {
                    MessageBox.Show("添加成功！");
                }
            }
            else
            {
                MessageBox.Show("不能为空！");
            }
        }

        private void tianjiakahao_Load(object sender, EventArgs e)
        {

        }
    }
}


#endregion