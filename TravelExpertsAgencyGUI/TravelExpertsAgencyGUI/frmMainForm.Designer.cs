namespace TravelExpertsAgencyGUI
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
            btnProductSupplier = new Button();
            btnSuppliers = new Button();
            btnProducts = new Button();
            btnPackages = new Button();
            pictureBox1 = new PictureBox();
            pnlTopSIde = new Panel();
            iconMinimize = new PictureBox();
            iconReset = new PictureBox();
            iconMaximize = new PictureBox();
            iconExit = new PictureBox();
            btnSlide = new PictureBox();
            pnlMainContent = new Panel();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTopSIde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconReset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSlide).BeginInit();
            SuspendLayout();
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.BackColor = Color.FromArgb(51, 73, 107);
            pnlLeftSide.Controls.Add(btnProductSupplier);
            pnlLeftSide.Controls.Add(btnSuppliers);
            pnlLeftSide.Controls.Add(btnProducts);
            pnlLeftSide.Controls.Add(btnPackages);
            pnlLeftSide.Controls.Add(pictureBox1);
            pnlLeftSide.Dock = DockStyle.Left;
            pnlLeftSide.Location = new Point(0, 0);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(250, 600);
            pnlLeftSide.TabIndex = 0;
            // 
            // btnProductSupplier
            // 
            btnProductSupplier.FlatAppearance.BorderSize = 0;
            btnProductSupplier.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnProductSupplier.FlatStyle = FlatStyle.Flat;
            btnProductSupplier.Font = new Font("Franklin Gothic Book", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductSupplier.ForeColor = Color.White;
            btnProductSupplier.Image = (Image)resources.GetObject("btnProductSupplier.Image");
            btnProductSupplier.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductSupplier.Location = new Point(0, 299);
            btnProductSupplier.Name = "btnProductSupplier";
            btnProductSupplier.Size = new Size(250, 62);
            btnProductSupplier.TabIndex = 4;
            btnProductSupplier.Text = "      Product Supplier";
            btnProductSupplier.UseVisualStyleBackColor = true;
            btnProductSupplier.Click += btnProductSupplier_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Franklin Gothic Book", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Image = (Image)resources.GetObject("btnSuppliers.Image");
            btnSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.Location = new Point(0, 231);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(250, 62);
            btnSuppliers.TabIndex = 3;
            btnSuppliers.Text = "  Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Franklin Gothic Book", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducts.ForeColor = Color.White;
            btnProducts.Image = (Image)resources.GetObject("btnProducts.Image");
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(3, 163);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(250, 62);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnPackages
            // 
            btnPackages.FlatAppearance.BorderSize = 0;
            btnPackages.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnPackages.FlatStyle = FlatStyle.Flat;
            btnPackages.Font = new Font("Franklin Gothic Book", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnPackages.ForeColor = Color.White;
            btnPackages.Image = (Image)resources.GetObject("btnPackages.Image");
            btnPackages.ImageAlign = ContentAlignment.MiddleLeft;
            btnPackages.Location = new Point(3, 95);
            btnPackages.Name = "btnPackages";
            btnPackages.Size = new Size(250, 62);
            btnPackages.TabIndex = 1;
            btnPackages.Text = "Packages";
            btnPackages.UseVisualStyleBackColor = true;
            btnPackages.Click += btnPackages_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlTopSIde
            // 
            pnlTopSIde.BackColor = Color.WhiteSmoke;
            pnlTopSIde.Controls.Add(iconMinimize);
            pnlTopSIde.Controls.Add(iconReset);
            pnlTopSIde.Controls.Add(iconMaximize);
            pnlTopSIde.Controls.Add(iconExit);
            pnlTopSIde.Controls.Add(btnSlide);
            pnlTopSIde.Dock = DockStyle.Top;
            pnlTopSIde.Location = new Point(250, 0);
            pnlTopSIde.Name = "pnlTopSIde";
            pnlTopSIde.Size = new Size(1050, 50);
            pnlTopSIde.TabIndex = 1;
            // 
            // iconMinimize
            // 
            iconMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMinimize.Image = (Image)resources.GetObject("iconMinimize.Image");
            iconMinimize.Location = new Point(946, 9);
            iconMinimize.Name = "iconMinimize";
            iconMinimize.Size = new Size(25, 25);
            iconMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            iconMinimize.TabIndex = 1;
            iconMinimize.TabStop = false;
            iconMinimize.Click += iconMinimize_Click;
            // 
            // iconReset
            // 
            iconReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconReset.Image = (Image)resources.GetObject("iconReset.Image");
            iconReset.Location = new Point(977, 9);
            iconReset.Name = "iconReset";
            iconReset.Size = new Size(25, 25);
            iconReset.SizeMode = PictureBoxSizeMode.Zoom;
            iconReset.TabIndex = 1;
            iconReset.TabStop = false;
            iconReset.Visible = false;
            iconReset.Click += iconReset_Click;
            // 
            // iconMaximize
            // 
            iconMaximize.Image = (Image)resources.GetObject("iconMaximize.Image");
            iconMaximize.Location = new Point(977, 9);
            iconMaximize.Name = "iconMaximize";
            iconMaximize.Size = new Size(25, 25);
            iconMaximize.SizeMode = PictureBoxSizeMode.Zoom;
            iconMaximize.TabIndex = 1;
            iconMaximize.TabStop = false;
            iconMaximize.Click += iconMaximize_Click;
            // 
            // iconExit
            // 
            iconExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconExit.Image = (Image)resources.GetObject("iconExit.Image");
            iconExit.Location = new Point(1008, 9);
            iconExit.Name = "iconExit";
            iconExit.Size = new Size(25, 25);
            iconExit.SizeMode = PictureBoxSizeMode.Zoom;
            iconExit.TabIndex = 0;
            iconExit.TabStop = false;
            iconExit.Click += iconExit_Click;
            // 
            // btnSlide
            // 
            btnSlide.Image = (Image)resources.GetObject("btnSlide.Image");
            btnSlide.Location = new Point(6, 9);
            btnSlide.Name = "btnSlide";
            btnSlide.Size = new Size(35, 35);
            btnSlide.SizeMode = PictureBoxSizeMode.Zoom;
            btnSlide.TabIndex = 0;
            btnSlide.TabStop = false;
            btnSlide.Click += btnSlide_Click;
            // 
            // pnlMainContent
            // 
            pnlMainContent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlMainContent.BackColor = Color.WhiteSmoke;
            pnlMainContent.ForeColor = Color.Black;
            pnlMainContent.Location = new Point(250, 50);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1050, 550);
            pnlMainContent.TabIndex = 2;
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 600);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlTopSIde);
            Controls.Add(pnlLeftSide);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlLeftSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTopSIde.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconReset).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSlide).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeftSide;
        private Panel pnlTopSIde;
        private PictureBox btnSlide;
        private Panel pnlMainContent;
        private PictureBox pictureBox1;
        private PictureBox iconExit;
        private PictureBox iconMinimize;
        private PictureBox iconReset;
        private PictureBox iconMaximize;
        private Button btnPackages;
        private Button btnProducts;
        private Button btnSuppliers;
        private Button btnProductSupplier;
    }
}