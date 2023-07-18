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
            cmbSuppliers = new ComboBox();
            lstProducts = new ListBox();
            btnAddSupplier = new Button();
            btnRemoveSupplier = new Button();
            btnRemoveProduct = new Button();
            btnAddProduct = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            // cmbSuppliers
            // 
            cmbSuppliers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.Location = new Point(114, 55);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new Size(329, 36);
            cmbSuppliers.TabIndex = 14;
            cmbSuppliers.SelectedIndexChanged += cmbSuppliers_SelectedIndexChanged;
            // 
            // lstProducts
            // 
            lstProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 28;
            lstProducts.Location = new Point(114, 179);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(329, 256);
            lstProducts.TabIndex = 15;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddSupplier.Location = new Point(449, 52);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(94, 40);
            btnAddSupplier.TabIndex = 16;
            btnAddSupplier.Text = "Add";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // btnRemoveSupplier
            // 
            btnRemoveSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveSupplier.Location = new Point(549, 52);
            btnRemoveSupplier.Name = "btnRemoveSupplier";
            btnRemoveSupplier.Size = new Size(112, 40);
            btnRemoveSupplier.TabIndex = 17;
            btnRemoveSupplier.Text = "Remove";
            btnRemoveSupplier.UseVisualStyleBackColor = true;
            btnRemoveSupplier.Click += btnRemoveSupplier_Click;
            // 
            // btnRemoveProduct
            // 
            btnRemoveProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveProduct.Location = new Point(549, 395);
            btnRemoveProduct.Name = "btnRemoveProduct";
            btnRemoveProduct.Size = new Size(112, 40);
            btnRemoveProduct.TabIndex = 19;
            btnRemoveProduct.Text = "Remove";
            btnRemoveProduct.UseVisualStyleBackColor = true;
            btnRemoveProduct.Click += btnRemoveProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProduct.Location = new Point(449, 395);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(94, 40);
            btnAddProduct.TabIndex = 18;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 179);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 20;
            label1.Text = "Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 21;
            label2.Text = "Supplier";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(66, 102);
            label3.Name = "label3";
            label3.Size = new Size(31, 28);
            label3.TabIndex = 22;
            label3.Text = "ID";
            // 
            // frmSuppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 550);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRemoveProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(btnRemoveSupplier);
            Controls.Add(btnAddSupplier);
            Controls.Add(lstProducts);
            Controls.Add(cmbSuppliers);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSuppliers";
            Text = "frmSuppliers";
            Load += frmSuppliers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnExit;
        private ComboBox cmbSuppliers;
        private ListBox lstProducts;
        private Button btnAddSupplier;
        private Button btnRemoveSupplier;
        private Button btnRemoveProduct;
        private Button btnAddProduct;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}