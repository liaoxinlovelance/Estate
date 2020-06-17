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
//    public partial class loupanxinxiweihu : Form
//    {
//        public loupanxinxiweihu()
//        {
//            InitializeComponent();
//        }

//        private void loupan_Load(object sender, EventArgs e)
//        {
//            jiazai();


//        }

//private void jiazai()
//{
//            string sql = string.Format(@"  
//
//
//select [LouID],[LouPrice],[LouZhang],[loupantype],[yhname] from [dbo].[LouPan],[dbo].[yonghuzhuce]
//where [dbo].[LouPan].lfID=[dbo].[yonghuzhuce].lfID
//group by [LouID],[LouPrice],[LouZhang],[loupantype],[yhname]
//
//
// ");


//            this.dgv_loupanweihu.DataSource = DBHelper.Select(sql);

//}
       
//        private void btn_cha_Click(object sender, EventArgs e)
//        {
//            string name = this.tbx_cha.Text;

//            string sql = string.Format(@"  
//select  [LouID],[LouPrice],[LouZhang],[loupantype],[yhname] from [dbo].[LouPan],[dbo].[yonghuzhuce]
//where [dbo].[LouPan].lfID=[dbo].[yonghuzhuce].lfID  and  [yhname]like'%{0}%'
//group by  [LouID],[LouPrice],[LouZhang],[loupantype],[yhname]
//
// ", name);
//            this.dgv_loupanweihu.DataSource = DBHelper.Select(sql);
//        }

//        private void dgv_loupanweihu_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
//            //选中行
//            int count = this.dgv_loupanweihu.SelectedRows.Count;
//            if (count > 0)
//            {
//                this.textBox1.Text = this.dgv_loupanweihu.SelectedRows[0].Cells["LouID"].Value.ToString();
//                this.textBox2.Text = this.dgv_loupanweihu.SelectedRows[0].Cells["LouPrice"].Value.ToString();
//                this.textBox3.Text = this.dgv_loupanweihu.SelectedRows[0].Cells["yhname"].Value.ToString();
//                if (this.dgv_loupanweihu.SelectedRows[0].Cells["LouZhang"].Value.ToString() == this.radioButton1.Text)
//                {
//                    this.radioButton1.Checked = true;
//                }
//                else if (this.dgv_loupanweihu.SelectedRows[0].Cells["LouZhang"].Value.ToString() == this.radioButton2.Text)
//                {
//                    this.radioButton2.Checked = true;
//                }
//                else if (this.dgv_loupanweihu.SelectedRows[0].Cells["LouZhang"].Value.ToString() == this.radioButton3.Text)
//                {
//                    this.radioButton3.Checked = true;
//                }
//                if (this.dgv_loupanweihu.SelectedRows[0].Cells["loupantype"].Value.ToString() == this.radioButton4.Text)
//                {
//                    this.radioButton4.Checked = true;
//                }
//                else if (this.dgv_loupanweihu.SelectedRows[0].Cells["loupantype"].Value.ToString() == this.radioButton5.Text)
//                {
//                    this.radioButton5.Checked = true;
//                }
//            }
//        }

//        private void button1_Click_1(object sender, EventArgs e)
//        {
//            try
//            {
//                //获取编号
//            string tiaojian = this.dgv_loupanweihu.SelectedRows[0].Cells["LouID"].Value.ToString();
//                //楼盘号
//                string box1 = this.textBox1.Text;
//            //价格
//                string box2 = this.textBox2.Text;
//                double jiage = double.Parse(box2);
//            //状态
//                string box4 = "";
//            //类型
//                string box5 = "";

//                if (this.radioButton1.Checked)
//                {
//                    box4 = radioButton1.Text;
//                }
//                else if (this.radioButton2.Checked)
//                {
//                    box4 = radioButton2.Text;
//                }
//                else if (this.radioButton3.Checked)
//                {
//                    box4 = radioButton3.Text;
//                }

//                if (this.radioButton4.Checked)
//                {
//                    box5 = radioButton4.Text;
//                }
//                else if (this.radioButton5.Checked)
//                {
//                    box5 = radioButton5.Text;
//                }

//                string sql = string.Format(@"
//
//
//
//UPDATE [dbo].[LouPan]
//   SET 
//      [LouID] = '{0}'
//      ,[LouPrice] = '{1}'
//      ,[LouZhang] = '{2}'
//      ,[loupantype] = '{3}'
// WHERE [LouID]='{4}'
//
//
//
//
//", box1, jiage, box4, box5, tiaojian);
//                if (DBHelper. Execute( sql))
//                { 
                 
//                        MessageBox.Show("保存成功！");
//                        jiazai();
//                }
//                else
//                {
//                    MessageBox.Show("保存失败！");
//                }
//            }
//            catch (Exception)
//            {

//                MessageBox.Show("系统出现异常，请联系管理员！");
//            }
//        }

//        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
//        {

//            int count = this.dgv_loupanweihu.SelectedRows.Count;
//            if (count > 0)
//            {
//                string id = this.dgv_loupanweihu.SelectedRows[0].Cells["LouID"].Value.ToString();
//                string sql = string.Format("delete from LouPan where LouID='{0}'", id);
//                if (DBHelper.Execute(sql))
//                {
//                    MessageBox.Show("删除成功！");
//                    jiazai();
//                }
//                else
//                {
//                    MessageBox.Show("删除失败！");
//                }
//            }
//            else
//            {
//                MessageBox.Show("请选中要删除的数据行！");
//            }
//        }
//        }
//    }

