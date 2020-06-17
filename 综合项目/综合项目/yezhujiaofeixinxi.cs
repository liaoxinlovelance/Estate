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
//    public partial class yezhujiaofeixinxi : Form
//    {
//        public yezhujiaofeixinxi()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            string chaxun = this.textBox1.Text;
//            string sql = string.Format(@"
//select  [yhname],[ChongDate],[Chongmoney]from [dbo].[yonghuzhuce],[dbo].[Userchong]
//where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID  and [yhname] like'%{0}%'
//group by [yhname],[ChongDate],[Chongmoney]", chaxun);
//            DataTable dt = DBHelper.Select(sql);
//            this.dataGridView1.DataSource = dt;
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            string chaxun = this.textBox1.Text;
//            string sql = string.Format(@"
//select  [yhname],[ChongDate],[Chongmoney]from [dbo].[yonghuzhuce],[dbo].[Userchong]
//where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID  and [yhname] like'%{0}%'
//group by [yhname],[ChongDate],[Chongmoney]", chaxun);
//            DataTable dt = DBHelper.Select(sql);
//            this.dataGridView1.DataSource = dt;
//        }

//        private void yezhujiaofeixinxi_Load(object sender, EventArgs e)
//        {
           
//            string sql = string.Format(@"
//select  [yhname],[ChongDate],[Chongmoney]from [dbo].[yonghuzhuce],[dbo].[Userchong]
//where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID 
//group by [yhname],[ChongDate],[Chongmoney]");
//            DataTable dt = DBHelper.Select(sql);
//            this.dataGridView1.DataSource = dt;
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
    public partial class yezhujiaofeixinxi : Form
    {
        public yezhujiaofeixinxi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chaxun = this.textBox1.Text;
            //            string sql = string.Format(@"
            //select  [yhname],[ChongDate],[Chongmoney]from [dbo].[yonghuzhuce],[dbo].[Userchong]
            //where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID  and [yhname] like'%{0}%'
            //group by [yhname],[ChongDate],[Chongmoney]", chaxun);
            List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@name",chaxun)

            };
            SqlParameter[] parm = list.ToArray();
            string procname = "P_yonghujiaofeixinxi";
            DataTable dt = DBHelper.Select(procname, parm);
            this.dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chaxun = this.textBox1.Text;
            //            string sql = string.Format(@"
            //select  [yhname],[ChongDate],[Chongmoney]from [dbo].[yonghuzhuce],[dbo].[Userchong]
            //where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID  and [yhname] like'%{0}%'
            //group by [yhname],[ChongDate],[Chongmoney]", chaxun);
            List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@name",chaxun)

            };
            SqlParameter[] parm = list.ToArray();
            string procname = "P_yonghujiaofeixinxi";
            DataTable dt = DBHelper.Select(procname, parm);
            this.dataGridView1.DataSource = dt;
        }

        private void yezhujiaofeixinxi_Load(object sender, EventArgs e)
        {

            //            string sql = string.Format(@"
            //select  [yhname],[ChongDate],[Chongmoney]from [dbo].[yonghuzhuce],[dbo].[Userchong]
            //where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID 
            //group by [yhname],[ChongDate],[Chongmoney]");
            DataTable dt = DBHelper.GetDataTable("P_yonghujiaofeixinxiq");
            this.dataGridView1.DataSource = dt;
        }
    }
}


#endregion