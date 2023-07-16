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
            label3 = new Label();
            label1 = new Label();
            txtProductId = new TextBox();
            label2 = new Label();
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
            btnAddProdSup.Click += btnAddProdSup_Click;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(116, 151);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 27;
            label3.Text = "Product :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(116, 214);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 28;
            label1.Text = "Supplier:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(312, 101);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(224, 27);
            txtProductId.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(116, 103);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 29;
            label2.Text = "Product ID :";
            // 
            // frmAddModifyProdSuppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1032, 503);
            Controls.Add(txtProductId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
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
        private Label label3;
        private Label label1;
        private TextBox txtProductId;
        private Label label2;
    }
}