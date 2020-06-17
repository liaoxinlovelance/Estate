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
//using System.Data.SqlClient;

//namespace 综合项目
//{
//    public partial class loupanxinxixiugai : Form
//    {
//        public loupanxinxixiugai()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                //获取编号
//                string tiaojian = this.dgv_loupanweihu.SelectedRows[0].Cells["LouID"].Value.ToString();
                
//                string box1 = this.textBox1.Text;
//                string box2 = this.textBox2.Text;
//                string box3 = this.textBox3.Text;
//                string box4 = "";
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
//UPDATE [dbo].[LouPan]
//   SET [LouID] = '{0}'
//      ,[LouPrice] = '{1}'
//      ,[LouZhang] = '{2}'
// ,[LouUser] ='{3}'
//      ,[loupantype] = '{4}'
// WHERE [LouID]=[5]
//
//
////UPDATE [dbo].[LouPan]
////   SET [lfID] = <lfID, int,>
////      ,[LouID] = <LouID, nvarchar(50),>
////      ,[LouPrice] = <LouPrice, numeric(18,0),>
////      ,[LouZhang] = <LouZhang, nvarchar(50),>
////      ,[loupantype] = <loupantype, nvarchar(50),>
//// WHERE <搜索条件,,>
//
//
//
//
//", box1, box2, box3, box4, box5, tiaojian);

//                if (DBHelper.Execute(sql))
//                {
//                    MessageBox.Show("保存成功！");
//                }
//                else
//                {
//                    MessageBox.Show("保存失败！");
//                }
//            }
//            catch (Exception)
//            {

//                MessageBox.Show("保存成功！！");
//            }
//        }

//        private void loupanxinxixiugai_Load(object sender, EventArgs e)
//        {
//            jiazai();
//        }
//        private void jiazai()
//        {
////            string sql = string.Format(@"  
////select [LouID],[LouPrice],[LouZhang],[loupantype],[yhname] from [dbo].[LouPan],[dbo].[yonghuzhuce]
////where  [dbo].[LouPan].lfID=[dbo].[yonghuzhuce].lfID
////group by[LouID],[LouPrice],[LouZhang],[loupantype],[yhname]
//// ");

//            //条件加载个人楼盘信息
//            //查到一条数据，保存提交按钮不可用，否则可以用
//            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@yhname", Conmen.SuoQuName) };
//            this.dgv_loupanweihu.DataSource = DBHelper.SelectPrc("Pro_loupanxinxixiugai", parm);
//            int hang = this.dgv_loupanweihu.RowCount;
//            if (hang >0)
//            {
//                this.button1.Enabled = false;
//                this.button1.Text = "您已经有楼盘信息，如需修改请联系管理员";
//            }
//            else
//            {
//                this.button1.Enabled = false;
//                this.button1.Text = "您还没有楼盘信息，请及时找管理员核实您的身份";

//            }
//        }

//        private void dgv_loupanweihu_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
//            this.textBox1.Text = this.dgv_loupanweihu.SelectedRows[0].Cells["LouID"].Value.ToString();
//            this.textBox2.Text = this.dgv_loupanweihu.SelectedRows[0].Cells["LouPrice"].Value.ToString();
//            this.textBox3.Text = this.dgv_loupanweihu.SelectedRows[0].Cells["yhname"].Value.ToString();
//            if (this.dgv_loupanweihu.SelectedRows[0].Cells["LouZhang"].Value.ToString()=="拥有")
//            {
//                this.radioButton1.Checked = true;
//            }
//           else  if (this.dgv_loupanweihu.SelectedRows[0].Cells["LouZhang"].Value.ToString() == "出租")
//            {
//                this.radioButton2.Checked = true;
//            }
//            else // (this.dgv_loupanweihu.SelectedRows[0].Cells["LouZhang"].Value.ToString() == "闲置")
//            {
//                this.radioButton3.Checked = true;
//            }

//            if (this.dgv_loupanweihu.SelectedRows[0].Cells["loupantype"].Value.ToString() == "廉租房")
//            {
//                this.radioButton5.Checked = true;
//            }
//            else if (this.dgv_loupanweihu.SelectedRows[0].Cells["loupantype"].Value.ToString() == "商品房")
//            {
//                this.radioButton4.Checked = true;
//            }
//        }

       
//    }
//}
#endregion
#region 新版 操作人 周文韬

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
    public partial class loupanxinxixiugai : Form
    {
        public loupanxinxixiugai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //获取编号
                string tiaojian = this.dgv_loupanweihu.SelectedRows[0].Cells["LouID"].Value.ToString();
                //
                string box1 = this.textBox1.Text;
                string box2 = this.textBox2.Text;
                string box3 = this.textBox3.Text;
                string box4 = "";
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

                //                string sql = string.Format(@"
                //UPDATE [dbo].[LouPan]
                //   SET [LouID] = '{0}'
                //      ,[LouPrice] = '{1}'
                //      ,[LouZhang] = '{2}'
                // ,[LouUser] ='{3}'
                //      ,[loupantype] = '{4}'
                // WHERE [LouID]=[5]
                //", box1, box2, box3, box4, box5, tiaojian);
                List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@id",box1),
                new SqlParameter("@jg",box2),
                new SqlParameter("@zhang",box3),
                new SqlParameter("@type",box5),
                new SqlParameter("@idg",tiaojian)

            };
                SqlParameter[] parm = list.ToArray();
                string procname = "P_loupanxinxigai";
                if (DBHelper.ExecutenonQuery(procname, parm))
                {
                    MessageBox.Show("保存成功！");
                }
                else
                {
                    MessageBox.Show("保存失败！");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("保存成功！！");
            }
        }

        private void loupanxinxixiugai_Load(object sender, EventArgs e)
        {
            jiazai();
        }
        private void jiazai()
        {
            //            string sql = string.Format(@"  
            //select [LouID],[LouPrice],[LouZhang],[loupantype],[yhname] from [dbo].[LouPan],[dbo].[yonghuzhuce]
            //where  [dbo].[LouPan].lfID=[dbo].[yonghuzhuce].lfID
            //group by[LouID],[LouPrice],[LouZhang],[loupantype],[yhname]
            // ");


            this.dgv_loupanweihu.DataSource = DBHelper.GetDataTable("P_louoanxinxi");

        }

        private void dgv_loupanweihu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox1.Text = this.dgv_loupanweihu.SelectedRows[0].Cells["LouID"].Value.ToString();
            this.textBox2.Text = this.dgv_loupanweihu.SelectedRows[0].Cells["LouPrice"].Value.ToString();
            this.textBox3.Text = this.dgv_loupanweihu.SelectedRows[0].Cells["yhname"].Value.ToString();
            if (this.dgv_loupanweihu.SelectedRows[0].Cells["LouZhang"].Value.ToString() == "拥有")
            {
                this.radioButton1.Checked = true;
            }
            else if (this.dgv_loupanweihu.SelectedRows[0].Cells["LouZhang"].Value.ToString() == "出租")
            {
                this.radioButton2.Checked = true;
            }
            else // (this.dgv_loupanweihu.SelectedRows[0].Cells["LouZhang"].Value.ToString() == "闲置")
            {
                this.radioButton3.Checked = true;
            }

            if (this.dgv_loupanweihu.SelectedRows[0].Cells["loupantype"].Value.ToString() == "廉租房")
            {
                this.radioButton5.Checked = true;
            }
            else if (this.dgv_loupanweihu.SelectedRows[0].Cells["loupantype"].Value.ToString() == "商品房")
            {
                this.radioButton4.Checked = true;
            }
        }


    }
}

#endregion