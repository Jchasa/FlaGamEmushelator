using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FlashGameEmulator
{
    public partial class FirstTimeSetup : Form
    {
        
        public FirstTimeSetup()
        {
            
            InitializeComponent();
        }
        public string gamefolderpath = "";

        //On load 
        private void FirstTimeSetup_Load(object sender, EventArgs e)
        {
           
        }

        //if the "X" is clicked this warning message wil show
        private void FirstTimeSetup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("If you leave now, the application will not be fully setup and will not work as expected." + "\n" + "\n" + "Are you sure you still want to quit setup",
                               "Unfinished Setup Warning",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.No)
            {
                // e.Cancel = true;
            }
        }

     
        //If continue button is clicked the next step in first time setup will occure
        private void continuebutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            Environment.SpecialFolder root = FBD.RootFolder;
            FBD.ShowNewFolderButton = false;
            FBD.Description = "Please choose your Flash game folder";
            

            // Show the FolderBrowserDialog to chose Flash Game Folder                                                                                                                                                                                                                                                                                                                                                                                    

            DialogResult result = FBD.ShowDialog();

            //If user choses folder and clicks OK do this
            if (result == DialogResult.OK)

            {
                //Check to make sure folder contains flash game files
                if (Directory.GetFiles(FBD.SelectedPath, "*.swf").Length == 0)
                {

                    //If NO matching *.swf files error message will show
                    if (MessageBox.Show("Selected folder has no Flash Games in it (.swf), Please choose another folder.",
                               "No .swf files.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        // e.Cancel = true;
                    }
                }
                else
                {
                    //If the folder selection has matching *.swf files next step
                    gamefolderpath = FBD.SelectedPath;

                    //testing purposes 
                    // MessageBox.Show(gamefolderpath);

                    //take gamefolderpath make it is giving path and take the filenames only from it for 1st array and then path in secound array
                    //Getting file names

                    //loops through given game folder and displays game paths
                        string[] array1 = Directory.GetFiles(@"C:\Users\chast\Desktop\New folder", "*.swf");
                    foreach (string swf in array1)

                    {
                        listView1.Items.Add(Path.GetFileName(swf));
                        //trying to make work
                       // ListViewItem row = new ListViewItem();
                       // row.SubItems.Add(swf.ToString());
                       // listView1.Items.Add(row);
                        //end of trying to make work
                        listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }

                        //loops through given game folder and displays game paths
                     /*   string[] array2 = Directory.GetFiles(@"C:\Users\chast\Desktop\New folder", "*.swf");
                    foreach (string swf in array2)
                    {
                        listView1.Items.Add(swf.ToString());
                        listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }*/
                                                       
                }



            }//End If Dialog result is OK
        }
    }
}
