using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using AxShockwaveFlashObjects;

namespace FlashGameEmulator
{
    public partial class Main : Form
    {
        
        
        public Main()
        {
            InitializeComponent();
        }

       

        //On form load
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                //If it is the first time running do this
                if ((bool)Properties.Settings.Default["FirstRun"] == true)
                {
                    //First application run
                    //Update setting
                    Properties.Settings.Default["FirstRun"] = false;
                    //Save setting
                    Properties.Settings.Default.Save();
                    //    Create new instance of Dialog             
                    FirstTimeSetup fts = new FirstTimeSetup();
                    //Show the dialog
                    fts.ShowDialog();

                    
                }
                else
                {
                    //Not first time of running application.
                    try
                    {
                        //database connection from my DB Class
                        OleDbConnection cn = DatabaseConnection.openConnection();

                        cn.Open();

                        checkConnection.Text = "Connection Succesful";

                        // TODO: This line of code loads data into the 'gameDBDataSet.GameData' table. You can move, or remove it, as needed.
                        this.gameDataTableAdapter.Fill(this.gameDBDataSet.GameData);

                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex);
                    }

                }

            }
            catch (Exception ex1)
            {
                MessageBox.Show("Error " + ex1);
            }

        } //End of onload

        //open game from gridview in FlaGamePlayer
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Testing with just a static game to pass to player form
            //*** game does not load - something to do with how I am passing it 
            FlaGamePlayer player = new FlaGamePlayer();
            player.CurrentGame = (@"C:\Users\chast\Desktop\1 Screen Hero.swf");
            player.Show();
            this.Hide();

            /*Process.Start(@"C:\Users\chast\Desktop\1 Screen Hero.swf");

            FlaGamePlayer fPlayer = new FlaGamePlayer(Process.Start(@"C:\Users\chast\Desktop\1 Screen Hero.swf"));
            fPlayer.Show();
            this.Hide();  */
        }

        // in Options Tab opens FlaGamePlayer without a game loaded
        private void buttonopenFGP_Click(object sender, EventArgs e)
        {
            FlaGamePlayer player = new FlaGamePlayer();
            player.Show();
        }
    }
}
