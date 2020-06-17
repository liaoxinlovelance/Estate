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
    public partial class chakanshangpingjiage : Form
    {
        public chakanshangpingjiage()
        {
            InitializeComponent();
        }

        private void chakanshangpingjiage_Load(object sender, EventArgs e)
        {
            dataGridViewGoods.AutoGenerateColumns = false;
            //string select = string.Format("select * from Goods ");
            //dataGridViewGoods.DataSource = DBHelper.Select(select);
            dataGridViewGoods.DataSource = DBHelper.SelectPrc("Pro_chakanshangpingjiage");
        }
    }
}
