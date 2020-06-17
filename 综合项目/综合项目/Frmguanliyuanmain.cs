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
    public partial class Frmguanliyuanmain : Form
    {
        Sunisoft.IrisSkin.SkinEngine skinEngine = null;
        public Frmguanliyuanmain()
        {
            InitializeComponent();
        }

        private void 楼盘管理ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            loupanxinxiweihu lp = new loupanxinxiweihu();
           lp.Show();
           lp.MdiParent = this;

           
        }

        private void 车位信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cheweixinxiweihu chewei = new cheweixinxiweihu();
            chewei.MdiParent = this;
            chewei.Show();
        }

        private void 业主信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yezhuxinxiweihu yz = new yezhuxinxiweihu();
            yz.MdiParent = this;
            yz.Show();
        }

        private void 查看楼盘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chakanloupan lpxinxi = new chakanloupan();
            lpxinxi.MdiParent = this;
            lpxinxi.Show();
        }

        private void 查看车位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chakanchewei ckcww = new chakanchewei();
            ckcww.MdiParent = this;
            ckcww.Show();
        }

        private void 登陆信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            chakandlxinxi ck = new chakandlxinxi();
            ck.MdiParent = this;
            ck.Show();
        }

        private void 住房信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zhufangxinxi zfxinxi = new zhufangxinxi();
            zfxinxi.MdiParent = this;
            zfxinxi.Show();

        }

        private void 业主缴费信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yezhujiaofeixinxi jiaofei=new yezhujiaofeixinxi();
            jiaofei.MdiParent = this;
            jiaofei.Show();
        }

        private void 查看业主余额ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guanliyuanchakanyue chakanyue = new guanliyuanchakanyue();
            chakanyue.MdiParent = this;
            chakanyue.Show();
        }

        private void 欠费提醒ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qianfei qf = new qianfei();
            qf.MdiParent = this;
            qf.Show();
        }

        private void 项目更新维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xiangmugengxinweihu xmgxwh = new xiangmugengxinweihu();
            xmgxwh.MdiParent = this;
            xmgxwh.Show();
        }

        private void 投诉管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jiqiren tsgl = new jiqiren();
            tsgl.MdiParent = this;
            tsgl.Show();
        }

       

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出系统吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            skinEngine.SkinFile = this.toolStripComboBox1.Text + ".ssk";
        }

        private void Frmguanliyuanmain_Load(object sender, EventArgs e)
        {
            skinEngine = new Sunisoft.IrisSkin.SkinEngine();
            skinEngine.SkinAllForm = true;
            skinEngine.SkinFile = "DeepCyan.ssk";
            this.toolStripStatusLabel1.Text = string.Format("时间：{0},欢迎", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            this.toolStripStatusLabel2.Text = Conmen.SuoQuGuanLiYuanDLName;
            this.toolStripStatusLabel3.Text = "使用Another小区业务管理系统";
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

        private void 切换账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guanlidl dl = new guanlidl();
            dl.Show();
            Frmguanliyuanmain main = new Frmguanliyuanmain();
            main.Close();
        }

        private void 反馈系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guanliyuanfankui fk = new guanliyuanfankui();
            fk.MdiParent = this;
            fk.Show();
        }

        private void 维修申请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            YongHuFanKuixinxi wxsq = new YongHuFanKuixinxi();
            wxsq.MdiParent = this;
            wxsq.Show();
       
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format("时间：{0},欢迎", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TongZhiYongHu tz = new TongZhiYongHu();
            tz.MdiParent = this;
            tz.Show();
        }

        private void 办理入住信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xinhuruzhu xh = new xinhuruzhu();
            xh.MdiParent = this;
            xh.Show();
        }

        private void 注册管理员账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmguanliyuanzhuce form4 = new Frmguanliyuanzhuce();
            form4.Show();
            this.Show();
            //this.Hide();
        }

        private void 注册用户账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmyonghuzhuce form4 = new Frmyonghuzhuce();
            form4.Show();

           // this.Hide();
        }

        private void 商品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shangpingguanli sp = new shangpingguanli();
            sp.Show();
        }

        

       
        
       

        

        
           
    
            

      

     
    }
}
