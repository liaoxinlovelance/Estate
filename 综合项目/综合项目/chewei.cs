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
    public partial class chewei : Form
    {
        public chewei()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       chewei che=new chewei ();
            che.Show();
        
            Frmguanliyuanmain Form8 = new Frmguanliyuanmain();
            Form8.Show();
        }

        private void chewei_Load(object sender, EventArgs e)
        {

        }
        }
    }

