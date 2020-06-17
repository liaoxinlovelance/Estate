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
    public partial class shiping : Form
    {
        public shiping()
        {
            InitializeComponent();
        }

        private void Player_Enter(object sender, EventArgs e)
        {
            this.Player.URL = @"时间.mp4";
            Player.Ctlcontrols.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            yonghudl Login = new yonghudl();
            Login.Show();
            this.Hide();
            this.timer1.Enabled = false;
            
        }
    }
}
