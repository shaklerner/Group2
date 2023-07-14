namespace TravelExpertsGUI
{
    partial class Packages
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
            components = new System.ComponentModel.Container();
            btnPackages = new Button();
            btnCancel = new Label();
            dgvPackages = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            btnOpenAddPackage = new Button();
            btnEditPAckages = new Button();
            pnlPackageContent = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            pnlPackageContent.SuspendLayout();
            SuspendLayout();
            // 
            // btnPackages
            // 
            btnPackages.BackColor = Color.Teal;
            btnPackages.FlatAppearance.BorderSize = 0;
            btnPackages.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPackages.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnPackages.FlatStyle = FlatStyle.Flat;
            btnPackages.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPackages.ForeColor = Color.White;
            btnPackages.ImageAlign = ContentAlignment.MiddleLeft;
            btnPackages.Location = new Point(431, 623);
            btnPackages.Name = "btnPackages";
            btnPackages.Size = new Size(250, 40);
            btnPackages.TabIndex = 2;
            btnPackages.Text = "Edit Packages ";
            btnPackages.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.AutoSize = true;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Gray;
            btnCancel.Location = new Point(1016, 8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(20, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "X";
            btnCancel.Click += btnCancel_Click;
            // 
            // dgvPackages
            // 
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvPackages.Location = new Point(66, 91);
            dgvPackages.Name = "dgvPackages";
            dgvPackages.RowHeadersWidth = 51;
            dgvPackages.RowTemplate.Height = 29;
            dgvPackages.Size = new Size(891, 476);
            dgvPackages.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "Package Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Package Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Package Start Date";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Package End Date";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Package Descrption";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Base Price";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Agency Commission";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // btnOpenAddPackage
            // 
            btnOpenAddPackage.BackColor = Color.Teal;
            btnOpenAddPackage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenAddPackage.ForeColor = Color.White;
            btnOpenAddPackage.Location = new Point(49, 11);
            btnOpenAddPackage.Name = "btnOpenAddPackage";
            btnOpenAddPackage.Size = new Size(178, 45);
            btnOpenAddPackage.TabIndex = 17;
            btnOpenAddPackage.Text = "&Create New ";
            btnOpenAddPackage.UseVisualStyleBackColor = false;
            //btnOpenAddPackage.Click += btnOpenAddPackage_Click;
            // 
            // btnEditPAckages
            // 
            btnEditPAckages.BackColor = Color.Teal;
            btnEditPAckages.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditPAckages.ForeColor = Color.White;
            btnEditPAckages.Location = new Point(259, 11);
            btnEditPAckages.Name = "btnEditPAckages";
            btnEditPAckages.Size = new Size(156, 45);
            btnEditPAckages.TabIndex = 18;
            btnEditPAckages.Text = "&Update Package";
            btnEditPAckages.UseVisualStyleBackColor = false;
            // 
            // pnlPackageContent
            // 
            pnlPackageContent.Controls.Add(btnEditPAckages);
            pnlPackageContent.Controls.Add(btnOpenAddPackage);
            pnlPackageContent.Controls.Add(dgvPackages);
            pnlPackageContent.Controls.Add(btnCancel);
            pnlPackageContent.Location = new Point(3, 1);
            pnlPackageContent.Name = "pnlPackageContent";
            pnlPackageContent.Size = new Size(1050, 600);
            pnlPackageContent.TabIndex = 19;
            // 
            // Packages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1050, 600);
            Controls.Add(pnlPackageContent);
            Controls.Add(btnPackages);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Packages";
            Text = "Packages";
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            pnlPackageContent.ResumeLayout(false);
            pnlPackageContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnPackages;
        private Label btnCancel;
        private DataGridView dgvPackages;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private BindingSource bindingSource1;
        private Button btnOpenAddPackage;
        private Button btnEditPAckages;
        private Panel pnlPackageContent;
    }
}