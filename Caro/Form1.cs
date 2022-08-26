using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    public partial class Form_Caro : Form
    {
        public Form_Caro()
        {
            InitializeComponent();          
        }
        BanCo bc;
       

        Panel banco;
        void EndGame()
        {
            
            MessageBox.Show("Kết thúc! "+"Người chơi "+((bc.Currentplayer==1?0:1)+1).ToString()+" thắng!");
        }
    
        void EndTime()
        {
            MessageBox.Show("Người chơi "+(bc.Currentplayer+1).ToString()+" hết thời gian đánh! Người chơi " + ((bc.Currentplayer == 1 ? 0 : 1) + 1).ToString() + " thắng!");
        }

        void bc_Endgame(object sender, EventArgs e)
        {
            EndGame();
            undoToolStripMenuItem.Enabled = false;
        }
  

        private void timerCoolTime_Tick(object sender, EventArgs e)
        {

            if (prcbCoolTime.Value >= prcbCoolTime.Maximum)
            {
                timerCoolTime.Stop();
                banco.Enabled = false;
                EndTime();              
            }
            else prcbCoolTime.Value += 10;
            
        }

        private void ngườiVsNgườiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load_UserInfo(true); Load_BGGame(false);
            undoToolStripMenuItem.Enabled = true;
            bc.Kieuchoi = KieuChoi.PvP;
            if(banco!=null) banco.Controls.Clear();
            Controls.Remove(banco);
            banco = bc.StartGame(txtNguoiChoi, timerCoolTime, prcbCoolTime, ptrPhoto);
            Controls.Add(banco);
            

            prcbCoolTime.Value = 0;
        }

        private void ngườiVsMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load_UserInfo(true); Load_BGGame(false);
            undoToolStripMenuItem.Enabled = true;
            bc.Kieuchoi = KieuChoi.PvE;
            if (banco != null) banco.Controls.Clear();
            Controls.Remove(banco);
            banco = bc.StartGame(txtNguoiChoi, timerCoolTime, prcbCoolTime, ptrPhoto);
            Controls.Add(banco);
            

            prcbCoolTime.Value = 0;
        }

        private void Load_UserInfo(bool flag)
        {
            lblPhoto.Visible = flag;
            ptrPhoto.Visible = flag;
            lblCoolTime.Visible = flag;
            prcbCoolTime.Visible = flag;
            lblNguoiChoi.Visible = flag;
            txtNguoiChoi.Visible = flag;     
        }

        private void Load_BGGame(bool flag)
        {
            btnPvsE.Visible = flag;
            btnPvsP.Visible = flag;
            lblLogo.Visible = flag;
            ptrbLeftLogoGame.Visible = flag;
            ptrbRightLogoGame.Visible = flag;
        }
        private void Form_Caro_Load(object sender, EventArgs e)
        {
            bc = new BanCo();
            Load_UserInfo(false); Load_BGGame(true);
            bc.Endgame += bc_Endgame;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bc.Kieuchoi == KieuChoi.PvP) bc.RedoPvP();
            else bc.RedoPvE();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bc.Kieuchoi == KieuChoi.PvP)
                bc.UndoPvP();
            else bc.UndoPvE();
        }

        private void btnPvsP_Click(object sender, EventArgs e)
        {
            ngườiVsNgườiToolStripMenuItem_Click(sender, e);
        }

        private void btnPvsE_Click(object sender, EventArgs e)
        {
            ngườiVsMáyToolStripMenuItem_Click(sender, e);
        }
    }
}
