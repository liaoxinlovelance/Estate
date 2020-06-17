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
//    public partial class TongZhiYongHu : Form
//    {
//        public TongZhiYongHu()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {   int box1 =int.Parse ( this.textBox1.Text);
//            DateTime box2 = Convert.ToDateTime(this.dateTimePicker1.Text );
//            string box3 = this.textBox1.Text;
//            if (true  )
//            {
            
//            string sql = string.Format(@"
//INSERT INTO [dbo].[TongZhi]
//           ([yhtzID]
//           ,[TZtime]
//           ,[TZnr])
//     VALUES
//           ('{0}'
//           ,'{1}'
//           ,'{2}')
//
//
//",box1 ,box2 ,box3 );
//            if (DBHelper .Execute(sql )  )
//            {
//                MessageBox.Show("发送成功！");
//            }
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
    public partial class TongZhiYongHu : Form
    {
        public TongZhiYongHu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // int box1 = int.Parse(this.textBox1.Text);
            DateTime box2 = Convert.ToDateTime(this.dateTimePicker1.Text);
            string box3 = this.textBox2.Text;
            if (true)
            {

                //            string sql = string.Format(@"
                //INSERT INTO [dbo].[TongZhi]
                //           ([yhtzID]
                //           ,[TZtime]
                //           ,[TZnr])
                //     VALUES
                //           ('{0}'
                //           ,'{1}'
                //           ,'{2}')
                //
                //
                //",box1 ,box2 ,box3 );
            //    List<SqlParameter> list = new List<SqlParameter>(){
            //   // new SqlParameter("@id",box1),
            //    new SqlParameter("@TZtime",box2),
            //    new SqlParameter("@TZnr",box3)

            //};
            //    //SqlParameter[] parm = list.ToArray();
            //    //string procname = " Pro_TongZhiYongHu";
                SqlParameter[] parm = new SqlParameter[] { 
                new SqlParameter("@TZtime",box2),
                 new SqlParameter("@TZnr",box3)
                };
                if (DBHelper.ExcutePrc("Pro_TongZhiYongHu", parm))
                {
                    MessageBox.Show("发送成功！");
                }
                else
                {
                    MessageBox.Show("发送失败！");
                }
            }

        }

        private void TongZhiYongHu_Load(object sender, EventArgs e)
        {

        }
    }
}

#endregion
