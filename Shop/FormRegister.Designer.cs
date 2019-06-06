namespace Shop
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.labelReg = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelReturnPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxReturnPassword = new System.Windows.Forms.TextBox();
            this.labelFam = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxFam = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Font = new System.Drawing.Font("Verdana", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(178)))), ((int)(((byte)(80)))));
            this.labelReg.Location = new System.Drawing.Point(271, 9);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(445, 78);
            this.labelReg.TabIndex = 1;
            this.labelReg.Text = "Регистрация";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.labelLogin.Location = new System.Drawing.Point(27, 121);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(106, 29);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Логин:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.labelPassword.Location = new System.Drawing.Point(27, 200);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(125, 29);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Пароль:";
            // 
            // labelReturnPassword
            // 
            this.labelReturnPassword.AutoSize = true;
            this.labelReturnPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReturnPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.labelReturnPassword.Location = new System.Drawing.Point(27, 274);
            this.labelReturnPassword.Name = "labelReturnPassword";
            this.labelReturnPassword.Size = new System.Drawing.Size(274, 29);
            this.labelReturnPassword.TabIndex = 4;
            this.labelReturnPassword.Text = "Повторите пароль:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(313, 121);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(208, 41);
            this.textBoxLogin.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(313, 188);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '❂';
            this.textBoxPassword.Size = new System.Drawing.Size(208, 41);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxReturnPassword
            // 
            this.textBoxReturnPassword.Location = new System.Drawing.Point(313, 261);
            this.textBoxReturnPassword.Multiline = true;
            this.textBoxReturnPassword.Name = "textBoxReturnPassword";
            this.textBoxReturnPassword.PasswordChar = '❂';
            this.textBoxReturnPassword.Size = new System.Drawing.Size(208, 41);
            this.textBoxReturnPassword.TabIndex = 8;
            this.textBoxReturnPassword.TextChanged += new System.EventHandler(this.textBoxReturnPassword_TextChanged);
            // 
            // labelFam
            // 
            this.labelFam.AutoSize = true;
            this.labelFam.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.labelFam.Location = new System.Drawing.Point(580, 121);
            this.labelFam.Name = "labelFam";
            this.labelFam.Size = new System.Drawing.Size(149, 29);
            this.labelFam.TabIndex = 9;
            this.labelFam.Text = "Фамилия:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.labelName.Location = new System.Drawing.Point(580, 200);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(79, 29);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Имя:";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.labelMiddleName.Location = new System.Drawing.Point(580, 274);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(147, 29);
            this.labelMiddleName.TabIndex = 11;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.labelPosition.Location = new System.Drawing.Point(580, 339);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(176, 29);
            this.labelPosition.TabIndex = 12;
            this.labelPosition.Text = "Должность:";
            // 
            // textBoxFam
            // 
            this.textBoxFam.Location = new System.Drawing.Point(769, 121);
            this.textBoxFam.Multiline = true;
            this.textBoxFam.Name = "textBoxFam";
            this.textBoxFam.Size = new System.Drawing.Size(208, 41);
            this.textBoxFam.TabIndex = 13;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(769, 188);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(208, 41);
            this.textBoxName.TabIndex = 14;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(769, 261);
            this.textBoxMiddleName.Multiline = true;
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(208, 41);
            this.textBoxMiddleName.TabIndex = 15;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(769, 339);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(208, 28);
            this.comboBoxPosition.TabIndex = 16;
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.White;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(178)))), ((int)(((byte)(80)))));
            this.buttonReg.Location = new System.Drawing.Point(774, 414);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(202, 48);
            this.buttonReg.TabIndex = 17;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPassword.Location = new System.Drawing.Point(31, 350);
            this.checkBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(249, 33);
            this.checkBoxPassword.TabIndex = 23;
            this.checkBoxPassword.Text = "Показать пароль";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1015, 494);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxFam);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelFam);
            this.Controls.Add(this.textBoxReturnPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelReturnPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelReg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegister_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelReturnPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxReturnPassword;
        private System.Windows.Forms.Label labelFam;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxFam;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.CheckBox checkBoxPassword;
    }
}