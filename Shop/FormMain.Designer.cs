namespace Shop
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonCreateDoc = new System.Windows.Forms.Button();
            this.buttonAcc = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonSettingColor = new System.Windows.Forms.Button();
            this.buttonTovar = new System.Windows.Forms.Button();
            this.buttonRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateOrder.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.buttonCreateOrder.Location = new System.Drawing.Point(42, 49);
            this.buttonCreateOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(166, 65);
            this.buttonCreateOrder.TabIndex = 2;
            this.buttonCreateOrder.Text = "Заказы";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonCreateDoc
            // 
            this.buttonCreateDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateDoc.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.buttonCreateDoc.Location = new System.Drawing.Point(42, 379);
            this.buttonCreateDoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCreateDoc.Name = "buttonCreateDoc";
            this.buttonCreateDoc.Size = new System.Drawing.Size(166, 65);
            this.buttonCreateDoc.TabIndex = 6;
            this.buttonCreateDoc.Text = "Отчеты";
            this.buttonCreateDoc.UseVisualStyleBackColor = true;
            // 
            // buttonAcc
            // 
            this.buttonAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcc.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.buttonAcc.Location = new System.Drawing.Point(892, 72);
            this.buttonAcc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAcc.Name = "buttonAcc";
            this.buttonAcc.Size = new System.Drawing.Size(166, 65);
            this.buttonAcc.TabIndex = 7;
            this.buttonAcc.Text = "Сотрудники";
            this.buttonAcc.UseVisualStyleBackColor = true;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // buttonSettingColor
            // 
            this.buttonSettingColor.BackgroundImage = global::Shop.Properties.Resources.icons8_шестерни_48;
            this.buttonSettingColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSettingColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSettingColor.Location = new System.Drawing.Point(1018, 12);
            this.buttonSettingColor.Name = "buttonSettingColor";
            this.buttonSettingColor.Size = new System.Drawing.Size(40, 35);
            this.buttonSettingColor.TabIndex = 8;
            this.buttonSettingColor.UseVisualStyleBackColor = true;
            this.buttonSettingColor.Click += new System.EventHandler(this.buttonSettingColor_Click);
            // 
            // buttonTovar
            // 
            this.buttonTovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTovar.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTovar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.buttonTovar.Location = new System.Drawing.Point(42, 217);
            this.buttonTovar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTovar.Name = "buttonTovar";
            this.buttonTovar.Size = new System.Drawing.Size(166, 65);
            this.buttonTovar.TabIndex = 10;
            this.buttonTovar.Text = "Поставки";
            this.buttonTovar.UseVisualStyleBackColor = true;
            // 
            // buttonRole
            // 
            this.buttonRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRole.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.buttonRole.Location = new System.Drawing.Point(892, 171);
            this.buttonRole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRole.Name = "buttonRole";
            this.buttonRole.Size = new System.Drawing.Size(166, 65);
            this.buttonRole.TabIndex = 9;
            this.buttonRole.Text = "Роли";
            this.buttonRole.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1074, 491);
            this.Controls.Add(this.buttonTovar);
            this.Controls.Add(this.buttonRole);
            this.Controls.Add(this.buttonSettingColor);
            this.Controls.Add(this.buttonAcc);
            this.Controls.Add(this.buttonCreateDoc);
            this.Controls.Add(this.buttonCreateOrder);
            this.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа в приложении";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonCreateDoc;
        private System.Windows.Forms.Button buttonAcc;
        private System.Windows.Forms.Button buttonSettingColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonTovar;
        private System.Windows.Forms.Button buttonRole;
    }
}