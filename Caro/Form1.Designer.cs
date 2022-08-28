namespace Caro
{
    partial class Form_Caro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Caro));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chếĐộToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiVsNgườiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiVsMáyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNguoiChoi = new System.Windows.Forms.TextBox();
            this.prcbCoolTime = new System.Windows.Forms.ProgressBar();
            this.timerCoolTime = new System.Windows.Forms.Timer(this.components);
            this.lblCoolTime = new System.Windows.Forms.Label();
            this.lblNguoiChoi = new System.Windows.Forms.Label();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.ptrbLogo = new System.Windows.Forms.PictureBox();
            this.ptrbLeftLogoGame = new System.Windows.Forms.PictureBox();
            this.btnPvsE = new System.Windows.Forms.Button();
            this.btnPvsP = new System.Windows.Forms.Button();
            this.ptrPhoto = new System.Windows.Forms.PictureBox();
            this.ptrbRightLogoGame = new System.Windows.Forms.PictureBox();
            this.cbbLanguages = new System.Windows.Forms.ComboBox();
            this.lblWbPlr1 = new System.Windows.Forms.Label();
            this.lblWbPlr2 = new System.Windows.Forms.Label();
            this.lblWinBoard = new System.Windows.Forms.Label();
            this.lblScorePlr1 = new System.Windows.Forms.Label();
            this.lblScorePlr2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnResetWb = new System.Windows.Forms.Button();
            this.btnReplay = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.lblRulesContent = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbLeftLogoGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbRightLogoGame)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chếĐộToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.newGameToolStripMenuItem.Text = "Menu";
            // 
            // chếĐộToolStripMenuItem
            // 
            this.chếĐộToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngườiVsNgườiToolStripMenuItem,
            this.ngườiVsMáyToolStripMenuItem});
            this.chếĐộToolStripMenuItem.Name = "chếĐộToolStripMenuItem";
            this.chếĐộToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.chếĐộToolStripMenuItem.Text = "Chế Độ";
            // 
            // ngườiVsNgườiToolStripMenuItem
            // 
            this.ngườiVsNgườiToolStripMenuItem.Name = "ngườiVsNgườiToolStripMenuItem";
            this.ngườiVsNgườiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.ngườiVsNgườiToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.ngườiVsNgườiToolStripMenuItem.Text = "Người vs Người";
            this.ngườiVsNgườiToolStripMenuItem.Click += new System.EventHandler(this.ngườiVsNgườiToolStripMenuItem_Click);
            // 
            // ngườiVsMáyToolStripMenuItem
            // 
            this.ngườiVsMáyToolStripMenuItem.Name = "ngườiVsMáyToolStripMenuItem";
            this.ngườiVsMáyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ngườiVsMáyToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.ngườiVsMáyToolStripMenuItem.Text = "Người vs Máy";
            this.ngườiVsMáyToolStripMenuItem.Click += new System.EventHandler(this.ngườiVsMáyToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // txtNguoiChoi
            // 
            this.txtNguoiChoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtNguoiChoi.Location = new System.Drawing.Point(798, 425);
            this.txtNguoiChoi.Name = "txtNguoiChoi";
            this.txtNguoiChoi.ReadOnly = true;
            this.txtNguoiChoi.Size = new System.Drawing.Size(100, 20);
            this.txtNguoiChoi.TabIndex = 2;
            // 
            // prcbCoolTime
            // 
            this.prcbCoolTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.prcbCoolTime.BackColor = System.Drawing.Color.Purple;
            this.prcbCoolTime.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.prcbCoolTime.Location = new System.Drawing.Point(798, 384);
            this.prcbCoolTime.Name = "prcbCoolTime";
            this.prcbCoolTime.Size = new System.Drawing.Size(100, 23);
            this.prcbCoolTime.TabIndex = 3;
            this.prcbCoolTime.Value = 50;
            // 
            // timerCoolTime
            // 
            this.timerCoolTime.Interval = 1000;
            this.timerCoolTime.Tick += new System.EventHandler(this.timerCoolTime_Tick);
            // 
            // lblCoolTime
            // 
            this.lblCoolTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCoolTime.AutoSize = true;
            this.lblCoolTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCoolTime.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoolTime.ForeColor = System.Drawing.Color.Maroon;
            this.lblCoolTime.Location = new System.Drawing.Point(659, 387);
            this.lblCoolTime.Name = "lblCoolTime";
            this.lblCoolTime.Size = new System.Drawing.Size(63, 20);
            this.lblCoolTime.TabIndex = 4;
            this.lblCoolTime.Text = "Time :";
            // 
            // lblNguoiChoi
            // 
            this.lblNguoiChoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNguoiChoi.AutoSize = true;
            this.lblNguoiChoi.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiChoi.ForeColor = System.Drawing.Color.Maroon;
            this.lblNguoiChoi.Location = new System.Drawing.Point(656, 422);
            this.lblNguoiChoi.Name = "lblNguoiChoi";
            this.lblNguoiChoi.Size = new System.Drawing.Size(66, 20);
            this.lblNguoiChoi.TabIndex = 5;
            this.lblNguoiChoi.Text = "Turn :";
            // 
            // lblPhoto
            // 
            this.lblPhoto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoto.ForeColor = System.Drawing.Color.Maroon;
            this.lblPhoto.Location = new System.Drawing.Point(657, 325);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(66, 20);
            this.lblPhoto.TabIndex = 7;
            this.lblPhoto.Text = "Logo :";
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Red;
            this.lblLogo.Location = new System.Drawing.Point(262, 77);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(401, 58);
            this.lblLogo.TabIndex = 8;
            this.lblLogo.Text = "GAME CARO";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMenu.BackColor = System.Drawing.Color.Snow;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenu.FlatAppearance.BorderSize = 3;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenu.Location = new System.Drawing.Point(740, 219);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(158, 68);
            this.btnMenu.TabIndex = 16;
            this.btnMenu.Text = "RETURN TO MENU";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Visible = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMusic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMusic.BackgroundImage = global::Caro.Properties.Resources.music_icon;
            this.btnMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMusic.FlatAppearance.BorderSize = 3;
            this.btnMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusic.Location = new System.Drawing.Point(855, 41);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(49, 37);
            this.btnMusic.TabIndex = 18;
            this.btnMusic.UseVisualStyleBackColor = false;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // ptrbLogo
            // 
            this.ptrbLogo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ptrbLogo.Image = global::Caro.Properties.Resources.my_logo;
            this.ptrbLogo.Location = new System.Drawing.Point(689, 106);
            this.ptrbLogo.Name = "ptrbLogo";
            this.ptrbLogo.Size = new System.Drawing.Size(158, 121);
            this.ptrbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbLogo.TabIndex = 15;
            this.ptrbLogo.TabStop = false;
            this.ptrbLogo.MouseLeave += new System.EventHandler(this.ptrbLogo_MouseLeave);
            this.ptrbLogo.MouseHover += new System.EventHandler(this.ptrbLogo_MouseHover);
            // 
            // ptrbLeftLogoGame
            // 
            this.ptrbLeftLogoGame.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ptrbLeftLogoGame.Image = global::Caro.Properties.Resources.logo_game;
            this.ptrbLeftLogoGame.Location = new System.Drawing.Point(47, 260);
            this.ptrbLeftLogoGame.Name = "ptrbLeftLogoGame";
            this.ptrbLeftLogoGame.Size = new System.Drawing.Size(176, 168);
            this.ptrbLeftLogoGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbLeftLogoGame.TabIndex = 14;
            this.ptrbLeftLogoGame.TabStop = false;
            // 
            // btnPvsE
            // 
            this.btnPvsE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPvsE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPvsE.BackgroundImage = global::Caro.Properties.Resources.btn_color;
            this.btnPvsE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPvsE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPvsE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPvsE.FlatAppearance.BorderSize = 3;
            this.btnPvsE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPvsE.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPvsE.ForeColor = System.Drawing.Color.Maroon;
            this.btnPvsE.Location = new System.Drawing.Point(342, 366);
            this.btnPvsE.Name = "btnPvsE";
            this.btnPvsE.Size = new System.Drawing.Size(241, 118);
            this.btnPvsE.TabIndex = 10;
            this.btnPvsE.Text = "PEOPLE VS AI";
            this.btnPvsE.UseVisualStyleBackColor = false;
            this.btnPvsE.Click += new System.EventHandler(this.btnPvsE_Click);
            // 
            // btnPvsP
            // 
            this.btnPvsP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPvsP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPvsP.BackgroundImage = global::Caro.Properties.Resources.btn_color;
            this.btnPvsP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPvsP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPvsP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPvsP.FlatAppearance.BorderSize = 3;
            this.btnPvsP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPvsP.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPvsP.ForeColor = System.Drawing.Color.Maroon;
            this.btnPvsP.Location = new System.Drawing.Point(342, 227);
            this.btnPvsP.Name = "btnPvsP";
            this.btnPvsP.Size = new System.Drawing.Size(241, 118);
            this.btnPvsP.TabIndex = 9;
            this.btnPvsP.Text = "PEOPLE VS PEOPLE";
            this.btnPvsP.UseVisualStyleBackColor = false;
            this.btnPvsP.Click += new System.EventHandler(this.btnPvsP_Click);
            // 
            // ptrPhoto
            // 
            this.ptrPhoto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ptrPhoto.Location = new System.Drawing.Point(795, 306);
            this.ptrPhoto.Name = "ptrPhoto";
            this.ptrPhoto.Size = new System.Drawing.Size(80, 57);
            this.ptrPhoto.TabIndex = 6;
            this.ptrPhoto.TabStop = false;
            // 
            // ptrbRightLogoGame
            // 
            this.ptrbRightLogoGame.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ptrbRightLogoGame.Image = ((System.Drawing.Image)(resources.GetObject("ptrbRightLogoGame.Image")));
            this.ptrbRightLogoGame.Location = new System.Drawing.Point(689, 260);
            this.ptrbRightLogoGame.Name = "ptrbRightLogoGame";
            this.ptrbRightLogoGame.Size = new System.Drawing.Size(176, 168);
            this.ptrbRightLogoGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbRightLogoGame.TabIndex = 12;
            this.ptrbRightLogoGame.TabStop = false;
            // 
            // cbbLanguages
            // 
            this.cbbLanguages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbLanguages.DisplayMember = "English";
            this.cbbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLanguages.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLanguages.FormattingEnabled = true;
            this.cbbLanguages.Items.AddRange(new object[] {
            "English",
            "Tiếng Việt",
            "China",
            "French"});
            this.cbbLanguages.Location = new System.Drawing.Point(47, 50);
            this.cbbLanguages.Name = "cbbLanguages";
            this.cbbLanguages.Size = new System.Drawing.Size(121, 28);
            this.cbbLanguages.TabIndex = 19;
            this.cbbLanguages.SelectedIndexChanged += new System.EventHandler(this.cbbLanguages_SelectedIndexChanged);
            // 
            // lblWbPlr1
            // 
            this.lblWbPlr1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblWbPlr1.AutoSize = true;
            this.lblWbPlr1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWbPlr1.ForeColor = System.Drawing.Color.Maroon;
            this.lblWbPlr1.Location = new System.Drawing.Point(668, 509);
            this.lblWbPlr1.Name = "lblWbPlr1";
            this.lblWbPlr1.Size = new System.Drawing.Size(88, 17);
            this.lblWbPlr1.TabIndex = 20;
            this.lblWbPlr1.Text = "Người chơi 1";
            this.lblWbPlr1.Visible = false;
            // 
            // lblWbPlr2
            // 
            this.lblWbPlr2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblWbPlr2.AutoSize = true;
            this.lblWbPlr2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWbPlr2.ForeColor = System.Drawing.Color.Maroon;
            this.lblWbPlr2.Location = new System.Drawing.Point(779, 510);
            this.lblWbPlr2.Name = "lblWbPlr2";
            this.lblWbPlr2.Size = new System.Drawing.Size(89, 17);
            this.lblWbPlr2.TabIndex = 21;
            this.lblWbPlr2.Text = "Người chơi 2";
            this.lblWbPlr2.Visible = false;
            // 
            // lblWinBoard
            // 
            this.lblWinBoard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblWinBoard.AutoSize = true;
            this.lblWinBoard.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinBoard.ForeColor = System.Drawing.Color.Maroon;
            this.lblWinBoard.Location = new System.Drawing.Point(712, 472);
            this.lblWinBoard.Name = "lblWinBoard";
            this.lblWinBoard.Size = new System.Drawing.Size(110, 23);
            this.lblWinBoard.TabIndex = 22;
            this.lblWinBoard.Text = "Bàn thắng";
            this.lblWinBoard.Visible = false;
            // 
            // lblScorePlr1
            // 
            this.lblScorePlr1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblScorePlr1.AutoSize = true;
            this.lblScorePlr1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePlr1.ForeColor = System.Drawing.Color.Yellow;
            this.lblScorePlr1.Location = new System.Drawing.Point(699, 538);
            this.lblScorePlr1.Name = "lblScorePlr1";
            this.lblScorePlr1.Size = new System.Drawing.Size(20, 32);
            this.lblScorePlr1.TabIndex = 23;
            this.lblScorePlr1.Text = "0";
            this.lblScorePlr1.UseCompatibleTextRendering = true;
            this.lblScorePlr1.Visible = false;
            // 
            // lblScorePlr2
            // 
            this.lblScorePlr2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblScorePlr2.AutoSize = true;
            this.lblScorePlr2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePlr2.ForeColor = System.Drawing.Color.Yellow;
            this.lblScorePlr2.Location = new System.Drawing.Point(808, 538);
            this.lblScorePlr2.Name = "lblScorePlr2";
            this.lblScorePlr2.Size = new System.Drawing.Size(24, 27);
            this.lblScorePlr2.TabIndex = 24;
            this.lblScorePlr2.Text = "0";
            this.lblScorePlr2.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnResetWb
            // 
            this.btnResetWb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnResetWb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnResetWb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetWb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResetWb.FlatAppearance.BorderSize = 3;
            this.btnResetWb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnResetWb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetWb.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetWb.ForeColor = System.Drawing.Color.Maroon;
            this.btnResetWb.Location = new System.Drawing.Point(828, 468);
            this.btnResetWb.Name = "btnResetWb";
            this.btnResetWb.Size = new System.Drawing.Size(69, 35);
            this.btnResetWb.TabIndex = 25;
            this.btnResetWb.Text = "Reset";
            this.btnResetWb.UseVisualStyleBackColor = false;
            this.btnResetWb.Visible = false;
            this.btnResetWb.Click += new System.EventHandler(this.btnResetWb_Click);
            // 
            // btnReplay
            // 
            this.btnReplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReplay.BackColor = System.Drawing.Color.Black;
            this.btnReplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReplay.FlatAppearance.BorderSize = 3;
            this.btnReplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplay.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReplay.Location = new System.Drawing.Point(244, 295);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(158, 68);
            this.btnReplay.TabIndex = 26;
            this.btnReplay.Text = "Play Again";
            this.btnReplay.UseVisualStyleBackColor = false;
            this.btnReplay.Visible = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // btnRules
            // 
            this.btnRules.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRules.BackColor = System.Drawing.Color.Snow;
            this.btnRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRules.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnRules.FlatAppearance.BorderSize = 3;
            this.btnRules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnRules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRules.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRules.Location = new System.Drawing.Point(753, 41);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(94, 37);
            this.btnRules.TabIndex = 27;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // lblRulesContent
            // 
            this.lblRulesContent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRulesContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRulesContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRulesContent.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRulesContent.Location = new System.Drawing.Point(504, 92);
            this.lblRulesContent.Name = "lblRulesContent";
            this.lblRulesContent.Padding = new System.Windows.Forms.Padding(10);
            this.lblRulesContent.Size = new System.Drawing.Size(343, 112);
            this.lblRulesContent.TabIndex = 28;
            this.lblRulesContent.Text = "Đánh dấu 5 ô liên tiếp theo hàng, cột hoặc đường chéo là THẮNG";
            this.lblRulesContent.Visible = false;
            this.lblRulesContent.Paint += new System.Windows.Forms.PaintEventHandler(this.lblRulesContent_Paint);
            // 
            // Form_Caro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(916, 588);
            this.Controls.Add(this.lblRulesContent);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.btnResetWb);
            this.Controls.Add(this.lblScorePlr2);
            this.Controls.Add(this.lblScorePlr1);
            this.Controls.Add(this.lblWinBoard);
            this.Controls.Add(this.lblWbPlr2);
            this.Controls.Add(this.lblWbPlr1);
            this.Controls.Add(this.cbbLanguages);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.ptrbLogo);
            this.Controls.Add(this.ptrbLeftLogoGame);
            this.Controls.Add(this.btnPvsE);
            this.Controls.Add(this.btnPvsP);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.ptrPhoto);
            this.Controls.Add(this.lblNguoiChoi);
            this.Controls.Add(this.lblCoolTime);
            this.Controls.Add(this.prcbCoolTime);
            this.Controls.Add(this.txtNguoiChoi);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ptrbRightLogoGame);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Caro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Caro";
            this.Load += new System.EventHandler(this.Form_Caro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbLeftLogoGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbRightLogoGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNguoiChoi;
        private System.Windows.Forms.ProgressBar prcbCoolTime;
        private System.Windows.Forms.Timer timerCoolTime;
        private System.Windows.Forms.Label lblCoolTime;
        private System.Windows.Forms.Label lblNguoiChoi;
        private System.Windows.Forms.PictureBox ptrPhoto;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.ToolStripMenuItem chếĐộToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiVsNgườiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiVsMáyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnPvsP;
        private System.Windows.Forms.Button btnPvsE;
        private System.Windows.Forms.PictureBox ptrbRightLogoGame;
        private System.Windows.Forms.PictureBox ptrbLeftLogoGame;
        private System.Windows.Forms.PictureBox ptrbLogo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.ComboBox cbbLanguages;
        private System.Windows.Forms.Label lblWbPlr1;
        private System.Windows.Forms.Label lblWbPlr2;
        private System.Windows.Forms.Label lblWinBoard;
        private System.Windows.Forms.Label lblScorePlr1;
        private System.Windows.Forms.Label lblScorePlr2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnResetWb;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Label lblRulesContent;
    }
}

