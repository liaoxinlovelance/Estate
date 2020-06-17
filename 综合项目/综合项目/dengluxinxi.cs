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
    public partial class dengluxinxi : Form
    {
        public dengluxinxi()
        {
            InitializeComponent();
        }

        private void dengluxinxi_Load(object sender, EventArgs e)
        {
//            string select = string.Format(@"
//SELECT [yhdlname]
//      ,[yhmima]
//      ,[yhname]
//      ,[gender]
//      ,[sfz]
//      ,[phone]
//      ,[age]
//      ,[area]
//  FROM [dbo].[yonghuzhuce]
//where yhdlname = '{0}'
//", Conmen.SuoQuName);
//            dataGridViewDeng.DataSource = DBHelper.Select(select);
//            this.lblyh.Text = this.dataGridViewDeng.SelectedRows[0].Cells["yhdlname"].Value.ToString();
//            this.lblmima.Text = this.dataGridViewDeng.SelectedRows[0].Cells["yhmima"].Value.ToString();
//            this.lblxm.Text = this.dataGridViewDeng.SelectedRows[0].Cells["yhname"].Value.ToString();
//            this.lblxb.Text = this.dataGridViewDeng.SelectedRows[0].Cells["gender"].Value.ToString();
//            this.lblsf.Text = this.dataGridViewDeng.SelectedRows[0].Cells["sfz"].Value.ToString();
//            this.lblhm.Text = this.dataGridViewDeng.SelectedRows[0].Cells["phone"].Value.ToString();
//            this.lblnl.Text = this.dataGridViewDeng.SelectedRows[0].Cells["age"].Value.ToString();
//            this.lbldq.Text = this.dataGridViewDeng.SelectedRows[0].Cells["area"].Value.ToString();
            //清除多余列表项
            this.dataGridViewDeng.AutoGenerateColumns = false;

            //创建参数列表
            SqlParameter[] parm = new SqlParameter[]{
            new SqlParameter("@yhdlname",Conmen.SuoQuName)};
             //绑定数据源
            this.dataGridViewDeng.DataSource = DBHelper.SelectPrc("Pro_dengluxinxi", parm);
            this.lblyh.Text = this.dataGridViewDeng.SelectedRows[0].Cells["yhdlname"].Value.ToString();
            this.lblmima.Text = this.dataGridViewDeng.SelectedRows[0].Cells["yhmima"].Value.ToString();
            this.lblxm.Text = this.dataGridViewDeng.SelectedRows[0].Cells["yhname"].Value.ToString();
            this.lblxb.Text = this.dataGridViewDeng.SelectedRows[0].Cells["gender"].Value.ToString();
            this.lblsf.Text = this.dataGridViewDeng.SelectedRows[0].Cells["sfz"].Value.ToString();
            this.lblhm.Text = this.dataGridViewDeng.SelectedRows[0].Cells["phone"].Value.ToString();
            this.lblnl.Text = this.dataGridViewDeng.SelectedRows[0].Cells["age"].Value.ToString();
            this.lbldq.Text = this.dataGridViewDeng.SelectedRows[0].Cells["area"].Value.ToString();
        }
    }
}
