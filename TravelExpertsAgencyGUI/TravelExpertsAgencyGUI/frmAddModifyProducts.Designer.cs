namespace TravelExpertsAgencyGUI
{
    partial class frmAddModifyProducts
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
            txtProductName = new TextBox();
            btnExit = new Label();
            btnAddProducts = new Button();
            btnSaveProduct = new Button();
            txtProductId = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(115, 227);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 41);
            label1.TabIndex = 8;
            label1.Text = "Product Name:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(385, 230);
            txtProductName.Margin = new Padding(5);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(412, 39);
            txtProductName.TabIndex = 10;
            txtProductName.Tag = "Product name";
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(1618, 14);
            btnExit.Margin = new Padding(5, 0, 5, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(38, 41);
            btnExit.TabIndex = 12;
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
            btnAddProducts.Location = new Point(110, 454);
            btnAddProducts.Margin = new Padding(5);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(221, 75);
            btnAddProducts.TabIndex = 13;
            btnAddProducts.Text = "&Add ";
            btnAddProducts.UseVisualStyleBackColor = false;
            btnAddProducts.Click += btnAddProducts_Click;
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.BackColor = Color.FromArgb(51, 73, 107);
            btnSaveProduct.FlatAppearance.BorderSize = 0;
            btnSaveProduct.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnSaveProduct.FlatStyle = FlatStyle.Flat;
            btnSaveProduct.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveProduct.ForeColor = Color.White;
            btnSaveProduct.Location = new Point(576, 454);
            btnSaveProduct.Margin = new Padding(5);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(221, 75);
            btnSaveProduct.TabIndex = 15;
            btnSaveProduct.Text = "&Cancel";
            btnSaveProduct.UseVisualStyleBackColor = false;
            btnSaveProduct.Click += btnExit_Click;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(385, 165);
            txtProductId.Margin = new Padding(5);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(412, 39);
            txtProductId.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(165, 165);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(166, 41);
            label3.TabIndex = 16;
            label3.Text = "Product ID:";
            // 
            // frmAddModifyProducts
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1677, 805);
            Controls.Add(txtProductId);
            Controls.Add(label3);
            Controls.Add(btnSaveProduct);
            Controls.Add(btnAddProducts);
            Controls.Add(btnExit);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "frmAddModifyProducts";
            Text = "frmAddModifyProducts";
            Load += frmAddModifyProducts_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductName;
        private Label btnExit;
        private Button btnAddProducts;
        private Button btnSaveProduct;
        private TextBox txtProductId;
        private Label label3;
    }
}