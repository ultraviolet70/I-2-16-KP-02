﻿namespace Shop
{
    partial class FormScreen
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBarScreen = new System.Windows.Forms.ProgressBar();
            this.labelScreen = new System.Windows.Forms.Label();
            this.timerScreen = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shop.Properties.Resources.bf5647f0f2fba4595b89ec9b1497ad06;
            this.pictureBox1.Location = new System.Drawing.Point(175, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBarScreen
            // 
            this.progressBarScreen.Location = new System.Drawing.Point(36, 390);
            this.progressBarScreen.Name = "progressBarScreen";
            this.progressBarScreen.Size = new System.Drawing.Size(620, 31);
            this.progressBarScreen.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarScreen.TabIndex = 1;
            this.progressBarScreen.UseWaitCursor = true;
            // 
            // labelScreen
            // 
            this.labelScreen.AutoSize = true;
            this.labelScreen.Font = new System.Drawing.Font("Verdana", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(178)))), ((int)(((byte)(80)))));
            this.labelScreen.Location = new System.Drawing.Point(12, 9);
            this.labelScreen.Name = "labelScreen";
            this.labelScreen.Size = new System.Drawing.Size(667, 67);
            this.labelScreen.TabIndex = 2;
            this.labelScreen.Text = "Загрузка приложения";
            // 
            // timerScreen
            // 
            this.timerScreen.Enabled = true;
            this.timerScreen.Interval = 1;
            this.timerScreen.Tick += new System.EventHandler(this.timerScreen_Tick);
            // 
            // FormScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.labelScreen);
            this.Controls.Add(this.progressBarScreen);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBarScreen;
        private System.Windows.Forms.Label labelScreen;
        private System.Windows.Forms.Timer timerScreen;
    }
}