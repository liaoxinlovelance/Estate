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
    public partial class zuixin : Form
    {
        public zuixin()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
//            string sql = string.Format(@"
//select [yhname],[neirong],[shijian] from [dbo].[gerentongzhi],[dbo].[yonghuzhuce]
//where [dbo].[gerentongzhi].grtzID=[dbo].[yonghuzhuce].grtzID
//group by[yhname],[neirong],[shijian]");
//            DataTable dt = DBHelper.Select(sql);
//            this.dataGridView1.DataSource = dt;
            //重新加载全部
            this.dataGridView1.AutoGenerateColumns = false;
           // this.dataGridView1.DataSource = DBHelper.SelectPrc("Pro_chakantongzhilan");
            DataTable dt = DBHelper.GetDataTable("Pro_chakantongzhilan");
            this.dataGridView1.DataSource = dt;
            this.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells["TZnr"].Value.ToString();
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.dataGridView1.SelectedRows.Count;
            if (count > 0)
            {
                this.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells["TZnr"].Value.ToString();
            }
        }

        private void zuixin_Load(object sender, EventArgs e)
        {
//            string sql = string.Format(@"
//select [yhname],[neirong],[shijian] from [dbo].[gerentongzhi],[dbo].[yonghuzhuce]
//where [dbo].[gerentongzhi].grtzID=[dbo].[yonghuzhuce].grtzID
//group by[yhname],[neirong],[shijian]");
//            DataTable dt = DBHelper.Select(sql);
//            this.dataGridView1.DataSource = dt;
            //加载全部
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = DBHelper.SelectPrc("Pro_chakantongzhilan");

            this.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells["TZnr"].Value.ToString();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime chaxun = Convert.ToDateTime(this.dateTimePicker1.Text);
            string sql = string.Format(@"
select [shijian],[dengluname],[neirong] from [dbo].[guanliyuzhucexinxi],[dbo].[ZUIXINXIAOXI]
where [dbo].[guanliyuzhucexinxi].workid=[dbo].[ZUIXINXIAOXI].zuixinID  
group by [shijian],[dengluname],[neirong]", chaxun);
            DataTable dt = DBHelper.Select(sql);
            this.dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sd = Conmen.SuoQuName;
            string sql = string.Format(@"
select [yhname],[neirong],[shijian] from [dbo].[gerentongzhi],[dbo].[yonghuzhuce]
where [dbo].[gerentongzhi].grtzID=[dbo].[yonghuzhuce].grtzID and [yhdlname] like'%{0}%'
group by[yhname],[neirong],[shijian]", sd);
            DataTable dt = DBHelper.Select(sql);
            this.dataGridView1.DataSource = dt;
        }
    }
}
