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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        // Event handler for the "frmProducts" form load event
        private void frmProducts_Load(object sender, EventArgs e)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                // Retrieve and display data for products in the DataGridView
                dgvProducts.DataSource = db.Products
                    .Select(p => new
                    {
                        p.ProductId,
                        p.ProdName
                    }).ToList();

                // Apply styling to the DataGridView
                dgvProducts.EnableHeadersVisualStyles = false;
                dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 73, 107);
                dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvProducts.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 73, 107);
                dgvProducts.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvProducts.DefaultCellStyle.BackColor = Color.White;
                dgvProducts.DefaultCellStyle.ForeColor = Color.Black;
                dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(225, 225, 225);
                dgvProducts.Font = new Font("Segoe UI", 9);

                // Change header text
                dgvProducts.Columns[0].HeaderText = "Product ID";
                dgvProducts.Columns[1].HeaderText = "Product Name";

                // Set the DataGridView's AutoSizeColumnsMode property to fit all cells
                dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Auto resize columns
                dgvProducts.AutoResizeColumns();
            }
        }

        // Event handler for the "Exit" button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Method to open the "frmAddModifyProducts" form inside the panel "pnlMainContent"
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

        // Event handler for the "Add Products" button click
        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            // Create the frmAddModifyPackages form and set its ParentForm property to this instance
            frmAddModifyProducts addForm = new frmAddModifyProducts();


            // Open the frmAddModifyPackages form in the same panel (pnlMainContent)
            openFormInPanel(this.ParentForm, addForm);
        }
    }
}