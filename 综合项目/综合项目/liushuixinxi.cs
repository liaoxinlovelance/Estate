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
//    public partial class liushuixinxi : Form
//    {
//        public liushuixinxi()
//        {
//            InitializeComponent();
//        }

//        private void liushuixinxi_Load(object sender, EventArgs e)
//        {
//            dataGridViewLiu.AutoGenerateColumns = false;
//            string select = string.Format(@"select * from UserXiao,yonghuzhuce where  dbo.UserXiao.xiaofeiID = dbo.yonghuzhuce.xiaofeiID and yhdlname = '{0}'
//", Conmen.SuoQuName);
//            dataGridViewLiu.DataSource = DBHelper.Select(select);
//        }

//        private void dataGridViewLiu_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

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
    public partial class liushuixinxi : Form
    {
        public liushuixinxi()
        {
            InitializeComponent();
        }

        private void liushuixinxi_Load(object sender, EventArgs e)
        {
            dataGridViewLiu.AutoGenerateColumns = false;
            //            string select = string.Format(@"select * from UserXiao,yonghuzhuce where  dbo.UserXiao.xiaofeiID = dbo.yonghuzhuce.xiaofeiID and yhdlname = '{0}'
            //", Conmen.SuoQuName);
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@name", Conmen.SuoQuName));
            SqlParameter[] pram = list.ToArray();
            dataGridViewLiu.DataSource = DBHelper.Select("P_liushuixinxi", pram);
        }
    }
}
#endregion