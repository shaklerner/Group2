namespace TravelExpertsGUI
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
            button4 = new Button();
            btnSuppliers = new Button();
            btnProducts = new Button();
            btnPackages = new Button();
            pictureBox1 = new PictureBox();
            iconMinimizer = new PictureBox();
            iconMaximizer = new PictureBox();
            iconReset = new PictureBox();
            iconCancel = new PictureBox();
            pnlMainContent = new Panel();
            pnlTopSIde = new Panel();
            btnSlide = new PictureBox();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMinimizer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMaximizer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconReset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCancel).BeginInit();
            pnlTopSIde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSlide).BeginInit();
            SuspendLayout();
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.BackColor = Color.Teal;
            pnlLeftSide.Controls.Add(button4);
            pnlLeftSide.Controls.Add(btnSuppliers);
            pnlLeftSide.Controls.Add(btnProducts);
            pnlLeftSide.Controls.Add(btnPackages);
            pnlLeftSide.Controls.Add(pictureBox1);
            pnlLeftSide.Dock = DockStyle.Left;
            pnlLeftSide.Location = new Point(0, 0);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(250, 650);
            pnlLeftSide.TabIndex = 0;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Gray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-3, 259);
            button4.Name = "button4";
            button4.Size = new Size(250, 40);
            button4.TabIndex = 4;
            button4.Text = "      Product_Suppliers";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSuppliers.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Image = (Image)resources.GetObject("btnSuppliers.Image");
            btnSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.Location = new Point(0, 213);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(250, 40);
            btnSuppliers.TabIndex = 3;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProducts.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducts.ForeColor = Color.White;
            btnProducts.Image = (Image)resources.GetObject("btnProducts.Image");
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(0, 167);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(250, 40);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnPackages
            // 
            btnPackages.FlatAppearance.BorderSize = 0;
            btnPackages.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPackages.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnPackages.FlatStyle = FlatStyle.Flat;
            btnPackages.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPackages.ForeColor = Color.White;
            btnPackages.Image = (Image)resources.GetObject("btnPackages.Image");
            btnPackages.ImageAlign = ContentAlignment.MiddleLeft;
            btnPackages.Location = new Point(3, 121);
            btnPackages.Name = "btnPackages";
            btnPackages.Size = new Size(250, 40);
            btnPackages.TabIndex = 1;
            btnPackages.Text = "Packages ";
            btnPackages.UseVisualStyleBackColor = true;
            btnPackages.Click += btnPackages_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // iconMinimizer
            // 
            iconMinimizer.Anchor = AnchorStyles.Right;
            iconMinimizer.Cursor = Cursors.Hand;
            iconMinimizer.Image = (Image)resources.GetObject("iconMinimizer.Image");
            iconMinimizer.Location = new Point(961, 12);
            iconMinimizer.Name = "iconMinimizer";
            iconMinimizer.Size = new Size(20, 20);
            iconMinimizer.SizeMode = PictureBoxSizeMode.Zoom;
            iconMinimizer.TabIndex = 2;
            iconMinimizer.TabStop = false;
            iconMinimizer.Click += iconMinimizer_Click;
            // 
            // iconMaximizer
            // 
            iconMaximizer.Anchor = AnchorStyles.Right;
            iconMaximizer.Cursor = Cursors.Hand;
            iconMaximizer.Image = (Image)resources.GetObject("iconMaximizer.Image");
            iconMaximizer.Location = new Point(987, 12);
            iconMaximizer.Name = "iconMaximizer";
            iconMaximizer.Size = new Size(20, 20);
            iconMaximizer.SizeMode = PictureBoxSizeMode.Zoom;
            iconMaximizer.TabIndex = 2;
            iconMaximizer.TabStop = false;
            iconMaximizer.Click += iconMaximizer_Click_1;
            // 
            // iconReset
            // 
            iconReset.Cursor = Cursors.Hand;
            iconReset.Image = (Image)resources.GetObject("iconReset.Image");
            iconReset.Location = new Point(987, 12);
            iconReset.Name = "iconReset";
            iconReset.Size = new Size(20, 20);
            iconReset.SizeMode = PictureBoxSizeMode.Zoom;
            iconReset.TabIndex = 2;
            iconReset.TabStop = false;
            iconReset.Click += iconReset_Click_1;
            // 
            // iconCancel
            // 
            iconCancel.Anchor = AnchorStyles.Right;
            iconCancel.Cursor = Cursors.Hand;
            iconCancel.Image = (Image)resources.GetObject("iconCancel.Image");
            iconCancel.Location = new Point(1013, 12);
            iconCancel.Name = "iconCancel";
            iconCancel.Size = new Size(20, 20);
            iconCancel.SizeMode = PictureBoxSizeMode.Zoom;
            iconCancel.TabIndex = 1;
            iconCancel.TabStop = false;
            iconCancel.Click += iconCancel_Click;
            // 
            // pnlMainContent
            // 
            pnlMainContent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlMainContent.BackColor = SystemColors.ButtonHighlight;
            pnlMainContent.Cursor = Cursors.Hand;
            pnlMainContent.Location = new Point(250, 50);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1050, 600);
            pnlMainContent.TabIndex = 2;
            // 
            // pnlTopSIde
            // 
            pnlTopSIde.Anchor = AnchorStyles.Right;
            pnlTopSIde.BackColor = Color.WhiteSmoke;
            pnlTopSIde.Controls.Add(btnSlide);
            pnlTopSIde.Controls.Add(iconMinimizer);
            pnlTopSIde.Controls.Add(iconMaximizer);
            pnlTopSIde.Controls.Add(iconReset);
            pnlTopSIde.Controls.Add(iconCancel);
            pnlTopSIde.Location = new Point(250, 0);
            pnlTopSIde.Name = "pnlTopSIde";
            pnlTopSIde.Size = new Size(1050, 50);
            pnlTopSIde.TabIndex = 1;
            // 
            // btnSlide
            // 
            btnSlide.Image = (Image)resources.GetObject("btnSlide.Image");
            btnSlide.Location = new Point(6, 9);
            btnSlide.Name = "btnSlide";
            btnSlide.Size = new Size(35, 35);
            btnSlide.SizeMode = PictureBoxSizeMode.Zoom;
            btnSlide.TabIndex = 3;
            btnSlide.TabStop = false;
            btnSlide.Click += btnSlide_Click;
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1300, 650);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlTopSIde);
            Controls.Add(pnlLeftSide);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlLeftSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMinimizer).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMaximizer).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconReset).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCancel).EndInit();
            pnlTopSIde.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSlide).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeftSide;
        private Panel pnlMainContent;
        private PictureBox pictureBox1;
        private PictureBox iconCancel;
        private PictureBox iconMinimizer;
        private PictureBox iconMaximizer;
        private PictureBox iconReset;
        private Button btnPackages;
        private Button button4;
        private Button btnSuppliers;
        private Button btnProducts;
        private Panel pnlTopSIde;
        private PictureBox btnSlide;
    }
}