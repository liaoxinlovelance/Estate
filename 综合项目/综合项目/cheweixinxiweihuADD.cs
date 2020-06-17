#region  老版
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
//    public partial class cheweixinxiweihuADD : Form
//    {
//        public cheweixinxiweihuADD()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            string box1 = this.textBox1.Text;
//            string box2 = this.textBox2.Text;
//            string box3 = this.textBox3.Text;
//            string box4 = "";
//            if (this.radioButton1.Checked)
//            {
//                box4 = "占用";
//            }
//            else if (this.radioButton2.Checked)
//            {
//                box4 = "闲置";
//            }

//            string box5 = "";
//            if (this.radioButton3.Checked)
//            {
//                box5 = this.radioButton3.Text ;
//            }
//            else if (this.radioButton4.Checked)
//            {
//                box5 = this.radioButton4.Text;
//            }


//            string sql = string.Format(@"
//
//INSERT INTO [dbo].[Cheweixinxi]
//           ([cwID]
//           ,[CheIDs]
//           ,[ChePrice]
//           ,[CheZhang]
//           ,[Chetype])
//     VALUES
//           ('{0}'
//           ,'{1}'
//           ,'{2}'
//           ,'{3}'
//           ,'{4}')
//
//
//
//
//", box1, box2, box3, box4,box5);
//            if (DBHelper.Execute(sql))
//            {
//                MessageBox.Show("添加成功！");
                
//            }
//            else
//            {
//                MessageBox.Show("添加失败！");
//            }
//        }
//    }
//}
#endregion 
#region 操作人周文韬    
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
    public partial class cheweixinxiweihuADD : Form
    {
        public cheweixinxiweihuADD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string box1 = this.textBox1.Text;
            string box2 = this.textBox2.Text;
            string box3 = this.textBox3.Text;
            string box4 = "";
            if (this.radioButton1.Checked)
            {
                box4 = "占用";
            }
            else if (this.radioButton2.Checked)
            {
                box4 = "闲置";
            }

            string box5 = "";
            if (this.radioButton3.Checked)
            {
                box5 = this.radioButton3.Text;
            }
            else if (this.radioButton4.Checked)
            {
                box5 = this.radioButton4.Text;
            }


            //            string sql = string.Format(@"
            //
            //INSERT INTO [dbo].[Cheweixinxi]
            //           ([cwID]
            //           ,[CheIDs]
            //           ,[ChePrice]
            //           ,[CheZhang]
            //           ,[Chetype])
            //     VALUES
            //           ('{0}'
            //           ,'{1}'
            //           ,'{2}'
            //           ,'{3}'
            //           ,'{4}')
            //
            //
            //
            //
            //", box1, box2, box3, box4,box5);
            List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@cwid",box1),
                new SqlParameter("@cheid",box2),
                new SqlParameter("@jg",box3),
                new SqlParameter("@zhang",box4),
                new SqlParameter("@type",box5)

            };
            SqlParameter[] parm = list.ToArray();
            string procname = "P_cheweijia";
            if (DBHelper.ExecutenonQuery(procname, parm))
            {
                MessageBox.Show("添加成功！");

            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void cheweixinxiweihuADD_Load(object sender, EventArgs e)
        {

        }
    }
}


#endregion