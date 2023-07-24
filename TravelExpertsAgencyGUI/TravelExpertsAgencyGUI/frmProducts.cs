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
        public Product? currentProduct;

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
                dgvProducts.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvProducts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        // This method stores the selected product from the data grid view
        // Handles both single cell selection (id or product name cell) and whole row selection
        public void getSelectedProduct()
        {
            if (dgvProducts.SelectedRows.Count >= 0 || dgvProducts.SelectedCells.Count >= 0)
            {
                int selectedProductID = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value);
                try
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        currentProduct = db.Products.Find(selectedProductID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while processing selected product for editing." + ex.Message,
                        ex.GetType().ToString());
                }
            }
            else return;

        }

        // Event handler for the "Exit" button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for the "Add Products" button click
        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            // Create the frmAddModifyPackages form and set its ParentForm property to this instance
            frmAddModifyProducts addForm = new frmAddModifyProducts();

            addForm.isAdd = true;
            // Open the frmAddModifyPackages form in the same panel (pnlMainContent)
            Actions.Actions.openFormInPanel(this.ParentForm, addForm);
        }

        // Passes selected product to Add/Modify form and opens it
        private void btnEditProducts_Click(object sender, EventArgs e)
        {
            frmAddModifyProducts editForm = new frmAddModifyProducts();
            editForm.isAdd = false;
            getSelectedProduct(); // get selected product
            editForm.product = currentProduct; // pass selected product to second form
            Actions.Actions.openFormInPanel(this.ParentForm, editForm);
        }
    }
}