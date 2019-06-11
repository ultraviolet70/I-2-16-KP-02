namespace Shop
{
    partial class FormConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnection));
            this.cbIPServer = new System.Windows.Forms.ComboBox();
            this.lblServers = new System.Windows.Forms.Label();
            this.cbDataSource = new System.Windows.Forms.ComboBox();
            this.lbServer = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbInitialCatalog = new System.Windows.Forms.ComboBox();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.statusConect = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btConect = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.statusConect.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbIPServer
            // 
            this.cbIPServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbIPServer.Enabled = false;
            this.cbIPServer.FormattingEnabled = true;
            this.cbIPServer.Location = new System.Drawing.Point(0, 20);
            this.cbIPServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIPServer.Name = "cbIPServer";
            this.cbIPServer.Size = new System.Drawing.Size(431, 28);
            this.cbIPServer.TabIndex = 46;
            // 
            // lblServers
            // 
            this.lblServers.AutoSize = true;
            this.lblServers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblServers.Location = new System.Drawing.Point(0, 0);
            this.lblServers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServers.Name = "lblServers";
            this.lblServers.Size = new System.Drawing.Size(127, 20);
            this.lblServers.TabIndex = 45;
            this.lblServers.Text = "Адрес сервера:";
            // 
            // cbDataSource
            // 
            this.cbDataSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDataSource.Enabled = false;
            this.cbDataSource.FormattingEnabled = true;
            this.cbDataSource.Location = new System.Drawing.Point(0, 68);
            this.cbDataSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDataSource.Name = "cbDataSource";
            this.cbDataSource.Size = new System.Drawing.Size(431, 28);
            this.cbDataSource.TabIndex = 48;
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbServer.Location = new System.Drawing.Point(0, 48);
            this.lbServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(149, 20);
            this.lbServer.TabIndex = 47;
            this.lbServer.Text = "Название сервера";
            // 
            // tbUserID
            // 
            this.tbUserID.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUserID.Enabled = false;
            this.tbUserID.Location = new System.Drawing.Point(0, 116);
            this.tbUserID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.PasswordChar = '*';
            this.tbUserID.Size = new System.Drawing.Size(431, 26);
            this.tbUserID.TabIndex = 50;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsers.Location = new System.Drawing.Point(0, 96);
            this.lblUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(191, 20);
            this.lblUsers.TabIndex = 49;
            this.lblUsers.Text = "Пользователь сервера:";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(0, 162);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(431, 26);
            this.tbPassword.TabIndex = 52;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPassword.Location = new System.Drawing.Point(0, 142);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(184, 20);
            this.lblPassword.TabIndex = 51;
            this.lblPassword.Text = "Пароль пользователя:";
            // 
            // cbInitialCatalog
            // 
            this.cbInitialCatalog.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbInitialCatalog.Enabled = false;
            this.cbInitialCatalog.FormattingEnabled = true;
            this.cbInitialCatalog.Location = new System.Drawing.Point(0, 208);
            this.cbInitialCatalog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbInitialCatalog.Name = "cbInitialCatalog";
            this.cbInitialCatalog.Size = new System.Drawing.Size(431, 28);
            this.cbInitialCatalog.TabIndex = 54;
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDataSource.Location = new System.Drawing.Point(0, 188);
            this.lblDataSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(219, 20);
            this.lblDataSource.TabIndex = 53;
            this.lblDataSource.Text = "Список источников данных:";
            // 
            // statusConect
            // 
            this.statusConect.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusConect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusConect.Location = new System.Drawing.Point(0, 350);
            this.statusConect.Name = "statusConect";
            this.statusConect.Size = new System.Drawing.Size(431, 30);
            this.statusConect.TabIndex = 57;
            this.statusConect.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(19, 25);
            this.tsslStatus.Text = "-";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btConect);
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.btCheck);
            this.panel1.Location = new System.Drawing.Point(0, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 53);
            this.panel1.TabIndex = 58;
            // 
            // btConect
            // 
            this.btConect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btConect.Enabled = false;
            this.btConect.Location = new System.Drawing.Point(112, 0);
            this.btConect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btConect.Name = "btConect";
            this.btConect.Size = new System.Drawing.Size(207, 53);
            this.btConect.TabIndex = 19;
            this.btConect.Text = "Подключить";
            this.btConect.UseVisualStyleBackColor = true;
            this.btConect.Click += new System.EventHandler(this.btConect_Click);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Location = new System.Drawing.Point(319, 0);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(112, 53);
            this.btCancel.TabIndex = 18;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCheck
            // 
            this.btCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.btCheck.Enabled = false;
            this.btCheck.Location = new System.Drawing.Point(0, 0);
            this.btCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(112, 53);
            this.btCheck.TabIndex = 17;
            this.btCheck.Text = "Проверка";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // FormConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 380);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusConect);
            this.Controls.Add(this.cbInitialCatalog);
            this.Controls.Add(this.lblDataSource);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.cbDataSource);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.cbIPServer);
            this.Controls.Add(this.lblServers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подлючение";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConnection_FormClosing);
            this.Load += new System.EventHandler(this.FormConnection_Load);
            this.statusConect.ResumeLayout(false);
            this.statusConect.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIPServer;
        private System.Windows.Forms.Label lblServers;
        private System.Windows.Forms.ComboBox cbDataSource;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cbInitialCatalog;
        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.StatusStrip statusConect;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btConect;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCheck;
    }
}