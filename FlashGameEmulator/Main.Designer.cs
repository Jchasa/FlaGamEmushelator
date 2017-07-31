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
            this.optionstabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flashgamespathbuttonS = new System.Windows.Forms.Button();
            this.flashgamespathtextBox = new System.Windows.Forms.TextBox();
            this.flashgamespathbuttonB = new System.Windows.Forms.Button();
            this.filetabPage = new System.Windows.Forms.TabPage();
            this.main1tabPage = new System.Windows.Forms.TabPage();
            this.main1groupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkConnection = new System.Windows.Forms.Label();
            this.maintabControl = new System.Windows.Forms.TabControl();
            this.gameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearMadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.developerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameDBDataSet = new FlashGameEmulator.GameDBDataSet1();
            this.gameDataTableAdapter = new FlashGameEmulator.GameDBDataSet1TableAdapters.GameDataTableAdapter();
            this.optionstabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.main1tabPage.SuspendLayout();
            this.main1groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.maintabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // optionstabPage
            // 
            this.optionstabPage.Controls.Add(this.groupBox1);
            this.optionstabPage.Location = new System.Drawing.Point(4, 22);
            this.optionstabPage.Name = "optionstabPage";
            this.optionstabPage.Padding = new System.Windows.Forms.Padding(3);
            this.optionstabPage.Size = new System.Drawing.Size(842, 436);
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
            // filetabPage
            // 
            this.filetabPage.Location = new System.Drawing.Point(4, 22);
            this.filetabPage.Name = "filetabPage";
            this.filetabPage.Padding = new System.Windows.Forms.Padding(3);
            this.filetabPage.Size = new System.Drawing.Size(842, 436);
            this.filetabPage.TabIndex = 0;
            this.filetabPage.Text = "File";
            this.filetabPage.UseVisualStyleBackColor = true;
            // 
            // main1tabPage
            // 
            this.main1tabPage.Controls.Add(this.main1groupBox);
            this.main1tabPage.Location = new System.Drawing.Point(4, 22);
            this.main1tabPage.Name = "main1tabPage";
            this.main1tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.main1tabPage.Size = new System.Drawing.Size(778, 436);
            this.main1tabPage.TabIndex = 3;
            this.main1tabPage.Text = "Main1";
            this.main1tabPage.UseVisualStyleBackColor = true;
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
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.yearMadeDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.developerDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.seriesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gameDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 159);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.maintabControl.Controls.Add(this.main1tabPage);
            this.maintabControl.Controls.Add(this.filetabPage);
            this.maintabControl.Controls.Add(this.optionstabPage);
            this.maintabControl.Location = new System.Drawing.Point(-1, -1);
            this.maintabControl.Multiline = true;
            this.maintabControl.Name = "maintabControl";
            this.maintabControl.SelectedIndex = 0;
            this.maintabControl.Size = new System.Drawing.Size(786, 462);
            this.maintabControl.TabIndex = 0;
            // 
            // gameIDDataGridViewTextBoxColumn
            // 
            this.gameIDDataGridViewTextBoxColumn.DataPropertyName = "Game ID";
            this.gameIDDataGridViewTextBoxColumn.HeaderText = "Game ID";
            this.gameIDDataGridViewTextBoxColumn.Name = "gameIDDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // yearMadeDataGridViewTextBoxColumn
            // 
            this.yearMadeDataGridViewTextBoxColumn.DataPropertyName = "Year Made";
            this.yearMadeDataGridViewTextBoxColumn.HeaderText = "Year Made";
            this.yearMadeDataGridViewTextBoxColumn.Name = "yearMadeDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // developerDataGridViewTextBoxColumn
            // 
            this.developerDataGridViewTextBoxColumn.DataPropertyName = "Developer";
            this.developerDataGridViewTextBoxColumn.HeaderText = "Developer";
            this.developerDataGridViewTextBoxColumn.Name = "developerDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            // 
            // seriesDataGridViewTextBoxColumn
            // 
            this.seriesDataGridViewTextBoxColumn.DataPropertyName = "Series";
            this.seriesDataGridViewTextBoxColumn.HeaderText = "Series";
            this.seriesDataGridViewTextBoxColumn.Name = "seriesDataGridViewTextBoxColumn";
            // 
            // gameDataBindingSource
            // 
            this.gameDataBindingSource.DataMember = "GameData";
            this.gameDataBindingSource.DataSource = this.gameDBDataSet;
            // 
            // gameDBDataSet
            // 
            this.gameDBDataSet.DataSetName = "GameDBDataSet";
            this.gameDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameDataTableAdapter
            // 
            this.gameDataTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(785, 461);
            this.Controls.Add(this.maintabControl);
            this.MinimumSize = new System.Drawing.Size(770, 424);
            this.Name = "Main";
            this.Text = "FlaGamEmushelator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.optionstabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.main1tabPage.ResumeLayout(false);
            this.main1groupBox.ResumeLayout(false);
            this.main1groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.maintabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage optionstabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button flashgamespathbuttonS;
        private System.Windows.Forms.TextBox flashgamespathtextBox;
        private System.Windows.Forms.Button flashgamespathbuttonB;
        private System.Windows.Forms.TabPage filetabPage;
        private System.Windows.Forms.TabPage main1tabPage;
        private System.Windows.Forms.GroupBox main1groupBox;
        private System.Windows.Forms.TabControl maintabControl;
        private System.Windows.Forms.Label checkConnection;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GameDBDataSet1 gameDBDataSet;
        private System.Windows.Forms.BindingSource gameDataBindingSource;
        private GameDBDataSet1TableAdapters.GameDataTableAdapter gameDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearMadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn developerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesDataGridViewTextBoxColumn;
    }
}