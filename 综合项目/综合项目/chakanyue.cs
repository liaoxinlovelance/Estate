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
    public partial class chakanyue : Form
    {
        public chakanyue()
        {
            InitializeComponent();
        }

        private void chakanyue_Load(object sender, EventArgs e)
        {
            dataGridViewYu.AutoGenerateColumns = false;
            string select = string.Format(@"SELECT   dbo.Userchong.*, dbo.yonghuzhuce.*
FROM      dbo.Userchong INNER JOIN
                dbo.yonghuzhuce ON dbo.Userchong.chongzhiID = dbo.yonghuzhuce.chongzhiID and yhdlname = '{0}'", Conmen.SuoQuName);
            dataGridViewYu.DataSource = DBHelper.Select(select);
        }
    }
}
