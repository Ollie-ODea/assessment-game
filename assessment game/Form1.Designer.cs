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
            this.tmrEnemyPlane.Interval = 3;
            this.tmrEnemyPlane.Tick += new System.EventHandler(this.tmrEnemyPlane_Tick);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.DoubleBuffered = true;
            this.Name = "FrmGame";
            this.Text = "Fight or Flight";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmGame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrBluePlane;
        private System.Windows.Forms.Timer tmrEnemyPlane;
    }
}

