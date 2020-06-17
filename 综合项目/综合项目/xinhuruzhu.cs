#region  老版

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
//    public partial class xinhuruzhu : Form
//    {
//        public xinhuruzhu()
//        {
//            InitializeComponent();
//        }

//        private void xinhuruzhu_Load(object sender, EventArgs e)
//        {
//            jiazai();
//        }

//        private void jiazai()
//        {
//            string sql = string.Format(@"
//SELECT [yhdlname]
//      ,[yhmima]
//      ,[yhname]
//      ,[gender]
//      ,[sfz]
//      ,[yhmenhao]
//      ,[phone]
//      ,[age]
//      ,[area]
//      ,[xiaofeiID]
//      ,[chongzhiID]
//      ,[lfID]
//      ,[cwID]
//      ,[kfID]
//      ,[grtzID]
//  FROM [dbo].[yonghuzhuce]
//
//
//");
//            this.dataGridView1.AutoGenerateColumns = false;
//            this.dataGridView1.DataSource = DBHelper.Select(sql);
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            chakanchewei ckcww = new chakanchewei();
//            ckcww.Show();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            chakanloupan lp = new chakanloupan();
//            lp.Show();
//        }

//        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
//            int count = this.dataGridView1.SelectedRows.Count;
//            if (count>0)
//            {
//                this.textBox1.Text =this.dataGridView1.SelectedRows[0].Cells["yhname"].Value.ToString();
//                this.textBox2.Text = this.dataGridView1.SelectedRows[0].Cells["chongzhiID"].Value.ToString();
//                this.textBox3.Text = this.dataGridView1.SelectedRows[0].Cells["lfID"].Value.ToString();
//                this.textBox4.Text = this.dataGridView1.SelectedRows[0].Cells["cwID"].Value.ToString();
//            }
//        }

//        private void button3_Click(object sender, EventArgs e)
//        {
//            string dingwei = this.dataGridView1.SelectedRows[0].Cells["yhname"].Value.ToString();
//            string box1 = this.textBox1.Text;
//            string box2 = this.textBox2.Text;
//            string box3 = this.textBox3.Text;
//            string box4 = this.textBox4.Text;

//            string sql = string.Format(@"
//UPDATE [dbo].[yonghuzhuce]
//   SET  [yhname] = '{0}'
//       ,[chongzhiID] =  '{1}'
//       ,[lfID] =  '{2}'
//       ,[cwID] =  '{3}'
//       
// WHERE   [yhname] = '{4}'
//
//
//", box1, box2, box3, box4,dingwei);

//            if (DBHelper .Execute (sql ))
//            {
//                MessageBox.Show("绑定成功！");
//                jiazai();
//            }
//        }

//        private void button4_Click(object sender, EventArgs e)
//        {
//            chakanzhongzhikahao kh = new chakanzhongzhikahao();
//            kh.Show();
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
    public partial class xinhuruzhu : Form
    {
        public xinhuruzhu()
        {
            InitializeComponent();
        }

        private void xinhuruzhu_Load(object sender, EventArgs e)
        {
            jiazai();
        }

        private void jiazai()
        {
            //            string sql = string.Format(@"
            //SELECT [yhdlname]
            //      ,[yhmima]
            //      ,[yhname]
            //      ,[gender]
            //      ,[sfz]
            //      ,[yhmenhao]
            //      ,[phone]
            //      ,[age]
            //      ,[area]
            //      ,[xiaofeiID]
            //      ,[chongzhiID]
            //      ,[lfID]
            //      ,[cwID]
            //      ,[kfID]
            //      ,[grtzID]
            //  FROM [dbo].[yonghuzhuce]
            //
            //
            //");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = DBHelper.GetDataTable("P_xinhuruzhucha");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chakanchewei ckcww = new chakanchewei();
            ckcww.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chakanloupan lp = new chakanloupan();
            lp.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.dataGridView1.SelectedRows.Count;
            if (count > 0)
            {
                this.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells["yhname"].Value.ToString();
                this.textBox2.Text = this.dataGridView1.SelectedRows[0].Cells["chongzhiID"].Value.ToString();
                this.textBox3.Text = this.dataGridView1.SelectedRows[0].Cells["lfID"].Value.ToString();
                this.textBox4.Text = this.dataGridView1.SelectedRows[0].Cells["cwID"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dingwei = this.dataGridView1.SelectedRows[0].Cells["yhname"].Value.ToString();
            string box1 = this.textBox1.Text;
            string box2 = this.textBox2.Text;
            string box3 = this.textBox3.Text;
            string box4 = this.textBox4.Text;

            //            string sql = string.Format(@"
            //UPDATE [dbo].[yonghuzhuce]
            //   SET  [yhname] = '{0}'
            //       ,[chongzhiID] =  '{1}'
            //       ,[lfID] =  '{2}'
            //       ,[cwID] =  '{3}'
            //       
            // WHERE   [yhname] = '{4}'
            //
            //
            //", box1, box2, box3, box4,dingwei);
            List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@name",box1),
                new SqlParameter("@cz",box2),
                new SqlParameter("@if",box3),
                new SqlParameter("@cw",box4),
                new SqlParameter("@namegai",dingwei)

            };
            SqlParameter[] parm = list.ToArray();
            string procname = "Pr_xinhuruzhuxiugai";
            if (DBHelper.ExecutenonQuery(procname, parm))
            {
                MessageBox.Show("绑定成功！");
                jiazai();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chakanzhongzhikahao kh = new chakanzhongzhikahao();
            kh.Show();
        }
    }
}

#endregion