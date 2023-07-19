using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsAgencyGUI.Models;

namespace TravelExpertsAgencyGUI
{
    public partial class frmPackages : Form
    {
        private TravelExpertsContext dbContext;
        
        public frmPackages()
        {
            dbContext = new TravelExpertsContext();
            InitializeComponent();
        }
        // Method to open a form inside the panel "pnlMainContent"
        private void openFormInPanel(Form mainForm, Form subForm)
        {
            // Find the panel control on the main form by its name
            Panel? mainPanel = mainForm.Controls.Find("pnlMainContent", true).FirstOrDefault() as Panel;

            // Check if the main panel exists and has child controls
            if (mainPanel != null && mainPanel.Controls.Count > 0)
            {
                // Remove the first child control from the main panel
                mainPanel.Controls.RemoveAt(0);
            }

            if (mainPanel != null)
            {
                // Set properties of the subForm
                subForm.TopLevel = false;
                subForm.Dock = DockStyle.Fill;

                // Add the subForm to the main panel's controls
                mainPanel.Controls.Add(subForm);

                // Set the tag of the main panel to the subForm (optional)
                mainPanel.Tag = subForm;

                // Show the subForm
                subForm.Show();
            }
        }
        // Event handler for the "Add Packages" button click
        private void btnAddPackages_Click(object sender, EventArgs e)
        {
            // Create the frmAddModifyPackages form and set its ParentForm property to this instance
            frmAddModifyPackages addForm = new frmAddModifyPackages();


            // Open the frmAddModifyPackages form in the same panel (pnlMainContent)
            openFormInPanel(this.ParentForm, addForm);
        }

        // Event handler for the "frmPackages" form load event
        private void frmPackages_Load(object sender, EventArgs e)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                // Retrieve and display packages data in the DataGridView
                dgvPackages.DataSource = db.Packages
                    .Select(p => new
                    {
                        p.PackageId,
                        p.PkgName,
                        PkgStartDate = p.PkgStartDate.GetValueOrDefault().ToShortDateString(), // Custom format for start date
                        PkgEndDate = p.PkgEndDate.GetValueOrDefault().ToShortDateString(),     // Custom format for end date
                        p.PkgDesc,
                        p.PkgBasePrice,
                        p.PkgAgencyCommission
                    }).ToList();

                // Format the grid
                dgvPackages.EnableHeadersVisualStyles = false;
                dgvPackages.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 73, 107);
                dgvPackages.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvPackages.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 73, 107);
                dgvPackages.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvPackages.DefaultCellStyle.BackColor = Color.White;
                dgvPackages.DefaultCellStyle.ForeColor = Color.Black;
                dgvPackages.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(225, 225, 225);
                dgvPackages.Font = new Font("Segoe UI", 9);

                // Change header text
                dgvPackages.Columns[0].HeaderText = "Package Id";
                dgvPackages.Columns[1].HeaderText = "Name";
                dgvPackages.Columns[2].HeaderText = "Start Date";
                dgvPackages.Columns[3].HeaderText = "End Date";
                dgvPackages.Columns[4].HeaderText = "Description";
                dgvPackages.Columns[5].HeaderText = "Base Price";
                dgvPackages.Columns[6].HeaderText = "Agency Commission";

                // Alignments
                dgvPackages.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
        }

        // Event handler for the "Exit" button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}