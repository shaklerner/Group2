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
            btnEditSuppliers = new Button();
            btnAddSuppliers = new Button();
            dgvSuppliers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
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
            // btnEditSuppliers
            // 
            btnEditSuppliers.BackColor = Color.FromArgb(51, 73, 107);
            btnEditSuppliers.FlatAppearance.BorderSize = 0;
            btnEditSuppliers.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnEditSuppliers.FlatStyle = FlatStyle.Flat;
            btnEditSuppliers.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditSuppliers.ForeColor = Color.White;
            btnEditSuppliers.Location = new Point(233, 22);
            btnEditSuppliers.Name = "btnEditSuppliers";
            btnEditSuppliers.Size = new Size(136, 47);
            btnEditSuppliers.TabIndex = 16;
            btnEditSuppliers.Text = "&Edit";
            btnEditSuppliers.UseVisualStyleBackColor = false;
            // 
            // btnAddSuppliers
            // 
            btnAddSuppliers.BackColor = Color.FromArgb(51, 73, 107);
            btnAddSuppliers.FlatAppearance.BorderSize = 0;
            btnAddSuppliers.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnAddSuppliers.FlatStyle = FlatStyle.Flat;
            btnAddSuppliers.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddSuppliers.ForeColor = Color.White;
            btnAddSuppliers.Location = new Point(67, 22);
            btnAddSuppliers.Name = "btnAddSuppliers";
            btnAddSuppliers.Size = new Size(136, 47);
            btnAddSuppliers.TabIndex = 15;
            btnAddSuppliers.Text = "&Add ";
            btnAddSuppliers.UseVisualStyleBackColor = false;
            btnAddSuppliers.Click += btnAddSuppliers_Click;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.BackgroundColor = Color.WhiteSmoke;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(46, 100);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.RowTemplate.Height = 29;
            dgvSuppliers.Size = new Size(986, 423);
            dgvSuppliers.TabIndex = 17;
            // 
            // frmSuppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 550);
            Controls.Add(dgvSuppliers);
            Controls.Add(btnEditSuppliers);
            Controls.Add(btnAddSuppliers);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSuppliers";
            Text = "frmSuppliers";
            Load += frmSuppliers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnExit;
        private Button btnEditSuppliers;
        private Button btnAddSuppliers;
        private DataGridView dgvSuppliers;
    }
}