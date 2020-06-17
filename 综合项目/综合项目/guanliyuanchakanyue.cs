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
    public partial class guanliyuanchakanyue : Form
    {
        public guanliyuanchakanyue()
        {
            InitializeComponent();
        }

        private void guanliyuanchakanyue_Load(object sender, EventArgs e)
        {
            string chaxun = this.textBox1.Text;
            //            string sql = string.Format(@"
            //select [yhmenhao],[yhname],[Yue],[phone] from [dbo].[yonghuzhuce],[dbo].[Userchong]
            //where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID and [yhname] like'%{0}%'
            //group by [yhmenhao],[yhname],[Yue],[phone]",chaxun );
            List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@yhname",chaxun)
            };
            SqlParameter[] parm = list.ToArray();
            string procname = "Pro_guanliyuanchakanyue";
            DataTable dt = DBHelper.SelectPrc(procname, parm);
            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chaxun = this.textBox1.Text;
            //            string sql = string.Format(@"
            //select [yhmenhao],[yhname],[Yue],[phone] from [dbo].[yonghuzhuce],[dbo].[Userchong]
            //where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID and [yhname] like'%{0}%'
            //group by [yhmenhao],[yhname],[Yue],[phone]",chaxun );
            List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@yhname",chaxun)
            };
            SqlParameter[] parm = list.ToArray();
            string procname = "Pro_guanliyuanchakanyue";
            DataTable dt = DBHelper.SelectPrc(procname, parm);
            this.dataGridView1.DataSource = dt;
        }
    }
}
