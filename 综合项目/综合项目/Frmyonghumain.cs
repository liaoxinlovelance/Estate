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
    public partial class Frmyonghumain : Form
    {
        Sunisoft.IrisSkin.SkinEngine skinEngine = null;
        public Frmyonghumain()
        {
            InitializeComponent();
        }

        private void 查看个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 登陆信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dengluxinxi dlxinxi = new dengluxinxi();
            dlxinxi.MdiParent = this;
            dlxinxi.Show();
        }

        private void 实名信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shimingxinxi smxinxi = new shimingxinxi();
            smxinxi.MdiParent = this;
            smxinxi.Show();

        }

        private void 查看车位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yonghuchakanchewei ckcw = new yonghuchakanchewei();
            ckcw.MdiParent = this;
            ckcw.Show();

        }

        private void 查看余额ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chakanyezhuyue ckye = new chakanyezhuyue();
            ckye.MdiParent = this;
            ckye.Show();
        }

        private void 查看商品价格ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chakanshangpingjiage ckspjg = new chakanshangpingjiage();
            ckspjg.MdiParent = this;
            ckspjg.Show();
        }

        private void 查看楼盘信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yonghuchakanloupan lpxinxi = new yonghuchakanloupan();
            lpxinxi.MdiParent = this;
            lpxinxi.Show();
        }

        private void 楼盘信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loupanxinxixiugai lpxinxigg = new loupanxinxixiugai();
            lpxinxigg.MdiParent = this;
            lpxinxigg.Show();
        }

        private void 流水信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liushuixinxi lsxinxi = new liushuixinxi();
            lsxinxi.MdiParent = this;
            lsxinxi.Show();
        }

        private void 缴费充值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jiaofeichongzhi jfcz = new jiaofeichongzhi();
            jfcz.MdiParent = this;
            jfcz.Show();
        }

        private void 余额查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chakanyue ckye = new chakanyue();
            ckye.MdiParent = this;
            ckye.Show();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出系统吗？","提示",MessageBoxButtons .YesNo ,MessageBoxIcon.Question );
            if (result ==DialogResult .Yes )
            {
                 Application.Exit();
            }
           
        }

        private void 个人信息更改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gerenxinxixiugai xiugai = new gerenxinxixiugai();
            xiugai.MdiParent = this;
            xiugai.Show();
        }

        private void 最新消息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zuixin zx = new zuixin();
            zx.MdiParent = this;
            zx.Show();
            

        }

        private void 车位更换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cheweigenghuan cheweigh = new cheweigenghuan();
            cheweigh.MdiParent = this;
            cheweigh.Show();
        }

        private void 联系客服ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kefufuwu kf = new kefufuwu();
            //kf.MdiParent = this;
            //kf.Show();
        }

        private void 用户反馈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yonghufankui fk = new yonghufankui();
            fk.MdiParent = this;
            fk.Show();
        }

        

        private void 在线客服ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jiqiren jiqiren = new jiqiren();
            jiqiren.Show();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            skinEngine.SkinFile = this.toolStripComboBox1.Text + ".ssk";
        }

        private void Frmyonghumain_Load(object sender, EventArgs e)
        {
            skinEngine = new Sunisoft.IrisSkin.SkinEngine();
            skinEngine.SkinAllForm = true;
            skinEngine.SkinFile = "DeepCyan.ssk";
            this.toolStripStatusLabel1.Text = string.Format("时间：{0},欢迎", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            this.toolStripStatusLabel2.Text = Conmen.SuoQuName;
            this.toolStripStatusLabel3.Text = "使用Another小区业务管理系统";
            
        }

        private void 切换用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yonghudl dl = new yonghudl();
            dl.Show();
            Frmyonghumain main = new Frmyonghumain();
            main.Close();
        }

        private void 音乐1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Player.URL = @"音乐\音乐1.mp3";
            Player.Ctlcontrols.play();

        }

        private void 音乐2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Player.URL = @"音乐\音乐2.mp3";
            Player.Ctlcontrols.play();
        }

        private void 音乐3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Player.URL = @"音乐\音乐3.mp3";
            Player.Ctlcontrols.play();
        }

        private void 音乐4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Player.URL = @"音乐\音乐4.mp3";
            Player.Ctlcontrols.play();
        }

        private void 音乐5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Player.URL = @"音乐\音乐5.mp3";
            Player.Ctlcontrols.play();
        }

        private void 音乐6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Player.URL = @"音乐\音乐6.mp3";
            Player.Ctlcontrols.play();
        }

        private void 音乐7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Player.URL = @"音乐\音乐7.mp3";
            Player.Ctlcontrols.play();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format("时间：{0},欢迎", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        


        
    }
}
