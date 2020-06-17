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
//    public partial class cheweixinxiweihu : Form
//    {
//        public cheweixinxiweihu()
//        {
//            InitializeComponent();
//        }
//        private void jiazai()
//        {
//            string sql = string.Format(@"
//select [CheIDs],[ChePrice],[CheZhang],[Chetype],[yhname] from [dbo].[yonghuzhuce],[dbo].[Cheweixinxi]
//where [dbo].[yonghuzhuce].cwID=[dbo].[Cheweixinxi].cwID
//group by [CheIDs],[ChePrice],[CheZhang],[Chetype],[yhname]
//
//
//");

//            DataTable dt = DBHelper.Select(sql);
//            this.dataGridView1.DataSource = dt;

//        }

//        private void chewei_Load(object sender, EventArgs e)
//        {
//            jiazai();
//        }

//        private void button4_Click(object sender, EventArgs e)
//        {
//            cheweixinxiweihuADD add = new cheweixinxiweihuADD();
//            add.ShowDialog();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            //获取选中行
//            int count = this.dataGridView1.SelectedRows.Count;
//            if (count > 0)
//            {
//                string shanchu = this.dataGridView1.SelectedRows[0].Cells["CheIDs"].Value.ToString();
//                string sql = string.Format(@"
//DELETE FROM [dbo].[Cheweixinxi]
// 
//
//      WHERE CheIDs='{0}'
//
//
//", shanchu);
//                if (DBHelper.Execute(sql))
//                {
//                    MessageBox.Show("删除成功！");
//                    jiazai();
//                }
//            }
//            else
//            {
//                MessageBox.Show("删除必须选中行！");
//            } 
//        }

//        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
//             //获取选中行
//            int count = this.dataGridView1.SelectedRows.Count;
//            if (count > 0)
//            {
               
//                this.textBox2.Text = this.dataGridView1.SelectedRows[0].Cells["ChePrice"].Value.ToString();
//                if (this.dataGridView1.SelectedRows[0].Cells["CheZhang"].Value.ToString() == "占用")
//                {
//                    this.radioButton1.Checked = true;
//                }
//                else if (this.dataGridView1.SelectedRows[0].Cells["CheZhang"].Value.ToString() == "闲置")
//                {
//                    this.radioButton2.Checked = true;
//                }
//                this.textBox3.Text = this.dataGridView1.SelectedRows[0].Cells["yhname"].Value.ToString();
//                this.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells["CheIDs"].Value.ToString();
//                this.comboBox1.Text = this.dataGridView1.SelectedRows[0].Cells["Chetype"].Value.ToString();
//            }
//        }

//        private void button3_Click(object sender, EventArgs e)
//        { string chaxun=this.textBox4 .Text;
//            string sql = string.Format(@"
//select [CheIDs],[ChePrice],[CheZhang],[Chetype],[yhname] from [dbo].[yonghuzhuce],[dbo].[Cheweixinxi]
//where [dbo].[yonghuzhuce].cwID=[dbo].[Cheweixinxi].cwID and  [CheIDs]like'%{0}%'
//group by [CheIDs],[ChePrice],[CheZhang],[Chetype],[yhname]
//
//
//",chaxun );

//            DataTable dt = DBHelper.Select(sql);
//            this.dataGridView1.DataSource = dt;
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                string tiaojian = this.dataGridView1.SelectedRows[0].Cells["CheIDs"].Value.ToString();
//                string box1 = this.textBox1.Text;
//                string box2 = this.textBox2.Text;
//                string box3 = "";
//                if (this.radioButton1.Checked)
//                {
//                    box3 = this.radioButton1.Text;
//                }
//                else if (this.radioButton2.Checked)
//                {
//                    box3 = this.radioButton2.Text;
//                }
//                string box4 = this.comboBox1.Text;
//                string sql = string.Format(@"
//
//
//UPDATE [dbo].[Cheweixinxi]
//   SET 
//      [CheIDs] ='{0}'
//      ,[ChePrice] ='{1}'
//      ,[CheZhang] = '{2}'
//      ,[Chetype] = '{3}'
// WHERE [CheIDs]='{4}'
//
//
//", box1, box2, box3, box4, tiaojian);
//                if (DBHelper.Execute(sql))
//                {
//                    MessageBox.Show("保存成功！");
//                    jiazai();
//                }
//                else
//                {
//                    MessageBox.Show("保存失败！");
//                }
//            }
//            catch (Exception)
//            {
                
//                 MessageBox.Show("错误！请联系管理员！");
//            }

//        }

//        private void button5_Click(object sender, EventArgs e)
//        {
//            this.textBox1.Text = "";
//            this.textBox3.Text = "";
//            this.textBox2.Text = "";
//            this.comboBox1.Text = "";
//            this.radioButton1.Checked = false;
//            this.radioButton2.Checked = false;
//        }
//        }
//        }

