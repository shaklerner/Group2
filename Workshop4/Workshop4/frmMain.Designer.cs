namespace Workshop4
{
	partial class frmMain
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
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			dgv = new DataGridView();
			button1 = new Button();
			button2 = new Button();
			btnAddPkg = new Button();
			groupBox2 = new GroupBox();
			txtPkgCount = new TextBox();
			label6 = new Label();
			tabPage2 = new TabPage();
			tabPage3 = new TabPage();
			label3 = new Label();
			label2 = new Label();
			lstProducts = new ListBox();
			groupBox1 = new GroupBox();
			txtProdCount = new TextBox();
			label1 = new Label();
			btnDeleteProd = new Button();
			btnModifyProd = new Button();
			btnAddProd = new Button();
			btnSortByName = new Button();
			btnSortByID = new Button();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
			groupBox2.SuspendLayout();
			tabPage3.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Alignment = TabAlignment.Left;
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Controls.Add(tabPage3);
			tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
			tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			tabControl1.ItemSize = new Size(100, 300);
			tabControl1.Location = new Point(12, 12);
			tabControl1.Multiline = true;
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1831, 839);
			tabControl1.SizeMode = TabSizeMode.Fixed;
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(dgv);
			tabPage1.Controls.Add(button1);
			tabPage1.Controls.Add(button2);
			tabPage1.Controls.Add(btnAddPkg);
			tabPage1.Controls.Add(groupBox2);
			tabPage1.Location = new Point(304, 4);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(1523, 831);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Packages";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// dgv
			// 
			dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv.Location = new Point(33, 35);
			dgv.Name = "dgv";
			dgv.RowTemplate.Height = 25;
			dgv.Size = new Size(654, 465);
			dgv.TabIndex = 17;
			// 
			// button1
			// 
			button1.Location = new Point(722, 295);
			button1.Name = "button1";
			button1.Size = new Size(253, 71);
			button1.TabIndex = 12;
			button1.Text = "Delete Package";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(722, 189);
			button2.Name = "button2";
			button2.Size = new Size(253, 71);
			button2.TabIndex = 11;
			button2.Text = "Modify Package";
			button2.UseVisualStyleBackColor = true;
			// 
			// btnAddPkg
			// 
			btnAddPkg.Location = new Point(722, 84);
			btnAddPkg.Name = "btnAddPkg";
			btnAddPkg.Size = new Size(253, 71);
			btnAddPkg.TabIndex = 10;
			btnAddPkg.Text = "Add Package";
			btnAddPkg.UseVisualStyleBackColor = true;
			btnAddPkg.Click += btnAddPkg_Click;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(txtPkgCount);
			groupBox2.Controls.Add(label6);
			groupBox2.Location = new Point(1021, 35);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(468, 771);
			groupBox2.TabIndex = 13;
			groupBox2.TabStop = false;
			groupBox2.Text = "Statistics";
			// 
			// txtPkgCount
			// 
			txtPkgCount.Location = new Point(70, 110);
			txtPkgCount.Name = "txtPkgCount";
			txtPkgCount.Size = new Size(185, 29);
			txtPkgCount.TabIndex = 1;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(29, 62);
			label6.Name = "label6";
			label6.Size = new Size(196, 21);
			label6.TabIndex = 0;
			label6.Text = "Total Number of Packages: ";
			// 
			// tabPage2
			// 
			tabPage2.Location = new Point(304, 4);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(1523, 831);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Suppliers";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			tabPage3.BorderStyle = BorderStyle.FixedSingle;
			tabPage3.Controls.Add(label3);
			tabPage3.Controls.Add(label2);
			tabPage3.Controls.Add(lstProducts);
			tabPage3.Controls.Add(groupBox1);
			tabPage3.Controls.Add(btnDeleteProd);
			tabPage3.Controls.Add(btnModifyProd);
			tabPage3.Controls.Add(btnAddProd);
			tabPage3.Controls.Add(btnSortByName);
			tabPage3.Controls.Add(btnSortByID);
			tabPage3.ImageKey = "PngItem_272007.png";
			tabPage3.Location = new Point(304, 4);
			tabPage3.Name = "tabPage3";
			tabPage3.Size = new Size(1523, 831);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "Products";
			tabPage3.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(253, 26);
			label3.Name = "label3";
			label3.Size = new Size(110, 21);
			label3.TabIndex = 9;
			label3.Text = "Product Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(40, 26);
			label2.Name = "label2";
			label2.Size = new Size(83, 21);
			label2.TabIndex = 8;
			label2.Text = "Product ID";
			// 
			// lstProducts
			// 
			lstProducts.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lstProducts.FormattingEnabled = true;
			lstProducts.ItemHeight = 19;
			lstProducts.Location = new Point(40, 74);
			lstProducts.Name = "lstProducts";
			lstProducts.Size = new Size(641, 593);
			lstProducts.TabIndex = 7;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txtProdCount);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(1028, 37);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(468, 771);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			groupBox1.Text = "Statistics";
			// 
			// txtProdCount
			// 
			txtProdCount.Location = new Point(70, 110);
			txtProdCount.Name = "txtProdCount";
			txtProdCount.Size = new Size(185, 29);
			txtProdCount.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(29, 62);
			label1.Name = "label1";
			label1.Size = new Size(194, 21);
			label1.TabIndex = 0;
			label1.Text = "Total Number of Products: ";
			// 
			// btnDeleteProd
			// 
			btnDeleteProd.Location = new Point(729, 297);
			btnDeleteProd.Name = "btnDeleteProd";
			btnDeleteProd.Size = new Size(253, 71);
			btnDeleteProd.TabIndex = 5;
			btnDeleteProd.Text = "Delete Product";
			btnDeleteProd.UseVisualStyleBackColor = true;
			// 
			// btnModifyProd
			// 
			btnModifyProd.Location = new Point(729, 191);
			btnModifyProd.Name = "btnModifyProd";
			btnModifyProd.Size = new Size(253, 71);
			btnModifyProd.TabIndex = 4;
			btnModifyProd.Text = "Modify Product";
			btnModifyProd.UseVisualStyleBackColor = true;
			// 
			// btnAddProd
			// 
			btnAddProd.Location = new Point(729, 86);
			btnAddProd.Name = "btnAddProd";
			btnAddProd.Size = new Size(253, 71);
			btnAddProd.TabIndex = 3;
			btnAddProd.Text = "Add Product";
			btnAddProd.UseVisualStyleBackColor = true;
			btnAddProd.Click += btnAddProd_Click;
			// 
			// btnSortByName
			// 
			btnSortByName.Location = new Point(438, 703);
			btnSortByName.Name = "btnSortByName";
			btnSortByName.Size = new Size(243, 105);
			btnSortByName.TabIndex = 2;
			btnSortByName.Text = "Sort by name";
			btnSortByName.UseVisualStyleBackColor = true;
			// 
			// btnSortByID
			// 
			btnSortByID.Location = new Point(40, 703);
			btnSortByID.Name = "btnSortByID";
			btnSortByID.Size = new Size(243, 105);
			btnSortByID.TabIndex = 1;
			btnSortByID.Text = "Sort by ID";
			btnSortByID.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1604, 863);
			Controls.Add(tabControl1);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "frmMain";
			Text = "Form1";
			Load += frmMain_Load;
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgv).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			tabPage3.ResumeLayout(false);
			tabPage3.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private Button btnDeleteProd;
		private Button btnModifyProd;
		private Button btnAddProd;
		private Button btnSortByName;
		private Button btnSortByID;
		private GroupBox groupBox1;
		private TextBox txtProdCount;
		private Label label1;
		private ListBox lstProducts;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Button button1;
		private Button button2;
		private Button btnAddPkg;
		private GroupBox groupBox2;
		private TextBox txtPkgCount;
		private Label label6;
		private DataGridView dgv;
	}
}