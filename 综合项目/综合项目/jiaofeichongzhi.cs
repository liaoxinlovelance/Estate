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
//    public partial class jiaofeichongzhi : Form
//    {
//        public jiaofeichongzhi()
//        {
//            InitializeComponent();
//        }

//        private void btnque_Click(object sender, EventArgs e)
//        {
//            string insert = string.Format("update from UserChong set UserYu+={0}", textchong.Text);

//            DBHelper.Execute(insert);

//        }

//        private void btnqu_Click(object sender, EventArgs e)
//        {
//            textchong.Text = "";
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
    public partial class jiaofeichongzhi : Form
    {
        public jiaofeichongzhi()
        {
            InitializeComponent();
        }

        private void btnque_Click(object sender, EventArgs e)
        {//SDlfID
            //string insert = string.Format("update from UserChong set UserYu+={0}", textchong.Text);
            List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@money",textchong.Text),
                new SqlParameter("@id",Conmen.SDlfID)

            };
            SqlParameter[] parm = list.ToArray();
            string procname = "P_chongzhi";
            DBHelper.ExecutenonQuery(procname, parm);

        }

        private void btnqu_Click(object sender, EventArgs e)
        {
            textchong.Text = "";
        }

        private void jiaofeichongzhi_Load(object sender, EventArgs e)
        {

        }
    }
}


#endregion