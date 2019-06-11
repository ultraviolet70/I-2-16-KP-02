namespace Shop
{
    partial class FormAddSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSupplier));
            this.textBoxNameSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.cueTextBoxPhoneSupplier = new CueTextBox();
            this.cueTextBoxEmailSupplier = new CueTextBox();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.buttonDelSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNameSupplier
            // 
            this.textBoxNameSupplier.Location = new System.Drawing.Point(330, 59);
            this.textBoxNameSupplier.Name = "textBoxNameSupplier";
            this.textBoxNameSupplier.Size = new System.Drawing.Size(305, 26);
            this.textBoxNameSupplier.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(30, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование поставщика:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.label2.Location = new System.Drawing.Point(30, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Контактный телефон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.label3.Location = new System.Drawing.Point(30, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Электронная почта:";
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.buttonAddSupplier.Location = new System.Drawing.Point(33, 204);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(121, 33);
            this.buttonAddSupplier.TabIndex = 13;
            this.buttonAddSupplier.Text = "Добавить";
            this.buttonAddSupplier.UseVisualStyleBackColor = true;
            this.buttonAddSupplier.Click += new System.EventHandler(this.buttonAddSupplier_Click);
            // 
            // cueTextBoxPhoneSupplier
            // 
            this.cueTextBoxPhoneSupplier.Cue = "+7(987)-879-64-87";
            this.cueTextBoxPhoneSupplier.Location = new System.Drawing.Point(330, 107);
            this.cueTextBoxPhoneSupplier.Name = "cueTextBoxPhoneSupplier";
            this.cueTextBoxPhoneSupplier.Size = new System.Drawing.Size(305, 26);
            this.cueTextBoxPhoneSupplier.TabIndex = 1;
            // 
            // cueTextBoxEmailSupplier
            // 
            this.cueTextBoxEmailSupplier.Cue = "name@gmail.com";
            this.cueTextBoxEmailSupplier.Location = new System.Drawing.Point(330, 158);
            this.cueTextBoxEmailSupplier.Name = "cueTextBoxEmailSupplier";
            this.cueTextBoxEmailSupplier.Size = new System.Drawing.Size(305, 26);
            this.cueTextBoxEmailSupplier.TabIndex = 14;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.White;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(33, 253);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowTemplate.Height = 28;
            this.dgvSupplier.Size = new System.Drawing.Size(602, 231);
            this.dgvSupplier.TabIndex = 15;
            // 
            // buttonDelSupplier
            // 
            this.buttonDelSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.buttonDelSupplier.Location = new System.Drawing.Point(182, 204);
            this.buttonDelSupplier.Name = "buttonDelSupplier";
            this.buttonDelSupplier.Size = new System.Drawing.Size(121, 33);
            this.buttonDelSupplier.TabIndex = 16;
            this.buttonDelSupplier.Text = "Удалить";
            this.buttonDelSupplier.UseVisualStyleBackColor = true;
            this.buttonDelSupplier.Click += new System.EventHandler(this.buttonDelSupplier_Click);
            // 
            // FormAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 513);
            this.Controls.Add(this.buttonDelSupplier);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.cueTextBoxEmailSupplier);
            this.Controls.Add(this.buttonAddSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cueTextBoxPhoneSupplier);
            this.Controls.Add(this.textBoxNameSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить поставщика";
            this.Load += new System.EventHandler(this.FormAddSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameSupplier;
        private CueTextBox cueTextBoxPhoneSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddSupplier;
        private CueTextBox cueTextBoxEmailSupplier;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Button buttonDelSupplier;
    }
}