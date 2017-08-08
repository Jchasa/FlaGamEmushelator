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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.optionstabPage = new System.Windows.Forms.TabPage();
            this.gamefolderlocationGC = new DevExpress.XtraEditors.GroupControl();
            this.gamefolderlocationTB = new System.Windows.Forms.TextBox();
            this.FlaGamecontrol = new DevExpress.XtraEditors.GroupControl();
            this.buttonopenFGP = new System.Windows.Forms.Button();
            this.flashgamespathbuttonS = new System.Windows.Forms.Button();
            this.flashgamespathtextBox = new System.Windows.Forms.TextBox();
            this.flashgamespathbuttonB = new System.Windows.Forms.Button();
            this.tab2File = new System.Windows.Forms.TabPage();
            this.tab1GameList = new System.Windows.Forms.TabPage();
            this.main1groupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearMadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.developerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gameDBDataSet = new FlashGameEmulator.GameDBDataSet1();
            this.checkConnection = new System.Windows.Forms.Label();
            this.maintabControl = new System.Windows.Forms.TabControl();
            this.gameDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameDataTableAdapter = new FlashGameEmulator.GameDBDataSet1TableAdapters.GameDataTableAdapter();
            this.gameDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.buttonISW = new System.Windows.Forms.Button();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.button1 = new System.Windows.Forms.Button();
            this.optionstabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamefolderlocationGC)).BeginInit();
            this.gamefolderlocationGC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlaGamecontrol)).BeginInit();
            this.FlaGamecontrol.SuspendLayout();
            this.tab2File.SuspendLayout();
            this.tab1GameList.SuspendLayout();
            this.main1groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet)).BeginInit();
            this.maintabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionstabPage
            // 
            this.optionstabPage.Controls.Add(this.groupControl2);
            this.optionstabPage.Controls.Add(this.gamefolderlocationGC);
            this.optionstabPage.Controls.Add(this.FlaGamecontrol);
            this.optionstabPage.Location = new System.Drawing.Point(4, 22);
            this.optionstabPage.Name = "optionstabPage";
            this.optionstabPage.Padding = new System.Windows.Forms.Padding(3);
            this.optionstabPage.Size = new System.Drawing.Size(781, 437);
            this.optionstabPage.TabIndex = 1;
            this.optionstabPage.Text = "Options";
            this.optionstabPage.UseVisualStyleBackColor = true;
            // 
            // gamefolderlocationGC
            // 
            this.gamefolderlocationGC.Controls.Add(this.gamefolderlocationTB);
            this.gamefolderlocationGC.Location = new System.Drawing.Point(7, 72);
            this.gamefolderlocationGC.Name = "gamefolderlocationGC";
            this.gamefolderlocationGC.Size = new System.Drawing.Size(276, 59);
            this.gamefolderlocationGC.TabIndex = 2;
            this.gamefolderlocationGC.Text = "GameFolderLocation";
            // 
            // gamefolderlocationTB
            // 
            this.gamefolderlocationTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.gamefolderlocationTB.Location = new System.Drawing.Point(6, 24);
            this.gamefolderlocationTB.Name = "gamefolderlocationTB";
            this.gamefolderlocationTB.ReadOnly = true;
            this.gamefolderlocationTB.Size = new System.Drawing.Size(265, 21);
            this.gamefolderlocationTB.TabIndex = 0;
            // 
            // FlaGamecontrol
            // 
            this.FlaGamecontrol.Controls.Add(this.buttonopenFGP);
            this.FlaGamecontrol.Location = new System.Drawing.Point(6, 6);
            this.FlaGamecontrol.Name = "FlaGamecontrol";
            this.FlaGamecontrol.Size = new System.Drawing.Size(277, 59);
            this.FlaGamecontrol.TabIndex = 1;
            this.FlaGamecontrol.Text = "FlaGamePlayer";
            // 
            // buttonopenFGP
            // 
            this.buttonopenFGP.Location = new System.Drawing.Point(7, 24);
            this.buttonopenFGP.Name = "buttonopenFGP";
            this.buttonopenFGP.Size = new System.Drawing.Size(116, 23);
            this.buttonopenFGP.TabIndex = 0;
            this.buttonopenFGP.Text = "Open FlaGamePlayer";
            this.buttonopenFGP.UseVisualStyleBackColor = true;
            this.buttonopenFGP.Click += new System.EventHandler(this.buttonopenFGP_Click);
            // 
            // flashgamespathbuttonS
            // 
            this.flashgamespathbuttonS.Location = new System.Drawing.Point(0, 0);
            this.flashgamespathbuttonS.Name = "flashgamespathbuttonS";
            this.flashgamespathbuttonS.Size = new System.Drawing.Size(75, 23);
            this.flashgamespathbuttonS.TabIndex = 0;
            // 
            // flashgamespathtextBox
            // 
            this.flashgamespathtextBox.Location = new System.Drawing.Point(0, 0);
            this.flashgamespathtextBox.Name = "flashgamespathtextBox";
            this.flashgamespathtextBox.Size = new System.Drawing.Size(100, 20);
            this.flashgamespathtextBox.TabIndex = 0;
            // 
            // flashgamespathbuttonB
            // 
            this.flashgamespathbuttonB.Location = new System.Drawing.Point(0, 0);
            this.flashgamespathbuttonB.Name = "flashgamespathbuttonB";
            this.flashgamespathbuttonB.Size = new System.Drawing.Size(75, 23);
            this.flashgamespathbuttonB.TabIndex = 0;
            // 
            // tab2File
            // 
            this.tab2File.Controls.Add(this.groupControl1);
            this.tab2File.Location = new System.Drawing.Point(4, 22);
            this.tab2File.Name = "tab2File";
            this.tab2File.Padding = new System.Windows.Forms.Padding(3);
            this.tab2File.Size = new System.Drawing.Size(781, 437);
            this.tab2File.TabIndex = 0;
            this.tab2File.Text = "File";
            this.tab2File.UseVisualStyleBackColor = true;
            // 
            // tab1GameList
            // 
            this.tab1GameList.Controls.Add(this.main1groupBox);
            this.tab1GameList.Location = new System.Drawing.Point(4, 22);
            this.tab1GameList.Name = "tab1GameList";
            this.tab1GameList.Padding = new System.Windows.Forms.Padding(3);
            this.tab1GameList.Size = new System.Drawing.Size(781, 437);
            this.tab1GameList.TabIndex = 3;
            this.tab1GameList.Text = "Game List";
            this.tab1GameList.UseVisualStyleBackColor = true;
            // 
            // main1groupBox
            // 
            this.main1groupBox.Controls.Add(this.dataGridView1);
            this.main1groupBox.Controls.Add(this.checkConnection);
            this.main1groupBox.Location = new System.Drawing.Point(6, 6);
            this.main1groupBox.Name = "main1groupBox";
            this.main1groupBox.Size = new System.Drawing.Size(766, 424);
            this.main1groupBox.TabIndex = 0;
            this.main1groupBox.TabStop = false;
            this.main1groupBox.Text = "Flash Games";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.yearMadeDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.developerDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.seriesDataGridViewTextBoxColumn,
            this.fileLocationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gameDataBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(10, 20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(750, 398);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gameIDDataGridViewTextBoxColumn
            // 
            this.gameIDDataGridViewTextBoxColumn.DataPropertyName = "Game ID";
            this.gameIDDataGridViewTextBoxColumn.HeaderText = "Game ID";
            this.gameIDDataGridViewTextBoxColumn.Name = "gameIDDataGridViewTextBoxColumn";
            this.gameIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gameIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearMadeDataGridViewTextBoxColumn
            // 
            this.yearMadeDataGridViewTextBoxColumn.DataPropertyName = "Year Made";
            this.yearMadeDataGridViewTextBoxColumn.HeaderText = "Year Made";
            this.yearMadeDataGridViewTextBoxColumn.Name = "yearMadeDataGridViewTextBoxColumn";
            this.yearMadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // developerDataGridViewTextBoxColumn
            // 
            this.developerDataGridViewTextBoxColumn.DataPropertyName = "Developer";
            this.developerDataGridViewTextBoxColumn.HeaderText = "Developer";
            this.developerDataGridViewTextBoxColumn.Name = "developerDataGridViewTextBoxColumn";
            this.developerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seriesDataGridViewTextBoxColumn
            // 
            this.seriesDataGridViewTextBoxColumn.DataPropertyName = "Series";
            this.seriesDataGridViewTextBoxColumn.HeaderText = "Series";
            this.seriesDataGridViewTextBoxColumn.Name = "seriesDataGridViewTextBoxColumn";
            this.seriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileLocationDataGridViewTextBoxColumn
            // 
            this.fileLocationDataGridViewTextBoxColumn.DataPropertyName = "File Location";
            this.fileLocationDataGridViewTextBoxColumn.HeaderText = "File Location";
            this.fileLocationDataGridViewTextBoxColumn.Name = "fileLocationDataGridViewTextBoxColumn";
            this.fileLocationDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileLocationDataGridViewTextBoxColumn.Visible = false;
            // 
            // gameDataBindingSource1
            // 
            this.gameDataBindingSource1.DataMember = "GameData";
            this.gameDataBindingSource1.DataSource = this.gameDBDataSet;
            // 
            // gameDBDataSet
            // 
            this.gameDBDataSet.DataSetName = "GameDBDataSet";
            this.gameDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkConnection
            // 
            this.checkConnection.AutoSize = true;
            this.checkConnection.Location = new System.Drawing.Point(7, 395);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(0, 13);
            this.checkConnection.TabIndex = 1;
            // 
            // maintabControl
            // 
            this.maintabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maintabControl.Controls.Add(this.tab1GameList);
            this.maintabControl.Controls.Add(this.tab2File);
            this.maintabControl.Controls.Add(this.optionstabPage);
            this.maintabControl.Location = new System.Drawing.Point(-1, -1);
            this.maintabControl.Multiline = true;
            this.maintabControl.Name = "maintabControl";
            this.maintabControl.SelectedIndex = 0;
            this.maintabControl.Size = new System.Drawing.Size(789, 463);
            this.maintabControl.TabIndex = 0;
            // 
            // gameDataBindingSource
            // 
            this.gameDataBindingSource.DataMember = "GameData";
            this.gameDataBindingSource.DataSource = this.gameDBDataSet;
            // 
            // gameDataTableAdapter
            // 
            this.gameDataTableAdapter.ClearBeforeFill = true;
            // 
            // gameDBDataSetBindingSource
            // 
            this.gameDBDataSetBindingSource.DataSource = this.gameDBDataSet;
            this.gameDBDataSetBindingSource.Position = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.buttonISW);
            this.groupControl1.Location = new System.Drawing.Point(6, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(117, 56);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Intial Setup Wizard";
            // 
            // buttonISW
            // 
            this.buttonISW.Location = new System.Drawing.Point(17, 23);
            this.buttonISW.Name = "buttonISW";
            this.buttonISW.Size = new System.Drawing.Size(75, 23);
            this.buttonISW.TabIndex = 0;
            this.buttonISW.Text = "Start";
            this.buttonISW.UseVisualStyleBackColor = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.button1);
            this.groupControl2.Location = new System.Drawing.Point(290, 7);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(123, 58);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Restart Initial Setup";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(22, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(788, 462);
            this.Controls.Add(this.maintabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(770, 424);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlaGamEmushelator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.optionstabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gamefolderlocationGC)).EndInit();
            this.gamefolderlocationGC.ResumeLayout(false);
            this.gamefolderlocationGC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlaGamecontrol)).EndInit();
            this.FlaGamecontrol.ResumeLayout(false);
            this.tab2File.ResumeLayout(false);
            this.tab1GameList.ResumeLayout(false);
            this.main1groupBox.ResumeLayout(false);
            this.main1groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet)).EndInit();
            this.maintabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage optionstabPage;
        private System.Windows.Forms.Button flashgamespathbuttonS;
        private System.Windows.Forms.TextBox flashgamespathtextBox;
        private System.Windows.Forms.Button flashgamespathbuttonB;
        private System.Windows.Forms.TabPage tab2File;
        private System.Windows.Forms.TabPage tab1GameList;
        private System.Windows.Forms.GroupBox main1groupBox;
        private System.Windows.Forms.TabControl maintabControl;
        private System.Windows.Forms.Label checkConnection;
        private GameDBDataSet1 gameDBDataSet;
        private System.Windows.Forms.BindingSource gameDataBindingSource;
        private GameDBDataSet1TableAdapters.GameDataTableAdapter gameDataTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gameDataBindingSource1;
        private System.Windows.Forms.BindingSource gameDBDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearMadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn developerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileLocationDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.GroupControl FlaGamecontrol;
        private System.Windows.Forms.Button buttonopenFGP;
        private DevExpress.XtraEditors.GroupControl gamefolderlocationGC;
        public System.Windows.Forms.TextBox gamefolderlocationTB;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button buttonISW;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button button1;
    }
}