#endregion
#region  新版 操作人周文韬
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
    public partial class loupanxinxiweihu : Form
    {
        public loupanxinxiweihu()
        {
            InitializeComponent();
        }

        private void loupan_Load(object sender, EventArgs e)
        {
            jiazai();


        }

        private void jiazai()
        {
            //            string sql = string.Format(@"  
            //
            //
            //select [LouID],[LouPrice],[LouZhang],[loupantype],[yhname] from [dbo].[LouPan],[dbo].[yonghuzhuce]
            //where [dbo].[LouPan].lfID=[dbo].[yonghuzhuce].lfID
            //group by [LouID],[LouPrice],[LouZhang],[loupantype],[yhname]
            //
            //
            // ");


            this.dgv_loupanweihu.DataSource = DBHelper.GetDataTable("P_louoanxinxi");

        }

        private void btn_cha_Click(object sender, EventArgs e)
        {
            string name = this.tbx_cha.Text;
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@name", name));
            SqlParameter[] pram = list.ToArray();
            //            string sql = string.Format(@"  
            //select  [LouID],[LouPrice],[LouZhang],[loupantype],[yhname] from [dbo].[LouPan],[dbo].[yonghuzhuce]
            //where [dbo].[LouPan].lfID=[dbo].[yonghuzhuce].lfID  and  [yhname]like'%{0}%'
            //group by  [LouID],[LouPrice],[LouZhang],[loupantype],[yhname]
            //
            // ", name);
            this.dgv_loupanweihu.DataSource = DBHelper.Select("P_louoanxinxicha", pram);
        }

        private void dgv_loupanweihu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //选中行
            int count = this.dgv_loupanweihu.SelectedRows.Count;
            if (count > 0)
            {
                this.textBox1.Text = this.dgv_loupanweihu.SelectedRows[0].Cells["LouID"].Value.ToString();
                this.textBox2.Text = this.dgv_loupanweihu.SelectedRows[0].Cells["LouPrice"].Value.ToString();
                this.textBox3.Text = this.dgv_loupanweihu.SelectedRows[0].Cells["yhname"].Value.ToString();
                if (this.dgv_loupanweihu.SelectedRows[0].Cells["LouZhang"].Value.ToString() == this.radioButton1.Text)
                {
                    this.radioButton1.Checked = true;
                }
                else if (this.dgv_loupanweihu.SelectedRows[0].Cells["LouZhang"].Value.ToString() == this.radioButton2.Text)
                {
                    this.radioButton2.Checked = true;
                }
                else if (this.dgv_loupanweihu.SelectedRows[0].Cells["LouZhang"].Value.ToString() == this.radioButton3.Text)
                {
                    this.radioButton3.Checked = true;
                }
                if (this.dgv_loupanweihu.SelectedRows[0].Cells["loupantype"].Value.ToString() == this.radioButton4.Text)
                {
                    this.radioButton4.Checked = true;
                }
                else if (this.dgv_loupanweihu.SelectedRows[0].Cells["loupantype"].Value.ToString() == this.radioButton5.Text)
                {
                    this.radioButton5.Checked = true;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //获取编号
                string tiaojian = this.dgv_loupanweihu.SelectedRows[0].Cells["LouID"].Value.ToString();
                //楼盘号
                string box1 = this.textBox1.Text;
                //价格
                string box2 = this.textBox2.Text;
                double jiage = double.Parse(box2);
                //状态
                string box4 = "";
                //类型
                string box5 = "";

                if (this.radioButton1.Checked)
                {
                    box4 = radioButton1.Text;
                }
                else if (this.radioButton2.Checked)
                {
                    box4 = radioButton2.Text;
                }
                else if (this.radioButton3.Checked)
                {
                    box4 = radioButton3.Text;
                }

                if (this.radioButton4.Checked)
                {
                    box5 = radioButton4.Text;
                }
                else if (this.radioButton5.Checked)
                {
                    box5 = radioButton5.Text;
                }
                List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@gaiid",box1),
                new SqlParameter("@jg",jiage),
                new SqlParameter("@you",box4),
                new SqlParameter("@lx",box5),
                new SqlParameter("@id",tiaojian)

            };
                SqlParameter[] parm = list.ToArray();
                string procname = "P_louoanxinxigai";

                //                string sql = string.Format(@"
                //
                //
                //
                //UPDATE [dbo].[LouPan]
                //   SET 
                //      [LouID] = '{0}'
                //      ,[LouPrice] = '{1}'
                //      ,[LouZhang] = '{2}'
                //      ,[loupantype] = '{3}'
                // WHERE [LouID]='{4}'
                //
                //
                //
                //
                //", box1, jiage, box4, box5, tiaojian);
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
            catch (Exception)
            {

                MessageBox.Show("系统出现异常，请联系管理员！");
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int count = this.dgv_loupanweihu.SelectedRows.Count;
            if (count > 0)
            {
                string id = this.dgv_loupanweihu.SelectedRows[0].Cells["LouID"].Value.ToString();
                //string sql = string.Format("delete from LouPan where LouID='{0}'", id);
                List<SqlParameter> list = new List<SqlParameter>();
                list.Add(new SqlParameter("@id", id));
                SqlParameter[] pram = list.ToArray();
                if (DBHelper.ExecutenonQuery("P_louoanxinxishan", pram))
                {
                    MessageBox.Show("删除成功！");
                    jiazai();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            else
            {
                MessageBox.Show("请选中要删除的数据行！");
            }
        }
    }
}



#endregion