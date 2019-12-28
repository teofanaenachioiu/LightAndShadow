using System;
using System.Windows.Forms;

namespace LightAndShadow
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.metroTrackBarAmbientRed = new MetroFramework.Controls.MetroTrackBar();
            this.metroTrackBarAmbientGreen = new MetroFramework.Controls.MetroTrackBar();
            this.metroTrackBarAmbientBlue = new MetroFramework.Controls.MetroTrackBar();
            this.metroTrackBarDifusseRed = new MetroFramework.Controls.MetroTrackBar();
            this.metroTrackBarDifusseGreen = new MetroFramework.Controls.MetroTrackBar();
            this.metroTrackBarDifusseBlue = new MetroFramework.Controls.MetroTrackBar();
            this.metroTrackBarSpecularRed = new MetroFramework.Controls.MetroTrackBar();
            this.metroTrackBarSpecularGreen = new MetroFramework.Controls.MetroTrackBar();
            this.metroTrackBarSpecularBlue = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelLight = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxXL = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxYL = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxZL = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxXV = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxYV = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxZV = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonLight = new MetroFramework.Controls.MetroButton();
            this.metroButtonViewer = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroTrackBarAmbientRed
            // 
            this.metroTrackBarAmbientRed.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBarAmbientRed.Location = new System.Drawing.Point(105, 399);
            this.metroTrackBarAmbientRed.Maximum = 255;
            this.metroTrackBarAmbientRed.Name = "metroTrackBarAmbientRed";
            this.metroTrackBarAmbientRed.Size = new System.Drawing.Size(75, 23);
            this.metroTrackBarAmbientRed.TabIndex = 3;
            this.metroTrackBarAmbientRed.Text = "trackBarAmbientRed";
            this.metroTrackBarAmbientRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBarAmbientRed_Scroll);
            // 
            // metroTrackBarAmbientGreen
            // 
            this.metroTrackBarAmbientGreen.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBarAmbientGreen.Location = new System.Drawing.Point(105, 442);
            this.metroTrackBarAmbientGreen.Maximum = 255;
            this.metroTrackBarAmbientGreen.Name = "metroTrackBarAmbientGreen";
            this.metroTrackBarAmbientGreen.Size = new System.Drawing.Size(75, 23);
            this.metroTrackBarAmbientGreen.TabIndex = 4;
            this.metroTrackBarAmbientGreen.Text = "trackBarAmbientGreen";
            this.metroTrackBarAmbientGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBarAmbientGreen_Scroll);
            // 
            // metroTrackBarAmbientBlue
            // 
            this.metroTrackBarAmbientBlue.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBarAmbientBlue.Location = new System.Drawing.Point(105, 481);
            this.metroTrackBarAmbientBlue.Maximum = 255;
            this.metroTrackBarAmbientBlue.Name = "metroTrackBarAmbientBlue";
            this.metroTrackBarAmbientBlue.Size = new System.Drawing.Size(75, 23);
            this.metroTrackBarAmbientBlue.TabIndex = 5;
            this.metroTrackBarAmbientBlue.Text = "trackBarAmbientBlue";
            this.metroTrackBarAmbientBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBarAmbientBlue_Scroll);
            // 
            // metroTrackBarDifusseRed
            // 
            this.metroTrackBarDifusseRed.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBarDifusseRed.Location = new System.Drawing.Point(245, 399);
            this.metroTrackBarDifusseRed.Maximum = 255;
            this.metroTrackBarDifusseRed.Name = "metroTrackBarDifusseRed";
            this.metroTrackBarDifusseRed.Size = new System.Drawing.Size(75, 23);
            this.metroTrackBarDifusseRed.TabIndex = 6;
            this.metroTrackBarDifusseRed.Text = "metroTrackBar1";
            this.metroTrackBarDifusseRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBarDifusseRed_Scroll);
            // 
            // metroTrackBarDifusseGreen
            // 
            this.metroTrackBarDifusseGreen.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBarDifusseGreen.Location = new System.Drawing.Point(245, 442);
            this.metroTrackBarDifusseGreen.Maximum = 255;
            this.metroTrackBarDifusseGreen.Name = "metroTrackBarDifusseGreen";
            this.metroTrackBarDifusseGreen.Size = new System.Drawing.Size(75, 23);
            this.metroTrackBarDifusseGreen.TabIndex = 7;
            this.metroTrackBarDifusseGreen.Text = "metroTrackBar1";
            this.metroTrackBarDifusseGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBarDifusseGreen_Scroll);
            // 
            // metroTrackBarDifusseBlue
            // 
            this.metroTrackBarDifusseBlue.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBarDifusseBlue.Location = new System.Drawing.Point(245, 481);
            this.metroTrackBarDifusseBlue.Maximum = 255;
            this.metroTrackBarDifusseBlue.Name = "metroTrackBarDifusseBlue";
            this.metroTrackBarDifusseBlue.Size = new System.Drawing.Size(75, 23);
            this.metroTrackBarDifusseBlue.TabIndex = 8;
            this.metroTrackBarDifusseBlue.Text = "metroTrackBar1";
            this.metroTrackBarDifusseBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBarDifusseBlue_Scroll);
            // 
            // metroTrackBarSpecularRed
            // 
            this.metroTrackBarSpecularRed.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBarSpecularRed.Location = new System.Drawing.Point(382, 399);
            this.metroTrackBarSpecularRed.Maximum = 255;
            this.metroTrackBarSpecularRed.Name = "metroTrackBarSpecularRed";
            this.metroTrackBarSpecularRed.Size = new System.Drawing.Size(75, 23);
            this.metroTrackBarSpecularRed.TabIndex = 9;
            this.metroTrackBarSpecularRed.Text = "metroTrackBar1";
            this.metroTrackBarSpecularRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBarSpecularRed_Scroll);
            // 
            // metroTrackBarSpecularGreen
            // 
            this.metroTrackBarSpecularGreen.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBarSpecularGreen.Location = new System.Drawing.Point(382, 442);
            this.metroTrackBarSpecularGreen.Maximum = 255;
            this.metroTrackBarSpecularGreen.Name = "metroTrackBarSpecularGreen";
            this.metroTrackBarSpecularGreen.Size = new System.Drawing.Size(75, 23);
            this.metroTrackBarSpecularGreen.TabIndex = 10;
            this.metroTrackBarSpecularGreen.Text = "metroTrackBar1";
            this.metroTrackBarSpecularGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBarSpecularGreen_Scroll);
            // 
            // metroTrackBarSpecularBlue
            // 
            this.metroTrackBarSpecularBlue.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBarSpecularBlue.Location = new System.Drawing.Point(382, 481);
            this.metroTrackBarSpecularBlue.Maximum = 255;
            this.metroTrackBarSpecularBlue.Name = "metroTrackBarSpecularBlue";
            this.metroTrackBarSpecularBlue.Size = new System.Drawing.Size(75, 23);
            this.metroTrackBarSpecularBlue.TabIndex = 11;
            this.metroTrackBarSpecularBlue.Text = "metroTrackBar1";
            this.metroTrackBarSpecularBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBarSpecularBlue_Scroll);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(105, 359);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Ambiant Light";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(245, 360);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Difusse Light";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(382, 359);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Specular Light";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(64, 403);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(32, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Red";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(50, 442);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Green";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(60, 485);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(34, 19);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Blue";
            // 
            // metroLabelLight
            // 
            this.metroLabelLight.AutoSize = true;
            this.metroLabelLight.Location = new System.Drawing.Point(346, 83);
            this.metroLabelLight.Name = "metroLabelLight";
            this.metroLabelLight.Size = new System.Drawing.Size(86, 19);
            this.metroLabelLight.TabIndex = 22;
            this.metroLabelLight.Text = "Light Position";
            // 
            // metroTextBoxXL
            // 
            this.metroTextBoxXL.Location = new System.Drawing.Point(371, 128);
            this.metroTextBoxXL.Name = "metroTextBoxXL";
            this.metroTextBoxXL.Size = new System.Drawing.Size(30, 23);
            this.metroTextBoxXL.TabIndex = 23;
            // 
            // metroTextBoxYL
            // 
            this.metroTextBoxYL.Location = new System.Drawing.Point(371, 174);
            this.metroTextBoxYL.Name = "metroTextBoxYL";
            this.metroTextBoxYL.Size = new System.Drawing.Size(30, 23);
            this.metroTextBoxYL.TabIndex = 24;
            // 
            // metroTextBoxZL
            // 
            this.metroTextBoxZL.Location = new System.Drawing.Point(371, 216);
            this.metroTextBoxZL.Name = "metroTextBoxZL";
            this.metroTextBoxZL.Size = new System.Drawing.Size(30, 23);
            this.metroTextBoxZL.TabIndex = 25;
            // 
            // metroTextBoxXV
            // 
            this.metroTextBoxXV.Location = new System.Drawing.Point(469, 128);
            this.metroTextBoxXV.Name = "metroTextBoxXV";
            this.metroTextBoxXV.Size = new System.Drawing.Size(30, 23);
            this.metroTextBoxXV.TabIndex = 26;
            // 
            // metroTextBoxYV
            // 
            this.metroTextBoxYV.Location = new System.Drawing.Point(469, 174);
            this.metroTextBoxYV.Name = "metroTextBoxYV";
            this.metroTextBoxYV.Size = new System.Drawing.Size(30, 23);
            this.metroTextBoxYV.TabIndex = 27;
            // 
            // metroTextBoxZV
            // 
            this.metroTextBoxZV.Location = new System.Drawing.Point(469, 216);
            this.metroTextBoxZV.Name = "metroTextBoxZV";
            this.metroTextBoxZV.Size = new System.Drawing.Size(30, 23);
            this.metroTextBoxZV.TabIndex = 28;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(438, 83);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(97, 19);
            this.metroLabel7.TabIndex = 29;
            this.metroLabel7.Text = "Viewer Position";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(346, 128);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(17, 19);
            this.metroLabel8.TabIndex = 30;
            this.metroLabel8.Text = "X";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(346, 174);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(17, 19);
            this.metroLabel9.TabIndex = 31;
            this.metroLabel9.Text = "Y";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(346, 216);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(17, 19);
            this.metroLabel10.TabIndex = 32;
            this.metroLabel10.Text = "Z";
            // 
            // metroButtonLight
            // 
            this.metroButtonLight.Location = new System.Drawing.Point(360, 261);
            this.metroButtonLight.Name = "metroButtonLight";
            this.metroButtonLight.Size = new System.Drawing.Size(50, 23);
            this.metroButtonLight.TabIndex = 33;
            this.metroButtonLight.Text = "Apply";
            this.metroButtonLight.Click += new System.EventHandler(this.metroButtonLight_Click);
            // 
            // metroButtonViewer
            // 
            this.metroButtonViewer.Location = new System.Drawing.Point(460, 261);
            this.metroButtonViewer.Name = "metroButtonViewer";
            this.metroButtonViewer.Size = new System.Drawing.Size(50, 23);
            this.metroButtonViewer.TabIndex = 34;
            this.metroButtonViewer.Text = "Apply";
            this.metroButtonViewer.Click += new System.EventHandler(this.metroButtonViewer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 533);
            this.Controls.Add(this.metroButtonViewer);
            this.Controls.Add(this.metroButtonLight);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroTextBoxZV);
            this.Controls.Add(this.metroTextBoxYV);
            this.Controls.Add(this.metroTextBoxXV);
            this.Controls.Add(this.metroTextBoxZL);
            this.Controls.Add(this.metroTextBoxYL);
            this.Controls.Add(this.metroTextBoxXL);
            this.Controls.Add(this.metroLabelLight);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTrackBarSpecularBlue);
            this.Controls.Add(this.metroTrackBarSpecularGreen);
            this.Controls.Add(this.metroTrackBarSpecularRed);
            this.Controls.Add(this.metroTrackBarDifusseBlue);
            this.Controls.Add(this.metroTrackBarDifusseGreen);
            this.Controls.Add(this.metroTrackBarDifusseRed);
            this.Controls.Add(this.metroTrackBarAmbientBlue);
            this.Controls.Add(this.metroTrackBarAmbientGreen);
            this.Controls.Add(this.metroTrackBarAmbientRed);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Phong Model";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ColorDialog colorDialog1;
        private MetroFramework.Controls.MetroTrackBar metroTrackBarAmbientRed;
        private MetroFramework.Controls.MetroTrackBar metroTrackBarAmbientGreen;
        private MetroFramework.Controls.MetroTrackBar metroTrackBarAmbientBlue;
        private MetroFramework.Controls.MetroTrackBar metroTrackBarDifusseRed;
        private MetroFramework.Controls.MetroTrackBar metroTrackBarDifusseGreen;
        private MetroFramework.Controls.MetroTrackBar metroTrackBarDifusseBlue;
        private MetroFramework.Controls.MetroTrackBar metroTrackBarSpecularRed;
        private MetroFramework.Controls.MetroTrackBar metroTrackBarSpecularGreen;
        private MetroFramework.Controls.MetroTrackBar metroTrackBarSpecularBlue;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabelLight;
        private MetroFramework.Controls.MetroTextBox metroTextBoxXL;
        private MetroFramework.Controls.MetroTextBox metroTextBoxYL;
        private MetroFramework.Controls.MetroTextBox metroTextBoxZL;
        private MetroFramework.Controls.MetroTextBox metroTextBoxXV;
        private MetroFramework.Controls.MetroTextBox metroTextBoxYV;
        private MetroFramework.Controls.MetroTextBox metroTextBoxZV;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton metroButtonLight;
        private MetroFramework.Controls.MetroButton metroButtonViewer;
    }
}

