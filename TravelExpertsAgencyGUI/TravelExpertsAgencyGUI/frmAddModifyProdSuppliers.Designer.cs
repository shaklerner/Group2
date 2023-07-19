namespace TravelExpertsAgencyGUI
{
    partial class frmAddModifyProdSuppliers
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
            btnEditProdSup = new Button();
            btnAddProdSup = new Button();
            btnSaveProdSup = new Button();
            cboProduct = new ComboBox();
            cboSupplier = new ComboBox();
            lblProduct = new Label();
            lblSupplier = new Label();
            txtProductSupId = new TextBox();
            lblProdSupId = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(996, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(24, 25);
            btnExit.TabIndex = 23;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // btnEditProdSup
            // 
            btnEditProdSup.BackColor = Color.FromArgb(51, 73, 107);
            btnEditProdSup.FlatAppearance.BorderSize = 0;
            btnEditProdSup.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnEditProdSup.FlatStyle = FlatStyle.Flat;
            btnEditProdSup.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditProdSup.ForeColor = Color.White;
            btnEditProdSup.Location = new Point(182, 12);
            btnEditProdSup.Name = "btnEditProdSup";
            btnEditProdSup.Size = new Size(136, 47);
            btnEditProdSup.TabIndex = 22;
            btnEditProdSup.Text = "&Edit";
            btnEditProdSup.UseVisualStyleBackColor = false;
            // 
            // btnAddProdSup
            // 
            btnAddProdSup.BackColor = Color.FromArgb(51, 73, 107);
            btnAddProdSup.FlatAppearance.BorderSize = 0;
            btnAddProdSup.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnAddProdSup.FlatStyle = FlatStyle.Flat;
            btnAddProdSup.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProdSup.ForeColor = Color.White;
            btnAddProdSup.Location = new Point(27, 12);
            btnAddProdSup.Name = "btnAddProdSup";
            btnAddProdSup.Size = new Size(136, 47);
            btnAddProdSup.TabIndex = 21;
            btnAddProdSup.Text = "&Add ";
            btnAddProdSup.UseVisualStyleBackColor = false;
            
            // 
            // btnSaveProdSup
            // 
            btnSaveProdSup.BackColor = Color.FromArgb(51, 73, 107);
            btnSaveProdSup.FlatAppearance.BorderSize = 0;
            btnSaveProdSup.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnSaveProdSup.FlatStyle = FlatStyle.Flat;
            btnSaveProdSup.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveProdSup.ForeColor = Color.White;
            btnSaveProdSup.Location = new Point(351, 12);
            btnSaveProdSup.Name = "btnSaveProdSup";
            btnSaveProdSup.Size = new Size(136, 47);
            btnSaveProdSup.TabIndex = 24;
            btnSaveProdSup.Text = "&Save";
            btnSaveProdSup.UseVisualStyleBackColor = false;
            btnSaveProdSup.Click += btnSaveProdSup_Click;
            // 
            // cboProduct
            // 
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(312, 152);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(224, 28);
            cboProduct.TabIndex = 25;
            // 
            // cboSupplier
            // 
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(312, 211);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(224, 28);
            cboSupplier.TabIndex = 26;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblProduct.Location = new Point(116, 151);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(87, 25);
            lblProduct.TabIndex = 27;
            lblProduct.Text = "Product :";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplier.Location = new Point(116, 214);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(86, 25);
            lblSupplier.TabIndex = 28;
            lblSupplier.Text = "Supplier:";
            // 
            // txtProductSupId
            // 
            txtProductSupId.Location = new Point(312, 101);
            txtProductSupId.Name = "txtProductSupId";
            txtProductSupId.Size = new Size(224, 27);
            txtProductSupId.TabIndex = 30;
            // 
            // lblProdSupId
            // 
            lblProdSupId.AutoSize = true;
            lblProdSupId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblProdSupId.Location = new Point(116, 103);
            lblProdSupId.Name = "lblProdSupId";
            lblProdSupId.Size = new Size(185, 25);
            lblProdSupId.TabIndex = 29;
            lblProdSupId.Text = "Product Supplier ID :";
            // 
            // frmAddModifyProdSuppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1032, 503);
            Controls.Add(txtProductSupId);
            Controls.Add(lblProdSupId);
            Controls.Add(lblSupplier);
            Controls.Add(lblProduct);
            Controls.Add(cboSupplier);
            Controls.Add(cboProduct);
            Controls.Add(btnSaveProdSup);
            Controls.Add(btnExit);
            Controls.Add(btnEditProdSup);
            Controls.Add(btnAddProdSup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddModifyProdSuppliers";
            Text = "frmAddModifyProdSuppliers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnExit;
        private Button btnEditProdSup;
        private Button btnAddProdSup;
        private Button btnSaveProdSup;
        private ComboBox cboProduct;
        private ComboBox cboSupplier;
        private Label lblProduct;
        private Label lblSupplier;
        private TextBox txtProductSupId;
        private Label lblProdSupId;
    }
}