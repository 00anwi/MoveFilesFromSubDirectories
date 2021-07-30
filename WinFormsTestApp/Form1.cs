using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
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


        private void Form1_Load(object sender, EventArgs e)
        {
            LBL_CurrentFileProgress.Text = "";
            LBL_TotalProgress.Text = "";
            FileCopyProgress += Form1_FileCopyProgress;
        }

        private void Form1_FileCopyProgress(int Int)
        {
            progressBarCurrent.Value = Int;
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

            var TotalProgress = 1;
            foreach (var directory in subDirectorys)
            {
                var files = Directory.GetFiles(directory);
                if (files.Length == 1 && new FileInfo(files[0]).Length > 1000)
                {
                    var moveDestination = Path.Combine(moveDirectory, new DirectoryInfo(System.IO.Path.GetDirectoryName(files[0])).Name + Path.GetExtension(files[0]));
                    LBL_CurrentFileProgress.Text = $"{Path.GetFileName(moveDestination)}";
                    Application.DoEvents();
                    FileDownloadComplete = false;
                    CopyFileWithProgress(files[0], moveDestination);
                    while (FileDownloadComplete == false)
                    {
                        Application.DoEvents();
                    }
                }
                currentProgress += progressPerFile;

                progressBarTotal.Value = (int)currentProgress;
                LBL_TotalProgress.Text = $"{TotalProgress} of {subDirectorys.Length}";
                TotalProgress++;
                Application.DoEvents();
            }


            progressBarTotal.Value = 100;
            Application.DoEvents();

            MessageBox.Show("Move Files Complete!!!");
        }

        static bool FileDownloadComplete = false;

        public delegate void IntDelegate(int Int);

        public static event IntDelegate FileCopyProgress;
        public static void CopyFileWithProgress(string source, string destination)
        {
            var webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgress;
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
            webClient.DownloadFileAsync(new Uri(source), destination);
        }

        private static void WebClient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            FileDownloadComplete = true;
        }

        private static void DownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            if (FileCopyProgress != null)
            {
                FileCopyProgress(e.ProgressPercentage);
            }
        }

    }
}
