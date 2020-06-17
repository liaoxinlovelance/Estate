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
//    public partial class YongHuFanKuixinxi : Form
//    {
//        public YongHuFanKuixinxi()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            this.Close();
           
//            Frmguanliyuanmain form8 = new Frmguanliyuanmain();
//            form8.Show();
//        }

//        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {    
//            int count=   this.dataGridView1.SelectedRows.Count;
//            if (count>0)
//    {
//        this.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells["neirong"].Value.ToString();
	
           
//            }
//            }
    

//        private void YongHuFanKuixinxi_Load(object sender, EventArgs e)
//        {
//            string sql = string.Format(@"
//select [yhname],[neirong],[shijian] from [dbo].[yonghuzhuce],[dbo].[kefu]
//where [dbo].[yonghuzhuce].kfID=[dbo].[kefu].kfID
//group by [yhname],[neirong],[shijian]
//");
//            DataTable dt = DBHelper.Select(sql);
//            this.dataGridView1.DataSource = dt;
//        }

//        private void 刷新内容ToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            string sql = string.Format(@"
//select [yhname],[neirong],[shijian] from [dbo].[yonghuzhuce],[dbo].[kefu]
//where [dbo].[yonghuzhuce].kfID=[dbo].[kefu].kfID
//group by [yhname],[neirong],[shijian]
//");
//            DataTable dt = DBHelper.Select(sql);
//            this.dataGridView1.DataSource = dt;
//            MessageBox.Show("刷新成功！");
//        }

//        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                int count = this.dataGridView1.SelectedRows.Count;
//                if (count > 0)
//                {
//                    string tiaojian = this.dataGridView1.SelectedRows[0].Cells["neirong"].Value.ToString();
//                    string sql = string.Format(@"
//
//DELETE FROM [dbo].[kefu]
//      WHERE [neirong]='{0}'
//
//
//", tiaojian);
//                }
//            }
//            catch (Exception)
//            {

//                MessageBox.Show("错误，请联系程序员！");
//            }
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

namespace 综合项目
{
    public partial class YongHuFanKuixinxi : Form
    {
        public YongHuFanKuixinxi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Frmguanliyuanmain form8 = new Frmguanliyuanmain();
            form8.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.dataGridView1.SelectedRows.Count;
            if (count > 0)
            {
                this.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells["fknr"].Value.ToString();


            }
        }


        private void YongHuFanKuixinxi_Load(object sender, EventArgs e)
        {
            //            string sql = string.Format(@"
            //select [yhname],[neirong],[shijian] from [dbo].[yonghuzhuce],[dbo].[kefu]
            //where [dbo].[yonghuzhuce].kfID=[dbo].[kefu].kfID
            //group by [yhname],[neirong],[shijian]
            //");
            DataTable dt = DBHelper.GetDataTable("Pro_YongHuFanKuixinxi");
            this.dataGridView1.DataSource = dt;
        }

        private void 刷新内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //            string sql = string.Format(@"
            //select [yhname],[neirong],[shijian] from [dbo].[yonghuzhuce],[dbo].[kefu]
            //where [dbo].[yonghuzhuce].kfID=[dbo].[kefu].kfID
            //group by [yhname],[neirong],[shijian]
            //");
            DataTable dt = DBHelper.GetDataTable("Pro_YongHuFanKuixinxi");
            this.dataGridView1.DataSource = dt;
            MessageBox.Show("刷新成功！");
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int count = this.dataGridView1.SelectedRows.Count;
                if (count > 0)
                {
                    string tiaojian = this.dataGridView1.SelectedRows[0].Cells["neirong"].Value.ToString();
                    string sql = string.Format(@"

DELETE FROM [dbo].[kefu]
      WHERE [neirong]='{0}'


", tiaojian);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("错误，请联系程序员！");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}


#endregion