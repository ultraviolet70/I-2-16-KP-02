namespace Shop
{
    partial class FormAddPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPosition));
            this.dgvPosition = new System.Windows.Forms.DataGridView();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.btnDelPosition = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPosition
            // 
            this.dgvPosition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosition.BackgroundColor = System.Drawing.Color.White;
            this.dgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosition.Location = new System.Drawing.Point(40, 156);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.RowTemplate.Height = 28;
            this.dgvPosition.Size = new System.Drawing.Size(349, 198);
            this.dgvPosition.TabIndex = 35;
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPosition.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.btnAddPosition.Location = new System.Drawing.Point(66, 95);
            this.btnAddPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(135, 44);
            this.btnAddPosition.TabIndex = 34;
            this.btnAddPosition.Text = "Добавить";
            this.btnAddPosition.UseVisualStyleBackColor = true;
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click);
            // 
            // btnDelPosition
            // 
            this.btnDelPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelPosition.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.btnDelPosition.Location = new System.Drawing.Point(224, 95);
            this.btnDelPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelPosition.Name = "btnDelPosition";
            this.btnDelPosition.Size = new System.Drawing.Size(135, 44);
            this.btnDelPosition.TabIndex = 33;
            this.btnDelPosition.Text = "Удалить";
            this.btnDelPosition.UseVisualStyleBackColor = true;
            this.btnDelPosition.Click += new System.EventHandler(this.btnDelPosition_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(86, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Наименование должности";
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(66, 63);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(293, 26);
            this.tbPosition.TabIndex = 31;
            // 
            // FormAddPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 395);
            this.Controls.Add(this.dgvPosition);
            this.Controls.Add(this.btnAddPosition);
            this.Controls.Add(this.btnDelPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPosition);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Должности";
            this.Load += new System.EventHandler(this.FormAddPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPosition;
        private System.Windows.Forms.Button btnAddPosition;
        private System.Windows.Forms.Button btnDelPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPosition;
    }
}