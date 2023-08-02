namespace TravelExpertsAgencyGUI
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
            btnExit = new Label();
            lstProducts = new ListBox();
            btnEditSupplier = new Button();
            btnAddProduct = new Button();
            label1 = new Label();
            dgvSuppliers = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            label2 = new Label();
            btnGoProductsSuppliers = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(1014, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(24, 25);
            btnExit.TabIndex = 13;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // lstProducts
            // 
            lstProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 28;
            lstProducts.Location = new Point(600, 128);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(394, 312);
            lstProducts.TabIndex = 15;
            // 
            // btnEditSupplier
            // 
            btnEditSupplier.BackColor = Color.FromArgb(51, 73, 107);
            btnEditSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditSupplier.ForeColor = Color.White;
            btnEditSupplier.Location = new Point(368, 446);
            btnEditSupplier.Name = "btnEditSupplier";
            btnEditSupplier.Size = new Size(120, 55);
            btnEditSupplier.TabIndex = 19;
            btnEditSupplier.Text = "Edit";
            btnEditSupplier.UseVisualStyleBackColor = false;
            btnEditSupplier.Click += btnEditSupplier_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(51, 73, 107);
            btnAddProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(242, 446);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(120, 55);
            btnAddProduct.TabIndex = 18;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(600, 97);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 20;
            label1.Text = "Supplier's Products";
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.BackgroundColor = Color.WhiteSmoke;
            dgvSuppliers.BorderStyle = BorderStyle.None;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Columns.AddRange(new DataGridViewColumn[] { ID, SupplierName });
            dgvSuppliers.Location = new Point(45, 128);
            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.RowTemplate.Height = 29;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.Size = new Size(443, 312);
            dgvSuppliers.TabIndex = 21;
            dgvSuppliers.SelectionChanged += dgvSuppliers_SelectionChanged;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // SupplierName
            // 
            SupplierName.HeaderText = "Supplier Name";
            SupplierName.MinimumWidth = 6;
            SupplierName.Name = "SupplierName";
            SupplierName.ReadOnly = true;
            SupplierName.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 88);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 22;
            label2.Text = "Suppliers";
            // 
            // btnGoProductsSuppliers
            // 
            btnGoProductsSuppliers.BackColor = Color.FromArgb(51, 73, 107);
            btnGoProductsSuppliers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGoProductsSuppliers.ForeColor = Color.White;
            btnGoProductsSuppliers.Location = new Point(859, 446);
            btnGoProductsSuppliers.Name = "btnGoProductsSuppliers";
            btnGoProductsSuppliers.Size = new Size(135, 55);
            btnGoProductsSuppliers.TabIndex = 23;
            btnGoProductsSuppliers.Text = "More Info";
            btnGoProductsSuppliers.UseVisualStyleBackColor = false;
            btnGoProductsSuppliers.Click += btnGoProductsSuppliers_Click;
            // 
            // frmSuppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 550);
            Controls.Add(btnGoProductsSuppliers);
            Controls.Add(label2);
            Controls.Add(dgvSuppliers);
            Controls.Add(label1);
            Controls.Add(btnEditSupplier);
            Controls.Add(btnAddProduct);
            Controls.Add(lstProducts);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSuppliers";
            Text = "frmSuppliers";
            Load += frmSuppliers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnExit;
        private ListBox lstProducts;
        private Button btnRemoveSupplier;
        private Button btnEditSupplier;
        private Button btnAddProduct;
        private Label label1;
        private DataGridView dgvSuppliers;
        private Label label2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn SupplierName;
        private Button btnGoProductsSuppliers;
    }
}