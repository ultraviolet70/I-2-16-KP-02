namespace Shop
{
    partial class FormSupply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupply));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.cbPost = new System.Windows.Forms.ComboBox();
            this.btnPostInsert = new System.Windows.Forms.Button();
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.maskedTextBoxDTSupply = new System.Windows.Forms.MaskedTextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPriceOrder = new System.Windows.Forms.TextBox();
            this.tbNumberOrder = new System.Windows.Forms.TextBox();
            this.btnKlientInsert = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(29, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Поставщик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(297, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Сотрудник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Дата поставки";
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(231, 57);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(219, 26);
            this.cbEmployee.TabIndex = 33;
            // 
            // cbPost
            // 
            this.cbPost.FormattingEnabled = true;
            this.cbPost.Location = new System.Drawing.Point(32, 151);
            this.cbPost.Name = "cbPost";
            this.cbPost.Size = new System.Drawing.Size(208, 26);
            this.cbPost.TabIndex = 39;
            // 
            // btnPostInsert
            // 
            this.btnPostInsert.BackgroundImage = global::Shop.Properties.Resources.icons8_add_new_48;
            this.btnPostInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPostInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostInsert.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPostInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.btnPostInsert.Location = new System.Drawing.Point(246, 151);
            this.btnPostInsert.Name = "btnPostInsert";
            this.btnPostInsert.Size = new System.Drawing.Size(27, 27);
            this.btnPostInsert.TabIndex = 28;
            this.btnPostInsert.UseVisualStyleBackColor = true;
            this.btnPostInsert.Click += new System.EventHandler(this.btnPostInsert_Click);
            // 
            // buttonBack2
            // 
            this.buttonBack2.BackgroundImage = global::Shop.Properties.Resources.icons8_long_arrow_left_48;
            this.buttonBack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack2.Location = new System.Drawing.Point(694, 12);
            this.buttonBack2.Name = "buttonBack2";
            this.buttonBack2.Size = new System.Drawing.Size(46, 21);
            this.buttonBack2.TabIndex = 16;
            this.buttonBack2.UseVisualStyleBackColor = true;
            this.buttonBack2.Click += new System.EventHandler(this.buttonBack2_Click);
            // 
            // maskedTextBoxDTSupply
            // 
            this.maskedTextBoxDTSupply.Location = new System.Drawing.Point(32, 56);
            this.maskedTextBoxDTSupply.Mask = "00/00/0000";
            this.maskedTextBoxDTSupply.Name = "maskedTextBoxDTSupply";
            this.maskedTextBoxDTSupply.Size = new System.Drawing.Size(135, 27);
            this.maskedTextBoxDTSupply.TabIndex = 40;
            this.maskedTextBoxDTSupply.ValidatingType = typeof(System.DateTime);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(32, 390);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(319, 26);
            this.cbCategory.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(29, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Цена товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Категория товара";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(29, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "Наименование товара";
            // 
            // tbPriceOrder
            // 
            this.tbPriceOrder.Location = new System.Drawing.Point(32, 310);
            this.tbPriceOrder.Name = "tbPriceOrder";
            this.tbPriceOrder.Size = new System.Drawing.Size(319, 27);
            this.tbPriceOrder.TabIndex = 43;
            // 
            // tbNumberOrder
            // 
            this.tbNumberOrder.Location = new System.Drawing.Point(32, 228);
            this.tbNumberOrder.Name = "tbNumberOrder";
            this.tbNumberOrder.Size = new System.Drawing.Size(319, 27);
            this.tbNumberOrder.TabIndex = 42;
            // 
            // btnKlientInsert
            // 
            this.btnKlientInsert.BackgroundImage = global::Shop.Properties.Resources.icons8_add_new_48;
            this.btnKlientInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKlientInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKlientInsert.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKlientInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.btnKlientInsert.Location = new System.Drawing.Point(371, 389);
            this.btnKlientInsert.Name = "btnKlientInsert";
            this.btnKlientInsert.Size = new System.Drawing.Size(28, 27);
            this.btnKlientInsert.TabIndex = 41;
            this.btnKlientInsert.UseVisualStyleBackColor = true;
            this.btnKlientInsert.Click += new System.EventHandler(this.btnKlientInsert_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.btnAddProduct.Location = new System.Drawing.Point(32, 486);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(160, 36);
            this.btnAddProduct.TabIndex = 13;
            this.btnAddProduct.Text = "Создать";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.buttonAddSup_Click);
            // 
            // FormSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 547);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPriceOrder);
            this.Controls.Add(this.tbNumberOrder);
            this.Controls.Add(this.btnKlientInsert);
            this.Controls.Add(this.maskedTextBoxDTSupply);
            this.Controls.Add(this.cbPost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.btnPostInsert);
            this.Controls.Add(this.buttonBack2);
            this.Controls.Add(this.btnAddProduct);
            this.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSupply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с поставками";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSupply_FormClosing);
            this.Load += new System.EventHandler(this.FormSupply_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBack2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Button btnPostInsert;
        private System.Windows.Forms.ComboBox cbPost;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDTSupply;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPriceOrder;
        private System.Windows.Forms.TextBox tbNumberOrder;
        private System.Windows.Forms.Button btnKlientInsert;
        private System.Windows.Forms.Button btnAddProduct;
    }
}