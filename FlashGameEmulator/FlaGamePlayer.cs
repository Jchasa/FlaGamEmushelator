using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashGameEmulator
{
    public partial class FlaGamePlayer : Form
    {
        private Process process;

        public FlaGamePlayer()
        {
            InitializeComponent();
        }

        public string gamefolderpath;

        public FlaGamePlayer(Process process)
        {
            this.process = process;
        }
        // String to catch the currently selected game to play from main form
        public string CurrentGame { get; set; }

        //Passes to the Flash Player
        private void SWFPFlaGamePlayer_Load(object sender, EventArgs e)
        {
            axShockwaveFlash1.LoadMovie(0, CurrentGame);
            axShockwaveFlash1.Play();
        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {
                    
    }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File Dialog to choose flash game
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Cursor Files|*.swf";
            openFileDialog1.Title = "Select a Game";

            //If the OFD OK button is press the following will happen
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                String SWFgame = openFileDialog1.FileName;
                axShockwaveFlash1.LoadMovie(0, SWFgame);
                axShockwaveFlash1.Play();

               // MessageBox.Show(SWFgame);

            }
        }
    }
}
