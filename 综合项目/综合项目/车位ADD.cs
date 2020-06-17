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
    public partial class 车位ADD : Form
    {
        public 车位ADD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            double jiage = Convert.ToDouble(this.textBox2.Text);
            string zt = this.comboBox1.Text;
            string lx = this.comboBox2.Text;
            if (name != "" && zt != "" && lx != "")
            {
                string sql = string.Format(@"


INSERT INTO [dbo].[Cheweixinxi]
           ([CheIDs]
           ,[ChePrice]
           ,[CheZhang]
           ,[Chetype])
     VALUES('{0}'
           ,{1}
           ,'{2}'
           ,'{3}')
           

           

", name, jiage, zt, lx);
                if (DBHelper.Execute(sql))
                {
                    MessageBox.Show("添加成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }

            }
            else
            {
                MessageBox.Show("请书写完整内容！");
            }
        }
    }
}
