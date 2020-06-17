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
    public partial class qianfei : Form
    {
        private static char[] constant ={'0','1','2','3','4','5','6','7','8','9'
        };
        public qianfei()
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
            try
            {
                string box1 = this.textBox1.Text;
                string box2 = this.textBox2.Text;
                string box3 = GetRandomNumber(3);
                string sql = string.Format(@"
INSERT INTO [dbo].[gerentongzhi]
           ([grtzID]
           ,[neirong]
           )
     VALUES
           ('{0}'
           ,'{1}'
           )




", box3, box2);
                if (DBHelper.Execute(sql))
                {

                    string yhinsert = string.Format(@"
UPDATE [dbo].[yonghuzhuce]
   SET  [grtzID] = '{0}'
     
 WHERE yhname ='{1}'


", box3, box1);
                    if (DBHelper.Execute(yhinsert))
                    {
                        MessageBox.Show("发送成功！");
                    }

                }

            }
            catch (Exception)
            {

                MessageBox.Show("发送成功！");
                return;
            }

        }

        private void qianfei_Load(object sender, EventArgs e)
        {
//            string sql = string.Format(@"
//select [yhname] from [dbo].[yonghuzhuce]
//group by [yhname]");

//            DataTable dt = DBHelper.Select(sql );
//            this.dataGridView1.DataSource = dt;
        }
    }
}
