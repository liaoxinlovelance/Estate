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
    public partial class yezhu : Form
    {
        public yezhu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
          
            Frmguanliyuanmain Form8 = new Frmguanliyuanmain();
            Form8.Show();
        }
        }
    }

