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
//    public partial class zhufangxinxi : Form
//    {
//        public zhufangxinxi()
//        {
//            InitializeComponent();
//        }

//        private void zhufangxinxi_Load(object sender, EventArgs e)
//        {

//            string sql = string.Format(@"
//select [yhname],[LouZhang],[loupantype] from [dbo].[yonghuzhuce],[dbo].[LouPan]
//where [dbo].[yonghuzhuce].lfID=[dbo].[LouPan].lfID
//group by[yhname],[LouZhang],[loupantype]");

//            DataTable dt = DBHelper.Select(sql);
//            this.dataGridView1.DataSource = dt;
//        }

//        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

//        }
//    }
//}
#endregion
#region 新版 操作人 周文韬
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
    public partial class zhufangxinxi : Form
    {
        public zhufangxinxi()
        {
            InitializeComponent();
        }

        private void zhufangxinxi_Load(object sender, EventArgs e)
        {

            //            string sql = string.Format(@"
            //select [yhname],[LouZhang],[loupantype] from [dbo].[yonghuzhuce],[dbo].[LouPan]
            //where [dbo].[yonghuzhuce].lfID=[dbo].[LouPan].lfID
            //group by[yhname],[LouZhang],[loupantype]");

            DataTable dt = DBHelper.GetDataTable("P_zhufangxinxicha");
            this.dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

#endregion
