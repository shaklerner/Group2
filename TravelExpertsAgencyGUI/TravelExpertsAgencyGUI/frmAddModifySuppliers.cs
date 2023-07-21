using Microsoft.Data.SqlClient;
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
    public partial class frmAddModifySuppliers : Form
    {
        private Supplier? _supplier;
        private int? _id;

        /*
         * This form allows the user to add or edit a supplier. If the constructor is given
         * a supplier argument, then that supplier will be edited, otherwise a new supplier
         * will be created.
         */
        public frmAddModifySuppliers(Supplier? ToEdit = null!)
        {
            // The supplier we're editing (if we are at all)
            _supplier = ToEdit;
            InitializeComponent();

            if (_supplier != null)
            {
                // Edit mode, fill out the fields with existing info
                lblMode.Text = "Edit Supplier";
                txtID.Text = $"{_supplier.SupplierId}";
                txtName.Text = _supplier.SupName;
            }
            else
            {
                // Add mode, clear the fields and generate a unique ID (because the database
                // does not autogenerate them)
                lblMode.Text = "Create Supplier";
                txtName.Text = "";

                using (TravelExpertsContext ctx = new())
                {
                    // Query for max ID
                    int? maxID = ctx
                        .Suppliers
                        .OrderByDescending(s => s.SupplierId)
                        .Select(s => s.SupplierId)
                        .FirstOrDefault();

                    // There are no existing suppliers
                    if (maxID == null)
                    {
                        maxID = 1;
                    }

                    // New id will be old id + 1
                    _id = maxID + 1;

                    txtID.Text = $"{_id}";
                }
            }
        }

        private void btnExitSuppliers_Click(object sender, EventArgs e)
        {
            this.Close();
            Actions.Actions.openFormInPanel(frmMainForm.ActiveForm, new frmSuppliers());
        }

        /*
         * OnClick handler for  Add/Edit. Validates the data and either updates or creates a
         * new entry in the Suppliers table. Reopens the suppliers form when done
         */
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Validate the name before adding/editing
            // Maximum length is set by the textbox property, so code-validation is not necessary
            if (!Validator.IsPresent(txtName))
            {
                return;
            }

            using (TravelExpertsContext ctx = new())
            {
                Supplier? dbSupplier = new();

                // _supplier was supplied to constructor, so it's edit mode
                if (_supplier != null)
                {
                    // get the corresponding entry from the DB
                    dbSupplier = ctx
                         .Suppliers
                         .Where(s => s.SupplierId == _supplier.SupplierId)
                         .FirstOrDefault();
                }
                else
                {
                    dbSupplier.SupplierId = (int)_id!;
                }

                dbSupplier!.SupName = txtName.Text;

                if (_supplier == null)
                {
                    ctx.Suppliers.Add(dbSupplier);
                }

                try
                {
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            openSuppliers();
        }

        /*
         * OnClick handler for the cancel button, re-opens the Suppliers form
         */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            openSuppliers();
        }

        // Slight modification of the openFormInPanel function to open the suppliers form
        private void openSuppliers()
        {
            Form mainForm = this.ParentForm;
            Form subForm = new frmSuppliers();

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
    }
}
