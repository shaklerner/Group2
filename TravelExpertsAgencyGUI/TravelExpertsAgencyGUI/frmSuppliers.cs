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

            using (TravelExpertsContext ctx = new())
            {
                dgvSuppliers.AutoGenerateColumns = false;

                dgvSuppliers.DataSource = ctx
                    .Suppliers
                    .OrderBy(s => s.SupName)
                    .ToList();

                dgvSuppliers.Columns[0].HeaderText = "ID";
                dgvSuppliers.Columns[0].DataPropertyName = "SupplierId";
                dgvSuppliers.Columns[1].HeaderText = "Supplier Name";
                dgvSuppliers.Columns[1].DataPropertyName = "SupName";
                dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSuppliers.AutoResizeColumns();
            }

            RefreshProducts();

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

        private void RefreshProducts()
        {
            if (dgvSuppliers.SelectedRows.Count != 1) return;

            Supplier? selected = dgvSuppliers.SelectedRows[0].DataBoundItem as Supplier;

            if (selected == null) return;

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                lstProducts.DataSource = db
                .Suppliers
                .Where(s => s.SupplierId == selected.SupplierId)
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

        private void dgvSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        private void btnGoProductsSuppliers_Click(object sender, EventArgs e)
        {
            frmProdSuppliers prodSupForm = new();

            openFormInPanel(this.ParentForm, prodSupForm );
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddModifySuppliers addForm = new();

            openFormInPanel(this.ParentForm, addForm);
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            Supplier? selected = dgvSuppliers.SelectedRows[0].DataBoundItem as Supplier;

            if (selected == null) return;

            frmAddModifySuppliers editForm = new(selected!);

            openFormInPanel(this.ParentForm, editForm);
        }
    }
}
