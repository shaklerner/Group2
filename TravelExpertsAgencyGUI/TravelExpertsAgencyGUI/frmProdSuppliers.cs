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
    /* displays a listing product-supplier relationships from the "ProductsSuppliers" table.
     * Agents can add new product-supplier relationships and modify existing ones using the selected ProductSupplier relationship.
     * refreshed to display the updated or newly added relationship in the DataGridView.
     * when: July 2023
     * Author : Kiranpal
     */
    public partial class frmProdSuppliers : Form
    {

        public frmProdSuppliers()
        {
            InitializeComponent();
        }

        // Event handler for the "Add ProdSuppliers" button click
        private void btnAddProdSup_Click(object sender, EventArgs e)
        {
            // Create the frmAddModifyPackages form and set its ParentForm property to this instance
            frmAddModifyProdSuppliers addForm = new frmAddModifyProdSuppliers();


            // Open the frmAddModifyPackages form in the same panel (pnlMainContent)
            Actions.Actions.openFormInPanel(this.ParentForm, addForm);

        }

        // Event handler for the "frmProdSuppliers" form load event
        private void frmProdSuppliers_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
            try
            { 
                using (var db = new TravelExpertsContext())
                {
                    // Retrieve and display data for Product-Supplier relationship in the DataGridView
                    var prodSuppliersData = db.ProductsSuppliers
                        .Select(ps => new
                        {
                            ps.ProductSupplierId,
                            ProductName = ps.Product.ProdName,
                            SupplierName = ps.Supplier.SupName
                        })
                        .ToList();

                    dgvProdSup.DataSource = prodSuppliersData;

                    // Set the DataGridView's AutoSizeColumnsMode property to fit all cells
                    dgvProdSup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    // Set the AutoSizeMode of the "ProductName" and "SupplierName" columns to Fill
                    dgvProdSup.Columns["ProductName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvProdSup.Columns["SupplierName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    // Apply the same styling as dgvPackages
                    dgvProdSup.EnableHeadersVisualStyles = false;
                    dgvProdSup.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 73, 107);
                    dgvProdSup.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvProdSup.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 73, 107);
                    dgvProdSup.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvProdSup.DefaultCellStyle.BackColor = Color.White;
                    dgvProdSup.DefaultCellStyle.ForeColor = Color.Black;
                    dgvProdSup.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(225, 225, 225);
                    dgvProdSup.Font = new Font("Segoe UI", 9);

                    // Change header text
                    dgvProdSup.Columns[0].HeaderText = "ID";
                    dgvProdSup.Columns[1].HeaderText = "Product";
                    dgvProdSup.Columns[2].HeaderText = "Supplier";

                    // Alignments
                    dgvProdSup.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvProdSup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgvProdSup.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., display an error message)
                MessageBox.Show($"An error occurred while refreshing the DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditProdSup_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in dgvProdSuppliers
            if (dgvProdSup.SelectedRows.Count == 0 && dgvProdSup.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected ProductSupplier ID from the selected row
            int selectedProductSupplierId = Convert.ToInt32(dgvProdSup.CurrentRow.Cells[0].Value);
            // Create the frmAddModifyProdSuppliers form in edit mode and pass the selected ProductSupplier ID
            frmAddModifyProdSuppliers editForm = new frmAddModifyProdSuppliers(selectedProductSupplierId);


            // Open the frmAddModifyPackages form in the same panel (pnlMainContent)
            Actions.Actions.openFormInPanel(this.ParentForm, editForm);
        }

        // Event handler for the "Exit" button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
