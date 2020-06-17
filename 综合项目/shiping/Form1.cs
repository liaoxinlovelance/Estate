using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shiping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Player_Enter(object sender, EventArgs e)
        {
            this.Player.URL = @"时间.mp4";
            Player.Ctlcontrols.play();
        }
    }
}
