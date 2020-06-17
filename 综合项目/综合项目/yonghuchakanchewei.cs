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
    public partial class yonghuchakanchewei : Form
    {
        public yonghuchakanchewei()
        {
            InitializeComponent();
        }

        private void yonghuchakanchewei_Load(object sender, EventArgs e)
        {
            string name = Conmen.SuoQuName;
            string sql = string.Format(@"select * from[dbo].[Cheweixinxi]
where [cwID]=(select [cwID] from[dbo].[yonghuzhuce]
where [yhdlname]='{0}')", name);
            DataTable dt = DBHelper.Select(sql);
            this.label1.Text = dt.Rows[0][1].ToString();
            this.label2.Text = dt.Rows[0][2].ToString();
            this.label3.Text = dt.Rows[0][3].ToString();
            this.label4.Text = dt.Rows[0][4].ToString();
        }
    }
}
