﻿namespace TravelExpertsAgencyGUI
{
    partial class frmPackages
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
            dgvPackages = new DataGridView();
            btnAddPackages = new Button();
            btnUpdatePackages = new Button();
            btnExit = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            SuspendLayout();
            // 
            // dgvPackages
            // 
            dgvPackages.BackgroundColor = Color.WhiteSmoke;
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Location = new Point(17, 86);
            dgvPackages.Margin = new Padding(3, 2, 3, 2);
            dgvPackages.Name = "dgvPackages";
            dgvPackages.RowHeadersWidth = 51;
            dgvPackages.RowTemplate.Height = 29;
            dgvPackages.Size = new Size(877, 313);
            dgvPackages.TabIndex = 0;
            dgvPackages.CellClick += dgvPackages_CellClick;
            dgvPackages.CellDoubleClick += btnUpdatePackages_Click;
            // 
            // btnAddPackages
            // 
            btnAddPackages.BackColor = Color.FromArgb(51, 73, 107);
            btnAddPackages.FlatAppearance.BorderSize = 0;
            btnAddPackages.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnAddPackages.FlatStyle = FlatStyle.Flat;
            btnAddPackages.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddPackages.ForeColor = Color.White;
            btnAddPackages.Location = new Point(29, 29);
            btnAddPackages.Margin = new Padding(3, 2, 3, 2);
            btnAddPackages.Name = "btnAddPackages";
            btnAddPackages.Size = new Size(191, 35);
            btnAddPackages.TabIndex = 2;
            btnAddPackages.Text = "Create New ";
            btnAddPackages.UseVisualStyleBackColor = false;
            btnAddPackages.Click += btnAddPackages_Click;
            // 
            // btnUpdatePackages
            // 
            btnUpdatePackages.BackColor = Color.FromArgb(51, 73, 107);
            btnUpdatePackages.FlatAppearance.BorderSize = 0;
            btnUpdatePackages.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 145, 153);
            btnUpdatePackages.FlatStyle = FlatStyle.Flat;
            btnUpdatePackages.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdatePackages.ForeColor = Color.White;
            btnUpdatePackages.Location = new Point(242, 29);
            btnUpdatePackages.Margin = new Padding(3, 2, 3, 2);
            btnUpdatePackages.Name = "btnUpdatePackages";
            btnUpdatePackages.Size = new Size(191, 35);
            btnUpdatePackages.TabIndex = 3;
            btnUpdatePackages.Text = "Update Package";
            btnUpdatePackages.UseVisualStyleBackColor = false;
            btnUpdatePackages.Click += btnUpdatePackages_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(887, 7);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(19, 20);
            btnExit.TabIndex = 7;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // frmPackages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 412);
            Controls.Add(btnExit);
            Controls.Add(btnUpdatePackages);
            Controls.Add(btnAddPackages);
            Controls.Add(dgvPackages);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPackages";
            Text = "frmPackages";
            Load += frmPackages_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPackages;
        private Button btnAddPackages;
        private Button btnUpdatePackages;
        private Label btnExit;
    }
}