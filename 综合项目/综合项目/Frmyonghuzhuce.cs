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
//using System.Text.RegularExpressions;

//namespace 综合项目
//{
//    public partial class Frmyonghuzhuce : Form
//    {
//        public Frmyonghuzhuce()
//        {
//            InitializeComponent();
//        }
//        //电话号码的判断
//        public static bool phone(string sum)
//        {
//            Regex regex1 = new Regex(@"^1[34578]\d{9}$");
//            return regex1.IsMatch(sum);
//        }
//        // 身份证
//        public static bool identity(string num)
//        {
//            var regex2 = "(^4\\d{16}([0-9]|X)$)|(^4\\d{14}$)";
//            return Regex.IsMatch(num, regex2);
//        }
//        private void groupBox1_Enter(object sender, EventArgs e)
//        {
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            string dlname = this.textBox7.Text;
//            string mima = "";// this.textBox8.Text;
//            if (this.textBox8.Text == this.textBox9.Text)
//            {
//                mima = this.textBox8.Text;
//                this.label14.Text = "正确";
//            }
//            else
//            {
//                this.label14.Text = "错误";
//            }
//            string name = this.textBox1.Text;
            
//            string gender = "";
//            if (this.radioButton1.Checked)
//            {
//                gender = this.radioButton1.Text;
//            }
//            else if (this.radioButton2.Checked)
//            {
//                gender = this.radioButton2.Text;
//            }
//            //身份证
//            string shenfenzhen = this.textBox3.Text;
//            identity(shenfenzhen);
//            if (identity(shenfenzhen))
//            {
//                this.label4.Text = "正确";
//            }
//            else
//            {
//                this.label4.Text = "错误";
//            }

//            string menhao= this.textBox2.Text;

//            string dianhua = this.textBox4.Text;

//            phone(dianhua);
//            if (phone(dianhua))
//            {
//                this.label15.Text = "正确";
//            }
//            else
//            {
//                this.label15.Text = "错误";
//            }
//            string age = this.textBox5.Text;
//            string diqu = this.textBox6.Text;


//            if (menhao == "" || dlname == "" || mima == "" || name == "" || gender == "" || shenfenzhen == "" || dianhua == "" || age == "" || diqu == "")
//            {
//                MessageBox.Show("注册账号内容需要全部填满");

//            }
//            if (this.checkBox1.Checked && this.label14.Text == "正确" && this.label4.Text == "正确" )
//            {



//                string sql = string.Format(@"
//INSERT INTO [dbo].[yonghuzhuce]
//           ([yhdlname]
//           ,[yhmima]
//           ,[yhname]
//           ,[gender]
//           ,[sfz]
//           ,[yhmenhao]
//           ,[phone]
//           ,[age]
//           ,[area])
//     VALUES
//           ('{0}'
//           ,'{1}'
//           ,'{2}'
//           ,'{3}'
//           ,'{4}'
//           ,'{5}'
//           ,'{6}'
//           ,'{7}'
//           ,'{8}')
//
//
//", dlname, mima, name, gender, shenfenzhen,menhao, dianhua, age, diqu );

      
//             if (DBHelper.Execute(sql) )
//                {
//                    MessageBox.Show("注册成功！");
//                    shiping shiping = new shiping();
//                    shiping.ShowDialog(); 
//                    yonghudl form2 = new yonghudl();
//                    form2.Show();
                   
//                    this.Hide();
//                }
//                else
//                {
//                    MessageBox.Show("注册失败！");
//                }
//            }
//  else
//    {
//        MessageBox.Show("填写错误！");   
//    }
             
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            this.textBox7.Text = "";
//            this.textBox8.Text = "";
//           this.label14.Text = "";
          
//            this.textBox1.Text = "";
//            this.textBox3.Text = "";
//            this.label4.Text = "";
//            this.textBox2.Text = "";
//            this.textBox4.Text = "";
//            this.label7.Text = "";
//            this.label15.Text = "";
//            this.textBox5.Text = "";
//            this.textBox6.Text = "";
//            this.textBox9.Text = "";
           
//        }

