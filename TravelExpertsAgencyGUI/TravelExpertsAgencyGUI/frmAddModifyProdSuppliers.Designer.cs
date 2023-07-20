﻿namespace TravelExpertsAgencyGUI
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
            btnCancelProdSup = new Button();
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
            // btnCancelProdSup
            // 
            btnCancelProdSup.BackColor = Color.FromArgb(51, 73, 107);
            btnCancelProdSup.FlatAppearance.BorderSize = 0;
            btnCancelProdSup.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnCancelProdSup.FlatStyle = FlatStyle.Flat;
            btnCancelProdSup.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelProdSup.ForeColor = Color.White;
            btnCancelProdSup.Location = new Point(415, 274);
            btnCancelProdSup.Name = "btnCancelProdSup";
            btnCancelProdSup.Size = new Size(136, 47);
            btnCancelProdSup.TabIndex = 22;
            btnCancelProdSup.Text = "&Cancel";
            btnCancelProdSup.UseVisualStyleBackColor = false;
            btnCancelProdSup.Click += btnCancelProdSup_Click;
            // 
            // btnSaveProdSup
            // 
            btnSaveProdSup.BackColor = Color.FromArgb(51, 73, 107);
            btnSaveProdSup.FlatAppearance.BorderSize = 0;
            btnSaveProdSup.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnSaveProdSup.FlatStyle = FlatStyle.Flat;
            btnSaveProdSup.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveProdSup.ForeColor = Color.White;
            btnSaveProdSup.Location = new Point(250, 274);
            btnSaveProdSup.Name = "btnSaveProdSup";
            btnSaveProdSup.Size = new Size(136, 47);
            btnSaveProdSup.TabIndex = 24;
            btnSaveProdSup.Text = "&Save";
            btnSaveProdSup.UseVisualStyleBackColor = false;
            btnSaveProdSup.Click += btnSaveProdSup_Click;
            // 
            // cboProduct
            // 
            cboProduct.BackColor = SystemColors.Window;
            cboProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(312, 152);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(224, 28);
            cboProduct.TabIndex = 25;
            cboProduct.Tag = "Product";
            // 
            // cboSupplier
            // 
            cboSupplier.BackColor = SystemColors.Window;
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(312, 211);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(224, 28);
            cboSupplier.TabIndex = 26;
            cboSupplier.Tag = "Supplier";
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
            txtProductSupId.BackColor = Color.WhiteSmoke;
            txtProductSupId.Location = new Point(312, 101);
            txtProductSupId.Name = "txtProductSupId";
            txtProductSupId.Size = new Size(224, 27);
            txtProductSupId.TabIndex = 30;
            txtProductSupId.Tag = "ProductSupplierId";
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
            Controls.Add(btnCancelProdSup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddModifyProdSuppliers";
            Text = "frmAddModifyProdSuppliers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnExit;
        private Button btnCancelProdSup;
        private Button btnSaveProdSup;
        private ComboBox cboProduct;
        private ComboBox cboSupplier;
        private Label lblProduct;
        private Label lblSupplier;
        private TextBox txtProductSupId;
        private Label lblProdSupId;
    }
}