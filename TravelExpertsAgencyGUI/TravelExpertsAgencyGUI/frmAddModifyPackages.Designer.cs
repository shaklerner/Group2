namespace TravelExpertsAgencyGUI
{
    partial class frmAddModifyPackages
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
            btnOkPackage = new Button();
            btnCancel = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpPackageStartDate = new DateTimePicker();
            dtpPackageEndDate = new DateTimePicker();
            txtPackageBasePrice = new TextBox();
            txtAgencyCommission = new TextBox();
            btnExitPackages = new Label();
            label7 = new Label();
            txtDesc = new RichTextBox();
            txtPackageName = new TextBox();
            dgvProductSuppliers = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Supplier = new DataGridViewTextBoxColumn();
            dgvExistingProductSuppliers = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductSuppliers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExistingProductSuppliers).BeginInit();
            SuspendLayout();
            // 
            // btnOkPackage
            // 
            btnOkPackage.BackColor = Color.FromArgb(51, 73, 107);
            btnOkPackage.FlatAppearance.BorderSize = 0;
            btnOkPackage.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnOkPackage.FlatStyle = FlatStyle.Flat;
            btnOkPackage.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOkPackage.ForeColor = Color.White;
            btnOkPackage.Location = new Point(404, 368);
            btnOkPackage.Name = "btnOkPackage";
            btnOkPackage.Size = new Size(136, 47);
            btnOkPackage.TabIndex = 3;
            btnOkPackage.Text = "&Ok";
            btnOkPackage.UseVisualStyleBackColor = false;
            btnOkPackage.Click += btnOkPackage_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(51, 73, 107);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(262, 368);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(136, 47);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(72, 80);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 8;
            label2.Text = "Start Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(83, 127);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 9;
            label3.Text = "End Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(62, 288);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 10;
            label4.Text = "Description :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(72, 175);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 11;
            label5.Text = "Base Price :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(-4, 224);
            label6.Name = "label6";
            label6.Size = new Size(191, 25);
            label6.TabIndex = 12;
            label6.Text = "Agency Commission :";
            // 
            // dtpPackageStartDate
            // 
            dtpPackageStartDate.Location = new Point(192, 79);
            dtpPackageStartDate.Name = "dtpPackageStartDate";
            dtpPackageStartDate.Size = new Size(348, 27);
            dtpPackageStartDate.TabIndex = 15;
            dtpPackageStartDate.Tag = "Start date";
            // 
            // dtpPackageEndDate
            // 
            dtpPackageEndDate.Location = new Point(192, 127);
            dtpPackageEndDate.Name = "dtpPackageEndDate";
            dtpPackageEndDate.Size = new Size(348, 27);
            dtpPackageEndDate.TabIndex = 16;
            dtpPackageEndDate.Tag = "End Date";
            // 
            // txtPackageBasePrice
            // 
            txtPackageBasePrice.Location = new Point(190, 175);
            txtPackageBasePrice.Name = "txtPackageBasePrice";
            txtPackageBasePrice.Size = new Size(349, 27);
            txtPackageBasePrice.TabIndex = 17;
            txtPackageBasePrice.Tag = "Base Price";
            // 
            // txtAgencyCommission
            // 
            txtAgencyCommission.Location = new Point(190, 223);
            txtAgencyCommission.Name = "txtAgencyCommission";
            txtAgencyCommission.Size = new Size(349, 27);
            txtAgencyCommission.TabIndex = 18;
            txtAgencyCommission.Tag = "Agency Commission";
            // 
            // btnExitPackages
            // 
            btnExitPackages.Location = new Point(0, 0);
            btnExitPackages.Name = "btnExitPackages";
            btnExitPackages.Size = new Size(114, 31);
            btnExitPackages.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(34, 32);
            label7.Name = "label7";
            label7.Size = new Size(145, 25);
            label7.TabIndex = 22;
            label7.Text = "Package Name :";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(191, 288);
            txtDesc.Margin = new Padding(3, 4, 3, 4);
            txtDesc.MaxLength = 51;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(349, 73);
            txtDesc.TabIndex = 26;
            txtDesc.Tag = "Description";
            txtDesc.Text = "";
            // 
            // txtPackageName
            // 
            txtPackageName.Location = new Point(191, 31);
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(349, 27);
            txtPackageName.TabIndex = 27;
            txtPackageName.Tag = "Package Name";
            // 
            // dgvProductSuppliers
            // 
            dgvProductSuppliers.AllowUserToAddRows = false;
            dgvProductSuppliers.AllowUserToDeleteRows = false;
            dgvProductSuppliers.AllowUserToResizeColumns = false;
            dgvProductSuppliers.AllowUserToResizeRows = false;
            dgvProductSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductSuppliers.Columns.AddRange(new DataGridViewColumn[] { Product, Supplier });
            dgvProductSuppliers.Location = new Point(547, 31);
            dgvProductSuppliers.Name = "dgvProductSuppliers";
            dgvProductSuppliers.ReadOnly = true;
            dgvProductSuppliers.RowHeadersWidth = 51;
            dgvProductSuppliers.RowTemplate.Height = 29;
            dgvProductSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductSuppliers.Size = new Size(446, 298);
            dgvProductSuppliers.TabIndex = 30;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.MinimumWidth = 6;
            Product.Name = "Product";
            Product.ReadOnly = true;
            Product.Width = 125;
            // 
            // Supplier
            // 
            Supplier.HeaderText = "Supplier";
            Supplier.MinimumWidth = 6;
            Supplier.Name = "Supplier";
            Supplier.ReadOnly = true;
            Supplier.Width = 125;
            // 
            // dgvExistingProductSuppliers
            // 
            dgvExistingProductSuppliers.AllowUserToAddRows = false;
            dgvExistingProductSuppliers.AllowUserToDeleteRows = false;
            dgvExistingProductSuppliers.AllowUserToResizeColumns = false;
            dgvExistingProductSuppliers.AllowUserToResizeRows = false;
            dgvExistingProductSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExistingProductSuppliers.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dgvExistingProductSuppliers.Location = new Point(547, 338);
            dgvExistingProductSuppliers.MultiSelect = false;
            dgvExistingProductSuppliers.Name = "dgvExistingProductSuppliers";
            dgvExistingProductSuppliers.ReadOnly = true;
            dgvExistingProductSuppliers.RowHeadersWidth = 51;
            dgvExistingProductSuppliers.RowTemplate.Height = 29;
            dgvExistingProductSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExistingProductSuppliers.Size = new Size(446, 139);
            dgvExistingProductSuppliers.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Product";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Supplier";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // frmAddModifyPackages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(997, 503);
            Controls.Add(dgvExistingProductSuppliers);
            Controls.Add(dgvProductSuppliers);
            Controls.Add(txtPackageName);
            Controls.Add(txtDesc);
            Controls.Add(label7);
            Controls.Add(btnExitPackages);
            Controls.Add(txtAgencyCommission);
            Controls.Add(txtPackageBasePrice);
            Controls.Add(dtpPackageEndDate);
            Controls.Add(dtpPackageStartDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnOkPackage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddModifyPackages";
            Text = "frmAddModifyPackages";
            Load += frmAddModifyPackages_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductSuppliers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExistingProductSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOkPackage;
        private Button btnCancel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpPackageStartDate;
        private DateTimePicker dtpPackageEndDate;
        private TextBox txtPackageBasePrice;
        private TextBox txtAgencyCommission;
        private Label btnExitPackages;
        private Label label7;
        private RichTextBox txtDesc;
        private TextBox txtPackageName;
        private DataGridView dgvProductSuppliers;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Supplier;
        private DataGridView dgvExistingProductSuppliers;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}