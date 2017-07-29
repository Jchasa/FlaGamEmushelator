namespace FlashGameEmulator
{
    partial class Main
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
            this.maintabControl = new System.Windows.Forms.TabControl();
            this.main2tabPage = new System.Windows.Forms.TabPage();
            this.filetabPage = new System.Windows.Forms.TabPage();
            this.optionstabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flashgamespathbuttonS = new System.Windows.Forms.Button();
            this.flashgamespathtextBox = new System.Windows.Forms.TextBox();
            this.flashgamespathbuttonB = new System.Windows.Forms.Button();
            this.main1tabPage = new System.Windows.Forms.TabPage();
            this.main1groupBox = new System.Windows.Forms.GroupBox();
            this.main1listBox = new System.Windows.Forms.ListBox();
            this.main2groupBox = new System.Windows.Forms.GroupBox();
            this.main2listView = new System.Windows.Forms.ListView();
            this.maintabControl.SuspendLayout();
            this.main2tabPage.SuspendLayout();
            this.optionstabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.main1tabPage.SuspendLayout();
            this.main1groupBox.SuspendLayout();
            this.main2groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // maintabControl
            // 
            this.maintabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maintabControl.Controls.Add(this.main1tabPage);
            this.maintabControl.Controls.Add(this.main2tabPage);
            this.maintabControl.Controls.Add(this.filetabPage);
            this.maintabControl.Controls.Add(this.optionstabPage);
            this.maintabControl.Location = new System.Drawing.Point(-1, -1);
            this.maintabControl.Multiline = true;
            this.maintabControl.Name = "maintabControl";
            this.maintabControl.SelectedIndex = 0;
            this.maintabControl.Size = new System.Drawing.Size(485, 462);
            this.maintabControl.TabIndex = 0;
            // 
            // main2tabPage
            // 
            this.main2tabPage.Controls.Add(this.main2groupBox);
            this.main2tabPage.Location = new System.Drawing.Point(4, 22);
            this.main2tabPage.Name = "main2tabPage";
            this.main2tabPage.Size = new System.Drawing.Size(477, 436);
            this.main2tabPage.TabIndex = 2;
            this.main2tabPage.Text = "Main2";
            this.main2tabPage.UseVisualStyleBackColor = true;
            // 
            // filetabPage
            // 
            this.filetabPage.Location = new System.Drawing.Point(4, 22);
            this.filetabPage.Name = "filetabPage";
            this.filetabPage.Padding = new System.Windows.Forms.Padding(3);
            this.filetabPage.Size = new System.Drawing.Size(477, 436);
            this.filetabPage.TabIndex = 0;
            this.filetabPage.Text = "File";
            this.filetabPage.UseVisualStyleBackColor = true;
            // 
            // optionstabPage
            // 
            this.optionstabPage.Controls.Add(this.groupBox1);
            this.optionstabPage.Location = new System.Drawing.Point(4, 22);
            this.optionstabPage.Name = "optionstabPage";
            this.optionstabPage.Padding = new System.Windows.Forms.Padding(3);
            this.optionstabPage.Size = new System.Drawing.Size(477, 436);
            this.optionstabPage.TabIndex = 1;
            this.optionstabPage.Text = "Options";
            this.optionstabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flashgamespathbuttonS);
            this.groupBox1.Controls.Add(this.flashgamespathtextBox);
            this.groupBox1.Controls.Add(this.flashgamespathbuttonB);
            this.groupBox1.Location = new System.Drawing.Point(10, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flash Games Path";
            // 
            // flashgamespathbuttonS
            // 
            this.flashgamespathbuttonS.AutoSize = true;
            this.flashgamespathbuttonS.Location = new System.Drawing.Point(378, 57);
            this.flashgamespathbuttonS.Name = "flashgamespathbuttonS";
            this.flashgamespathbuttonS.Size = new System.Drawing.Size(75, 23);
            this.flashgamespathbuttonS.TabIndex = 2;
            this.flashgamespathbuttonS.Text = "Save";
            this.flashgamespathbuttonS.UseVisualStyleBackColor = true;
            this.flashgamespathbuttonS.Click += new System.EventHandler(this.flashgamespathbuttonS_Click);
            // 
            // flashgamespathtextBox
            // 
            this.flashgamespathtextBox.Location = new System.Drawing.Point(7, 20);
            this.flashgamespathtextBox.Name = "flashgamespathtextBox";
            this.flashgamespathtextBox.Size = new System.Drawing.Size(365, 20);
            this.flashgamespathtextBox.TabIndex = 1;
            // 
            // flashgamespathbuttonB
            // 
            this.flashgamespathbuttonB.AutoSize = true;
            this.flashgamespathbuttonB.Location = new System.Drawing.Point(378, 19);
            this.flashgamespathbuttonB.Name = "flashgamespathbuttonB";
            this.flashgamespathbuttonB.Size = new System.Drawing.Size(75, 23);
            this.flashgamespathbuttonB.TabIndex = 0;
            this.flashgamespathbuttonB.Text = "Browse";
            this.flashgamespathbuttonB.UseVisualStyleBackColor = true;
            this.flashgamespathbuttonB.Click += new System.EventHandler(this.flashgamespathbutton_Click);
            // 
            // main1tabPage
            // 
            this.main1tabPage.Controls.Add(this.main1groupBox);
            this.main1tabPage.Location = new System.Drawing.Point(4, 22);
            this.main1tabPage.Name = "main1tabPage";
            this.main1tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.main1tabPage.Size = new System.Drawing.Size(477, 436);
            this.main1tabPage.TabIndex = 3;
            this.main1tabPage.Text = "Main1";
            this.main1tabPage.UseVisualStyleBackColor = true;
            // 
            // main1groupBox
            // 
            this.main1groupBox.Controls.Add(this.main1listBox);
            this.main1groupBox.Location = new System.Drawing.Point(6, 6);
            this.main1groupBox.Name = "main1groupBox";
            this.main1groupBox.Size = new System.Drawing.Size(465, 424);
            this.main1groupBox.TabIndex = 0;
            this.main1groupBox.TabStop = false;
            this.main1groupBox.Text = "Flash Games";
            // 
            // main1listBox
            // 
            this.main1listBox.FormattingEnabled = true;
            this.main1listBox.Location = new System.Drawing.Point(7, 20);
            this.main1listBox.Name = "main1listBox";
            this.main1listBox.Size = new System.Drawing.Size(452, 394);
            this.main1listBox.TabIndex = 0;
            // 
            // main2groupBox
            // 
            this.main2groupBox.Controls.Add(this.main2listView);
            this.main2groupBox.Location = new System.Drawing.Point(10, 4);
            this.main2groupBox.Name = "main2groupBox";
            this.main2groupBox.Size = new System.Drawing.Size(459, 424);
            this.main2groupBox.TabIndex = 0;
            this.main2groupBox.TabStop = false;
            this.main2groupBox.Text = "Flash Games";
            // 
            // main2listView
            // 
            this.main2listView.Location = new System.Drawing.Point(7, 20);
            this.main2listView.Name = "main2listView";
            this.main2listView.Size = new System.Drawing.Size(446, 404);
            this.main2listView.TabIndex = 0;
            this.main2listView.UseCompatibleStateImageBehavior = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.maintabControl);
            this.Name = "Main";
            this.Text = "FlaGamEmushelator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.maintabControl.ResumeLayout(false);
            this.main2tabPage.ResumeLayout(false);
            this.optionstabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.main1tabPage.ResumeLayout(false);
            this.main1groupBox.ResumeLayout(false);
            this.main2groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl maintabControl;
        private System.Windows.Forms.TabPage filetabPage;
        private System.Windows.Forms.TabPage optionstabPage;
        private System.Windows.Forms.TabPage main2tabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox flashgamespathtextBox;
        private System.Windows.Forms.Button flashgamespathbuttonB;
        private System.Windows.Forms.Button flashgamespathbuttonS;
        private System.Windows.Forms.TabPage main1tabPage;
        private System.Windows.Forms.GroupBox main1groupBox;
        private System.Windows.Forms.ListBox main1listBox;
        private System.Windows.Forms.GroupBox main2groupBox;
        private System.Windows.Forms.ListView main2listView;
    }
}