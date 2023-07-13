namespace Workshop4
{
    partial class frmAddModifyProduct
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
            label1 = new Label();
            txtProdName = new TextBox();
            label2 = new Label();
            cmbSuppliers = new ComboBox();
            btnAccept = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 82);
            label1.Name = "label1";
            label1.Size = new Size(241, 45);
            label1.TabIndex = 0;
            label1.Text = "Product Name: ";
            // 
            // txtProdName
            // 
            txtProdName.Location = new Point(297, 79);
            txtProdName.Name = "txtProdName";
            txtProdName.Size = new Size(737, 50);
            txtProdName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 209);
            label2.Name = "label2";
            label2.Size = new Size(273, 45);
            label2.TabIndex = 2;
            label2.Text = "Product Supplier: ";
            // 
            // cmbSuppliers
            // 
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.Location = new Point(297, 201);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new Size(737, 53);
            cmbSuppliers.TabIndex = 3;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(174, 301);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(199, 80);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "&Ok";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(741, 301);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(199, 80);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddModifyProduct
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(1104, 418);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(cmbSuppliers);
            Controls.Add(label2);
            Controls.Add(txtProdName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmAddModifyProduct";
            Text = "Add Product";
            Load += frmAddModifyProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProdName;
        private Label label2;
        private ComboBox cmbSuppliers;
        private Button btnAccept;
        private Button btnCancel;
    }
}