#endregion
#region  新版（操作人周文韬）
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
    public partial class cheweixinxiweihu : Form
    {
        public cheweixinxiweihu()
        {
            InitializeComponent();
        }
        private void jiazai()
        {
            //            string sql = string.Format(@"
            //select [CheIDs],[ChePrice],[CheZhang],[Chetype],[yhname] from [dbo].[yonghuzhuce],[dbo].[Cheweixinxi]
            //where [dbo].[yonghuzhuce].cwID=[dbo].[Cheweixinxi].cwID
            //group by [CheIDs],[ChePrice],[CheZhang],[Chetype],[yhname]
            //
            //
            //");
            DataTable dt = DBHelper.GetDataTable("P_cheweikan");
            this.dataGridView1.DataSource = dt;

        }

        private void chewei_Load(object sender, EventArgs e)
        {
            jiazai();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cheweixinxiweihuADD add = new cheweixinxiweihuADD();
            add.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取选中行
            int count = this.dataGridView1.SelectedRows.Count;
            if (count > 0)
            {
                string shanchu = this.dataGridView1.SelectedRows[0].Cells["CheIDs"].Value.ToString();
                //                string sql = string.Format(@"
                //DELETE FROM [dbo].[Cheweixinxi]
                // 
                //
                //      WHERE CheIDs='{0}'
                //
                //
                //", shanchu);
                List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@cheid",shanchu)
            };
                SqlParameter[] parm = list.ToArray();
                string procname = "P_cheweishanchu";
                if (DBHelper.ExecutenonQuery(procname, parm))
                {
                    MessageBox.Show("删除成功！");
                    jiazai();
                }
            }
            else
            {
                MessageBox.Show("删除必须选中行！");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取选中行
            int count = this.dataGridView1.SelectedRows.Count;
            if (count > 0)
            {

                this.textBox2.Text = this.dataGridView1.SelectedRows[0].Cells["ChePrice"].Value.ToString();
                if (this.dataGridView1.SelectedRows[0].Cells["CheZhang"].Value.ToString() == "占用")
                {
                    this.radioButton1.Checked = true;
                }
                else if (this.dataGridView1.SelectedRows[0].Cells["CheZhang"].Value.ToString() == "闲置")
                {
                    this.radioButton2.Checked = true;
                }
                this.textBox3.Text = this.dataGridView1.SelectedRows[0].Cells["yhname"].Value.ToString();
                this.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells["CheIDs"].Value.ToString();
                this.comboBox1.Text = this.dataGridView1.SelectedRows[0].Cells["Chetype"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string chaxun = this.textBox4.Text;
            //            string sql = string.Format(@"
            //select [CheIDs],[ChePrice],[CheZhang],[Chetype],[yhname] from [dbo].[yonghuzhuce],[dbo].[Cheweixinxi]
            //where [dbo].[yonghuzhuce].cwID=[dbo].[Cheweixinxi].cwID and  [CheIDs]like'%{0}%'
            //group by [CheIDs],[ChePrice],[CheZhang],[Chetype],[yhname]
            //
            //
            //",chaxun );
            List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@cheid",chaxun)
            };
            SqlParameter[] parm = list.ToArray();
            string procname = "P_cheweichaxun";
            DataTable dt = DBHelper.Select(procname, parm);
            this.dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                string tiaojian = this.dataGridView1.SelectedRows[0].Cells["CheIDs"].Value.ToString();
                string box1 = this.textBox1.Text;
                string box2 = this.textBox2.Text;
                string box3 = "";
                if (this.radioButton1.Checked)
                {
                    box3 = this.radioButton1.Text;
                }
                else if (this.radioButton2.Checked)
                {
                    box3 = this.radioButton2.Text;
                }
                string box4 = this.comboBox1.Text;
                //                string sql = string.Forma t(@"
                //
                //
                //UPDATE [dbo].[Cheweixinxi]
                //   SET 
                //      [CheIDs] ='{0}'
                //      ,[ChePrice] ='{1}'
                //      ,[CheZhang] = '{2}'
                //      ,[Chetype] = '{3}'
                // WHERE [CheIDs]='{4}'
                //
                //
                //", box1, box2, box3, box4, tiaojian);
                // P_cheweichaxun指定过多的参数
                List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@cheid",box1),
                new SqlParameter("@jg",box2),
                new SqlParameter("@zhang",box3),
                new SqlParameter("@type",box4),
                new SqlParameter("@id",tiaojian)

            };
                SqlParameter[] parm = list.ToArray();
                string procname = "Pro_cheweixinxiweihubaocun";
                if (DBHelper.ExecutenonQuery(procname, parm))
                {
                    MessageBox.Show("保存成功！");
                    jiazai();
                }
                else
                {
                    MessageBox.Show("保存失败！");
                }
            }
            

    

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox3.Text = "";
            this.textBox2.Text = "";
            this.comboBox1.Text = "";
            this.radioButton1.Checked = false;
            this.radioButton2.Checked = false;
        }
    }
}
    


#endregion