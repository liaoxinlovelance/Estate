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
//    public partial class chakanyezhuyue : Form
//    {
//        public chakanyezhuyue()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            string chaxun = this.textBox1.Text;
//            string sql = string.Format(@"
//select [yhmenhao],[yhname],[Yue],[phone] from [dbo].[yonghuzhuce],[dbo].[Userchong]
//where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID and [yhname] like'%{0}%'
//group by [yhmenhao],[yhname],[Yue],[phone]",chaxun );
//            DataTable dt = DBHelper.Select(sql );
//            this.dataGridView1.DataSource = dt;
//        }

//        private void chakanyezhuyue_Load(object sender, EventArgs e)
//        {
//            string chaxun = this.textBox1.Text;
//            string sql = string.Format(@"
//select [yhmenhao],[yhname],[Yue],[phone] from [dbo].[yonghuzhuce],[dbo].[Userchong]
//where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID and [yhname] like'%{0}%'
//group by [yhmenhao],[yhname],[Yue],[phone]", chaxun);
//            DataTable dt = DBHelper.Select(sql);
//            this.dataGridView1.DataSource = dt;
//        }
//    }
//}
#endregion
#region 新版
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
    public partial class chakanyezhuyue : Form
    {
        public chakanyezhuyue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chaxun = this.textBox1.Text;
            //            string sql = string.Format(@"
            //select [yhmenhao],[yhname],[Yue],[phone] from [dbo].[yonghuzhuce],[dbo].[Userchong]
            //where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID and [yhname] like'%{0}%'
            //group by [yhmenhao],[yhname],[Yue],[phone]",chaxun );
            List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@name",chaxun)
            };
            SqlParameter[] parm = list.ToArray();
            string procname = "P_yue";
            DataTable dt = DBHelper.SelectPrc(procname, parm);
            this.dataGridView1.DataSource = dt;
        }

        private void chakanyezhuyue_Load(object sender, EventArgs e)
        {
            string chaxun = this.textBox1.Text;
            //            string sql = string.Format(@"
            //select [yhmenhao],[yhname],[Yue],[phone] from [dbo].[yonghuzhuce],[dbo].[Userchong]
            //where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID and [yhname] like'%{0}%'
            //group by [yhmenhao],[yhname],[Yue],[phone]", chaxun);
            //            DataTable dt = DBHelper.Select(sql);
            List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@yhname",Conmen.SuoQuName)
            };
            SqlParameter[] parm = list.ToArray();
            string procname = "Pro_chakanyezhuyue";
            DataTable dt = DBHelper.SelectPrc(procname, parm);
            this.dataGridView1.DataSource = dt;

            this.label1.Text = "当前位置：余额";
            this.label2.Visible = false;
            this.textBox1.Visible = false;
            this.button1.Visible = false;
        }
    }
}

#endregion