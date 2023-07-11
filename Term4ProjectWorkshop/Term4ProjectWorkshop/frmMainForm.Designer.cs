namespace Term4ProjectWorkshop
{
    partial class frmMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            pnlLeftSide = new Panel();
            pnlProducts = new Panel();
            button4 = new Button();
            pnlOnButtonSuppliers = new Panel();
            btnSupplier = new Button();
            pnlOnButtonProducts = new Panel();
            btnProducts = new Button();
            pnlOnButtonPackages = new Panel();
            btnPackages = new Button();
            pnlTopSide = new Panel();
            pnlPackages = new Panel();
            btnAddPackages = new Button();
            btnUpdatePackages = new Button();
            btnDeletePackages = new Button();
            button1 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            pnlLeftSide.SuspendLayout();
            pnlPackages.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.BackColor = Color.MediumPurple;
            pnlLeftSide.Controls.Add(pnlProducts);
            pnlLeftSide.Controls.Add(button4);
            pnlLeftSide.Controls.Add(pnlOnButtonSuppliers);
            pnlLeftSide.Controls.Add(btnSupplier);
            pnlLeftSide.Controls.Add(pnlOnButtonProducts);
            pnlLeftSide.Controls.Add(btnProducts);
            pnlLeftSide.Controls.Add(pnlOnButtonPackages);
            pnlLeftSide.Controls.Add(btnPackages);
            pnlLeftSide.Dock = DockStyle.Left;
            pnlLeftSide.Location = new Point(0, 0);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(245, 683);
            pnlLeftSide.TabIndex = 0;
            // 
            // pnlProducts
            // 
            pnlProducts.BackColor = Color.Teal;
            pnlProducts.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pnlProducts.Location = new Point(3, 289);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(12, 41);
            pnlProducts.TabIndex = 8;
            pnlProducts.TabStop = true;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumPurple;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Control;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(0, 289);
            button4.Name = "button4";
            button4.Size = new Size(245, 41);
            button4.TabIndex = 7;
            button4.Text = "  Products & Suppliers";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // pnlOnButtonSuppliers
            // 
            pnlOnButtonSuppliers.BackColor = Color.Teal;
            pnlOnButtonSuppliers.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pnlOnButtonSuppliers.Location = new Point(3, 224);
            pnlOnButtonSuppliers.Name = "pnlOnButtonSuppliers";
            pnlOnButtonSuppliers.Size = new Size(12, 41);
            pnlOnButtonSuppliers.TabIndex = 6;
            pnlOnButtonSuppliers.TabStop = true;
            // 
            // btnSupplier
            // 
            btnSupplier.BackColor = Color.MediumPurple;
            btnSupplier.FlatAppearance.BorderSize = 0;
            btnSupplier.FlatStyle = FlatStyle.Flat;
            btnSupplier.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSupplier.ForeColor = SystemColors.Control;
            btnSupplier.Image = (Image)resources.GetObject("btnSupplier.Image");
            btnSupplier.Location = new Point(-3, 224);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(245, 41);
            btnSupplier.TabIndex = 5;
            btnSupplier.Text = "  Suppliers";
            btnSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSupplier.UseVisualStyleBackColor = false;
            // 
            // pnlOnButtonProducts
            // 
            pnlOnButtonProducts.BackColor = Color.Teal;
            pnlOnButtonProducts.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pnlOnButtonProducts.Location = new Point(3, 151);
            pnlOnButtonProducts.Name = "pnlOnButtonProducts";
            pnlOnButtonProducts.Size = new Size(12, 41);
            pnlOnButtonProducts.TabIndex = 4;
            pnlOnButtonProducts.TabStop = true;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.MediumPurple;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducts.ForeColor = SystemColors.Control;
            btnProducts.Image = (Image)resources.GetObject("btnProducts.Image");
            btnProducts.Location = new Point(3, 151);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(245, 41);
            btnProducts.TabIndex = 3;
            btnProducts.Text = "  Products";
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // pnlOnButtonPackages
            // 
            pnlOnButtonPackages.BackColor = Color.Teal;
            pnlOnButtonPackages.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pnlOnButtonPackages.Location = new Point(3, 88);
            pnlOnButtonPackages.Name = "pnlOnButtonPackages";
            pnlOnButtonPackages.Size = new Size(12, 41);
            pnlOnButtonPackages.TabIndex = 2;
            pnlOnButtonPackages.TabStop = true;
            pnlOnButtonPackages.Paint += pnlOnButtonPackages_Paint;
            // 
            // btnPackages
            // 
            btnPackages.BackColor = Color.MediumPurple;
            btnPackages.FlatAppearance.BorderSize = 0;
            btnPackages.FlatStyle = FlatStyle.Flat;
            btnPackages.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPackages.ForeColor = SystemColors.Control;
            btnPackages.Image = (Image)resources.GetObject("btnPackages.Image");
            btnPackages.Location = new Point(0, 88);
            btnPackages.Name = "btnPackages";
            btnPackages.Size = new Size(245, 41);
            btnPackages.TabIndex = 0;
            btnPackages.Text = "  Packages";
            btnPackages.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPackages.UseVisualStyleBackColor = false;
            btnPackages.Click += btnPackages_Click;
            // 
            // pnlTopSide
            // 
            pnlTopSide.BackColor = Color.Teal;
            pnlTopSide.Dock = DockStyle.Top;
            pnlTopSide.Location = new Point(245, 0);
            pnlTopSide.Name = "pnlTopSide";
            pnlTopSide.Size = new Size(920, 23);
            pnlTopSide.TabIndex = 1;
            // 
            // pnlPackages
            // 
            pnlPackages.Controls.Add(listView1);
            pnlPackages.Controls.Add(button1);
            pnlPackages.Controls.Add(btnDeletePackages);
            pnlPackages.Controls.Add(btnUpdatePackages);
            pnlPackages.Controls.Add(btnAddPackages);
            pnlPackages.Location = new Point(247, 26);
            pnlPackages.Name = "pnlPackages";
            pnlPackages.Size = new Size(918, 657);
            pnlPackages.TabIndex = 2;
            // 
            // btnAddPackages
            // 
            btnAddPackages.Location = new Point(820, 164);
            btnAddPackages.Name = "btnAddPackages";
            btnAddPackages.Size = new Size(86, 38);
            btnAddPackages.TabIndex = 0;
            btnAddPackages.Text = "&Add";
            btnAddPackages.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePackages
            // 
            btnUpdatePackages.Location = new Point(820, 226);
            btnUpdatePackages.Name = "btnUpdatePackages";
            btnUpdatePackages.Size = new Size(86, 38);
            btnUpdatePackages.TabIndex = 1;
            btnUpdatePackages.Text = "&Update";
            btnUpdatePackages.UseVisualStyleBackColor = true;
            // 
            // btnDeletePackages
            // 
            btnDeletePackages.Location = new Point(820, 291);
            btnDeletePackages.Name = "btnDeletePackages";
            btnDeletePackages.Size = new Size(86, 38);
            btnDeletePackages.TabIndex = 2;
            btnDeletePackages.Text = "&Delete";
            btnDeletePackages.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(820, 353);
            button1.Name = "button1";
            button1.Size = new Size(86, 38);
            button1.TabIndex = 3;
            button1.Text = "&Exit";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(19, 21);
            listView1.Name = "listView1";
            listView1.Size = new Size(764, 360);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "PackageID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Package Name";
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 683);
            Controls.Add(pnlPackages);
            Controls.Add(pnlTopSide);
            Controls.Add(pnlLeftSide);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmMainForm_Load;
            pnlLeftSide.ResumeLayout(false);
            pnlPackages.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel pnlLeftSide;
        private Panel pnlOnButtonPackages;
        private Button btnPackages;
        private Panel pnlTopSide;
        private Panel pnlProducts;
        private Button button4;
        private Panel pnlOnButtonSuppliers;
        private Button btnSupplier;
        private Panel pnlOnButtonProducts;
        private Button btnProducts;
        private Panel pnlPackages;
        private Button btnAddPackages;
        private Button btnUpdatePackages;
        private ListView listView1;
        private Button button1;
        private Button btnDeletePackages;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}