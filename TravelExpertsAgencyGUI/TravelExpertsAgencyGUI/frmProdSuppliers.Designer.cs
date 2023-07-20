namespace TravelExpertsAgencyGUI
{
    partial class frmProdSuppliers
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
            btnEditProdSup = new Button();
            btnAddProdSup = new Button();
            dgvProdSup = new DataGridView();
            btnExit = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProdSup).BeginInit();
            SuspendLayout();
            // 
            // btnEditProdSup
            // 
            btnEditProdSup.BackColor = Color.FromArgb(51, 73, 107);
            btnEditProdSup.FlatAppearance.BorderSize = 0;
            btnEditProdSup.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnEditProdSup.FlatStyle = FlatStyle.Flat;
            btnEditProdSup.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditProdSup.ForeColor = Color.White;
            btnEditProdSup.Location = new Point(217, 12);
            btnEditProdSup.Name = "btnEditProdSup";
            btnEditProdSup.Size = new Size(136, 47);
            btnEditProdSup.TabIndex = 18;
            btnEditProdSup.Text = "&Edit";
            btnEditProdSup.UseVisualStyleBackColor = false;
            btnEditProdSup.Click += btnEditProdSup_Click;
            // 
            // btnAddProdSup
            // 
            btnAddProdSup.BackColor = Color.FromArgb(51, 73, 107);
            btnAddProdSup.FlatAppearance.BorderSize = 0;
            btnAddProdSup.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnAddProdSup.FlatStyle = FlatStyle.Flat;
            btnAddProdSup.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProdSup.ForeColor = Color.White;
            btnAddProdSup.Location = new Point(51, 12);
            btnAddProdSup.Name = "btnAddProdSup";
            btnAddProdSup.Size = new Size(136, 47);
            btnAddProdSup.TabIndex = 17;
            btnAddProdSup.Text = "&Add ";
            btnAddProdSup.UseVisualStyleBackColor = false;
            btnAddProdSup.Click += btnAddProdSup_Click;
            btnAddProdSup.MouseHover += btnAddProdSup_Click;
            // 
            // dgvProdSup
            // 
            dgvProdSup.BackgroundColor = Color.WhiteSmoke;
            dgvProdSup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdSup.Location = new Point(18, 92);
            dgvProdSup.Name = "dgvProdSup";
            dgvProdSup.RowHeadersWidth = 51;
            dgvProdSup.RowTemplate.Height = 29;
            dgvProdSup.Size = new Size(992, 379);
            dgvProdSup.TabIndex = 19;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(986, 22);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(24, 25);
            btnExit.TabIndex = 20;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // frmProdSuppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1032, 503);
            Controls.Add(btnExit);
            Controls.Add(dgvProdSup);
            Controls.Add(btnEditProdSup);
            Controls.Add(btnAddProdSup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProdSuppliers";
            Text = "frmProdSuppliers";
            Load += frmProdSuppliers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdSup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditProdSup;
        private Button btnAddProdSup;
        private DataGridView dgvProdSup;
        private Label btnExit;
    }
}