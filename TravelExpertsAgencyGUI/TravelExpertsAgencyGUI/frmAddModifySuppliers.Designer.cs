namespace TravelExpertsAgencyGUI
{
    partial class frmAddModifySuppliers
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
            label3 = new Label();
            label2 = new Label();
            txtSupplierId = new TextBox();
            txtSupplierName = new TextBox();
            btnGenerateIdSupplier = new Button();
            btnEditSupplier = new Button();
            btnAddSupplier = new Button();
            btnSaveSupplier = new Button();
            btnExitSuppliers = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 203);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 10;
            label3.Text = "Supplier Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 157);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 11;
            label2.Text = "Supplier ID :";
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(201, 155);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(209, 27);
            txtSupplierId.TabIndex = 12;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(202, 201);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(208, 27);
            txtSupplierName.TabIndex = 13;
            // 
            // btnGenerateIdSupplier
            // 
            btnGenerateIdSupplier.BackColor = Color.FromArgb(51, 73, 107);
            btnGenerateIdSupplier.FlatAppearance.BorderSize = 0;
            btnGenerateIdSupplier.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnGenerateIdSupplier.FlatStyle = FlatStyle.Flat;
            btnGenerateIdSupplier.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerateIdSupplier.ForeColor = Color.White;
            btnGenerateIdSupplier.Location = new Point(438, 139);
            btnGenerateIdSupplier.Name = "btnGenerateIdSupplier";
            btnGenerateIdSupplier.Size = new Size(136, 43);
            btnGenerateIdSupplier.TabIndex = 14;
            btnGenerateIdSupplier.Text = "&Generate Id";
            btnGenerateIdSupplier.UseVisualStyleBackColor = false;
            // 
            // btnEditSupplier
            // 
            btnEditSupplier.BackColor = Color.FromArgb(51, 73, 107);
            btnEditSupplier.FlatAppearance.BorderSize = 0;
            btnEditSupplier.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnEditSupplier.FlatStyle = FlatStyle.Flat;
            btnEditSupplier.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditSupplier.ForeColor = Color.White;
            btnEditSupplier.Location = new Point(189, 12);
            btnEditSupplier.Name = "btnEditSupplier";
            btnEditSupplier.Size = new Size(136, 47);
            btnEditSupplier.TabIndex = 16;
            btnEditSupplier.Text = "&Edit";
            btnEditSupplier.UseVisualStyleBackColor = false;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.BackColor = Color.FromArgb(51, 73, 107);
            btnAddSupplier.FlatAppearance.BorderSize = 0;
            btnAddSupplier.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnAddSupplier.FlatStyle = FlatStyle.Flat;
            btnAddSupplier.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddSupplier.ForeColor = Color.White;
            btnAddSupplier.Location = new Point(28, 12);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(136, 47);
            btnAddSupplier.TabIndex = 15;
            btnAddSupplier.Text = "&Add";
            btnAddSupplier.UseVisualStyleBackColor = false;
            // 
            // btnSaveSupplier
            // 
            btnSaveSupplier.BackColor = Color.FromArgb(51, 73, 107);
            btnSaveSupplier.FlatAppearance.BorderSize = 0;
            btnSaveSupplier.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnSaveSupplier.FlatStyle = FlatStyle.Flat;
            btnSaveSupplier.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveSupplier.ForeColor = Color.White;
            btnSaveSupplier.Location = new Point(355, 12);
            btnSaveSupplier.Name = "btnSaveSupplier";
            btnSaveSupplier.Size = new Size(136, 47);
            btnSaveSupplier.TabIndex = 18;
            btnSaveSupplier.Text = "&Save";
            btnSaveSupplier.UseVisualStyleBackColor = false;
            // 
            // btnExitSuppliers
            // 
            btnExitSuppliers.AutoSize = true;
            btnExitSuppliers.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExitSuppliers.Location = new Point(996, 9);
            btnExitSuppliers.Name = "btnExitSuppliers";
            btnExitSuppliers.Size = new Size(24, 25);
            btnExitSuppliers.TabIndex = 19;
            btnExitSuppliers.Text = "X";
            btnExitSuppliers.Click += btnExitSuppliers_Click;
            // 
            // frmAddModifySuppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1032, 503);
            Controls.Add(btnExitSuppliers);
            Controls.Add(btnSaveSupplier);
            Controls.Add(btnEditSupplier);
            Controls.Add(btnAddSupplier);
            Controls.Add(btnGenerateIdSupplier);
            Controls.Add(txtSupplierName);
            Controls.Add(txtSupplierId);
            Controls.Add(label2);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddModifySuppliers";
            Text = "frmAddModifySuppliers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox txtSupplierId;
        private TextBox txtSupplierName;
        private Button btnGenerateIdSupplier;
        private Button btnEditSupplier;
        private Button btnAddSupplier;
        private Button btnSaveSupplier;
        private Label btnExitSuppliers;
    }
}