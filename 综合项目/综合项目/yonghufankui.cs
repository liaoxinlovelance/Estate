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
    public partial class yonghufankui : Form
    {
        private static char[] constant ={'0','1','2','3','4','5','6','7','8','9'
        };
        public yonghufankui()
        {
            InitializeComponent();
        }
        public static string GetRandomNumber(int Len)
        {
            System.Text.StringBuilder newRandom = new StringBuilder(10);
            Random rd = new Random();
            for (int i = 0; i < Len; i++)
            {
                newRandom.Append(constant[rd.Next(10)]);
            }
            return newRandom.ToString();
        }     
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
          
            Frmguanliyuanmain form8 = new Frmguanliyuanmain();
            form8.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            #region 老版本
            //            try
//            {
//                string dlm = Conmen.SuoQuName;
//                string nerong = this.textBox1.Text;
//                string box3 = GetRandomNumber(3);
//                string sql = string.Format(@"
//INSERT INTO [dbo].[kefu]
//           ([kfID]
//           ,[neirong]
//           )
//     VALUES
//           ('{0}','{1}'
//           )
//
//
//", box3, nerong);
//            if (DBHelper.Execute(sql))
//                {
//                    string upddate = string.Format(@"
//
//
//UPDATE [dbo].[yonghuzhuce]
//   SET
//                
//      [kfID] = '{0}'
// WHERE  [yhdlname] = '{1}'
//
//
//", box3, dlm);
//                    if (DBHelper.Execute(sql))
//                    {
//                        MessageBox.Show("发送成功！");
//                    }
//                }
//            }
//            catch (Exception)
//            {

//                MessageBox.Show("发送成功！");
            //            }
            #endregion

            #region 新版本
            string fkname = Conmen.SuoQuName;
            string nerong = this.textBox1.Text;
            
            SqlParameter[] parm = new SqlParameter[] {
            new SqlParameter("@fkname",fkname ),
             new SqlParameter("@fknr ",nerong),
              new SqlParameter("@fkshijian ",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
             
            };
            if (DBHelper.ExcutePrc("Pro_yonghufankui",parm ))
            {
                MessageBox.Show("反馈成功！");
                this.Hide();
            }
            else
            {
                MessageBox.Show("反馈失败！");
            }
            #endregion
        }

        private void yonghufankui_Load(object sender, EventArgs e)
        {

        }
    }
}
