﻿using System;
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
            undoToolStripMenuItem.Enabled = true;
            bc.Kieuchoi = KieuChoi.PvE;
            if (banco != null) banco.Controls.Clear();
            Controls.Remove(banco);
            banco = bc.StartGame(txtNguoiChoi, timerCoolTime, prcbCoolTime, ptrPhoto);
            Controls.Add(banco);
            

            prcbCoolTime.Value = 0;
        }

        private void Form_Caro_Load(object sender, EventArgs e)
        {
            bc = new BanCo();
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
    }
}
