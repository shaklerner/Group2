namespace Workshop4
{
	partial class frmAddModifyPackage
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
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			btnOK = new Button();
			btnCancel = new Button();
			txtPkgId = new TextBox();
			txtName = new TextBox();
			txtPrice = new TextBox();
			txtCommission = new TextBox();
			txtDesc = new RichTextBox();
			cboProd = new ComboBox();
			cboSupp = new ComboBox();
			dtStart = new DateTimePicker();
			dtEnd = new DateTimePicker();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(21, 40);
			label1.Name = "label1";
			label1.Size = new Size(85, 21);
			label1.TabIndex = 0;
			label1.Text = "Package ID";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(54, 169);
			label2.Name = "label2";
			label2.Size = new Size(52, 21);
			label2.TabIndex = 1;
			label2.Text = "Name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(28, 212);
			label3.Name = "label3";
			label3.Size = new Size(78, 21);
			label3.TabIndex = 2;
			label3.Text = "Start Date";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(34, 255);
			label4.Name = "label4";
			label4.Size = new Size(72, 21);
			label4.TabIndex = 3;
			label4.Text = "End Date";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(17, 384);
			label5.Name = "label5";
			label5.Size = new Size(89, 21);
			label5.TabIndex = 4;
			label5.Text = "Description";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(26, 298);
			label6.Name = "label6";
			label6.Size = new Size(80, 21);
			label6.TabIndex = 5;
			label6.Text = "Base Price";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(9, 341);
			label7.Name = "label7";
			label7.Size = new Size(97, 21);
			label7.TabIndex = 6;
			label7.Text = "Commission";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(42, 83);
			label8.Name = "label8";
			label8.Size = new Size(64, 21);
			label8.TabIndex = 7;
			label8.Text = "Product";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label9.Location = new Point(38, 126);
			label9.Name = "label9";
			label9.Size = new Size(68, 21);
			label9.TabIndex = 8;
			label9.Text = "Supplier";
			// 
			// btnOK
			// 
			btnOK.Location = new Point(500, 22);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(139, 56);
			btnOK.TabIndex = 9;
			btnOK.Text = "&OK";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(500, 97);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(139, 62);
			btnCancel.TabIndex = 10;
			btnCancel.Text = "&Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// txtPkgId
			// 
			txtPkgId.Location = new Point(123, 38);
			txtPkgId.Name = "txtPkgId";
			txtPkgId.ReadOnly = true;
			txtPkgId.Size = new Size(106, 23);
			txtPkgId.TabIndex = 11;
			// 
			// txtName
			// 
			txtName.Location = new Point(123, 167);
			txtName.Name = "txtName";
			txtName.Size = new Size(228, 23);
			txtName.TabIndex = 12;
			// 
			// txtPrice
			// 
			txtPrice.Location = new Point(123, 300);
			txtPrice.Name = "txtPrice";
			txtPrice.Size = new Size(228, 23);
			txtPrice.TabIndex = 13;
			// 
			// txtCommission
			// 
			txtCommission.Location = new Point(123, 343);
			txtCommission.Name = "txtCommission";
			txtCommission.Size = new Size(228, 23);
			txtCommission.TabIndex = 14;
			// 
			// txtDesc
			// 
			txtDesc.Location = new Point(123, 386);
			txtDesc.Name = "txtDesc";
			txtDesc.Size = new Size(516, 137);
			txtDesc.TabIndex = 15;
			txtDesc.Text = "";
			// 
			// cboProd
			// 
			cboProd.FormattingEnabled = true;
			cboProd.Location = new Point(123, 81);
			cboProd.Name = "cboProd";
			cboProd.Size = new Size(228, 23);
			cboProd.TabIndex = 16;
			// 
			// cboSupp
			// 
			cboSupp.FormattingEnabled = true;
			cboSupp.Location = new Point(123, 128);
			cboSupp.Name = "cboSupp";
			cboSupp.Size = new Size(228, 23);
			cboSupp.TabIndex = 17;
			// 
			// dtStart
			// 
			dtStart.Location = new Point(123, 212);
			dtStart.Name = "dtStart";
			dtStart.Size = new Size(200, 23);
			dtStart.TabIndex = 18;
			// 
			// dtEnd
			// 
			dtEnd.Location = new Point(123, 255);
			dtEnd.Name = "dtEnd";
			dtEnd.Size = new Size(200, 23);
			dtEnd.TabIndex = 19;
			// 
			// frmAddModifyPackage
			// 
			AcceptButton = btnOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(680, 551);
			Controls.Add(dtEnd);
			Controls.Add(dtStart);
			Controls.Add(cboSupp);
			Controls.Add(cboProd);
			Controls.Add(txtDesc);
			Controls.Add(txtCommission);
			Controls.Add(txtPrice);
			Controls.Add(txtName);
			Controls.Add(txtPkgId);
			Controls.Add(btnCancel);
			Controls.Add(btnOK);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "frmAddModifyPackage";
			Text = "Add/Modify Package";
			Load += frmAddModifyPackage_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Button btnOK;
		private Button btnCancel;
		private TextBox txtPkgId;
		private TextBox txtName;
		private TextBox txtPrice;
		private TextBox txtCommission;
		private RichTextBox txtDesc;
		private ComboBox cboProd;
		private ComboBox cboSupp;
		private DateTimePicker dtStart;
		private DateTimePicker dtEnd;
	}
}