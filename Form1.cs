using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        private void Developed_Click(object sender, EventArgs e)
        {

        }
        //Create global variable of string type array to save titles or nam of the track and their paths
        string[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //cde to select the sound
            OpenFileDialog ofd = new OpenFileDialog();
            //code to select multiplefiles
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save name of the path to file array
                paths = ofd.FileNames; // save path of the file to path array
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]);

                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code to play music
            axWindowsMediaPlayer2.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //code to close App
            this.Close();
        }
    }
}
