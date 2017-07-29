namespace FlashGameEmulator
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.playeraxShockwaveFlash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.playeraxShockwaveFlash)).BeginInit();
            this.SuspendLayout();
            // 
            // playeraxShockwaveFlash
            // 
            this.playeraxShockwaveFlash.AllowDrop = true;
            this.playeraxShockwaveFlash.Enabled = true;
            this.playeraxShockwaveFlash.Location = new System.Drawing.Point(-2, -1);
            this.playeraxShockwaveFlash.Name = "playeraxShockwaveFlash";
            this.playeraxShockwaveFlash.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playeraxShockwaveFlash.OcxState")));
            this.playeraxShockwaveFlash.Size = new System.Drawing.Size(457, 378);
            this.playeraxShockwaveFlash.TabIndex = 0;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(454, 375);
            this.ControlBox = false;
            this.Controls.Add(this.playeraxShockwaveFlash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.playeraxShockwaveFlash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash playeraxShockwaveFlash;
    }
}