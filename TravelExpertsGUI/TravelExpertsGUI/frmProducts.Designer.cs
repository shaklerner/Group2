namespace TravelExpertsGUI
{
    partial class frmProducts
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
            label1 = new Label();
            dgvProducts = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnAddProducts = new Button();
            btnEditProducts = new Button();
            btnCancel = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(400, 29);
            label1.Name = "label1";
            label1.Size = new Size(113, 35);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvProducts.Location = new Point(46, 142);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.Size = new Size(979, 425);
            dgvProducts.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Product Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Product Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // btnAddProducts
            // 
            btnAddProducts.BackColor = Color.Teal;
            btnAddProducts.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProducts.ForeColor = Color.White;
            btnAddProducts.Location = new Point(55, 79);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(100, 45);
            btnAddProducts.TabIndex = 7;
            btnAddProducts.Text = "&Add";
            btnAddProducts.UseVisualStyleBackColor = false;
            // 
            // btnEditProducts
            // 
            btnEditProducts.BackColor = Color.Teal;
            btnEditProducts.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditProducts.ForeColor = Color.White;
            btnEditProducts.Location = new Point(161, 79);
            btnEditProducts.Name = "btnEditProducts";
            btnEditProducts.Size = new Size(100, 45);
            btnEditProducts.TabIndex = 8;
            btnEditProducts.Text = "&Edit";
            btnEditProducts.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.AutoSize = true;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Gray;
            btnCancel.Location = new Point(1018, 9);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(20, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "X";
            btnCancel.Click += btnCancel_Click;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 600);
            Controls.Add(btnCancel);
            Controls.Add(btnEditProducts);
            Controls.Add(btnAddProducts);
            Controls.Add(dgvProducts);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProducts";
            Text = "frmProducts";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnAddProducts;
        private Button btnEditProducts;
        private Label btnCancel;
    }
}