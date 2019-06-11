namespace Shop
{
    partial class FormCreateOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateOrder));
            this.dataGridViewTovar = new System.Windows.Forms.DataGridView();
            this.tbNumberOrder = new System.Windows.Forms.TextBox();
            this.tbPriceOrder = new System.Windows.Forms.TextBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.cbKlient = new System.Windows.Forms.ComboBox();
            this.btnKlientInsert = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTovar
            // 
            this.dataGridViewTovar.AllowUserToAddRows = false;
            this.dataGridViewTovar.AllowUserToDeleteRows = false;
            this.dataGridViewTovar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTovar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewTovar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTovar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTovar.Location = new System.Drawing.Point(43, 210);
            this.dataGridViewTovar.Name = "dataGridViewTovar";
            this.dataGridViewTovar.ReadOnly = true;
            this.dataGridViewTovar.RowTemplate.Height = 28;
            this.dataGridViewTovar.Size = new System.Drawing.Size(829, 228);
            this.dataGridViewTovar.TabIndex = 11;
            // 
            // tbNumberOrder
            // 
            this.tbNumberOrder.Location = new System.Drawing.Point(43, 74);
            this.tbNumberOrder.Name = "tbNumberOrder";
            this.tbNumberOrder.Size = new System.Drawing.Size(203, 27);
            this.tbNumberOrder.TabIndex = 17;
            // 
            // tbPriceOrder
            // 
            this.tbPriceOrder.Location = new System.Drawing.Point(337, 155);
            this.tbPriceOrder.Name = "tbPriceOrder";
            this.tbPriceOrder.Size = new System.Drawing.Size(203, 27);
            this.tbPriceOrder.TabIndex = 20;
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(337, 75);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(219, 26);
            this.cbEmployee.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Номер заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(334, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Сотрудник";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Клиент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(334, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Стоимость заказа";
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateOrder.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.buttonCreateOrder.Location = new System.Drawing.Point(737, 454);
            this.buttonCreateOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(135, 44);
            this.buttonCreateOrder.TabIndex = 27;
            this.buttonCreateOrder.Text = "Word";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // cbKlient
            // 
            this.cbKlient.FormattingEnabled = true;
            this.cbKlient.Location = new System.Drawing.Point(43, 154);
            this.cbKlient.Name = "cbKlient";
            this.cbKlient.Size = new System.Drawing.Size(203, 26);
            this.cbKlient.TabIndex = 28;
            // 
            // btnKlientInsert
            // 
            this.btnKlientInsert.BackgroundImage = global::Shop.Properties.Resources.icons8_add_new_48;
            this.btnKlientInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKlientInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKlientInsert.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKlientInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.btnKlientInsert.Location = new System.Drawing.Point(261, 154);
            this.btnKlientInsert.Name = "btnKlientInsert";
            this.btnKlientInsert.Size = new System.Drawing.Size(41, 27);
            this.btnKlientInsert.TabIndex = 12;
            this.btnKlientInsert.UseVisualStyleBackColor = true;
            this.btnKlientInsert.Click += new System.EventHandler(this.buttonAdd1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::Shop.Properties.Resources.icons8_long_arrow_left_48;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Location = new System.Drawing.Point(826, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(46, 21);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 510);
            this.Controls.Add(this.cbKlient);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.tbPriceOrder);
            this.Controls.Add(this.tbNumberOrder);
            this.Controls.Add(this.btnKlientInsert);
            this.Controls.Add(this.dataGridViewTovar);
            this.Controls.Add(this.buttonBack);
            this.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с заказами";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCreateOrder_FormClosing);
            this.Load += new System.EventHandler(this.FormCreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button btnKlientInsert;
        public System.Windows.Forms.DataGridView dataGridViewTovar;
        private System.Windows.Forms.TextBox tbNumberOrder;
        private System.Windows.Forms.TextBox tbPriceOrder;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.ComboBox cbKlient;
    }
}