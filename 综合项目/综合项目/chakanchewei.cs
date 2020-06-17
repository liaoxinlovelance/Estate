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
    public partial class chakanchewei : Form
    {
        public chakanchewei()
        {
            InitializeComponent();
        }

        private void btn_cha_Click(object sender, EventArgs e)
        {
            string box2 = this.comboBox1.Text;
            string box3 = this.comboBox2.Text;
            this.dataGridView1.AutoGenerateColumns = false;
           //创建参数列表
            SqlParameter[] parm = new SqlParameter[] { 
            new SqlParameter("@CheZhang",box2 ),
            new SqlParameter("@Chetype ",box3 )
            };

            this.dataGridView1.DataSource = DBHelper.SelectPrc("Pro_chakanchewei2",parm);
        
        }

        
         
         
//            string sql = string.Format(@"
//SELECT [cwID]
//      ,[CheIDs]
//      ,[ChePrice]
//      ,[CheZhang]
//      ,[Chetype]
//  FROM [dbo].[Cheweixinxi]
//where [CheZhang] like '%{0}%'  and [Chetype] like '%{1}%'
//
//",  box2, box3);
//            DataTable dt = DBHelper.Select(sql);
//            this.dataGridView1.DataSource = dt;
            

        private void chakanchewei_Load(object sender, EventArgs e)
        {
            //string sql = "select * from Cheweixinxi";
            //this.dataGridView1.DataSource = DBHelper.Select(sql);

            jiazai();



        }

        private void jiazai()
        {
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = DBHelper.SelectPrc("Pro_chakanchewei1");
        }

       

        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.dataGridView1.SelectedRows[0].Cells["cwID"].Value.ToString());
            string sql = string.Format(@"


DELETE FROM [dbo].[Cheweixinxi]


      WHERE cwID={0}

", num);
            if (DBHelper.Execute(sql))
            {
                MessageBox.Show("删除成功！");
                jiazai();
            }
}

        private void button2_Click(object sender, EventArgs e)
        {
            jiazai();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            车位ADD add = new 车位ADD();
            add.Show();
        }

       
    }
}
