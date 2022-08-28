using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Caro
{
    public partial class Form_Caro : Form
    {
        #region Attributes
        BanCo bc;
        Panel banco;
      
        SoundPlayer Sound;
        Boolean FightingStatus = false;
        Boolean MusicStatus = true;
        
        String PlayerName = "Player";       
        String BG_SOUND_LINKED = Environment.CurrentDirectory + @"\music\bg_sound.wav";
        String FIGHTING_SOUND_LINKED = Environment.CurrentDirectory + @"\music\fighting_sound.wav";

        int ScorePlayer1 = 0;
        int ScorePlayer2 = 0;
        #endregion

        public Form_Caro()
        { 
            InitializeComponent();          
            this.Sound = new SoundPlayer(BG_SOUND_LINKED);
            this.Sound.PlayLooping();
            cbbLanguages.Text = "English";           
        }

        void SetGoal()
        {
            if (bc.Currentplayer == 1)
            {
                ScorePlayer1++;
                lblScorePlr1.Text = ScorePlayer1.ToString();
            }
            else
            {
                ScorePlayer2++;
                lblScorePlr2.Text = ScorePlayer2.ToString();
            }
            btnReplay.Visible = true;
        }

        void SetMessageForEndGame()
        {
            String Language = cbbLanguages.Text;
            if (Language == "French") MessageBox.Show("Fin! " + "Tour " + ((bc.Currentplayer == 1 ? 0 : 1) + 1).ToString() + " GAGNER!");
           
            else if (Language == "Tiếng Việt")MessageBox.Show("Kết thúc! " + "Người chơi " + ((bc.Currentplayer == 1 ? 0 : 1) + 1).ToString() + " THẮNG!");
            
            else if (Language == "China") MessageBox.Show("结尾! " + "转动 " + ((bc.Currentplayer == 1 ? 0 : 1) + 1).ToString() + " 赢!");

            else MessageBox.Show("Finish! " + "Player " + ((bc.Currentplayer == 1 ? 0 : 1) + 1).ToString() + " WIN!");           
        }

        void SetMessageForEndTime()
        {
            String Language = cbbLanguages.Text;
            if (Language == "French") MessageBox.Show("le temps du joueur "+ ((bc.Currentplayer == 1 ? 0 : 1) + 1).ToString() + " est écoulé! Joueur " + (bc.Currentplayer  + 1).ToString() + " GAGNER!");

            else if (Language == "Tiếng Việt") MessageBox.Show("Người chơi " + ((bc.Currentplayer == 1 ? 0 : 1) + 1).ToString() + " hết thời gian đánh! Người chơi " + (bc.Currentplayer + 1).ToString() + " thắng!");

            else if (Language == "China") MessageBox.Show("玩家时 " + ((bc.Currentplayer == 1 ? 0 : 1) + 1).ToString() + " 间用完! 转动 " + (bc.Currentplayer + 1).ToString() + " 赢!");

            else MessageBox.Show("Player " + ((bc.Currentplayer == 1 ? 0 : 1) + 1).ToString() + " was timeout! Player " + (bc.Currentplayer + 1).ToString() + " WIN!");
        }
        
        void EndGame()
        {
            SetMessageForEndGame();
            SetGoal();
        }
    
        void EndTime()
        {
            SetMessageForEndTime();
            SetGoal();
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
            btnReplay.Visible = false;
            Load_UserInfo(true); Load_BGGame(false);
            undoToolStripMenuItem.Enabled = true;
            bc.Kieuchoi = KieuChoi.PvP;
            if(banco!=null) banco.Controls.Clear();
            Controls.Remove(banco);
            banco = bc.StartGame(txtNguoiChoi, timerCoolTime, prcbCoolTime, ptrPhoto, PlayerName);
            Controls.Add(banco);

            
            prcbCoolTime.Value = 0;
        }

        private void ngườiVsMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnReplay.Visible = false;
            Load_UserInfo(true); Load_BGGame(false);
            undoToolStripMenuItem.Enabled = true;
            bc.Kieuchoi = KieuChoi.PvE;
            if (banco != null) banco.Controls.Clear();
            Controls.Remove(banco);
            banco = bc.StartGame(txtNguoiChoi, timerCoolTime, prcbCoolTime, ptrPhoto, PlayerName);
            Controls.Add(banco);

            
            prcbCoolTime.Value = 0;
        }
       
        private void Load_UserInfo(bool flag)
        {
            FightingStatus = flag;
            if (MusicStatus == true)
            {
                if (FightingStatus == true)
                {
                    Sound.Stop();
                    Sound.SoundLocation = FIGHTING_SOUND_LINKED;
                    Sound.PlayLooping();
                }
                else
                {
                    Sound.Stop();
                    Sound.SoundLocation = BG_SOUND_LINKED;
                    Sound.PlayLooping();
                }
            }
            
            lblPhoto.Visible = flag;
            ptrPhoto.Visible = flag;
            lblCoolTime.Visible = flag;
            prcbCoolTime.Visible = flag;
            lblNguoiChoi.Visible = flag;
            txtNguoiChoi.Visible = flag;
            btnMenu.Visible = flag;

            lblWbPlr1.Visible = flag;
            lblWbPlr2.Visible = flag;
            lblWinBoard.Visible = flag;
            lblScorePlr1.Visible = flag;
            lblScorePlr2.Visible = flag;
            btnResetWb.Visible = flag;            
        }

        private void Load_BGGame(bool flag)
        {
            cbbLanguages.Visible = flag;
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Load_BGGame(true); Load_UserInfo(false);
            btnReplay.Visible = false;
            timerCoolTime.Stop();
            banco.Controls.Clear();
            Controls.Remove(banco);
        }
      
        private void btnMusic_Click(object sender, EventArgs e)
        {
            if(MusicStatus == true)
            {
                Sound.Stop();
                btnMusic.BackgroundImage = Caro.Properties.Resources.non_music_icon;
                MusicStatus = false;
            }
            else
            {
                if (FightingStatus == true) Sound.SoundLocation = FIGHTING_SOUND_LINKED;
                else Sound.SoundLocation = BG_SOUND_LINKED;
                Sound.PlayLooping();
                btnMusic.BackgroundImage = Caro.Properties.Resources.music_icon;
                MusicStatus = true;
            }
        }

        private void cbbLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Language = cbbLanguages.Text;
            if(Language == "French")
            {
                btnMenu.Text = "RETOUR À L'INTERFACE PRINCIPALE";
                btnPvsP.Text = "PERSONNES VS PERSONNES";
                btnPvsE.Text = "PERSONNES VS L'ORDINATEUR";
                lblPhoto.Text = "AVATAR :";
                lblCoolTime.Text = "RÉCRÉATION:";
                lblNguoiChoi.Text = "TOUR :";
                PlayerName = "Joueur";
                lblWinBoard.Text = "objectif";
                btnReplay.Text = "Rejouer";
                btnRules.Text = "Régner";
                lblRulesContent.Text = "Marquez 5 cellules consécutives par ligne, colonne ou diagonale comme WIN";
            }
            else if(Language == "Tiếng Việt")
            {
                btnMenu.Text = "TRỞ VỀ GIAO DIỆN CHÍNH";
                btnPvsP.Text = "NGƯỜI VS NGƯỜI";
                btnPvsE.Text = "NGƯỜI VS MÁY";
                lblPhoto.Text = "ẢNH ĐẠI DIỆN:";
                lblCoolTime.Text = "GIỜ CHƠI:";
                lblNguoiChoi.Text = "LƯỢT CHƠI:";
                PlayerName = "Người chơi";
                lblWinBoard.Text = "Bản thắng";
                btnReplay.Text = "Chơi lại";
                btnRules.Text = "Luật chơi";
                lblRulesContent.Text = "Đánh dấu 5 ô liên tiếp theo hàng, cột hoặc đường chéo là THẮNG";
            }
            else if(Language == "China")
            {
                btnMenu.Text = "返回主界面";
                btnPvsP.Text = "人们 VS 人们";
                btnPvsE.Text = "人们 VS 计算机";
                lblPhoto.Text = "阿凡达 : ";
                lblCoolTime.Text = "游戏时间:";
                lblNguoiChoi.Text = "转动 :";
                PlayerName = "播放器";
                lblWinBoard.Text = "目标";
                btnReplay.Text = "再玩一遍";
                btnRules.Text = "规则";
                lblRulesContent.Text = "将一行、一列或对角线中的五个连续单元格标记为获胜";
            }
            else
            {
                btnMenu.Text = "RETURN TO MENU";
                btnPvsP.Text = "PEOPLE VS PEOLE";
                btnPvsE.Text = "PEOPLE VS AI";
                lblPhoto.Text = "LOGO :";
                lblCoolTime.Text = "TIME :";
                lblNguoiChoi.Text = "TURN :";
                PlayerName = "Player";
                lblWinBoard.Text = "Goal";
                btnReplay.Text = "Play again";
                btnRules.Text = "Rules";
                lblRulesContent.Text = "Mark FIVE consecutive cells by row, column or diagonal as WIN";
            }
            
            lblWbPlr1.Text = PlayerName + " 1";
            lblWbPlr2.Text = PlayerName + " 2";
        }

        private void ptrbLogo_MouseHover(object sender, EventArgs e)
        {
            ptrbLogo.Size = new Size(200, 150);
            ptrbLogo.Location = new Point(660, 90);
        }

        private void ptrbLogo_MouseLeave(object sender, EventArgs e)
        {
            ptrbLogo.Size = new Size(158, 121);
            ptrbLogo.Location = new Point(689, 106);
        }

        private void btnResetWb_Click(object sender, EventArgs e)
        {
            ScorePlayer1 = 0; ScorePlayer2 = 0;
            lblScorePlr1.Text = ScorePlayer1.ToString(); lblScorePlr2.Text = ScorePlayer2.ToString();
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            btnReplay.Visible = false;
            if (bc.Kieuchoi == KieuChoi.PvP) btnPvsP_Click(sender, e);
            else btnPvsE_Click(sender, e);
            
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            lblRulesContent.Visible = lblRulesContent.Visible == false ? true : false;
        }

        private void lblRulesContent_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, lblRulesContent.DisplayRectangle, Color.DarkRed, ButtonBorderStyle.Solid);
        }
    }
}
