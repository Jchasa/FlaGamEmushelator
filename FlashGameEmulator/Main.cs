using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashGameEmulator
{
    public partial class Main : Form
    {
        //sets directory for flash game directory in app data
        string rootDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FlaGamEmushelator";

        

        public Main()
        {
            InitializeComponent();
        }
      
        //attempt to access info outside of button press
        FolderBrowserDialog fbd = new FolderBrowserDialog();
    
    //Browse to game path Button
    private void flashgamespathbutton_Click(object sender, EventArgs e)
        {

            //If the FBD OK button is press the following will happen
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                flashgamespathtextBox.Text = fbd.SelectedPath;
                string foldername = fbd.SelectedPath;
                foreach (string f in Directory.GetFiles(foldername))
                 this.main1listBox.Items.Add(Path.GetFileNameWithoutExtension(f));


            }
        }
        //Save Game Path Button
        private void flashgamespathbuttonS_Click(object sender, EventArgs e)
        {
            //Saves Flash Game Directory to AppData in Text File
            if (!Directory.Exists(rootDirectory)) { Directory.CreateDirectory(rootDirectory);  }

            using (StreamWriter sw = new StreamWriter(rootDirectory + "\\FlashGameDirectory.txt"))
            {
                sw.WriteLine(flashgamespathtextBox.Text);
            }
            MessageBox.Show("Directory Saved", "Directory Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //On form load
        private void Main_Load(object sender, EventArgs e)
        {

            //Check if file isn there and then creates it 
            if (!File.Exists(rootDirectory + "\\FlashGameDirectory.txt"))
            {
                FileStream fs = File.Create(rootDirectory + "\\FlashGameDirectory.txt");
            }
           
            //Reads txt file to txt box
            using (StreamReader sr = new StreamReader(rootDirectory + "\\FlashGameDirectory.txt"))
                {
                    flashgamespathtextBox.Text = sr.ReadLine();
                }
            
        }
    }
}
