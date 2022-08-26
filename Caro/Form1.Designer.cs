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
            this.btnPvsP = new System.Windows.Forms.Button();
            this.btnPvsE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptrbLeftLogoGame = new System.Windows.Forms.PictureBox();
            this.ptrPhoto = new System.Windows.Forms.PictureBox();
            this.ptrbRightLogoGame = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
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
            this.txtNguoiChoi.Location = new System.Drawing.Point(710, 470);
            this.txtNguoiChoi.Name = "txtNguoiChoi";
            this.txtNguoiChoi.ReadOnly = true;
            this.txtNguoiChoi.Size = new System.Drawing.Size(100, 20);
            this.txtNguoiChoi.TabIndex = 2;
            // 
            // prcbCoolTime
            // 
            this.prcbCoolTime.BackColor = System.Drawing.Color.Purple;
            this.prcbCoolTime.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.prcbCoolTime.Location = new System.Drawing.Point(710, 429);
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
            this.lblCoolTime.AutoSize = true;
            this.lblCoolTime.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoolTime.Location = new System.Drawing.Point(657, 436);
            this.lblCoolTime.Name = "lblCoolTime";
            this.lblCoolTime.Size = new System.Drawing.Size(47, 16);
            this.lblCoolTime.TabIndex = 4;
            this.lblCoolTime.Text = "Time :";
            // 
            // lblNguoiChoi
            // 
            this.lblNguoiChoi.AutoSize = true;
            this.lblNguoiChoi.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiChoi.Location = new System.Drawing.Point(656, 470);
            this.lblNguoiChoi.Name = "lblNguoiChoi";
            this.lblNguoiChoi.Size = new System.Drawing.Size(47, 19);
            this.lblNguoiChoi.TabIndex = 5;
            this.lblNguoiChoi.Text = "Turn :";
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoto.Location = new System.Drawing.Point(652, 368);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(51, 19);
            this.lblPhoto.TabIndex = 7;
            this.lblPhoto.Text = "Logo :";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Red;
            this.lblLogo.Location = new System.Drawing.Point(213, 77);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(401, 58);
            this.lblLogo.TabIndex = 8;
            this.lblLogo.Text = "GAME CARO";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPvsP
            // 
            this.btnPvsP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPvsP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPvsP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPvsP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPvsP.Location = new System.Drawing.Point(293, 235);
            this.btnPvsP.Name = "btnPvsP";
            this.btnPvsP.Size = new System.Drawing.Size(241, 118);
            this.btnPvsP.TabIndex = 9;
            this.btnPvsP.Text = "PEOPLE VS PEOPLE";
            this.btnPvsP.UseVisualStyleBackColor = false;
            this.btnPvsP.Click += new System.EventHandler(this.btnPvsP_Click);
            // 
            // btnPvsE
            // 
            this.btnPvsE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPvsE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPvsE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPvsE.Location = new System.Drawing.Point(293, 383);
            this.btnPvsE.Name = "btnPvsE";
            this.btnPvsE.Size = new System.Drawing.Size(241, 118);
            this.btnPvsE.TabIndex = 10;
            this.btnPvsE.Text = "PEOPLE VS AI";
            this.btnPvsE.UseVisualStyleBackColor = false;
            this.btnPvsE.Click += new System.EventHandler(this.btnPvsE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Caro.Properties.Resources.my_logo;
            this.pictureBox1.Location = new System.Drawing.Point(649, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ptrbLeftLogoGame
            // 
            this.ptrbLeftLogoGame.Image = global::Caro.Properties.Resources.logo_game;
            this.ptrbLeftLogoGame.Location = new System.Drawing.Point(47, 268);
            this.ptrbLeftLogoGame.Name = "ptrbLeftLogoGame";
            this.ptrbLeftLogoGame.Size = new System.Drawing.Size(176, 168);
            this.ptrbLeftLogoGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbLeftLogoGame.TabIndex = 14;
            this.ptrbLeftLogoGame.TabStop = false;
            // 
            // ptrPhoto
            // 
            this.ptrPhoto.Location = new System.Drawing.Point(710, 351);
            this.ptrPhoto.Name = "ptrPhoto";
            this.ptrPhoto.Size = new System.Drawing.Size(80, 57);
            this.ptrPhoto.TabIndex = 6;
            this.ptrPhoto.TabStop = false;
            // 
            // ptrbRightLogoGame
            // 
            this.ptrbRightLogoGame.Image = ((System.Drawing.Image)(resources.GetObject("ptrbRightLogoGame.Image")));
            this.ptrbRightLogoGame.Location = new System.Drawing.Point(592, 268);
            this.ptrbRightLogoGame.Name = "ptrbRightLogoGame";
            this.ptrbRightLogoGame.Size = new System.Drawing.Size(176, 168);
            this.ptrbRightLogoGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbRightLogoGame.TabIndex = 12;
            this.ptrbRightLogoGame.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Snow;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenu.Location = new System.Drawing.Point(649, 235);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(158, 68);
            this.btnMenu.TabIndex = 16;
            this.btnMenu.Text = "RETURN TO MENU";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Visible = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Form_Caro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(819, 605);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenu;
    }
}

