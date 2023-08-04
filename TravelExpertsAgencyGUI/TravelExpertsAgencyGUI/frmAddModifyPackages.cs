using Microsoft.EntityFrameworkCore; 
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
    // Define a read-only record struct named DGVItem with three properties - ID, Product, and Supplier.
    // This struct is used as a data type for DataGridView items to represent Product-Supplier pairs.
    public readonly record struct DGVItem(int ID, string Product, string Supplier);

    // Define a partial class frmAddModifyPackages, which is a Windows Forms form.
    public partial class frmAddModifyPackages : Form
    {
        // Fields and Properties:
        private bool isadd = false; // Field to indicate if the form is for adding a new package or modifying an existing one.
        public bool isAdd { get; set; } // Property that gets or sets the isadd field value.
        public Package? package; // Nullable Package object that holds the data for the current package being added or modified.

        // Constructor for frmAddModifyPackages class.
        public frmAddModifyPackages()
        {
            InitializeComponent(); // Initialize the components of the form.
        }

        // Event handler for the Load event of the form.
        private void frmAddModifyPackages_Load(object sender, EventArgs e)
        {
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    // Get the PackageId of the current package if available, otherwise set to 0.
                    int pid = package?.PackageId ?? 0;

                    // Get a list of ProductSupplierIds associated with the current package.
                    List<int> toFilter = db
                        .PackagesProductsSuppliers
                        .Where(pps => pps.PackageId == pid)
                        .Select(pps => pps.ProductSupplierId)
                        .ToList();

                    // Load data into the DataGridView for available Product-Supplier pairs that are not associated with the current package.
                    dgvProductSuppliers.AutoGenerateColumns = false;
                    dgvProductSuppliers.DataSource = db
                        .ProductsSuppliers
                        .Where(ps => !toFilter.Contains(ps.ProductSupplierId))
                        .Include(ps => ps.Product)
                        .Include(ps => ps.Supplier)
                        .OrderBy(ps => ps.Product!.ProdName)
                        .ThenBy(ps => ps.Supplier)
                        .Select(ps => new DGVItem(ps.ProductSupplierId, ps.Product!.ProdName, ps.Supplier!.SupName))
                        .ToList();

                    // Load data into the DataGridView for Product-Supplier pairs already associated with the current package.
                    dgvExistingProductSuppliers.AutoGenerateColumns = false;
                    dgvExistingProductSuppliers.DataSource = db
                        .ProductsSuppliers
                        .Where(ps => toFilter.Contains(ps.ProductSupplierId))
                        .Include(ps => ps.Product)
                        .Include(ps => ps.Supplier)
                        .OrderBy(ps => ps.Product!.ProdName)
                        .ThenBy(ps => ps.Supplier)
                        .Select(ps => new DGVItem(ps.ProductSupplierId, ps.Product!.ProdName, ps.Supplier!.SupName))
                        .ToList();

                    // Set up DataGridView column data properties and visual styles.
                    dgvProductSuppliers.Columns[0].DataPropertyName = "Product";
                    dgvProductSuppliers.Columns[1].DataPropertyName = "Supplier";
                    dgvProductSuppliers.EnableHeadersVisualStyles = false;
                    dgvProductSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvProductSuppliers.AutoResizeColumns();
                    dgvExistingProductSuppliers.Columns[0].DataPropertyName = "Product";
                    dgvExistingProductSuppliers.Columns[1].DataPropertyName = "Supplier";
                    dgvExistingProductSuppliers.EnableHeadersVisualStyles = false;
                    dgvExistingProductSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvExistingProductSuppliers.AutoResizeColumns();
                }

            }
            catch (Exception ex)
            {
                // Show an error message box if there's an exception while loading suppliers and products.
                MessageBox.Show("Error while loading suppliers and products: " + ex.Message, ex.GetType().ToString());
            }

            // If the form is  for UPDATING a package, display the package details in the form.
            if (!isAdd)
            {
                DisplayPackage();
                btnOkPackage.Text = "Update";
            }
            else
            {
                // If the form is for adding a new package, hide the DataGridView for existing Product-Supplier pairs.
                dgvExistingProductSuppliers.Visible = false;
            }
        }

        // Event handler for the Click event of the "OK" button (btnOkPackage).
        private void btnOkPackage_Click(object sender, EventArgs e)
        {
            // Perform data validation using the Validator class.
            if (Validator.IsPresent(txtPackageName) &&
                Validator.IsPresent(txtDesc) &&
                Validator.IsValidEndDate(dtpPackageStartDate, dtpPackageEndDate) &&
                Validator.isValidCommissionValue(txtPackageBasePrice, txtAgencyCommission) &&
                Validator.IsValidDescription(txtDesc))
            {
                // If it's a new package, create a new Package object.
                if (isAdd)
                {
                    package = new Package();
                }

                // Update the Package object with the form data.
                if (package != null)
                {
                    package.PkgName = txtPackageName.Text;
                    package.PkgStartDate = dtpPackageStartDate.Value;
                    package.PkgEndDate = dtpPackageEndDate.Value;
                    package.PkgDesc = txtDesc.Text;
                    package.PkgBasePrice = Convert.ToDecimal(txtPackageBasePrice.Text);
                    package.PkgAgencyCommission = Convert.ToDecimal(txtAgencyCommission.Text);

                    // Set the DialogResult to OK to indicate that the operation is successful.
                    this.DialogResult = DialogResult.OK;
                }

                // Call the CallDB method to save the changes to the database.
                CallDB();

                // Close the form after saving changes and open the frmPackages form in the frmMainForm panel.
                this.Close();
                Actions.Actions.openFormInPanel(frmMainForm.ActiveForm, new frmPackages());
            }
        }

        // Method to perform database operations based on the form data.
        private void CallDB()
        {
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    if (isAdd && package != null) // If this is a new productsSupplier item
                    {
                        // Add the new package to the Package table.
                        db.Packages.Add(package);
                        db.SaveChanges();

                        // Add the selected Product-Supplier pairs to the package_product_supplier table.
                        foreach (DataGridViewRow row in dgvProductSuppliers.SelectedRows)
                        {
                            PackagesProductsSupplier packagesProductsSupplier = new PackagesProductsSupplier();
                            packagesProductsSupplier.PackageId = package.PackageId;
                            packagesProductsSupplier.ProductSupplierId = ((DGVItem)row.DataBoundItem).ID;
                            db.PackagesProductsSuppliers.Add(packagesProductsSupplier);
                        }
                        db.SaveChanges();
                    }
                    else if (!isAdd && package != null) // If modifying an existing package
                    {
                        // Find the corresponding package in the database.
                        Package dbPackage = db.Packages.Find(package.PackageId)!;

                        // Display a confirmation message box for editing the package.
                        var confirmEdit = MessageBox.Show("Are you sure you want to edit the package?", "Confirm", MessageBoxButtons.YesNo);
                        if (confirmEdit == DialogResult.Yes)
                        {
                            // Update the package details in the database.
                            dbPackage.PkgName = txtPackageName.Text;
                            dbPackage.PkgDesc = txtDesc.Text;
                            dbPackage.PkgStartDate = dtpPackageStartDate.Value;
                            dbPackage.PkgEndDate = dtpPackageEndDate.Value;
                            dbPackage.PkgBasePrice = Convert.ToDecimal(txtPackageBasePrice.Text);
                            dbPackage.PkgAgencyCommission = Convert.ToDecimal(txtAgencyCommission.Text);

                            // Get the list of ProductSupplierIds associated with the package.
                            List<int> pkgProductSuppliers = db.PackagesProductsSuppliers
                                .Where(pps => pps.PackageId == package.PackageId)
                                .Select(pps => pps.ProductSupplierId)
                                .ToList();

                            // Add newly selected Product-Supplier pairs to the package_product_supplier table.
                            foreach (DataGridViewRow row in dgvProductSuppliers.SelectedRows)
                            {
                                PackagesProductsSupplier packagesProductsSupplier = new PackagesProductsSupplier();
                                packagesProductsSupplier.PackageId = package.PackageId;
                                if (pkgProductSuppliers.Contains(((DGVItem)row.DataBoundItem).ID))
                                {
                                    continue; // Skip if the Product-Supplier pair is already associated with the package.
                                }
                                packagesProductsSupplier.ProductSupplierId = ((DGVItem)row.DataBoundItem).ID;
                                db.PackagesProductsSuppliers.Add(packagesProductsSupplier);
                            }

                            db.SaveChanges();
                            this.Close();
                            Actions.Actions.openFormInPanel(frmMainForm.ActiveForm, new frmPackages());
                        }
                    }
                    else
                    {
                        return; // If no package data is available, return without performing any database operations.
                    }
                }
            }
            catch (Exception ex)
            {
                // Show an error message box if there's an exception while adding or updating the package.
                MessageBox.Show("Error while adding package." + ex.Message, ex.GetType().ToString());
            }
        }

        // Event handler for the Click event of the "Cancel" button (btnCancel).
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the current frmAddModifyPackages form and open the frmPackages form in the frmMainForm panel.
            this.Close();
            Actions.Actions.openFormInPanel(frmMainForm.ActiveForm, new frmPackages());
        }

        // Method to display package details in the form.
        private void DisplayPackage()
        {
            if (package != null)
            {
                txtPackageName.Text = package.PackageId.ToString();
                txtPackageName.Text = package.PkgName;
                txtPackageBasePrice.Text = $"{package.PkgBasePrice:F2}";
                txtDesc.Text = package.PkgDesc;
                txtAgencyCommission.Text = $"{package.PkgAgencyCommission:F2}";
                dtpPackageStartDate.Value = Convert.ToDateTime(package.PkgStartDate);
                dtpPackageEndDate.Value = Convert.ToDateTime(package.PkgEndDate);
                // Call the method to retrieve SupplierId and ProductId based on PackageId
            }
        }
    }
}
