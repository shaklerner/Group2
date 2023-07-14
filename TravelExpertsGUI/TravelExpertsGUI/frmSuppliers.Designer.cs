namespace TravelExpertsGUI
{
    partial class frmSuppliers
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
            btnAddSuppliers = new Button();
            btnEditSuppliers = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnCancel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAddSuppliers
            // 
            btnAddSuppliers.BackColor = Color.Teal;
            btnAddSuppliers.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddSuppliers.ForeColor = Color.White;
            btnAddSuppliers.Location = new Point(99, 47);
            btnAddSuppliers.Name = "btnAddSuppliers";
            btnAddSuppliers.Size = new Size(100, 45);
            btnAddSuppliers.TabIndex = 8;
            btnAddSuppliers.Text = "&Add";
            btnAddSuppliers.UseVisualStyleBackColor = false;
            // 
            // btnEditSuppliers
            // 
            btnEditSuppliers.BackColor = Color.Teal;
            btnEditSuppliers.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditSuppliers.ForeColor = Color.White;
            btnEditSuppliers.Location = new Point(231, 47);
            btnEditSuppliers.Name = "btnEditSuppliers";
            btnEditSuppliers.Size = new Size(100, 45);
            btnEditSuppliers.TabIndex = 9;
            btnEditSuppliers.Text = "&Edit";
            btnEditSuppliers.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(54, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(888, 393);
            dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            Column1.HeaderText = "Supplier Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Supplier Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.AutoSize = true;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Gray;
            btnCancel.Location = new Point(1000, 9);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(20, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "X";
            btnCancel.Click += btnCancel_Click;
            // 
            // frmSuppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 553);
            Controls.Add(btnCancel);
            Controls.Add(dataGridView1);
            Controls.Add(btnEditSuppliers);
            Controls.Add(btnAddSuppliers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSuppliers";
            Text = "frmSuppliers";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddSuppliers;
        private Button btnEditSuppliers;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label btnCancel;
    }
}