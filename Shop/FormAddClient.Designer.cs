namespace Shop
{
    partial class FormAddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddClient));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSurnameClient = new System.Windows.Forms.TextBox();
            this.textBoxNameClient = new System.Windows.Forms.TextBox();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.cueTextBoxEmailClient = new CueTextBox();
            this.cueTextBoxPhoneClient = new CueTextBox();
            this.cueTextBoxMiddleNameClient = new CueTextBox();
            this.buttonDelClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия клиента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.label2.Location = new System.Drawing.Point(40, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя клиента:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.label3.Location = new System.Drawing.Point(40, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество клиента:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.label4.Location = new System.Drawing.Point(40, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Контактный телефон:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.label5.Location = new System.Drawing.Point(40, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Электронная почта:";
            // 
            // textBoxSurnameClient
            // 
            this.textBoxSurnameClient.Location = new System.Drawing.Point(267, 46);
            this.textBoxSurnameClient.Name = "textBoxSurnameClient";
            this.textBoxSurnameClient.Size = new System.Drawing.Size(305, 26);
            this.textBoxSurnameClient.TabIndex = 5;
            // 
            // textBoxNameClient
            // 
            this.textBoxNameClient.Location = new System.Drawing.Point(267, 108);
            this.textBoxNameClient.Name = "textBoxNameClient";
            this.textBoxNameClient.Size = new System.Drawing.Size(305, 26);
            this.textBoxNameClient.TabIndex = 6;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.buttonAddClient.Location = new System.Drawing.Point(43, 349);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(121, 33);
            this.buttonAddClient.TabIndex = 12;
            this.buttonAddClient.Text = "Добавить";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvClient.BackgroundColor = System.Drawing.Color.White;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(26, 403);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowTemplate.Height = 28;
            this.dgvClient.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClient.Size = new System.Drawing.Size(910, 251);
            this.dgvClient.TabIndex = 16;
            // 
            // cueTextBoxEmailClient
            // 
            this.cueTextBoxEmailClient.Cue = "name@gmail.com";
            this.cueTextBoxEmailClient.Location = new System.Drawing.Point(267, 300);
            this.cueTextBoxEmailClient.Name = "cueTextBoxEmailClient";
            this.cueTextBoxEmailClient.Size = new System.Drawing.Size(305, 26);
            this.cueTextBoxEmailClient.TabIndex = 15;
            // 
            // cueTextBoxPhoneClient
            // 
            this.cueTextBoxPhoneClient.Cue = "+7(987)-879-64-87";
            this.cueTextBoxPhoneClient.Location = new System.Drawing.Point(267, 234);
            this.cueTextBoxPhoneClient.Name = "cueTextBoxPhoneClient";
            this.cueTextBoxPhoneClient.Size = new System.Drawing.Size(305, 26);
            this.cueTextBoxPhoneClient.TabIndex = 13;
            // 
            // cueTextBoxMiddleNameClient
            // 
            this.cueTextBoxMiddleNameClient.Cue = "(не обязательно)";
            this.cueTextBoxMiddleNameClient.Location = new System.Drawing.Point(267, 173);
            this.cueTextBoxMiddleNameClient.Name = "cueTextBoxMiddleNameClient";
            this.cueTextBoxMiddleNameClient.Size = new System.Drawing.Size(305, 26);
            this.cueTextBoxMiddleNameClient.TabIndex = 11;
            // 
            // buttonDelClient
            // 
            this.buttonDelClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.buttonDelClient.Location = new System.Drawing.Point(210, 349);
            this.buttonDelClient.Name = "buttonDelClient";
            this.buttonDelClient.Size = new System.Drawing.Size(121, 33);
            this.buttonDelClient.TabIndex = 17;
            this.buttonDelClient.Text = "Удалить";
            this.buttonDelClient.UseVisualStyleBackColor = true;
            this.buttonDelClient.Click += new System.EventHandler(this.buttonDelClient_Click);
            // 
            // FormAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 666);
            this.Controls.Add(this.buttonDelClient);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.cueTextBoxEmailClient);
            this.Controls.Add(this.cueTextBoxPhoneClient);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.cueTextBoxMiddleNameClient);
            this.Controls.Add(this.textBoxNameClient);
            this.Controls.Add(this.textBoxSurnameClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить клиента";
            this.Load += new System.EventHandler(this.AddClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSurnameClient;
        private System.Windows.Forms.TextBox textBoxNameClient;
        private CueTextBox cueTextBoxMiddleNameClient;
        private System.Windows.Forms.Button buttonAddClient;
        private CueTextBox cueTextBoxPhoneClient;
        private CueTextBox cueTextBoxEmailClient;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Button buttonDelClient;
    }
}