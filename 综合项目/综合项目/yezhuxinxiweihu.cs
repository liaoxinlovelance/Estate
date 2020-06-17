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
//    public partial class yezhuxinxiweihu : Form
//    {
//        public yezhuxinxiweihu()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            this.Close();
          
//            Frmguanliyuanmain Form8 = new Frmguanliyuanmain();
//            Form8.Show();
//        }

//        private void yezhuxinxiweihu_Load(object sender, EventArgs e)
//        {
//            jiazai();
//        }

//        private void jiazai()
//        {
//            string sql = string.Format(@"
//select [yhdlname],[yhmima],[yhname],[gender],[sfz],[phone],[age],[area],[dbo].[yonghuzhuce].[lfID],[dbo].[yonghuzhuce].[cwID],[LouID],[CheIDs]from [dbo].[yonghuzhuce],[dbo].[LouPan],[dbo].[Cheweixinxi]
//where [dbo].[yonghuzhuce].lfID=[dbo].[LouPan].lfID  and  [dbo].[yonghuzhuce].cwID=[dbo].[Cheweixinxi].cwID
//group by [yhdlname],[yhmima],[yhname],[gender],[sfz],[phone],[age],[area],[dbo].[yonghuzhuce].[lfID],[dbo].[yonghuzhuce].[cwID],[LouID],[CheIDs]");

//            DataTable dt = DBHelper.Select(sql);
//            this.dataGridView1.DataSource = dt;
//        }

//        private void button1_Click_1(object sender, EventArgs e)
//        {
//            string sql = string.Format(@"
//select [yhdlname],[yhmima],[yhname],[gender],[sfz],[phone],[age],[area],[dbo].[yonghuzhuce].[lfID],[dbo].[yonghuzhuce].[cwID],[LouID],[CheIDs]from [dbo].[yonghuzhuce],[dbo].[LouPan],[dbo].[Cheweixinxi]
//where [dbo].[yonghuzhuce].lfID=[dbo].[LouPan].lfID  and  [dbo].[yonghuzhuce].cwID=[dbo].[Cheweixinxi].cwID
//group by [yhdlname],[yhmima],[yhname],[gender],[sfz],[phone],[age],[area],[dbo].[yonghuzhuce].[lfID],[dbo].[yonghuzhuce].[cwID],[LouID],[CheIDs]");

//            DataTable dt = DBHelper.Select(sql);
//            this.dataGridView1.DataSource = dt;
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            chakanchewei ckcww = new chakanchewei();
//            ckcww.Show();
//        }

//        private void button3_Click(object sender, EventArgs e)
//        {
//            chakanloupan lp = new chakanloupan();
//            lp.Show();
//        }

//        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
//            this.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells["yhdlname"].Value.ToString();
//            this.textBox2.Text = this.dataGridView1.SelectedRows[0].Cells["yhmima"].Value.ToString();
//            this.textBox3.Text = this.dataGridView1.SelectedRows[0].Cells["yhname"].Value.ToString();
//            this.comboBox1.Text = this.dataGridView1.SelectedRows[0].Cells["gender"].Value.ToString();
//            this.textBox5.Text = this.dataGridView1.SelectedRows[0].Cells["sfz"].Value.ToString();
//            this.textBox6.Text = this.dataGridView1.SelectedRows[0].Cells["phone"].Value.ToString();
//            this.textBox7.Text = this.dataGridView1.SelectedRows[0].Cells["age"].Value.ToString();
//            this.textBox8.Text = this.dataGridView1.SelectedRows[0].Cells["area"].Value.ToString();
//            this.textBox9.Text = this.dataGridView1.SelectedRows[0].Cells["lfID"].Value.ToString();
//            this.textBox10.Text = this.dataGridView1.SelectedRows[0].Cells["cwID"].Value.ToString();
//        }

//        private void button4_Click(object sender, EventArgs e)
//        {
//            string tiaojian = this.dataGridView1.SelectedRows[0].Cells["yhname"].Value.ToString();
//            string box1 = this.textBox1.Text;
//            string box2 = this.textBox2.Text;
//           // string box3 = this.textBox3.Text;
//            string box4 = this.comboBox1.Text;
//            string box5 = this.textBox5.Text;
//            string box6 = this.textBox6.Text;
//            string box7 =this.textBox7.Text;
//            string box8 = this.textBox8.Text;
//            string box9 = this.textBox9.Text;
//            string box10 = this.textBox10.Text;

//            string sql = string.Format(@"
//
//UPDATE [dbo].[yonghuzhuce]
//   SET [yhdlname] = '{0}'
//      ,[yhmima] = '{1}'
//     
//      ,[gender] = '{2}'
//      ,[sfz] = '{3}'
//     
//      ,[phone] = '{4}'
//      ,[age] = '{5}'
//      ,[area] = '{6}'
//      
//      ,[lfID] = '{7}'
//      ,[cwID] = '{8}'
//      
// WHERE  [yhname]='{9}'
//
//
//",box1,box2,box4 ,box5,box6,box7,box8,box9,box10,tiaojian );
//            if (DBHelper .Execute (sql ))
//            {
//                MessageBox.Show("修改成功！");
//                jiazai();
//            }

