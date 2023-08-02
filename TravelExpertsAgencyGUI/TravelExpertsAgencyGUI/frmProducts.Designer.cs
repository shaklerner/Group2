namespace TravelExpertsAgencyGUI
{
    partial class frmProducts
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
            btnAddProducts = new Button();
            btnEditProducts = new Button();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(1014, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(24, 25);
            btnExit.TabIndex = 8;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // btnAddProducts
            // 
            btnAddProducts.BackColor = Color.FromArgb(51, 73, 107);
            btnAddProducts.FlatAppearance.BorderSize = 0;
            btnAddProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnAddProducts.FlatStyle = FlatStyle.Flat;
            btnAddProducts.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProducts.ForeColor = Color.White;
            btnAddProducts.Location = new Point(21, 12);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(136, 47);
            btnAddProducts.TabIndex = 9;
            btnAddProducts.Text = "&Add ";
            btnAddProducts.UseVisualStyleBackColor = false;
            btnAddProducts.Click += btnAddProducts_Click;
            // 
            // btnEditProducts
            // 
            btnEditProducts.BackColor = Color.FromArgb(51, 73, 107);
            btnEditProducts.FlatAppearance.BorderSize = 0;
            btnEditProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnEditProducts.FlatStyle = FlatStyle.Flat;
            btnEditProducts.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditProducts.ForeColor = Color.White;
            btnEditProducts.Location = new Point(180, 12);
            btnEditProducts.Name = "btnEditProducts";
            btnEditProducts.Size = new Size(136, 47);
            btnEditProducts.TabIndex = 10;
            btnEditProducts.Text = "&Edit";
            btnEditProducts.UseVisualStyleBackColor = false;
            btnEditProducts.Click += btnEditProducts_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.WhiteSmoke;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(23, 93);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1002, 433);
            dgvProducts.TabIndex = 11;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 550);
            Controls.Add(dgvProducts);
            Controls.Add(btnEditProducts);
            Controls.Add(btnAddProducts);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProducts";
            Text = "frmProducts";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnExit;
        private Button btnAddProducts;
        private Button btnEditProducts;
        private DataGridView dgvProducts;
    }
}