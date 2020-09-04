namespace assessment_game
{
    partial class FrmGame
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
            this.tmrBluePlane = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemyPlane = new System.Windows.Forms.Timer(this.components);
            this.StaminaBar = new System.Windows.Forms.ProgressBar();
            this.Staminatmr = new System.Windows.Forms.Timer(this.components);
            this.DrawEnemy1tmr = new System.Windows.Forms.Timer(this.components);
            this.lblAmmo = new System.Windows.Forms.Label();
            this.lblMissileTime = new System.Windows.Forms.Label();
            this.TmrAmmo = new System.Windows.Forms.Timer(this.components);
            this.tmrCoin = new System.Windows.Forms.Timer(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.PanlGame = new System.Windows.Forms.Panel();
            this.deathpic = new System.Windows.Forms.PictureBox();
            this.Pauseimg = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.PanlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deathpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pauseimg)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrBluePlane
            // 
            this.tmrBluePlane.Enabled = true;
            this.tmrBluePlane.Interval = 5;
            this.tmrBluePlane.Tick += new System.EventHandler(this.tmrBluePlane_Tick);
            // 
            // tmrEnemyPlane
            // 
            this.tmrEnemyPlane.Enabled = true;
            this.tmrEnemyPlane.Interval = 3;
            this.tmrEnemyPlane.Tick += new System.EventHandler(this.tmrEnemyPlane_Tick);
            // 
            // StaminaBar
            // 
            this.StaminaBar.Location = new System.Drawing.Point(63, 13);
            this.StaminaBar.Name = "StaminaBar";
            this.StaminaBar.Size = new System.Drawing.Size(327, 23);
            this.StaminaBar.TabIndex = 0;
            // 
            // Staminatmr
            // 
            this.Staminatmr.Enabled = true;
            this.Staminatmr.Interval = 1;
            this.Staminatmr.Tick += new System.EventHandler(this.Staminatmr_Tick);
            // 
            // DrawEnemy1tmr
            // 
            this.DrawEnemy1tmr.Enabled = true;
            this.DrawEnemy1tmr.Interval = 4000;
            this.DrawEnemy1tmr.Tick += new System.EventHandler(this.DrawEnemy1tmr_Tick);
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.Location = new System.Drawing.Point(461, 12);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(13, 13);
            this.lblAmmo.TabIndex = 1;
            this.lblAmmo.Text = "0";
            // 
            // lblMissileTime
            // 
            this.lblMissileTime.AutoSize = true;
            this.lblMissileTime.Location = new System.Drawing.Point(426, 12);
            this.lblMissileTime.Name = "lblMissileTime";
            this.lblMissileTime.Size = new System.Drawing.Size(0, 13);
            this.lblMissileTime.TabIndex = 2;
            // 
            // TmrAmmo
            // 
            this.TmrAmmo.Interval = 1;
            this.TmrAmmo.Tick += new System.EventHandler(this.TmrAmmo_Tick);
            // 
            // tmrCoin
            // 
            this.tmrCoin.Interval = 1;
            this.tmrCoin.Tick += new System.EventHandler(this.tmrCoin_Tick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(926, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(929, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(109, 733);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(96, 19);
            this.startToolStripMenuItem.Text = "          Start          ";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(96, 19);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(955, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ammo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stamina";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Score :";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(583, 12);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "0";
            // 
            // PanlGame
            // 
            this.PanlGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanlGame.BackgroundImage = global::assessment_game.Properties.Resources.Sky;
            this.PanlGame.Controls.Add(this.deathpic);
            this.PanlGame.Controls.Add(this.Pauseimg);
            this.PanlGame.Location = new System.Drawing.Point(12, 41);
            this.PanlGame.Name = "PanlGame";
            this.PanlGame.Size = new System.Drawing.Size(900, 650);
            this.PanlGame.TabIndex = 3;
            this.PanlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PanlGame_Paint);
            // 
            // deathpic
            // 
            this.deathpic.BackColor = System.Drawing.Color.Transparent;
            this.deathpic.Image = global::assessment_game.Properties.Resources.You_Died_Text;
            this.deathpic.Location = new System.Drawing.Point(341, 287);
            this.deathpic.Name = "deathpic";
            this.deathpic.Size = new System.Drawing.Size(206, 74);
            this.deathpic.TabIndex = 1;
            this.deathpic.TabStop = false;
            this.deathpic.Visible = false;
            // 
            // Pauseimg
            // 
            this.Pauseimg.BackColor = System.Drawing.Color.Transparent;
            this.Pauseimg.Image = global::assessment_game.Properties.Resources.Pausedimg;
            this.Pauseimg.Location = new System.Drawing.Point(246, 124);
            this.Pauseimg.Name = "Pauseimg";
            this.Pauseimg.Size = new System.Drawing.Size(407, 407);
            this.Pauseimg.TabIndex = 0;
            this.Pauseimg.TabStop = false;
            this.Pauseimg.Visible = false;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 733);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.PanlGame);
            this.Controls.Add(this.lblMissileTime);
            this.Controls.Add(this.lblAmmo);
            this.Controls.Add(this.StaminaBar);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGame";
            this.Text = "Fight or Flight";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmGame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deathpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pauseimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrBluePlane;
        private System.Windows.Forms.Timer tmrEnemyPlane;
        private System.Windows.Forms.ProgressBar StaminaBar;
        private System.Windows.Forms.Timer Staminatmr;
        private System.Windows.Forms.Timer DrawEnemy1tmr;
        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.Label lblMissileTime;
        private System.Windows.Forms.Timer TmrAmmo;
        private System.Windows.Forms.Panel PanlGame;
        private System.Windows.Forms.Timer tmrCoin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox Pauseimg;
        private System.Windows.Forms.PictureBox deathpic;
    }
}

