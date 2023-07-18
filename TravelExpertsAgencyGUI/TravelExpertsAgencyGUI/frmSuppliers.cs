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

            RefreshDisplay();

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

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmAddModifySuppliers addSuppForm = new frmAddModifySuppliers();
            Actions.Actions.openFormInPanel(this.ParentForm, addSuppForm);
        }

        private void btnRemoveSupplier_Click(object sender, EventArgs e)
        {
            int? selectedSupplier = cmbSuppliers.SelectedValue as int?;

            if (selectedSupplier == null)
            {
                return;
            }

            using (var db = new TravelExpertsContext())
            {

                var dbSupplier = db
                    .Suppliers
                    .Where(s => s.SupplierId == selectedSupplier)
                    .SingleOrDefault();

                if (dbSupplier == null)
                {
                    return;
                }

                db.Suppliers.Remove(dbSupplier);
                db.SaveChanges();

                RefreshDisplay();
            }
        }
    }
}
