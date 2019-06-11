namespace Shop
{
    partial class FormEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.dataGridViewAcc = new System.Windows.Forms.DataGridView();
            this.buttonAddPosition = new System.Windows.Forms.Button();
            this.buttonBack3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAcc
            // 
            this.dataGridViewAcc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAcc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewAcc.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAcc.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAcc.Name = "dataGridViewAcc";
            this.dataGridViewAcc.RowTemplate.Height = 28;
            this.dataGridViewAcc.Size = new System.Drawing.Size(690, 338);
            this.dataGridViewAcc.TabIndex = 0;
            // 
            // buttonAddPosition
            // 
            this.buttonAddPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPosition.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.buttonAddPosition.Location = new System.Drawing.Point(12, 373);
            this.buttonAddPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddPosition.Name = "buttonAddPosition";
            this.buttonAddPosition.Size = new System.Drawing.Size(183, 44);
            this.buttonAddPosition.TabIndex = 29;
            this.buttonAddPosition.Text = "Должности";
            this.buttonAddPosition.UseVisualStyleBackColor = true;
            this.buttonAddPosition.Click += new System.EventHandler(this.buttonAddPosition_Click);
            // 
            // buttonBack3
            // 
            this.buttonBack3.BackgroundImage = global::Shop.Properties.Resources.icons8_long_arrow_left_48;
            this.buttonBack3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack3.Location = new System.Drawing.Point(834, 12);
            this.buttonBack3.Name = "buttonBack3";
            this.buttonBack3.Size = new System.Drawing.Size(46, 21);
            this.buttonBack3.TabIndex = 11;
            this.buttonBack3.UseVisualStyleBackColor = true;
            this.buttonBack3.Click += new System.EventHandler(this.buttonBack3_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 611);
            this.Controls.Add(this.buttonAddPosition);
            this.Controls.Add(this.buttonBack3);
            this.Controls.Add(this.dataGridViewAcc);
            this.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmployee_FormClosing);
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAcc;
        private System.Windows.Forms.Button buttonBack3;
        private System.Windows.Forms.Button buttonAddPosition;
    }
}