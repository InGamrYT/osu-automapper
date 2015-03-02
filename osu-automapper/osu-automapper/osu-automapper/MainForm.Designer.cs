﻿namespace osu_automapper
{
    partial class MainForm
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
            this.loadMP3Button = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openOSUFile = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.waveViewer1 = new NAudio.Gui.WaveViewer();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadMP3Button
            // 
            this.loadMP3Button.BackColor = System.Drawing.Color.White;
            this.loadMP3Button.Location = new System.Drawing.Point(14, 5);
            this.loadMP3Button.Margin = new System.Windows.Forms.Padding(5);
            this.loadMP3Button.Name = "loadMP3Button";
            this.loadMP3Button.Size = new System.Drawing.Size(313, 37);
            this.loadMP3Button.TabIndex = 0;
            this.loadMP3Button.Text = "Open MP3 File";
            this.loadMP3Button.UseVisualStyleBackColor = false;
            this.loadMP3Button.Click += new System.EventHandler(this.openMP3Button_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.White;
            this.pauseButton.Location = new System.Drawing.Point(14, 52);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(5);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(313, 38);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause/Play MP3";
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openOSUFile
            // 
            this.openOSUFile.BackColor = System.Drawing.Color.White;
            this.openOSUFile.Location = new System.Drawing.Point(14, 100);
            this.openOSUFile.Margin = new System.Windows.Forms.Padding(5);
            this.openOSUFile.Name = "openOSUFile";
            this.openOSUFile.Size = new System.Drawing.Size(313, 34);
            this.openOSUFile.TabIndex = 2;
            this.openOSUFile.Text = "[DEBUG] Open .osu File";
            this.openOSUFile.UseVisualStyleBackColor = false;
            this.openOSUFile.Click += new System.EventHandler(this.openOSUFile_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.waveViewer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.openOSUFile);
            this.splitContainer1.Panel2.Controls.Add(this.loadMP3Button);
            this.splitContainer1.Panel2.Controls.Add(this.pauseButton);
            this.splitContainer1.Size = new System.Drawing.Size(1052, 318);
            this.splitContainer1.SplitterDistance = 157;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // waveViewer1
            // 
            this.waveViewer1.Location = new System.Drawing.Point(0, 0);
            this.waveViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.waveViewer1.Name = "waveViewer1";
            this.waveViewer1.SamplesPerPixel = 128;
            this.waveViewer1.Size = new System.Drawing.Size(1052, 157);
            this.waveViewer1.StartPosition = ((long)(0));
            this.waveViewer1.TabIndex = 0;
            this.waveViewer1.WaveStream = null;
            this.waveViewer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.waveViewer1_MouseDown);
            this.waveViewer1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.waveViewer1_MouseMove);
            this.waveViewer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.waveViewer1_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1052, 318);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Tutorial 10";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadMP3Button;
        private System.Windows.Forms.Button pauseButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button openOSUFile;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private NAudio.Gui.WaveViewer waveViewer1;

    }
}
