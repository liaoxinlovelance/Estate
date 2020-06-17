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
//using System.Data.SqlClient;

//namespace 综合项目
//{
//    public partial class shimingxinxi : Form
//    {
//        public shimingxinxi()
//        {
//            InitializeComponent();
//        }

//        private void shimingxinxi_Load(object sender, EventArgs e)
//        {
//            dataGridViewShi.AutoGenerateColumns = false;
////            string select = string.Format(@"select * from [yonghuzhuce] where yhdlname = '{0}'
////", Conmen.SuoQuName);

////            dataGridViewShi.DataSource = DBHelper.Select(select);
//            //创建参数列表
//            SqlParameter[] parm = new SqlParameter[]{ new SqlParameter("@yhdlname", Conmen.SuoQuName) };
//            //绑定数据源
//            this.dataGridViewShi.DataSource = DBHelper.SelectPrc("Pro_shimingxinxii",parm);
//        }

//        private void dataGridViewShi_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
using System.Data.SqlClient;

namespace 综合项目
{
    public partial class shimingxinxi : Form
    {
        public shimingxinxi()
        {
            InitializeComponent();
        }

        private void shimingxinxi_Load(object sender, EventArgs e)
        {
            dataGridViewShi.AutoGenerateColumns = false;
            //            string select = string.Format(@"select * from [yonghuzhuce] where yhdlname = '{0}'
            //", Conmen.SuoQuName);
            List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@name",Conmen.SuoQuName)

            };
            SqlParameter[] parm = list.ToArray();
            string procname = "P_shimingxinxi";
            dataGridViewShi.DataSource = DBHelper.Select(procname, parm);

        }

        private void dataGridViewShi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

#endregion