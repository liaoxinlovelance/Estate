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
    public partial class cheweigenghuan : Form
    {
        public cheweigenghuan()
        {
            InitializeComponent();
        }

        private void cheweigenghuan_Load(object sender, EventArgs e)
        {
            this.label9.Text = Conmen.SuoQuName;

            string box1 = this.comboBox1.Text;
            string box2 = this.comboBox2.Text;
            string sql = string.Format(@"
select [yhname],[CheIDs],[ChePrice],[CheZhang],[Chetype] from [dbo].[Cheweixinxi],[dbo].[yonghuzhuce]
where [dbo].[Cheweixinxi].cwID=[dbo].[yonghuzhuce].cwID  and [CheZhang]='{0}' and [Chetype]='{1}'
group by [yhname],[CheIDs],[ChePrice],[CheZhang],[Chetype]
", box1, box2);
            DataTable dt = DBHelper.Select(sql);
            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string box1 = this.comboBox1.Text;
            string box2 = this.comboBox2.Text;
            string sql = string.Format(@"
select [yhname],[CheIDs],[ChePrice],[CheZhang],[Chetype] from [dbo].[Cheweixinxi],[dbo].[yonghuzhuce]
where [dbo].[Cheweixinxi].cwID=[dbo].[yonghuzhuce].cwID  and [CheZhang]='{0}' and [Chetype]='{1}'
group by [yhname],[CheIDs],[ChePrice],[CheZhang],[Chetype]
", box1,box2);
            DataTable dt = DBHelper.Select(sql);
            this.dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string box1 = this.comboBox1.Text;
            string box2 = this.comboBox2.Text;
            string sql = string.Format(@"
select [yhname],[CheIDs],[ChePrice],[CheZhang],[Chetype] from [dbo].[Cheweixinxi],[dbo].[yonghuzhuce]
where [dbo].[Cheweixinxi].cwID=[dbo].[yonghuzhuce].cwID  and [CheZhang]='{0}' and [Chetype]='{1}'
group by [yhname],[CheIDs],[ChePrice],[CheZhang],[Chetype]
", box1, box2);
            DataTable dt = DBHelper.Select(sql);
            this.dataGridView1.DataSource = dt;
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hzdlname = Conmen.SuoQuName;

            string sql = string.Format(@"
UPDATE [dbo].[yonghuzhuce]
   SET [cwID] = <cwID, int,>
    WHERE yhdlname='{0}'
 
 
", hzdlname );

       
        }

        
    }
}
