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
            btnExitSuppliers = new Label();
            lblMode = new Label();
            label1 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
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
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMode.Location = new Point(218, 126);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(171, 28);
            lblMode.TabIndex = 20;
            lblMode.Text = "Add New Supplier";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(218, 207);
            label1.Name = "label1";
            label1.Size = new Size(31, 28);
            label1.TabIndex = 21;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(288, 204);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(125, 34);
            txtID.TabIndex = 22;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(288, 255);
            txtName.Name = "txtName";
            txtName.Size = new Size(462, 34);
            txtName.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(218, 258);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 23;
            label2.Text = "Name";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirm.Location = new Point(650, 316);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(100, 40);
            btnConfirm.TabIndex = 25;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(544, 316);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddModifySuppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1032, 503);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(lblMode);
            Controls.Add(btnExitSuppliers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddModifySuppliers";
            Text = "frmAddModifySuppliers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label btnExitSuppliers;
        private Label lblMode;
        private Label label1;
        private TextBox txtID;
        private TextBox txtName;
        private Label label2;
        private Button btnConfirm;
        private Button btnCancel;
    }
}