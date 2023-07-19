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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {

<<<<<<< HEAD
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

                
            }
=======
            RefreshDisplay();
>>>>>>> 3b0372016681571be7a1eec639fa34fb4bee9b6b

        }

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

        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? selected = cmbSuppliers.SelectedValue as int?;

            if (selected != null)
            {
                txtSupplierID.Text = $"{selected}";
            }
            else
            {
                txtSupplierID.Text = "";
            }

            RefreshProducts();
        }

        private void RefreshDisplay()
        {
            int? selectedSupplier = cmbSuppliers.SelectedValue as int?;
            int? selectedProduct = lstProducts.SelectedValue as int?;

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                cmbSuppliers.DataSource = db
                    .Suppliers
                    .Select(s => new { s.SupplierId, s.SupName })
                    .ToList();

                cmbSuppliers.ValueMember = "SupplierId";
                cmbSuppliers.DisplayMember = "SupName";

                if (selectedSupplier != null)
                    cmbSuppliers.SelectedValue = selectedSupplier;

                RefreshProducts();
            }
        }

        private void RefreshProducts()
        {
            int? selectedSupplier = cmbSuppliers.SelectedValue as int?;

            if (selectedSupplier == null) return;

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                lstProducts.DataSource = db
                .Suppliers
                .Where(s => s.SupplierId == selectedSupplier)
                .Join(
                    db.ProductsSuppliers,
                    s => s.SupplierId,
                    ps => ps.SupplierId,
                    (s, ps) => ps.ProductId)
                .Join(
                    db.Products,
                    ps => ps,
                    p => p.ProductId,
                    (ps, p) => new { p.ProductId, p.ProdName })
                .ToList();

                lstProducts.ValueMember = "ProductId";
                lstProducts.DisplayMember = "ProdName";
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            List<int> productIDsToExclude = new List<int>();

            int? productId = frmSelectProduct.SelectProduct(productIDsToExclude);

            if (productId != null)
            {
                using (var db = new TravelExpertsContext())
                {
                    var dbPS = new ProductsSupplier();
                    dbPS.ProductId = productsId;
                }
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            int? selectedSupplier = cmbSuppliers.SelectedValue as int?;
            int? selectedProduct = lstProducts.SelectedValue as int?;

            if (selectedProduct == null || selectedSupplier == null)
            {
                return;
            }

            using (var db = new TravelExpertsContext())
            {

                var dbProdSup = db
                    .ProductsSuppliers
                    .Where(ps => ps.SupplierId == selectedSupplier
                              && ps.ProductId == selectedProduct)
                    .SingleOrDefault();

                if (dbProdSup == null)
                {
                    MessageBox.Show($"Could not find product supplier for prod = {selectedProduct} and sup = {selectedSupplier}");
                    return;
                }

                db.ProductsSuppliers.Remove(dbProdSup);
                db.SaveChanges();

                RefreshProducts();
            }

            //private void btnAddSuppliers_Click(object sender, EventArgs e)
            //{
            //    // Create the frmAddModifyPackages form and set its ParentForm property to this instance
            //    frmAddModifySuppliers addForm = new frmAddModifySuppliers();


            //    // Open the frmAddModifyPackages form in the same panel (pnlMainContent)
            //    openFormInPanel(this.ParentForm, addForm);
            //}
        }
    }
}
