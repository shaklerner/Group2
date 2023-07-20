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
        /*
         * This is the Suppliers form, showing the list of all suppliers and their IDs
         * If a supplier is highlighted in the Suppliers list, their products are displayed
         * as well.
         */
        public frmSuppliers()
        {
            InitializeComponent();
        }

        /*
         * OnClick handler for the exit button
         */
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * OnLoad handler, queries the database for supplier data to fill the form
         */
        private void frmSuppliers_Load(object sender, EventArgs e)
        {

            using (TravelExpertsContext ctx = new())
            {
                // Supplying our own column names, so we can still use underlying Supplier
                // type (no intermediary/anonymous type for Select)
                dgvSuppliers.AutoGenerateColumns = false;

                // DataSource is all suppliers, sorted by name
                dgvSuppliers.DataSource = ctx
                    .Suppliers
                    .OrderBy(s => s.SupName)
                    .ToList();

                // Use these fields for each column, column titles are configured in design mode
                dgvSuppliers.Columns[0].DataPropertyName = "SupplierId";
                dgvSuppliers.Columns[1].DataPropertyName = "SupName";
                // Fill available space with columns
                dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSuppliers.AutoResizeColumns();
            }

            // Update display for whatever supplier is autoselected
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

        /*
         * This method updates the products listed for the selected supplier in the lstProducts
         * list box
         */
        private void RefreshProducts()
        {
            // either 0 or >1 rows selected, (shouldn't be possible, but just in case)
            if (dgvSuppliers.SelectedRows.Count != 1) return;

            // Get the selected supplier
            Supplier? selected = dgvSuppliers.SelectedRows[0].DataBoundItem as Supplier;

            // Should be impossible if SelectedRows.Count == 1
            if (selected == null) return;

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                // Get the list of products that this supplier supplies from the database
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

                // Value/Display members for the listbox
                lstProducts.ValueMember = "ProductId";
                lstProducts.DisplayMember = "ProdName";
            }
        }

        // Whenever the selection is changed in the DataGridView, update the
        // list of products for the selected supplier
        private void dgvSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        // The "More Info" button, takes the user to the ProductSuppliers form 
        private void btnGoProductsSuppliers_Click(object sender, EventArgs e)
        {
            frmProdSuppliers prodSupForm = new();

            openFormInPanel(this.ParentForm, prodSupForm );
        }

        // The "Add" button, open a form to add a new supplier
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddModifySuppliers addForm = new();

            openFormInPanel(this.ParentForm, addForm);
        }

        // The "Edit" button, open a form to edit the selected supplier
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            Supplier? selected = dgvSuppliers.SelectedRows[0].DataBoundItem as Supplier;

            if (selected == null) return;

            frmAddModifySuppliers editForm = new(selected!);

            openFormInPanel(this.ParentForm, editForm);
        }
    }
}
