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

        public frmAddModifySuppliers(Supplier? ToEdit = null!)
        {
            _supplier = ToEdit;
            InitializeComponent();

            if (_supplier != null)
            {
                lblMode.Text = "Edit Supplier";
                txtID.Text = $"{_supplier.SupplierId}";
                txtName.Text = _supplier.SupName;
            }
            else
            {
                lblMode.Text = "Create Supplier";
                txtName.Text = "";

                using (TravelExpertsContext ctx = new())
                {
                    int? maxID = ctx
                        .Suppliers
                        .OrderByDescending(s => s.SupplierId)
                        .Select(s => s.SupplierId)
                        .FirstOrDefault();

                    if (maxID == null)
                    {
                        maxID = 1;
                    }

                    _id = maxID + 1;

                    txtID.Text = $"{_id}";
                }
            }
        }

        private void btnExitSuppliers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (TravelExpertsContext ctx = new())
            {
                Supplier dbSupplier = new();

                if (_supplier != null)
                {
                    dbSupplier = ctx
                         .Suppliers
                         .Where(s => s.SupplierId == _supplier.SupplierId)
                         .First();
                }
                else
                {
                    dbSupplier.SupplierId = (int)_id!;
                }

                dbSupplier.SupName = txtName.Text;

                if (_supplier == null)
                {
                    ctx.Suppliers.Add(dbSupplier);
                }

                ctx.SaveChanges();
            }

            openSuppliers();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            openSuppliers();
        }

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