//        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void Frmyonghuzhuce_Load(object sender, EventArgs e)
//        {

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
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
namespace 综合项目
{//刘祖明2019/1/2用户注册页面
    public partial class Frmyonghuzhuce : Form
    {
        public Frmyonghuzhuce()
        {
            InitializeComponent();
        }
        //电话号码的判断
        public static bool phone(string sum)
        {
            Regex regex1 = new Regex(@"^1[34578]\d{9}$");
            return regex1.IsMatch(sum);
        }
        // 身份证
        public static bool identity(string num)
        {
            var regex2 = "(^4\\d{16}([0-9]|X)$)|(^4\\d{14}$)";
            return Regex.IsMatch(num, regex2);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dlname = this.textBox7.Text;
            string mima = "";// this.textBox8.Text;
            if (this.textBox8.Text == this.textBox9.Text)
            {
                mima = this.textBox8.Text;
                this.label14.Text = "正确";
            }
            else
            {
                this.label14.Text = "错误";
            }
            string name = this.textBox1.Text;

            string gender = "";
            if (this.radioButton1.Checked)
            {
                gender = this.radioButton1.Text;
            }
            else if (this.radioButton2.Checked)
            {
                gender = this.radioButton2.Text;
            }
            //身份证
            string shenfenzhen = this.textBox3.Text;
            identity(shenfenzhen);
            if (identity(shenfenzhen))
            {
                this.label4.Text = "正确";
            }
            else
            {
                this.label4.Text = "错误";
            }

            string menhao = this.textBox2.Text;

            string dianhua = this.textBox4.Text;

            phone(dianhua);
            if (phone(dianhua))
            {
                this.label15.Text = "正确";
            }
            else
            {
                this.label15.Text = "错误";
            }
            string age = this.textBox5.Text;
            string diqu = this.textBox6.Text;


            if (menhao == "" || dlname == "" || mima == "" || name == "" || gender == "" || shenfenzhen == "" || dianhua == "" || age == "" || diqu == "")
            {
                MessageBox.Show("注册账号内容需要全部填满");

            }
            if (this.checkBox1.Checked && this.label14.Text == "正确" && this.label4.Text == "正确")
            {



                string sql = string.Format(@"
INSERT INTO [dbo].[yonghuzhuce]
           ([yhdlname]
           ,[yhmima]
           ,[yhname]
           ,[gender]
           ,[sfz]
           ,[yhmenhao]
           ,[phone]
           ,[age]
           ,[area])
     VALUES
           ('{0}'
           ,'{1}'
           ,'{2}'
           ,'{3}'
           ,'{4}'
           ,'{5}'
           ,'{6}'
           ,'{7}'
           ,'{8}')


", dlname, mima, name, gender, shenfenzhen, menhao, dianhua, age, diqu);

                SqlParameter[] parm = new SqlParameter[] { 
                new  SqlParameter("@dname",dlname),
                new SqlParameter("@pwd",mima ),
                new  SqlParameter("@rname",name),
                   new  SqlParameter("@gender",gender),
                new SqlParameter("@idcard",shenfenzhen ),

                new  SqlParameter("@workid",menhao),
                   new  SqlParameter("@phone",dianhua),
                new SqlParameter("@age",age ),
                new  SqlParameter("@area",diqu)
                };

                if (DBHelper.Ex("proc_yongzhu", parm))
                {
                    MessageBox.Show("注册成功！");
                    //shiping shiping = new shiping();
                    //shiping.ShowDialog();
                    //yonghudl form2 = new yonghudl();
                    //form2.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("注册失败！");
                }
            }
            else
            {
                MessageBox.Show("填写错误！");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = "";
            this.textBox8.Text = "";
            this.label14.Text = "";

            this.textBox1.Text = "";
            this.textBox3.Text = "";
            this.label4.Text = "";
            this.textBox2.Text = "";
            this.textBox4.Text = "";
            this.label7.Text = "";
            this.label15.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox9.Text = "";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frmyonghuzhuce_Load(object sender, EventArgs e)
        {

        }
    }
}


#endregion