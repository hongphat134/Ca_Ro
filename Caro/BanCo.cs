using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    enum KieuChoi { PvP,PvE};
    class BanCo
    {
        #region Attributes
        private Button[,] listchess;

        public Button[,] Listchess
        {
            get { return listchess; }
            set { listchess = value; }
        }

        private int currentplayer;

        public int Currentplayer
        {
            get { return currentplayer; }
            set { currentplayer = value; }
        }

        private KieuChoi kieuchoi;

        internal KieuChoi Kieuchoi
        {
            get { return kieuchoi; }
            set { kieuchoi = value; }
        }

        private bool BuocDiDau;

        private List<Button> KetQuaThang;


        private List<Button> undo;

        private List<REDO> redo;

        private event EventHandler endgame;
        public event EventHandler Endgame
        {
            add
            {
                endgame += value;
            }
            remove
            {
                endgame -= value;
            }
        }
        private Panel pnlBanCo;

        private TextBox txtNguoiChoi;

        private PictureBox ptrPhoto;
        private Timer timerCoolDown;
        private ProgressBar prgbCoolDown;
        #endregion
        public BanCo()
        {
            
        }

        public Panel StartGame(TextBox txtName,Timer CoolDown,ProgressBar proCoolDown,PictureBox picture, String PlayerName)
        {
            
            pnlBanCo = new Panel();
            KetQuaThang = new List<Button>();
            undo = new List<Button>();
            redo = new List<REDO>();
            BuocDiDau = false;
            currentplayer = 0;
            listchess = new Button[18, 20];
            
            pnlBanCo.AutoSize = true;
            pnlBanCo.Anchor = AnchorStyles.Left;        
            pnlBanCo.Location = new Point(13, 36);
            pnlBanCo.Enabled = true;

            CoolDown.Stop();
            timerCoolDown = CoolDown;            
            prgbCoolDown = proCoolDown;
            txtNguoiChoi = txtName;
            ptrPhoto = picture;
            ptrPhoto.BackgroundImage = Image.FromFile("image/hinhx.png");
            ptrPhoto.BackgroundImageLayout = ImageLayout.Stretch;
            txtNguoiChoi.Text = PlayerName + " 1";
            int ChieuNgang, ChieuCao = 0;

            for (int i = 0; i < 18; i++)
            {
                ChieuNgang = 0;
                for (int j = 0; j < 20; j++)
                {
                    listchess[i, j] = new Button()
                    {
                        Width = 30,
                        Height = 30,
                        Location = new System.Drawing.Point(ChieuNgang, ChieuCao),
                        Tag = i.ToString(),
                        ForeColor = Color.AntiqueWhite,
                        BackColor = Color.AntiqueWhite,
                        FlatStyle=System.Windows.Forms.FlatStyle.Popup,                        
                    };
                    //listchess[i, j].Click += BanCo_Click;
                    listchess[i, j].Click += delegate (object sender, EventArgs e) { 
                        BanCo_Click(sender, e, PlayerName); 
                    };
                    ChieuNgang += 30;
                    pnlBanCo.Controls.Add(listchess[i, j]);
                }
                ChieuCao += 30;
            }
            return pnlBanCo;
        }
        private int TimKiemViTribtnChess(Button btnChess,int sodong)
        {
            for(int i=0;i<20;i++)
            {
                if (Listchess[sodong, i] == btnChess) return i;
            }
            return 0;
        }

        public void UndoPvP()
        {
            if (undo.Count > 0)
            {
                Button Back = undo[undo.Count - 1];
                undo.RemoveAt(undo.Count - 1);
                redo.Add(new REDO(Back,currentplayer));
                Back.BackgroundImage = null;
                Back.ResetText();
                currentplayer = currentplayer == 1 ? 0 : 1;
                if (currentplayer == 1) ptrPhoto.BackgroundImage = Image.FromFile("image/hinhO.png");
                else ptrPhoto.BackgroundImage = Image.FromFile("image/hinhx.png");
                txtNguoiChoi.Text = "Người chơi " + (1 + currentplayer).ToString();
                prgbCoolDown.Value = 0;
                timerCoolDown.Start();
            }
        }
        public void UndoPvE()
        {
            if (undo.Count > 0)
            {
                //Reset nút máy
                Button BackE =undo[undo.Count - 1];
                undo.RemoveAt(undo.Count - 1);
                BackE.BackgroundImage = null;
                BackE.ResetText();

                //Reset nút người chơi
                Button BackP = undo[undo.Count - 1];
                undo.RemoveAt(undo.Count - 1);
                BackP.BackgroundImage = null;
                BackP.ResetText();

                //Lưu lại các nút c.bị undo                
                //redo.Add(new REDO(BackE, 1));
                //redo.Add(new REDO(BackP, 0));

                //Load lại time left
                prgbCoolDown.Value = 0;
                timerCoolDown.Start();
                if(undo.Count==0) BuocDiDau = false;
            }
        }

        public void RedoPvP()
        {
            if(redo.Count>0)
            {
                REDO Come = redo[redo.Count - 1];

                redo.RemoveAt(redo.Count - 1);
                
                if(Come.Curr==1)
                {
                    Come.Btn.BackgroundImage = Image.FromFile("image/hinhx.png");
                    Come.Btn.Text = "X";
                    ptrPhoto.BackgroundImage = Image.FromFile("image/hinhO.png");
                    
                }
                else
                {
                     Come.Btn.BackgroundImage = Image.FromFile("image/hinhO.png");
                     Come.Btn.Text = "O";
                     ptrPhoto.BackgroundImage = Image.FromFile("image/hinhX.png");
                }

                undo.Add(Come.Btn);
                currentplayer=Come.Curr;
                //Load lại time left
                prgbCoolDown.Value = 0;
                timerCoolDown.Start();

                txtNguoiChoi.Text = "Người chơi " + (1 + currentplayer).ToString();
            }
        }
        public void RedoPvE()
        {
            //if (redo.Count > 0)
            //{
            //    REDO ComeP = redo[redo.Count - 1];

            //    redo.RemoveAt(redo.Count - 1);

            //    ComeP.Btn.BackgroundImage = Image.FromFile("image/hinhx.png");
            //    ComeP.Btn.Text = "X";
                


            //    REDO ComeE = redo[redo.Count - 1];

            //    redo.RemoveAt(redo.Count - 1);

            //    ComeE.Btn.BackgroundImage = Image.FromFile("image/hinhO.png");
            //    ComeE.Btn.Text = "O";

            //    ptrPhoto.BackgroundImage = Image.FromFile("image/hinhx.png");


            //    undo.Add(ComeP.Btn);
            //    undo.Add(ComeE.Btn);

            //    //Load lại time left
            //    prgbCoolDown.Value = 0;
            //    timerCoolDown.Start();


            //}
        }

        private Point LayViTriHienTai(Button btnChess)
        {
            int sodong = Int16.Parse(btnChess.Tag.ToString());
            int socot = TimKiemViTribtnChess(btnChess, sodong);
            return new Point(sodong, socot);
        }
        
        void BanCo_Click(object sender, EventArgs e, String PlayerName)
        {

            #region PvP
            if (kieuchoi == KieuChoi.PvP)
            {
                if (((Button)sender).BackgroundImage == null)
                {
                    if (currentplayer == 0)
                    {
                        ((Button)sender).BackgroundImage = Image.FromFile("image/hinhx.png");
                        ((Button)sender).BackgroundImageLayout = ImageLayout.Stretch;
                        ((Button)sender).Text = "X";
                        ptrPhoto.BackgroundImage = Image.FromFile("image/hinho.png");
                        ptrPhoto.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        ((Button)sender).BackgroundImage = Image.FromFile("image/hinho.png");
                        ((Button)sender).BackgroundImageLayout = ImageLayout.Stretch;
                        ((Button)sender).Text = "O";

                        ptrPhoto.BackgroundImage = Image.FromFile("image/hinhx.png");
                        ptrPhoto.BackgroundImageLayout = ImageLayout.Stretch;
                    }

                    
                    foreach(REDO  rd in redo)
                    {
                        if(rd.Btn==(Button)sender)
                        {
                            redo.Remove(rd); break;
                        }
                    }

                    
                    undo.Add((Button)sender);
                    
                    
                    currentplayer = currentplayer == 0 ? 1 : 0;
                    txtNguoiChoi.Text = PlayerName + " " + (1 + currentplayer).ToString();
                    prgbCoolDown.Value = 0;
                    timerCoolDown.Start();
                    if (KiemTraBanCo((Button)sender))
                    {
                        foreach (Button btn in KetQuaThang)  btn.BackColor = Color.Green;                      
                        timerCoolDown.Stop();
                        EndGame();
                        pnlBanCo.Enabled = false;
                    }
                }
            }
            #endregion

            #region PvE
            else
            {
                if (((Button)sender).BackgroundImage == null)
                {
                    //Người đánh
                    ((Button)sender).BackgroundImage = Image.FromFile("image/hinhx.png");
                    ((Button)sender).BackgroundImageLayout = ImageLayout.Stretch;
                    ((Button)sender).Text = "X";
                    ptrPhoto.BackgroundImage = Image.FromFile("image/hinhx.png");
                    ptrPhoto.BackgroundImageLayout = ImageLayout.Stretch;
                    

                    //mÁY tỰ ĐỘNG ĐÁNH
                    Point ComStep;
                    if (!BuocDiDau)
                    {
                        Point LayDiemDau = LayViTriHienTai((Button)sender);
                        Random r = new Random();
                        int RdX;
                        int RdY;
                        ComStep = new Point();
                        do
                        {                           
                            RdX = r.Next(-1, 2);
                            RdY = r.Next(-1, 2);
                            ComStep.X = LayDiemDau.X + RdX;
                            ComStep.Y = LayDiemDau.Y + RdY;                            
                        } while ((ComStep.X < 0 || ComStep.Y < 0)
                                || (ComStep.X >= 18 || ComStep.Y >= 20)
                                || (RdX == 0 && RdY == 0) );
                  
                        BuocDiDau = true;
                    }
                    else ComStep = TimKiemNuocDi();
                    
                    listchess[ComStep.X, ComStep.Y].BackgroundImage = Image.FromFile("image/hinhO.png");
                    listchess[ComStep.X, ComStep.Y].BackgroundImageLayout = ImageLayout.Stretch;
                    listchess[ComStep.X, ComStep.Y].Text = "O";

                    //for (int i = 0; i < redo.Count;i++ )
                    //{
                    //    if (redo[i].Btn == (Button)sender)
                    //    {
                    //        redo.Remove(redo[i]);
                    //        redo.Remove(redo[i - 1]);
                    //        break;
                    //    }
                    //}

                    undo.Add((Button)sender);
                    undo.Add(listchess[ComStep.X, ComStep.Y]);
                    txtNguoiChoi.Text = "Người chơi 1";
                    prgbCoolDown.Value = 0;
                    timerCoolDown.Start();
                   
                    if(KiemTraBanCo(listchess[ComStep.X, ComStep.Y]))
                    {
                        currentplayer = 0;
                        timerCoolDown.Stop();
                        foreach (Button btn in KetQuaThang) btn.BackColor = Color.Green;
                        EndGame();
                        pnlBanCo.Enabled = false;
                    }
                    if (KiemTraBanCo((Button)sender))
                    {
                        currentplayer = 1;
                        timerCoolDown.Stop();
                        foreach (Button btn in KetQuaThang) btn.BackColor = Color.Green;
                        EndGame();
                        pnlBanCo.Enabled = false;
                    }
                }
            }
            #endregion

        }


        public void EndGame()
        {
            if (endgame != null)
                endgame(this, new EventArgs());
        }

        #region Kiểm Tra Thắng
        private bool KiemTraBanCo(Button btnChess)
        {
            return KiemTraHangNgang(btnChess) || KiemTraHangDoc(btnChess) || KiemTraHangCheoChinh(btnChess) || KiemTraHangCheoPhu(btnChess);
        }
        private bool KiemTraHangNgang(Button btnChess)
        {
            KetQuaThang.Clear();
            int DemTrai = 0, DemPhai = 0;
            Point VT = LayViTriHienTai(btnChess);
            //Đếm tổng ô đánh bên trái
            for (int i = VT.Y; i >= 0; i--)
            {

                if (Listchess[VT.X, i].Text == btnChess.Text)
                {
                    KetQuaThang.Add(Listchess[VT.X, i]);
                    DemTrai++;
                }
                else break;
            }
            //Đếm tổng ô đánh bên phải
            for (int i = VT.Y + 1; i < 20; i++)
            {

                if (Listchess[VT.X, i].Text == btnChess.Text)
                {
                    KetQuaThang.Add(Listchess[VT.X, i]);
                    DemPhai++;
                }
                else break;
            }
            return (DemTrai + DemPhai) >= 5;
        }
        private bool KiemTraHangDoc(Button btnChess)
        {
            KetQuaThang.Clear();
            int DemTren = 0, DemDuoi = 0;
            Point VT = LayViTriHienTai(btnChess);
            //Đếm tổng ô đánh bên trên
            for (int i = VT.X; i >= 0; i--)
            {

                if (Listchess[i, VT.Y].Text == btnChess.Text)
                {
                    KetQuaThang.Add(Listchess[i, VT.Y]);
                    DemTren++;
                }
                else break;
            }
            //Đếm tổng ô đánh bên dưới
            for (int i = VT.X + 1; i < 18; i++)
            {

                if (Listchess[i, VT.Y].Text == btnChess.Text)
                {
                    KetQuaThang.Add(Listchess[i, VT.Y]);
                    DemDuoi++;
                }
                else break;
            }

            return (DemTren + DemDuoi) >= 5;
        }
        private bool KiemTraHangCheoChinh(Button btnChess)
        {
            KetQuaThang.Clear();
            int DemPhaiTren = 0, DemTraiDuoi = 0;
            Point VT = LayViTriHienTai(btnChess);

            //Đếm tổng ô đánh bên trái dưới

            for (int i = 0; i <= VT.Y; i++)
            {
                if (VT.X + i > 17 || VT.Y - i < 0) break;
                if (Listchess[VT.X + i, VT.Y - i].Text == btnChess.Text)
                {
                    KetQuaThang.Add(Listchess[VT.X + i, VT.Y - i]);
                    DemTraiDuoi++;
                }
                else break;
            }
            //Đếm tổng ô đánh bên phải trên

            for (int i = 1; i < 20; i++)
            {
                if (VT.X - i < 0 || VT.Y + i >= 20) break;
                if (Listchess[VT.X - i, VT.Y + i].Text == btnChess.Text)
                {
                    KetQuaThang.Add(Listchess[VT.X - i, VT.Y + i]);
                    DemPhaiTren++;
                }
                else break;
            }
            return (DemPhaiTren + DemTraiDuoi) >= 5;
        }
        private bool KiemTraHangCheoPhu(Button btnChess)
        {
            KetQuaThang.Clear();
            int DemTraiTren = 0, DemPhaiDuoi = 0;
            Point VT = LayViTriHienTai(btnChess);

            //Đếm tổng ô đánh bên trái trên

            for (int i = 0; i <= VT.Y; i++)
            {
                if (VT.X - i < 0 || VT.Y - i < 0) break;
                if (Listchess[VT.X - i, VT.Y - i].Text == btnChess.Text)
                {
                    KetQuaThang.Add(Listchess[VT.X - i, VT.Y - i]);
                    DemTraiTren++;
                }
                else break;
            }
            //Đếm tổng ô đánh bên phải dưới

            for (int i = 1; i < 20; i++)
            {
                if (VT.X + i >= 18 || VT.Y + i >= 20) break;
                if (Listchess[VT.X + i, VT.Y + i].Text == btnChess.Text)
                {
                    KetQuaThang.Add(Listchess[VT.X + i, VT.Y + i]);
                    DemPhaiDuoi++;
                }
                else break;
            }


            return (DemTraiTren + DemPhaiDuoi) >= 5;
        }
        #endregion

        #region AI
        private long[] MangDiemTanCong = new long[7] {0,3,24,192,1536,1288,98304 };
        private long[] MangDiemPhongThu = new long[7] { 0,1,9,81,729,6561,59049 };

        public Point TimKiemNuocDi()
        {
            long DiemMax = 0;
            Point ChessResult = new Point();
                       
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (listchess[i, j].Text == "")
                    {
                        long DiemTanCong = DiemTanCong_DuyetDoc(i, j) + DiemTanCong_DuyetNgang(i, j) + DiemTanCong_DuyetCheoChinh(i, j) + DiemTanCong_DuyetCheoPhu(i, j);
                        long DiemPhongNgu = DiemPhongNgu_DuyetDoc(i, j) + DiemPhongNgu_DuyetNgang(i, j) + DiemPhongNgu_DuyetCheoChinh(i, j) + DiemPhongNgu_DuyetCheoPhu(i, j);
                        long DiemTam = DiemTanCong > DiemPhongNgu ? DiemTanCong : DiemPhongNgu;
                        if (DiemMax < DiemTam)
                        {
                            DiemMax = DiemTam;
                            ChessResult.X = i;
                            ChessResult.Y = j;
                        }
                    }
                }
            }           

            return ChessResult;
        }
        #endregion

        #region TanCong
        private long DiemTanCong_DuyetDoc(int sodong,int socot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0, SoQuanDich = 0;
            for (int i = 1; i < 6 && sodong + i < 18; i++)
            {
                if (listchess[sodong + i, socot].Text == "X") SoQuanTa++;
                else if (listchess[sodong + i, socot].Text == "O")
                {
                    SoQuanDich++;
                    break;
                }
                else break;
            }

            for (int i = 1; i < 6 && sodong - i >= 0; i++)
            {
                if (listchess[sodong - i, socot].Text == "X") SoQuanTa++;
                else if (listchess[sodong - i, socot].Text == "O")
                {
                    SoQuanDich++;
                    break;
                }
                else break;
            }
            if (SoQuanDich == 2) return 0;
            DiemTong -= MangDiemPhongThu[SoQuanDich + 1];
            DiemTong += MangDiemTanCong[SoQuanTa];
            return DiemTong;
        }
        private long DiemTanCong_DuyetNgang(int sodong, int socot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0, SoQuanDich = 0;
            for (int i = 1; i < 6 && socot + i < 20; i++)
            {
                if (listchess[sodong, socot+i].Text == "X") SoQuanTa++;
                else if (listchess[sodong, socot+i].Text == "O")
                {
                    SoQuanDich++;
                    break;
                }
                else break;
            }

            for (int i = 1; i < 6 && socot - i >= 0; i++)
            {
                if (listchess[sodong, socot-i].Text == "X") SoQuanTa++;
                else if (listchess[sodong , socot-i].Text == "O")
                {
                    SoQuanDich++;
                    break;
                }
                else break;
            }
            if (SoQuanDich == 2) return 0;
            DiemTong -= MangDiemPhongThu[SoQuanDich + 1];
            DiemTong += MangDiemTanCong[SoQuanTa];
            return DiemTong;
        }
        private long DiemTanCong_DuyetCheoChinh(int sodong, int socot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0, SoQuanDich = 0;
            for (int i = 1; i < 6 && socot + i < 20&&sodong-i>=0; i++)
            {
                if (listchess[sodong-i, socot + i].Text == "X") SoQuanTa++;
                else if (listchess[sodong-i, socot + i].Text == "O")
                {
                    SoQuanDich++;
                    break;
                }
                else break;
            }

            for (int i = 1; i < 6 && socot - i >= 0&&sodong+i<18; i++)
            {
                if (listchess[sodong+i, socot - i].Text == "X") SoQuanTa++;
                else if (listchess[sodong+i, socot - i].Text == "O")
                {
                    SoQuanDich++;
                    break;
                }
                else break;
            }
            if (SoQuanDich == 2) return 0;
            DiemTong -= MangDiemPhongThu[SoQuanDich + 1];
            DiemTong += MangDiemTanCong[SoQuanTa];
            return DiemTong;
        }
        private long DiemTanCong_DuyetCheoPhu(int sodong, int socot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0, SoQuanDich = 0;
            for (int i = 1; i < 6 && socot + i < 20 && sodong + i <18; i++)
            {
                if (listchess[sodong + i, socot + i].Text == "X") SoQuanTa++;
                else if (listchess[sodong + i, socot + i].Text == "O")
                {
                    SoQuanDich++;
                    break;
                }
                else break;
            }

            for (int i = 1; i < 6 && socot - i >= 0 && sodong - i >= 0; i++)
            {
                if (listchess[sodong - i, socot - i].Text == "X") SoQuanTa++;
                else if (listchess[sodong - i, socot - i].Text == "O")
                {
                    SoQuanDich++;
                    break;
                }
                else break;
            }
            if (SoQuanDich == 2) return 0;
            DiemTong -= MangDiemPhongThu[SoQuanDich + 1];
            DiemTong += MangDiemTanCong[SoQuanTa];
            return DiemTong;
        }
        #endregion

        #region PhongNgu
        private long DiemPhongNgu_DuyetDoc(int sodong, int socot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0, SoQuanDich = 0;
            for (int i = 1; i < 6 && sodong + i < 18; i++)
            {
                if (listchess[sodong + i, socot].Text == "X")
                {
                    SoQuanTa++;
                    break;
                }
                else if (listchess[sodong + i, socot].Text == "O")     SoQuanDich++;
                else break;
            }

            for (int i = 1; i < 6 && sodong - i >= 0; i++)
            {
                if (listchess[sodong - i, socot].Text == "X") { SoQuanTa++; break; }
                else if (listchess[sodong - i, socot].Text == "O") SoQuanDich++;
                else break;
            }
            if (SoQuanTa == 2) return 0;
            DiemTong += MangDiemPhongThu[SoQuanDich];
            return DiemTong;
        }
        private long DiemPhongNgu_DuyetNgang(int sodong, int socot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0, SoQuanDich = 0;
            for (int i = 1; i < 6 && socot + i < 20; i++)
            {
                if (listchess[sodong, socot + i].Text == "X")
                {
                    SoQuanTa++; break;
                }
                else if (listchess[sodong, socot + i].Text == "O") SoQuanDich++;
                else break;
            }

            for (int i = 1; i < 6 && socot - i >= 0; i++)
            {
                if (listchess[sodong, socot - i].Text == "X") { SoQuanTa++; break; }
                else if (listchess[sodong, socot - i].Text == "O") SoQuanDich++;
                else break;
            }
            if (SoQuanTa == 2) return 0;
            DiemTong += MangDiemPhongThu[SoQuanDich];

            return DiemTong;
        }
        private long DiemPhongNgu_DuyetCheoChinh(int sodong, int socot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0, SoQuanDich = 0;
            for (int i = 1; i < 6 && socot + i < 20 && sodong - i >= 0; i++)
            {
                if (listchess[sodong - i, socot + i].Text == "X")
                {
                    SoQuanTa++; break;
                }
                else if (listchess[sodong - i, socot + i].Text == "O") SoQuanDich++;
                else break;
            }

            for (int i = 1; i < 6 && socot - i >= 0 && sodong + i < 18; i++)
            {
                if (listchess[sodong + i, socot - i].Text == "X") { SoQuanTa++; break; }
                else if (listchess[sodong + i, socot - i].Text == "O") SoQuanDich++;
                else break;
            }
            if (SoQuanTa == 2) return 0;
            DiemTong += MangDiemPhongThu[SoQuanDich];
            return DiemTong;
        }
        private long DiemPhongNgu_DuyetCheoPhu(int sodong, int socot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0, SoQuanDich = 0;
            for (int i = 1; i < 6 && socot + i < 20 && sodong + i < 18; i++)
            {
                if (listchess[sodong + i, socot + i].Text == "X") { SoQuanTa++; break; }
                else if (listchess[sodong + i, socot + i].Text == "O") SoQuanDich++;
                else break;
            }

            for (int i = 1; i < 6 && socot - i >= 0 && sodong - i >= 0; i++)
            {
                if (listchess[sodong - i, socot - i].Text == "X") { SoQuanTa++; break; }
                else if (listchess[sodong - i, socot - i].Text == "O") SoQuanDich++;
                else break;
            }
            if (SoQuanTa == 2) return 0;
            DiemTong += MangDiemPhongThu[SoQuanDich];
            return DiemTong;
        }
        #endregion
    }
}
