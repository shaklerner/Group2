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
    public partial class frmSuppliers : Form
    {
        public frmSuppliers()
        {
            InitializeComponent();
        }

        // Event handler for the "Exit" button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for the "frmSuppliers" form load event
        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                // Retrieve and display data for suppliers in the DataGridView
                dgvSuppliers.DataSource = db.Suppliers
                    .Select(s => new
                    {
                        s.SupplierId,
                        s.SupName
                    }).ToList();

                // Apply styling to the DataGridView
                dgvSuppliers.EnableHeadersVisualStyles = false;
                dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 73, 107);
                dgvSuppliers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvSuppliers.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 73, 107);
                dgvSuppliers.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvSuppliers.DefaultCellStyle.BackColor = Color.White;
                dgvSuppliers.DefaultCellStyle.ForeColor = Color.Black;
                dgvSuppliers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(225, 225, 225);
                dgvSuppliers.Font = new Font("Segoe UI", 9);

                // Change header text
                dgvSuppliers.Columns[0].HeaderText = "Supplier ID";
                dgvSuppliers.Columns[1].HeaderText = "Supplier Name";

                // Set equal width for both columns
                dgvSuppliers.Columns[0].FillWeight = 50;
                dgvSuppliers.Columns[1].FillWeight = 50;

                // Set column AutoSizeMode to Fill
                dgvSuppliers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvSuppliers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Auto resize columns
                dgvSuppliers.AutoResizeColumns();
            }

        }

        // Method to open the "frmAddModifySuppliers" form inside the panel "pnlMainContent"
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

        // Event handler for the "Add Suppliers" button click
        private void btnAddSuppliers_Click(object sender, EventArgs e)
        {
            // Create the frmAddModifySuppliers form and set its ParentForm property to this instance
            frmAddModifySuppliers addForm = new frmAddModifySuppliers();
            

            // Open the frmAddModifySuppliers form in the same panel (pnlMainContent)
            openFormInPanel(this, addForm);
        }
    }
}
