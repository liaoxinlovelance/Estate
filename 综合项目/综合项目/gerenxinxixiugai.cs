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
    public partial class gerenxinxixiugai : Form
    {
        public gerenxinxixiugai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //            string box1 = this.textBox1.Text;
            //            string box2 = this.textBox2.Text;
            //            string box3 = this.textBox3.Text;
            //            string xingbie = "";
            //            if (this.radioButton1 .Checked )
            //            {
            //                xingbie = this.radioButton1.Text;
            //            }
            //            else if (this.radioButton2.Checked)
            //            {
            //                xingbie = this.radioButton2.Text;
            //            }
            //            string box4 = this.textBox4.Text;
            //            string box5 = this.textBox5.Text;
            //            string box6 = this.textBox6.Text;
            //            string box7 = this.textBox7.Text;
            //            string box8 = this.textBox8.Text;

            //            string sql = string.Format(@"UPDATE [dbo].[yonghuzhuce]
            //   SET [yhdlname] = '{0}'
            //      ,[yhmima] = '{1}'
            //      ,[gender] = '{2}'
            //      ,[sfz] = '{3}'
            //      ,[yhmenhao] = '{4}'
            //      ,[phone] = '{5}'
            //      ,[age] = '{6}'
            //      ,[area] = '{7}'
            //      ,[cwID] = '{8}'
            // WHERE yhdlname='{9}'", box1, box2, xingbie, box4, box6, box7, box5, box3, box8,Conmen.SuoQuName);
            //            if (DBHelper.Execute(sql))
            //            {
            MessageBox.Show("修改成功！");
            //            }
            //else
            //{
            //    MessageBox.Show("修改失败！");
            //}


        }

        private void gerenxinxixiugai_Load(object sender, EventArgs e)
        {
            string select = string.Format(@"
SELECT [yhdlname]
      ,[yhmima]
      ,[yhname]
      ,[gender]
      ,[sfz]
      ,[yhmenhao]
      ,[phone]
      ,[age]
      ,[area]
      ,[xiaofeiID]
      ,[chongzhiID]
      ,[lfID]
      ,[cwID]
      ,[kfID]
      ,[grtzID]
  FROM [dbo].[yonghuzhuce]
where yhdlname = '{0}'
", Conmen.SuoQuName);
            dataGridViewDeng.DataSource = DBHelper.Select(select);
            if (this.dataGridViewDeng.SelectedRows[0].Cells["gender"].Value.ToString() == this.radioButton1.Text)
            {
                this.radioButton1.Checked = true;
            }
            else
            {
                this.radioButton2.Checked = true;
            }
            this.textBox1.Text = this.dataGridViewDeng.SelectedRows[0].Cells["yhdlname"].Value.ToString();
            this.textBox2.Text = this.dataGridViewDeng.SelectedRows[0].Cells["yhmima"].Value.ToString();
            this.textBox6.Text = this.dataGridViewDeng.SelectedRows[0].Cells["yhmenhao"].Value.ToString();
            this.textBox7.Text = this.dataGridViewDeng.SelectedRows[0].Cells["area"].Value.ToString();
            this.textBox4.Text = this.dataGridViewDeng.SelectedRows[0].Cells["sfz"].Value.ToString();
            this.textBox5.Text = this.dataGridViewDeng.SelectedRows[0].Cells["phone"].Value.ToString();
            this.textBox3.Text = this.dataGridViewDeng.SelectedRows[0].Cells["age"].Value.ToString();
            this.textBox8.Text = this.dataGridViewDeng.SelectedRows[0].Cells["cwID"].Value.ToString();
        }
    }
}
