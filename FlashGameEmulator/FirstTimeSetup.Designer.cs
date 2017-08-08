namespace FlashGameEmulator
{
    partial class FirstTimeSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstTimeSetup));
            this.richTextBoxEx1 = new DevExpress.Tutorials.Controls.RichTextBoxEx();
            this.continuebutton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TitlecH1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gamepathcH2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // richTextBoxEx1
            // 
            this.richTextBoxEx1.Cursor = System.Windows.Forms.Cursors.No;
            this.richTextBoxEx1.Font = new System.Drawing.Font("Microsoft Office Preview Font", 9.75F);
            this.richTextBoxEx1.Location = new System.Drawing.Point(13, 13);
            this.richTextBoxEx1.Name = "richTextBoxEx1";
            this.richTextBoxEx1.ReadOnly = true;
            this.richTextBoxEx1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxEx1.Size = new System.Drawing.Size(464, 45);
            this.richTextBoxEx1.TabIndex = 0;
            this.richTextBoxEx1.TabStop = false;
            this.richTextBoxEx1.Text = "If this is your first time using this emulator we have to get your games loaded. " +
    " In order for you to do that we have to choose your game folder in the next step" +
    ".\n";
            // 
            // continuebutton
            // 
            this.continuebutton.Location = new System.Drawing.Point(202, 64);
            this.continuebutton.Name = "continuebutton";
            this.continuebutton.Size = new System.Drawing.Size(75, 23);
            this.continuebutton.TabIndex = 1;
            this.continuebutton.Text = "Continue";
            this.continuebutton.UseVisualStyleBackColor = true;
            this.continuebutton.Click += new System.EventHandler(this.continuebutton_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Chose your Game Folder Location";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TitlecH1,
            this.gamepathcH2});
            this.listView1.Location = new System.Drawing.Point(13, 95);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(464, 278);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // TitlecH1
            // 
            this.TitlecH1.Text = "Title";
            // 
            // gamepathcH2
            // 
            this.gamepathcH2.Text = "Game Path";
            // 
            // FirstTimeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 385);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.continuebutton);
            this.Controls.Add(this.richTextBoxEx1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(506, 424);
            this.Name = "FirstTimeSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "First Time Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstTimeSetup_FormClosing);
            this.Load += new System.EventHandler(this.FirstTimeSetup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Tutorials.Controls.RichTextBoxEx richTextBoxEx1;
        private System.Windows.Forms.Button continuebutton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        internal System.Windows.Forms.ColumnHeader TitlecH1;
        internal System.Windows.Forms.ColumnHeader gamepathcH2;
        internal System.Windows.Forms.ListView listView1;
    }
}