//        }

       
//        }
//    }

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
    public partial class yezhuxinxiweihu : Form
    {
        public yezhuxinxiweihu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Frmguanliyuanmain Form8 = new Frmguanliyuanmain();
            Form8.Show();
        }

        private void yezhuxinxiweihu_Load(object sender, EventArgs e)
        {
            jiazai();
        }

        private void jiazai()
        {
            //            string sql = string.Format(@"
            //select [yhdlname],[yhmima],[yhname],[gender],[sfz],[phone],[age],[area],[dbo].[yonghuzhuce].[lfID],[dbo].[yonghuzhuce].[cwID],[LouID],[CheIDs]from [dbo].[yonghuzhuce],[dbo].[LouPan],[dbo].[Cheweixinxi]
            //where [dbo].[yonghuzhuce].lfID=[dbo].[LouPan].lfID  and  [dbo].[yonghuzhuce].cwID=[dbo].[Cheweixinxi].cwID
            //group by [yhdlname],[yhmima],[yhname],[gender],[sfz],[phone],[age],[area],[dbo].[yonghuzhuce].[lfID],[dbo].[yonghuzhuce].[cwID],[LouID],[CheIDs]");

            DataTable dt = DBHelper.GetDataTable("P_yezhuxinxicha");
            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //            string sql = string.Format(@"
            //select [yhdlname],[yhmima],[yhname],[gender],[sfz],[phone],[age],[area],[dbo].[yonghuzhuce].[lfID],[dbo].[yonghuzhuce].[cwID],[LouID],[CheIDs]from [dbo].[yonghuzhuce],[dbo].[LouPan],[dbo].[Cheweixinxi]
            //where [dbo].[yonghuzhuce].lfID=[dbo].[LouPan].lfID  and  [dbo].[yonghuzhuce].cwID=[dbo].[Cheweixinxi].cwID
            //group by [yhdlname],[yhmima],[yhname],[gender],[sfz],[phone],[age],[area],[dbo].[yonghuzhuce].[lfID],[dbo].[yonghuzhuce].[cwID],[LouID],[CheIDs]");

            DataTable dt = DBHelper.GetDataTable("P_yezhuxinxicha");
            this.dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chakanchewei ckcww = new chakanchewei();
            ckcww.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chakanloupan lp = new chakanloupan();
            lp.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells["yhdlname"].Value.ToString();
            this.textBox2.Text = this.dataGridView1.SelectedRows[0].Cells["yhmima"].Value.ToString();
            this.textBox3.Text = this.dataGridView1.SelectedRows[0].Cells["yhname"].Value.ToString();
            this.comboBox1.Text = this.dataGridView1.SelectedRows[0].Cells["gender"].Value.ToString();
            this.textBox5.Text = this.dataGridView1.SelectedRows[0].Cells["sfz"].Value.ToString();
            this.textBox6.Text = this.dataGridView1.SelectedRows[0].Cells["phone"].Value.ToString();
            this.textBox7.Text = this.dataGridView1.SelectedRows[0].Cells["age"].Value.ToString();
            this.textBox8.Text = this.dataGridView1.SelectedRows[0].Cells["area"].Value.ToString();
            this.textBox9.Text = this.dataGridView1.SelectedRows[0].Cells["lfID"].Value.ToString();
            this.textBox10.Text = this.dataGridView1.SelectedRows[0].Cells["cwID"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tiaojian = this.dataGridView1.SelectedRows[0].Cells["yhname"].Value.ToString();
            string box1 = this.textBox1.Text;
            string box2 = this.textBox2.Text;
            // string box3 = this.textBox3.Text;
            string box4 = this.comboBox1.Text;
            string box5 = this.textBox5.Text;
            string box6 = this.textBox6.Text;
            string box7 = this.textBox7.Text;
            string box8 = this.textBox8.Text;
            string box9 = this.textBox9.Text;
            string box10 = this.textBox10.Text;
            List<SqlParameter> list = new List<SqlParameter>(){
                new SqlParameter("@name",box1),
                new SqlParameter("@mima",box2),
                new SqlParameter("@xb",box4),
                new SqlParameter("@sfz",box5),
                new SqlParameter("@dh",box6),
                new SqlParameter("@age",box7),
                new SqlParameter("@dz",box8),
                new SqlParameter("@ifid",box9),
                new SqlParameter("@cwid",box10),
                new SqlParameter("@mz",tiaojian)

            };
            SqlParameter[] parm = list.ToArray();
            string procname = "P_yezhuxinxigai";
            //            string sql = string.Format(@"
            //
            //UPDATE [dbo].[yonghuzhuce]
            //   SET [yhdlname] = '{0}'
            //      ,[yhmima] = '{1}'
            //     
            //      ,[gender] = '{2}'
            //      ,[sfz] = '{3}'
            //     
            //      ,[phone] = '{4}'
            //      ,[age] = '{5}'
            //      ,[area] = '{6}'
            //      
            //      ,[lfID] = '{7}'
            //      ,[cwID] = '{8}'
            //      
            // WHERE  [yhname]='{9}'
            //
            //
            //",box1,box2,box4 ,box5,box6,box7,box8,box9,box10,tiaojian );
            if (DBHelper.ExecutenonQuery(procname, parm))
            {
                MessageBox.Show("修改成功！");
                jiazai();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}



#endregion