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
    public partial class shangpingtianjia : Form
    {
        public shangpingtianjia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string box1 = this.textBox1.Text;
            string box2 = this.textBox2.Text;
            string box3 = this.textBox3.Text;
            string box4 = this.textBox4.Text;
            string box5 = this.dateTimePicker1.Text;
            string box6 = this.dateTimePicker2.Text;
            SqlParameter[] parm = new SqlParameter[] { 
            new SqlParameter("@GoodPrice",box3),
            new SqlParameter("@GoodShenqi",box5),
            new SqlParameter("@GoodDaoqi ",box6),
            new SqlParameter("@GoodBaoqi",box4),
            new SqlParameter("@GoodType",box2),
            new SqlParameter("@GoodName",box1)
            };
            if (DBHelper.ExcutePrc("Pro_shangpingguanlitianjia",parm))
            {
                MessageBox.Show("添加成功！");
                this.Hide();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }
    }
}
