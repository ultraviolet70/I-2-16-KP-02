namespace Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScreen));
            this.progressBarScreen = new System.Windows.Forms.ProgressBar();
            this.labelScreen = new System.Windows.Forms.Label();
            this.timerScreen = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarScreen
            // 
            this.progressBarScreen.ForeColor = System.Drawing.SystemColors.Info;
            this.progressBarScreen.Location = new System.Drawing.Point(69, 328);
            this.progressBarScreen.Name = "progressBarScreen";
            this.progressBarScreen.Size = new System.Drawing.Size(692, 31);
            this.progressBarScreen.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarScreen.TabIndex = 1;
            this.progressBarScreen.UseWaitCursor = true;
            // 
            // labelScreen
            // 
            this.labelScreen.AutoSize = true;
            this.labelScreen.Font = new System.Drawing.Font("Verdana", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(178)))), ((int)(((byte)(80)))));
            this.labelScreen.Location = new System.Drawing.Point(82, 25);
            this.labelScreen.Name = "labelScreen";
            this.labelScreen.Size = new System.Drawing.Size(667, 67);
            this.labelScreen.TabIndex = 2;
            this.labelScreen.Text = "Загрузка приложения";
            // 
            // timerScreen
            // 
            this.timerScreen.Enabled = true;
            this.timerScreen.Interval = 5000;
            this.timerScreen.Tick += new System.EventHandler(this.timerScreen_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shop.Properties.Resources.bf5647f0f2fba4595b89ec9b1497ad06;
            this.pictureBox1.Location = new System.Drawing.Point(275, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(833, 394);
            this.Controls.Add(this.labelScreen);
            this.Controls.Add(this.progressBarScreen);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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