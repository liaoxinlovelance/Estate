#region 修改前
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
//    public partial class yonghudl : Form
//    {
//        Sunisoft.IrisSkin.SkinEngine skinEngine = null;
//        private static char[] constant ={'0','1','2','3','4','5','6','7','8','9',
//            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
//            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
//        };
//        public yonghudl()
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
//            guanlidl dl = new guanlidl();
//            dl.Show();
            
//            this.Hide ();
//        }

//        private void yonghudl_FormClosing(object sender, FormClosingEventArgs e)
//        {
//            Application.Exit();
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            string dlname = this.textBox1.Text;
           
//            string dlmima = this.textBox2.Text;
//            //非空验证
//            if (dlname == "" || dlmima == "")
//            {
//                MessageBox.Show("用户名或密码不能为空！", "验证错误：", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }
//            string sql = string.Format(@"
//SELECT [yhdlname]
//      ,[yhmima]
//      ,[yhname]
//      ,[gender]
//      ,[sfz]
//      ,[yhmenhao]
//      ,[phone]
//      ,[age]
//      ,[area]
//  FROM [dbo].[yonghuzhuce]
//where [yhdlname]='{0}'
//
//", dlname);
//            DataTable chaxun = DBHelper.Select(sql);
           
//            if (chaxun.Rows.Count == 0)
//            {
//                MessageBox.Show("用户名不存在！", "登录失败：", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;

//                //this.Hide();
//            }
//            if (chaxun.Rows[0]["yhmima"].ToString() != dlmima)
//            {
//                MessageBox.Show("密码错误！", "登录失败：", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            } 
//            else if (this.textBox3.Text != this.label5.Text)
//            {
//                this.label7.Text = "错误";
//                 MessageBox.Show("验证码错误!");
//            }
//            else if (this.textBox3.Text == this.label5.Text)
//            {
//                //登录成功！
//                MessageBox.Show("登陆成功！");
//                //锁定登录名
//                //获取当前用户的名字
//           // Conmen.SuoQuName = dlname; //Conmen suoding = new Conmen();
//               Conmen .SuoQuName = this.textBox1.Text;
//               Frmyonghumain dl = new Frmyonghumain();
//                dl.Show();
//                //this.Show();

//            }
//        }

//        private void button4_Click(object sender, EventArgs e)
//        {
//            this.label5.Text = GetRandomNumber(5);
//            this.textBox3.Text = "";
//            this.label7.Text = "";
//        }

//        private void yonghudl_Load(object sender, EventArgs e)
//        {
//            skinEngine = new Sunisoft.IrisSkin.SkinEngine();
//            skinEngine.SkinAllForm = true;
//            skinEngine.SkinFile = "DeepCyan.ssk";
//            this.label5.Text = GetRandomNumber(5);
//        }

//        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
//        {
//            Frmyonghuzhuce form4 = new Frmyonghuzhuce();
//            form4.Show();
            
//            this.Hide();
//        }

//        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            skinEngine.SkinFile = this.comboBox1.Text + ".ssk";
//        }

        
//    }
//}
#endregion
#region  修改后 操作人刘祖明
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
    public partial class yonghudl : Form
    {
        Sunisoft.IrisSkin.SkinEngine skinEngine = null;
        private static char[] constant ={'0','1','2','3','4','5','6','7','8','9',
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };
        public yonghudl()
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
            guanlidl dl = new guanlidl();
            dl.Show();

            this.Hide();
        }

        private void yonghudl_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
SELECT [yhdlname]
      ,[yhmima]
      ,[yhname]
      ,[gender]
      ,[sfz]
      ,[yhmenhao]
      ,[phone]
      ,[age]
      ,[area]
  FROM [dbo].[yonghuzhuce]
where [yhdlname]='{0}'

", dlname);
            SqlParameter[] parm = new SqlParameter[] { 
            new  SqlParameter("@name",dlname),
            new SqlParameter("@pwd",dlmima)
            
            };
            DataTable chaxun = DBHelper.Se("proc_yongLogin", parm);

            if (chaxun.Rows.Count == 0)
            {
                MessageBox.Show("用户名不存在！", "登录失败：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

                //this.Hide();
            }
            if (chaxun.Rows[0]["yhmima"].ToString() != dlmima)
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
                //锁定登录名
                //获取当前用户的名字
                // Conmen.SuoQuName = dlname; //Conmen suoding = new Conmen();
                Conmen.SuoQuName = this.textBox1.Text;
                shiping shiping = new shiping();
                shiping.ShowDialog(); 
                Frmyonghumain dl = new Frmyonghumain();
                dl.Show();
             
                //this.Show();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label5.Text = GetRandomNumber(5);
            this.textBox3.Text = "";
            this.label7.Text = "";
        }

        private void yonghudl_Load(object sender, EventArgs e)
        {
            skinEngine = new Sunisoft.IrisSkin.SkinEngine();
            skinEngine.SkinAllForm = true;
            skinEngine.SkinFile = "DeepCyan.ssk";
            this.label5.Text = GetRandomNumber(5);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmyonghuzhuce form4 = new Frmyonghuzhuce();
            form4.Show();

            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            skinEngine.SkinFile = this.comboBox1.Text + ".ssk";
        }


    }
}

#endregion