namespace TravelExpertsGUI
{
    partial class frmProductsSuppliers
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
            btnEditProdSupp = new Button();
            btnAddProdSupp = new Button();
            btnSaveProdSupp = new Button();
            label1 = new Label();
            label2 = new Label();
            cboProducts = new ComboBox();
            cboSuppliers = new ComboBox();
            btnCancel = new Label();
            SuspendLayout();
            // 
            // btnEditProdSupp
            // 
            btnEditProdSupp.BackColor = Color.Teal;
            btnEditProdSupp.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditProdSupp.ForeColor = Color.White;
            btnEditProdSupp.Location = new Point(208, 43);
            btnEditProdSupp.Name = "btnEditProdSupp";
            btnEditProdSupp.Size = new Size(100, 45);
            btnEditProdSupp.TabIndex = 9;
            btnEditProdSupp.Text = "&Edit";
            btnEditProdSupp.UseVisualStyleBackColor = false;
            // 
            // btnAddProdSupp
            // 
            btnAddProdSupp.BackColor = Color.Teal;
            btnAddProdSupp.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProdSupp.ForeColor = Color.White;
            btnAddProdSupp.Location = new Point(79, 43);
            btnAddProdSupp.Name = "btnAddProdSupp";
            btnAddProdSupp.Size = new Size(100, 45);
            btnAddProdSupp.TabIndex = 10;
            btnAddProdSupp.Text = "&Add";
            btnAddProdSupp.UseVisualStyleBackColor = false;
            // 
            // btnSaveProdSupp
            // 
            btnSaveProdSupp.BackColor = Color.Teal;
            btnSaveProdSupp.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveProdSupp.ForeColor = Color.White;
            btnSaveProdSupp.Location = new Point(330, 43);
            btnSaveProdSupp.Name = "btnSaveProdSupp";
            btnSaveProdSupp.Size = new Size(100, 45);
            btnSaveProdSupp.TabIndex = 11;
            btnSaveProdSupp.Text = "&Edit";
            btnSaveProdSupp.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(101, 156);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 12;
            label1.Text = "Product :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(101, 210);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 13;
            label2.Text = "Supplier :";
            // 
            // cboProducts
            // 
            cboProducts.FormattingEnabled = true;
            cboProducts.Location = new Point(219, 157);
            cboProducts.Name = "cboProducts";
            cboProducts.Size = new Size(292, 28);
            cboProducts.TabIndex = 14;
            // 
            // cboSuppliers
            // 
            cboSuppliers.FormattingEnabled = true;
            cboSuppliers.Location = new Point(219, 211);
            cboSuppliers.Name = "cboSuppliers";
            cboSuppliers.Size = new Size(292, 28);
            cboSuppliers.TabIndex = 15;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.AutoSize = true;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Gray;
            btnCancel.Location = new Point(1000, 9);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(20, 23);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "X";
            btnCancel.Click += btnCancel_Click;
            // 
            // frmProductsSuppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 553);
            Controls.Add(btnCancel);
            Controls.Add(cboSuppliers);
            Controls.Add(cboProducts);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSaveProdSupp);
            Controls.Add(btnAddProdSupp);
            Controls.Add(btnEditProdSupp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductsSuppliers";
            Text = "frmProductsSuppliers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditProdSupp;
        private Button btnAddProdSupp;
        private Button btnSaveProdSupp;
        private Label label1;
        private Label label2;
        private ComboBox cboProducts;
        private ComboBox cboSuppliers;
        private Label btnCancel;
    }
}