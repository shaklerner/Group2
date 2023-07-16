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
            btnAddProdSup = new Button();
            btnDeleteProdSupp = new Button();
            btnSavePackages = new Button();
            btnExitPackages = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPackageName = new TextBox();
            txtDescription = new TextBox();
            dtpPackageStartDate = new DateTimePicker();
            dtpPackageEndDate = new DateTimePicker();
            txtPackageBasePrice = new TextBox();
            txtAgencyCommission = new TextBox();
            dgvProductSuppliers = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductSuppliers).BeginInit();
            SuspendLayout();
            // 
            // btnAddProdSup
            // 
            btnAddProdSup.BackColor = Color.FromArgb(51, 73, 107);
            btnAddProdSup.FlatAppearance.BorderSize = 0;
            btnAddProdSup.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnAddProdSup.FlatStyle = FlatStyle.Flat;
            btnAddProdSup.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProdSup.ForeColor = Color.White;
            btnAddProdSup.Location = new Point(879, 378);
            btnAddProdSup.Name = "btnAddProdSup";
            btnAddProdSup.Size = new Size(136, 47);
            btnAddProdSup.TabIndex = 3;
            btnAddProdSup.Text = "&Add ";
            btnAddProdSup.UseVisualStyleBackColor = false;
            // 
            // btnDeleteProdSupp
            // 
            btnDeleteProdSupp.BackColor = Color.FromArgb(51, 73, 107);
            btnDeleteProdSupp.FlatAppearance.BorderSize = 0;
            btnDeleteProdSupp.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnDeleteProdSupp.FlatStyle = FlatStyle.Flat;
            btnDeleteProdSupp.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteProdSupp.ForeColor = Color.White;
            btnDeleteProdSupp.Location = new Point(879, 431);
            btnDeleteProdSupp.Name = "btnDeleteProdSupp";
            btnDeleteProdSupp.Size = new Size(136, 47);
            btnDeleteProdSupp.TabIndex = 4;
            btnDeleteProdSupp.Text = "&Delete";
            btnDeleteProdSupp.UseVisualStyleBackColor = false;
            // 
            // btnSavePackages
            // 
            btnSavePackages.BackColor = Color.FromArgb(51, 73, 107);
            btnSavePackages.FlatAppearance.BorderSize = 0;
            btnSavePackages.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnSavePackages.FlatStyle = FlatStyle.Flat;
            btnSavePackages.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSavePackages.ForeColor = Color.White;
            btnSavePackages.Location = new Point(640, 237);
            btnSavePackages.Name = "btnSavePackages";
            btnSavePackages.Size = new Size(136, 47);
            btnSavePackages.TabIndex = 5;
            btnSavePackages.Text = "&Save";
            btnSavePackages.UseVisualStyleBackColor = false;
            // 
            // btnExitPackages
            // 
            btnExitPackages.AutoSize = true;
            btnExitPackages.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExitPackages.Location = new Point(1014, 9);
            btnExitPackages.Name = "btnExitPackages";
            btnExitPackages.Size = new Size(24, 25);
            btnExitPackages.TabIndex = 6;
            btnExitPackages.Text = "X";
            btnExitPackages.Click += btnExitPackages_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 28);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 7;
            label1.Text = "Package Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 113);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 8;
            label2.Text = "Start Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 161);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 9;
            label3.Text = "End Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 68);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 10;
            label4.Text = "Description :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(36, 213);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 11;
            label5.Text = "Base Price :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 256);
            label6.Name = "label6";
            label6.Size = new Size(191, 25);
            label6.TabIndex = 12;
            label6.Text = "Agency Commission :";
            // 
            // txtPackageName
            // 
            txtPackageName.Location = new Point(245, 29);
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(349, 27);
            txtPackageName.TabIndex = 13;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(246, 69);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(348, 27);
            txtDescription.TabIndex = 14;
            // 
            // dtpPackageStartDate
            // 
            dtpPackageStartDate.Location = new Point(245, 111);
            dtpPackageStartDate.Name = "dtpPackageStartDate";
            dtpPackageStartDate.Size = new Size(349, 27);
            dtpPackageStartDate.TabIndex = 15;
            // 
            // dtpPackageEndDate
            // 
            dtpPackageEndDate.Location = new Point(246, 161);
            dtpPackageEndDate.Name = "dtpPackageEndDate";
            dtpPackageEndDate.Size = new Size(348, 27);
            dtpPackageEndDate.TabIndex = 16;
            // 
            // txtPackageBasePrice
            // 
            txtPackageBasePrice.Location = new Point(246, 213);
            txtPackageBasePrice.Name = "txtPackageBasePrice";
            txtPackageBasePrice.Size = new Size(349, 27);
            txtPackageBasePrice.TabIndex = 17;
            // 
            // txtAgencyCommission
            // 
            txtAgencyCommission.Location = new Point(246, 257);
            txtAgencyCommission.Name = "txtAgencyCommission";
            txtAgencyCommission.Size = new Size(349, 27);
            txtAgencyCommission.TabIndex = 18;
            // 
            // dgvProductSuppliers
            // 
            dgvProductSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductSuppliers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvProductSuppliers.Location = new Point(12, 343);
            dgvProductSuppliers.Name = "dgvProductSuppliers";
            dgvProductSuppliers.RowHeadersWidth = 51;
            dgvProductSuppliers.RowTemplate.Height = 29;
            dgvProductSuppliers.Size = new Size(834, 195);
            dgvProductSuppliers.TabIndex = 19;
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
            Column2.HeaderText = "Product ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Supplier";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(18, 305);
            label7.Name = "label7";
            label7.Size = new Size(125, 35);
            label7.TabIndex = 20;
            label7.Text = "Products ";
            // 
            // frmAddModifyPackages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1050, 550);
            Controls.Add(label7);
            Controls.Add(dgvProductSuppliers);
            Controls.Add(txtAgencyCommission);
            Controls.Add(txtPackageBasePrice);
            Controls.Add(dtpPackageEndDate);
            Controls.Add(dtpPackageStartDate);
            Controls.Add(txtDescription);
            Controls.Add(txtPackageName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExitPackages);
            Controls.Add(btnSavePackages);
            Controls.Add(btnDeleteProdSupp);
            Controls.Add(btnAddProdSup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddModifyPackages";
            Text = "frmAddModifyPackages";
            Load += frmAddModifyPackages_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddProdSup;
        private Button btnDeleteProdSupp;
        private Button btnSavePackages;
        private Label btnExitPackages;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPackageName;
        private TextBox txtDescription;
        private DateTimePicker dtpPackageStartDate;
        private DateTimePicker dtpPackageEndDate;
        private TextBox txtPackageBasePrice;
        private TextBox txtAgencyCommission;
        private DataGridView dgvProductSuppliers;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}