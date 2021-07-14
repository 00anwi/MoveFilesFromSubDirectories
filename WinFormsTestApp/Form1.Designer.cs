
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // TB_SourceDirectory
            // 
            this.TB_SourceDirectory.Location = new System.Drawing.Point(129, 25);
            this.TB_SourceDirectory.Name = "TB_SourceDirectory";
            this.TB_SourceDirectory.Size = new System.Drawing.Size(383, 23);
            this.TB_SourceDirectory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Directory:";
            // 
            // BTN_Run
            // 
            this.BTN_Run.Location = new System.Drawing.Point(356, 95);
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
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Move Directory:";
            // 
            // TB_MoveDirectory
            // 
            this.TB_MoveDirectory.Location = new System.Drawing.Point(129, 54);
            this.TB_MoveDirectory.Name = "TB_MoveDirectory";
            this.TB_MoveDirectory.Size = new System.Drawing.Size(383, 23);
            this.TB_MoveDirectory.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 112);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(338, 23);
            this.progressBar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 177);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_MoveDirectory);
            this.Controls.Add(this.BTN_Run);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_SourceDirectory);
            this.Name = "Form1";
            this.Text = "Flytta Filer App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.TextBox TB_SourceDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Run;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_MoveDirectory;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

