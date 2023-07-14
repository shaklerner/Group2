namespace TravelExpertsGUI
{
    partial class AddModifyPackages
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
            btnAddProdSupp = new Button();
            btnDeleteProdSupp = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnAddPackage = new Button();
            button1 = new Button();
            txtPackageName = new TextBox();
            txtPackageDescription = new TextBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAddProdSupp
            // 
            btnAddProdSupp.BackColor = Color.Teal;
            btnAddProdSupp.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProdSupp.ForeColor = Color.White;
            btnAddProdSupp.Location = new Point(816, 436);
            btnAddProdSupp.Name = "btnAddProdSupp";
            btnAddProdSupp.Size = new Size(100, 45);
            btnAddProdSupp.TabIndex = 6;
            btnAddProdSupp.Text = "&Add";
            btnAddProdSupp.UseVisualStyleBackColor = false;
            // 
            // btnDeleteProdSupp
            // 
            btnDeleteProdSupp.BackColor = Color.Teal;
            btnDeleteProdSupp.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteProdSupp.ForeColor = Color.White;
            btnDeleteProdSupp.Location = new Point(816, 513);
            btnDeleteProdSupp.Name = "btnDeleteProdSupp";
            btnDeleteProdSupp.Size = new Size(100, 45);
            btnDeleteProdSupp.TabIndex = 8;
            btnDeleteProdSupp.Text = "&Delete";
            btnDeleteProdSupp.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 66);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 9;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(103, 111);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 10;
            label2.Text = "Description :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(106, 161);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 11;
            label3.Text = "Start Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(106, 242);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 12;
            label4.Text = "Base Price :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(103, 289);
            label5.Name = "label5";
            label5.Size = new Size(203, 25);
            label5.TabIndex = 13;
            label5.Text = "Agency Commission :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(31, 324);
            label6.Name = "label6";
            label6.Size = new Size(124, 25);
            label6.TabIndex = 14;
            label6.Text = "PRODUCTS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(31, 357);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(766, 231);
            dataGridView1.TabIndex = 15;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Products";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Suppliers";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // btnAddPackage
            // 
            btnAddPackage.BackColor = Color.Teal;
            btnAddPackage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddPackage.ForeColor = Color.White;
            btnAddPackage.Location = new Point(640, 269);
            btnAddPackage.Name = "btnAddPackage";
            btnAddPackage.Size = new Size(178, 45);
            btnAddPackage.TabIndex = 16;
            btnAddPackage.Text = "&Create New Package ";
            btnAddPackage.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(879, -1);
            button1.Name = "button1";
            button1.Size = new Size(159, 45);
            button1.TabIndex = 17;
            button1.Text = "&Back to List";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtPackageName
            // 
            txtPackageName.Location = new Point(312, 64);
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(302, 27);
            txtPackageName.TabIndex = 18;
            // 
            // txtPackageDescription
            // 
            txtPackageDescription.Location = new Point(312, 112);
            txtPackageDescription.Name = "txtPackageDescription";
            txtPackageDescription.Size = new Size(302, 27);
            txtPackageDescription.TabIndex = 19;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(312, 159);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(302, 27);
            dtpStartDate.TabIndex = 20;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(312, 201);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(302, 27);
            dtpEndDate.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(117, 201);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(106, 197);
            label8.Name = "label8";
            label8.Size = new Size(104, 25);
            label8.TabIndex = 23;
            label8.Text = "End Date :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 243);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 27);
            textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(312, 289);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(302, 27);
            textBox2.TabIndex = 25;
            // 
            // AddModifyPackages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1050, 600);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(txtPackageDescription);
            Controls.Add(txtPackageName);
            Controls.Add(button1);
            Controls.Add(btnAddPackage);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDeleteProdSupp);
            Controls.Add(btnAddProdSupp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddModifyPackages";
            Text = "AddModifyPackages";
            Load += AddModifyPackages_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddProdSupp;
        private Button btnDeleteProdSupp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnAddPackage;
        private Button button1;
        private TextBox txtPackageName;
        private TextBox txtPackageDescription;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}