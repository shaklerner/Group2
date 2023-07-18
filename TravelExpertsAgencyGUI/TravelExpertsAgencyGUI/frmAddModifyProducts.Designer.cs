namespace TravelExpertsAgencyGUI
{
    partial class frmAddModifyProducts
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
            label2 = new Label();
            txtProductName = new TextBox();
            cboSuppliers = new ComboBox();
            btnExit = new Label();
            btnAddProducts = new Button();
            btnEditProduct = new Button();
            btnSaveProduct = new Button();
            btnGenerateProductId = new Button();
            txtProductId = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(82, 155);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 8;
            label1.Text = "Product Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(82, 198);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 9;
            label2.Text = "Supplier: ";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(237, 144);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(255, 27);
            txtProductName.TabIndex = 10;
            // 
            // cboSuppliers
            // 
            cboSuppliers.FormattingEnabled = true;
            cboSuppliers.Location = new Point(234, 195);
            cboSuppliers.Name = "cboSuppliers";
            cboSuppliers.Size = new Size(258, 28);
            cboSuppliers.TabIndex = 11;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(996, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(24, 25);
            btnExit.TabIndex = 12;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // btnAddProducts
            // 
            btnAddProducts.BackColor = Color.FromArgb(51, 73, 107);
            btnAddProducts.FlatAppearance.BorderSize = 0;
            btnAddProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnAddProducts.FlatStyle = FlatStyle.Flat;
            btnAddProducts.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProducts.ForeColor = Color.White;
            btnAddProducts.Location = new Point(68, 9);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(136, 47);
            btnAddProducts.TabIndex = 13;
            btnAddProducts.Text = "&Add ";
            btnAddProducts.UseVisualStyleBackColor = false;
            // 
            // btnEditProduct
            // 
            btnEditProduct.BackColor = Color.FromArgb(51, 73, 107);
            btnEditProduct.FlatAppearance.BorderSize = 0;
            btnEditProduct.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnEditProduct.FlatStyle = FlatStyle.Flat;
            btnEditProduct.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditProduct.ForeColor = Color.White;
            btnEditProduct.Location = new Point(234, 9);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(136, 47);
            btnEditProduct.TabIndex = 14;
            btnEditProduct.Text = "&Edit";
            btnEditProduct.UseVisualStyleBackColor = false;
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.BackColor = Color.FromArgb(51, 73, 107);
            btnSaveProduct.FlatAppearance.BorderSize = 0;
            btnSaveProduct.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnSaveProduct.FlatStyle = FlatStyle.Flat;
            btnSaveProduct.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveProduct.ForeColor = Color.White;
            btnSaveProduct.Location = new Point(401, 9);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(136, 47);
            btnSaveProduct.TabIndex = 15;
            btnSaveProduct.Text = "&Save";
            btnSaveProduct.UseVisualStyleBackColor = false;
            // 
            // btnGenerateProductId
            // 
            btnGenerateProductId.BackColor = Color.FromArgb(51, 73, 107);
            btnGenerateProductId.FlatAppearance.BorderSize = 0;
            btnGenerateProductId.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnGenerateProductId.FlatStyle = FlatStyle.Flat;
            btnGenerateProductId.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerateProductId.ForeColor = Color.White;
            btnGenerateProductId.Location = new Point(527, 95);
            btnGenerateProductId.Name = "btnGenerateProductId";
            btnGenerateProductId.Size = new Size(136, 43);
            btnGenerateProductId.TabIndex = 18;
            btnGenerateProductId.Text = "&Generate Id";
            btnGenerateProductId.UseVisualStyleBackColor = false;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(237, 103);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(255, 27);
            txtProductId.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(90, 103);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 16;
            label3.Text = "Product ID :";
            // 
            // frmAddModifyProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1032, 503);
            Controls.Add(btnGenerateProductId);
            Controls.Add(txtProductId);
            Controls.Add(label3);
            Controls.Add(btnSaveProduct);
            Controls.Add(btnEditProduct);
            Controls.Add(btnAddProducts);
            Controls.Add(btnExit);
            Controls.Add(cboSuppliers);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddModifyProducts";
            Text = "frmAddModifyProducts";
            Load += frmAddModifyProducts_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtProductName;
        private ComboBox cboSuppliers;
        private Label btnExit;
        private Button btnAddProducts;
        private Button btnEditProduct;
        private Button btnSaveProduct;
        private Button btnGenerateProductId;
        private TextBox txtProductId;
        private Label label3;
    }
}