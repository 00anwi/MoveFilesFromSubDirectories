using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Run_Click(object sender, EventArgs e)
        {
            MoveFilesInSubFolderToDestination(TB_MoveDirectory.Text, TB_SourceDirectory.Text);
        }

        public void MoveFilesInSubFolderToDestination(string moveDirectory, string sourceDirectory)
        {
            var subDirectorys = Directory.GetDirectories(sourceDirectory);

            float progressPerFile = 100 / subDirectorys.Length;
            float currentProgress = 0;

            foreach (var directory in subDirectorys)
            {
                var files = Directory.GetFiles(directory);
                if (files.Length == 1)
                {
                    var moveDestination = Path.Combine(moveDirectory, new DirectoryInfo(System.IO.Path.GetDirectoryName(files[0])).Name + Path.GetExtension(files[0]));
                    File.Copy(files[0], moveDestination, true);
                }
                currentProgress += progressPerFile;

                progressBar.Value = (int)currentProgress;
                Application.DoEvents();
            }

            progressBar.Value = 100;
            Application.DoEvents();
        }
    }
}
