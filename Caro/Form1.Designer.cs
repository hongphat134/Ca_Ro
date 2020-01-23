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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chếĐộToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiVsNgườiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiVsMáyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNguoiChoi = new System.Windows.Forms.TextBox();
            this.prcbCoolTime = new System.Windows.Forms.ProgressBar();
            this.timerCoolTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptrPhoto = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrPhoto)).BeginInit();
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
            this.chếĐộToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.prcbCoolTime.Location = new System.Drawing.Point(710, 429);
            this.prcbCoolTime.Name = "prcbCoolTime";
            this.prcbCoolTime.Size = new System.Drawing.Size(100, 23);
            this.prcbCoolTime.TabIndex = 3;
            // 
            // timerCoolTime
            // 
            this.timerCoolTime.Interval = 1000;
            this.timerCoolTime.Tick += new System.EventHandler(this.timerCoolTime_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(628, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lượt chơi :";
            // 
            // ptrPhoto
            // 
            this.ptrPhoto.Location = new System.Drawing.Point(727, 352);
            this.ptrPhoto.Name = "ptrPhoto";
            this.ptrPhoto.Size = new System.Drawing.Size(80, 57);
            this.ptrPhoto.TabIndex = 6;
            this.ptrPhoto.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(618, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hình đại diện :";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // Form_Caro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 605);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ptrPhoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prcbCoolTime);
            this.Controls.Add(this.txtNguoiChoi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Caro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Caro";
            this.Load += new System.EventHandler(this.Form_Caro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNguoiChoi;
        private System.Windows.Forms.ProgressBar prcbCoolTime;
        private System.Windows.Forms.Timer timerCoolTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptrPhoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem chếĐộToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiVsNgườiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiVsMáyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;

    }
}

