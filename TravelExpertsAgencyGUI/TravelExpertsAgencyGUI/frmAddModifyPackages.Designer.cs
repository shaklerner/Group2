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
            label8 = new Label();
            cboProd = new ComboBox();
            cboSupp = new ComboBox();
            txtDesc = new RichTextBox();
            txtPackageName = new TextBox();
            labelProd = new Label();
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
            btnOkPackage.Location = new Point(600, 266);
            btnOkPackage.Margin = new Padding(3, 2, 3, 2);
            btnOkPackage.Name = "btnOkPackage";
            btnOkPackage.Size = new Size(119, 35);
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
            btnCancel.Location = new Point(600, 328);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(119, 35);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(108, 123);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 8;
            label2.Text = "Start Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(118, 159);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 9;
            label3.Text = "End Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(99, 266);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 10;
            label4.Text = "Description :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(108, 195);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 11;
            label5.Text = "Base Price :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(41, 231);
            label6.Name = "label6";
            label6.Size = new Size(150, 20);
            label6.TabIndex = 12;
            label6.Text = "Agency Commission :";
            // 
            // dtpPackageStartDate
            // 
            dtpPackageStartDate.Location = new Point(213, 122);
            dtpPackageStartDate.Margin = new Padding(3, 2, 3, 2);
            dtpPackageStartDate.Name = "dtpPackageStartDate";
            dtpPackageStartDate.Size = new Size(305, 23);
            dtpPackageStartDate.TabIndex = 15;
            dtpPackageStartDate.Tag = "Start date";
            // 
            // dtpPackageEndDate
            // 
            dtpPackageEndDate.Location = new Point(213, 158);
            dtpPackageEndDate.Margin = new Padding(3, 2, 3, 2);
            dtpPackageEndDate.Name = "dtpPackageEndDate";
            dtpPackageEndDate.Size = new Size(305, 23);
            dtpPackageEndDate.TabIndex = 16;
            dtpPackageEndDate.Tag = "End Date";
            // 
            // txtPackageBasePrice
            // 
            txtPackageBasePrice.Location = new Point(211, 194);
            txtPackageBasePrice.Margin = new Padding(3, 2, 3, 2);
            txtPackageBasePrice.Name = "txtPackageBasePrice";
            txtPackageBasePrice.Size = new Size(306, 23);
            txtPackageBasePrice.TabIndex = 17;
            txtPackageBasePrice.Tag = "Base Price";
            // 
            // txtAgencyCommission
            // 
            txtAgencyCommission.Location = new Point(211, 230);
            txtAgencyCommission.Margin = new Padding(3, 2, 3, 2);
            txtAgencyCommission.Name = "txtAgencyCommission";
            txtAgencyCommission.Size = new Size(306, 23);
            txtAgencyCommission.TabIndex = 18;
            txtAgencyCommission.Tag = "Agency Commission";
            // 
            // btnExitPackages
            // 
            btnExitPackages.Location = new Point(0, 0);
            btnExitPackages.Name = "btnExitPackages";
            btnExitPackages.Size = new Size(100, 23);
            btnExitPackages.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(74, 87);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 22;
            label7.Text = "Package Name :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(77, 15);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 23;
            label8.Text = "Product Name :";
            // 
            // cboProd
            // 
            cboProd.FormattingEnabled = true;
            cboProd.Location = new Point(213, 14);
            cboProd.Name = "cboProd";
            cboProd.Size = new Size(305, 23);
            cboProd.TabIndex = 24;
            cboProd.Tag = "Product Name";
            // 
            // cboSupp
            // 
            cboSupp.FormattingEnabled = true;
            cboSupp.Location = new Point(213, 50);
            cboSupp.Name = "cboSupp";
            cboSupp.Size = new Size(305, 23);
            cboSupp.TabIndex = 25;
            cboSupp.Tag = "Package name";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(211, 266);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(306, 97);
            txtDesc.TabIndex = 26;
            txtDesc.Tag = "Description";
            txtDesc.Text = "";
            // 
            // txtPackageName
            // 
            txtPackageName.Location = new Point(212, 86);
            txtPackageName.Margin = new Padding(3, 2, 3, 2);
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(306, 23);
            txtPackageName.TabIndex = 27;
            txtPackageName.Tag = "Package Name";
            // 
            // labelProd
            // 
            labelProd.AutoSize = true;
            labelProd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelProd.Location = new Point(80, 51);
            labelProd.Name = "labelProd";
            labelProd.Size = new Size(111, 20);
            labelProd.TabIndex = 28;
            labelProd.Text = "Product Name :";
            // 
            // frmAddModifyPackages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(872, 377);
            Controls.Add(labelProd);
            Controls.Add(txtPackageName);
            Controls.Add(txtDesc);
            Controls.Add(cboSupp);
            Controls.Add(cboProd);
            Controls.Add(label8);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAddModifyPackages";
            Text = "frmAddModifyPackages";
            Load += frmAddModifyPackages_Load;
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
        private Label label8;
        private ComboBox cboProd;
        private ComboBox cboSupp;
        private RichTextBox txtDesc;
        private TextBox txtPackageName;
        private Label labelProd;
    }
}