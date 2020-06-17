#region 修改前的管理员登陆页面代码
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
//    public partial class guanlidl : Form
//    {
//        private static char[] constant ={'0','1','2','3','4','5','6','7','8','9',
//            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
//            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
//        };
//        public guanlidl()
//        {
//            InitializeComponent();
//        }
//        public static string GetRandomNumber(int Len)
//        {
//            System.Text.StringBuilder newRandom = new StringBuilder(62);
//            Random rd = new Random();
//            for (int i = 0; i < Len; i++)
//            {
//                newRandom.Append(constant[rd.Next(62)]);
//            }
//            return newRandom.ToString();
//        }     
//        private void button3_Click(object sender, EventArgs e)
//        {
//            yonghudl dl= new yonghudl();
//            dl.Show();
           
//            this.Hide();
//        }

//        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
//        {
//            Frmguanliyuanzhuce form4 = new Frmguanliyuanzhuce();
//            form4.Show();
//            this.Show();
//            this.Hide();
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
//        {
           
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            string dlname = this.textBox1.Text;
//            string dlmima = this.textBox2.Text;
//            //非空验证
//            if (dlname == "" || dlmima == "")
//            {
//                MessageBox.Show("用户名或密码不能为空！","验证错误：",MessageBoxButtons .OK ,MessageBoxIcon .Error );
//                return;
//            }
//            string sql = string.Format(@"
//SELECT [dengluname]
//      ,[glmima]
//      
//  FROM [dbo].[guanliyuzhucexinxi]
//where [dengluname]='{0}'
//
//", dlname);
//            DataTable chaxun = DBHelper.Select(sql);
//            if (chaxun .Rows .Count ==0)
//            {
//                MessageBox.Show("用户名不存在！","登录失败：",MessageBoxButtons .OK ,MessageBoxIcon .Error );
//                return;
                
//                //this.Hide();
//            }
//            if (chaxun .Rows [0]["glmima"].ToString ()!=dlmima )
//            {
//                 MessageBox.Show("密码错误！","登录失败：",MessageBoxButtons .OK ,MessageBoxIcon .Error );
//                return;
//            }
//            else if (this.textBox3.Text != this.label5.Text)
//            {
//                this.label7.Text = "错误";
//                MessageBox.Show("验证码错误!");
//            }
//            else if (this.textBox3.Text == this.label5.Text)
            
            
//            {
//               //登录成功！
//                MessageBox.Show("登陆成功！");
//                Conmen.SuoQuGuanLiYuanDLName = this.textBox1.Text;
//                Frmguanliyuanmain dl = new Frmguanliyuanmain();
//                dl.Show();
//                //this.Show();

//            }
//        }

//        private void guanlidl_Load(object sender, EventArgs e)
//        {
//            this.label5.Text = GetRandomNumber(5);
//        }

//        private void button4_Click(object sender, EventArgs e)
//        {

//            this.label5.Text = GetRandomNumber(5);
//            //this.textBox1.Text = "";
//        }

       

       
//    }
//}
#endregion
#region  修改后代码 刘祖明
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace 综合项目
{
    public partial class guanlidl : Form
    {
        private static char[] constant ={'0','1','2','3','4','5','6','7','8','9',
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };
        public guanlidl()
        {
            InitializeComponent();
        }
        public static string GetRandomNumber(int Len)
        {
            System.Text.StringBuilder newRandom = new StringBuilder(62);
            Random rd = new Random();
            for (int i = 0; i < Len; i++)
            {
                newRandom.Append(constant[rd.Next(62)]);
            }
            return newRandom.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            yonghudl dl = new yonghudl();
            dl.Show();

            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmguanliyuanzhuce form4 = new Frmguanliyuanzhuce();
            form4.Show();
            this.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dlname = this.textBox1.Text;
            string dlmima = this.textBox2.Text;
            //非空验证
            if (dlname == "" || dlmima == "")
            {
                MessageBox.Show("用户名或密码不能为空！", "验证错误：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql = string.Format(@"
SELECT [dengluname]
      ,[glmima]
      
  FROM [dbo].[guanliyuzhucexinxi]
where [dengluname]='{0}'

", dlname);
            SqlParameter[] parm = new SqlParameter[] { 
            new  SqlParameter("@name",dlname),
            new  SqlParameter("@pwd",dlmima)
            };

            DataTable chaxun = DBHelper.Se("proc_adminLogin", parm);
            if (chaxun.Rows.Count == 0)
            {
                MessageBox.Show("用户名不存在！", "登录失败：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

                //this.Hide();
            }
            if (chaxun.Rows[0]["glmima"].ToString() != dlmima)
            {
                MessageBox.Show("密码错误！", "登录失败：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (this.textBox3.Text != this.label5.Text)
            {
                this.label7.Text = "错误";
                MessageBox.Show("验证码错误!");
            }
            else if (this.textBox3.Text == this.label5.Text)
            {
                //登录成功！
                MessageBox.Show("登录成功！");
                Conmen.SuoQuGuanLiYuanDLName = this.textBox1.Text;
               
                shiping shiping = new shiping();
                shiping.ShowDialog(); 
                Frmguanliyuanmain dl = new Frmguanliyuanmain();
                dl.Show();
                //this.Show();

            }
        }

        private void guanlidl_Load(object sender, EventArgs e)
        {
            this.label5.Text = GetRandomNumber(5);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.label5.Text = GetRandomNumber(5);
            //this.textBox1.Text = "";
        }




    }
}


#endregion