
using System.IO;

namespace WinFormsTestApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_SourceDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Run = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_MoveDirectory = new System.Windows.Forms.TextBox();
            this.progressBarTotal = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarCurrent = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_CurrentFileProgress = new System.Windows.Forms.Label();
            this.LBL_TotalProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_SourceDirectory
            // 
            this.TB_SourceDirectory.Location = new System.Drawing.Point(129, 15);
            this.TB_SourceDirectory.Name = "TB_SourceDirectory";
            this.TB_SourceDirectory.Size = new System.Drawing.Size(383, 23);
            this.TB_SourceDirectory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Directory:";
            // 
            // BTN_Run
            // 
            this.BTN_Run.Location = new System.Drawing.Point(360, 100);
            this.BTN_Run.Name = "BTN_Run";
            this.BTN_Run.Size = new System.Drawing.Size(156, 65);
            this.BTN_Run.TabIndex = 2;
            this.BTN_Run.Text = "Move Files";
            this.BTN_Run.UseVisualStyleBackColor = true;
            this.BTN_Run.Click += new System.EventHandler(this.BTN_Run_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Move Directory:";
            // 
            // TB_MoveDirectory
            // 
            this.TB_MoveDirectory.Location = new System.Drawing.Point(129, 44);
            this.TB_MoveDirectory.Name = "TB_MoveDirectory";
            this.TB_MoveDirectory.Size = new System.Drawing.Size(383, 23);
            this.TB_MoveDirectory.TabIndex = 3;
            // 
            // progressBarTotal
            // 
            this.progressBarTotal.Location = new System.Drawing.Point(12, 142);
            this.progressBarTotal.Name = "progressBarTotal";
            this.progressBarTotal.Size = new System.Drawing.Size(338, 23);
            this.progressBarTotal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Progress: ";
            // 
            // progressBarCurrent
            // 
            this.progressBarCurrent.Location = new System.Drawing.Point(12, 99);
            this.progressBarCurrent.Name = "progressBarCurrent";
            this.progressBarCurrent.Size = new System.Drawing.Size(338, 23);
            this.progressBarCurrent.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current File Progress:";
            // 
            // LBL_CurrentFileProgress
            // 
            this.LBL_CurrentFileProgress.AutoSize = true;
            this.LBL_CurrentFileProgress.Location = new System.Drawing.Point(138, 81);
            this.LBL_CurrentFileProgress.Name = "LBL_CurrentFileProgress";
            this.LBL_CurrentFileProgress.Size = new System.Drawing.Size(38, 15);
            this.LBL_CurrentFileProgress.TabIndex = 9;
            this.LBL_CurrentFileProgress.Text = "label5";
            // 
            // LBL_TotalProgress
            // 
            this.LBL_TotalProgress.AutoSize = true;
            this.LBL_TotalProgress.Location = new System.Drawing.Point(104, 125);
            this.LBL_TotalProgress.Name = "LBL_TotalProgress";
            this.LBL_TotalProgress.Size = new System.Drawing.Size(38, 15);
            this.LBL_TotalProgress.TabIndex = 10;
            this.LBL_TotalProgress.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 177);
            this.Controls.Add(this.LBL_TotalProgress);
            this.Controls.Add(this.LBL_CurrentFileProgress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBarCurrent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBarTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_MoveDirectory);
            this.Controls.Add(this.BTN_Run);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_SourceDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Flytta Filer App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.TextBox TB_SourceDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Run;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_MoveDirectory;
        private System.Windows.Forms.ProgressBar progressBarTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBarCurrent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_CurrentFileProgress;
        private System.Windows.Forms.Label LBL_TotalProgress;
    }
}

