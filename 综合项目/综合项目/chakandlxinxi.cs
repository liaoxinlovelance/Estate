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
    public partial class chakandlxinxi : Form
    {
        public chakandlxinxi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jiazai();
        }

        private void jiazai()
        {
            string box1 = this.textBox1.Text;
            string sql = string.Format(@"
select   [yhdlname],[yhmima] from [dbo].[yonghuzhuce]
where [yhdlname]like'%{0}%'
group by [yhdlname],[yhmima]", box1);
            DataTable dt = DBHelper.Select(sql);
            this.dataGridView1.DataSource = dt;
        }

        private void chakandlxinxi_Load(object sender, EventArgs e)
        {
            jiazai();
        }
    }
}
