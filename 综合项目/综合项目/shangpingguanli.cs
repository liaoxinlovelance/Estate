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
    public partial class shangpingguanli : Form
    {
        #region 分页参数
        private int page = 1;//当前页面数
        private int rows = 6;//每页显示的行数
        private int countPage = 0;//总页数
        private bool flagAll = true;//是否是查询所有：true--查询所有，false--条件查询
        #endregion
        public shangpingguanli()
        {
            InitializeComponent();
        }

        private void shangpingguanli_Load(object sender, EventArgs e)
        {
            selectall();
        }

        private void selectall()
        {
            flagAll = true;
            //查询所有单车信息
            SqlParameter[] parm = new SqlParameter[]{
                new SqlParameter("@page",page),
                new SqlParameter("@row",rows),
                new SqlParameter("@count",SqlDbType.Int)
            };
            parm[2].Direction = ParameterDirection.Output;
            //查询方法
            Select("Pro_shangpingguanli", parm);
        }
        #region 根据存储过程明和参数列表查询单车信息
        /// <summary>
        /// 查询单车信息
        /// </summary>
        /// <param name="proc">存储过程名称</param>
        /// <param name="parm">参数列表</param>
        private void Select(string proc, SqlParameter[] parm)
        {
            this.button1.Enabled = false;

            //不自动产生列
            this.dataGridView1.AutoGenerateColumns = false;
            //窗体加载时显示所有单车信息
            this.dataGridView1.DataSource = DBHelper.Select(proc, parm);
            //总页数
            countPage = Convert.ToInt32(parm[2].Value) / rows;
            if ((Convert.ToInt32(parm[2].Value) % rows) > 0)
            {
                countPage++;
            }
            //总数据条数
            this.label6.Text = parm[2].Value.ToString();
            this.label4.Text = countPage.ToString();
            this.label2.Text = page.ToString();
            //当   当前页码数=总页数时，“下一页” 禁用
            if (page == countPage)
            {
                this.button2.Enabled = false;
            }
            else
            {
                this.button2.Enabled = true;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {//上一页
            if ( page!=1)
            {
                page--;
                if (flagAll)
                {
                    selectall();
                }
                else
                {
                    //SelectByC();
                }
                this.label2.Text = page.ToString();
                if (page == countPage)
                {
                    this.button2.Enabled = false;
                    this.button1.Enabled = true;
                }
                else
                {
                    this.button2.Enabled = true;
                    this.button1.Enabled = true;
                }
            }
            else
            {
                this.button1.Enabled = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {//下一页
            if (page!=countPage)
            {
                page++;
                if (flagAll)
                {
                    selectall();
                }
                else
                {
                    //SelectByC();
                }
                this.label2.Text = page.ToString();
                if (page == 1)
                {
                    this.button1.Enabled = false;
                    this.button2.Enabled = true;
                }
                else
                {
                    this.button2.Enabled = true;
                    this.button1.Enabled = true;
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {  string box1=this.textBox1.Text;
            SqlParameter[] parm1 = new SqlParameter[]{
            new SqlParameter("@GoodName",box1)
            };
            this.dataGridView1.DataSource = DBHelper.SelectPrc("Pro_shangpingguanlichaxun", parm1);
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectall();
            this.button2.Enabled = true;
            this.button1.Enabled = true;
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shangpingtianjia tianjia = new shangpingtianjia();
            tianjia.Show();
        }

        private void 删除商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = this.dataGridView1.SelectedRows[0].Cells["GoodName"].Value.ToString();
             SqlParameter[] parm2 = new SqlParameter[]{
            new SqlParameter("@GoodName",name)
            };
             if (DBHelper.ExcutePrc("Pro_shangpingguanlishanchu", parm2))
            {
                MessageBox.Show("删除成功！");
                selectall();
                this.button2.Enabled = true;
                this.button1.Enabled = true;
            }
             else
             {
                 MessageBox.Show("删除失败！");
             }
        }
    }
}
