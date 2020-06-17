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
    public partial class chakanzhongzhikahao : Form
    {
        public chakanzhongzhikahao()
        {
            InitializeComponent();
        }

        private void chakanzhongzhikahao_Load(object sender, EventArgs e)
        {
            jiazai();

        }

        private void jiazai()
        {
            string sql = string.Format(@"

SELECT [chongzhiID]
      ,[ChongDate]
      ,[Chongmoney]
      ,[Yue]
  FROM [dbo].[Userchong]


");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = DBHelper.Select(sql);
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jiazai();
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tianjiakahao kh = new tianjiakahao();
            kh.ShowDialog();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否删除？","提示", MessageBoxButtons .YesNo ,MessageBoxIcon.Question );
            if (dr==DialogResult .Yes)
            {
                int count = this.dataGridView1.SelectedRows.Count;
            if (count>0)
            {
                string shanchu = this.dataGridView1.SelectedRows[0].Cells["chongzhiID"].Value.ToString();
                string sql = string.Format(@"
DELETE FROM [dbo].[Userchong]
      WHERE [chongzhiID]='{0}'


",shanchu );
                if (DBHelper .Execute (sql ))
                {
                    MessageBox.Show("删除成功！");
                }
            }
            
            }
        }
    }
}
