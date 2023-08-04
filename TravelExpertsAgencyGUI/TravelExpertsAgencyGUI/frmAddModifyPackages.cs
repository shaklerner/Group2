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
    public readonly record struct DGVItem(int ID, string Product, string Supplier);
    public partial class frmAddModifyPackages : Form
    {
        public frmAddModifyPackages()
        {
            InitializeComponent();

        }
        private bool isadd = false;
        public bool isAdd { get; set; }
        public Package? package;

        private void frmAddModifyPackages_Load(object sender, EventArgs e)
        {

            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    int pid = package?.PackageId ?? 0;
                    List<int> toFilter = db
                        .PackagesProductsSuppliers
                        .Where(pps => pps.PackageId == pid)
                        .Select(pps => pps.ProductSupplierId)
                        .ToList();

                    dgvProductSuppliers.AutoGenerateColumns = false;
                    dgvExistingProductSuppliers.AutoGenerateColumns = false;
                    dgvProductSuppliers.DataSource = db
                        .ProductsSuppliers
                        .Where(ps => !toFilter.Contains(ps.ProductSupplierId))
                        .Include(ps => ps.Product)
                        .Include(ps => ps.Supplier)
                        .OrderBy(ps => ps.Product!.ProdName)
                        .ThenBy(ps => ps.Supplier)
                        .Select(ps => new DGVItem(ps.ProductSupplierId, ps.Product!.ProdName, ps.Supplier!.SupName))
                        .ToList();
                    dgvExistingProductSuppliers.DataSource = db
                        .ProductsSuppliers
                        .Where(ps => toFilter.Contains(ps.ProductSupplierId))
                        .Include(ps => ps.Product)
                        .Include(ps => ps.Supplier)
                        .OrderBy(ps => ps.Product!.ProdName)
                        .ThenBy(ps => ps.Supplier)
                        .Select(ps => new DGVItem(ps.ProductSupplierId, ps.Product!.ProdName, ps.Supplier!.SupName))
                        .ToList();

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
                MessageBox.Show("Error while loading suppliers and products: " +
                    ex.Message, ex.GetType().ToString());
            }

            if (!isAdd)
            {
                DisplayPackage();
                btnOkPackage.Text = "Update";
            }
            else
            {
                dgvExistingProductSuppliers.Visible = false;
            }
        }

        private void btnOkPackage_Click(object sender, EventArgs e)
        {

            if (Validator.IsPresent(txtPackageName) &&
                Validator.IsPresent(txtDesc) &&
                Validator.IsValidEndDate(dtpPackageStartDate, dtpPackageEndDate) &&
                Validator.isValidCommissionValue(txtPackageBasePrice, txtAgencyCommission) &&
                Validator.IsValidDescription(txtDesc)
                )
            {
                if (isAdd)
                {
                    package = new Package();
                }

                if (package != null)
                {
                    package.PkgName = txtPackageName.Text;
                    package.PkgStartDate = dtpPackageStartDate.Value;
                    package.PkgEndDate = dtpPackageEndDate.Value;
                    package.PkgDesc = txtDesc.Text;
                    package.PkgBasePrice = Convert.ToDecimal(txtPackageBasePrice.Text);
                    package.PkgAgencyCommission = Convert.ToDecimal(txtAgencyCommission.Text);

                    this.DialogResult = DialogResult.OK;
                }

                CallDB();

                this.Close();

                Actions.Actions.openFormInPanel(frmMainForm.ActiveForm, new frmPackages());

            }
        }

        private void CallDB()
        {
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    if (isAdd && package != null) //if this is a new productsSupplier item
                    {
                        #region add item to the Package table
                        db.Packages.Add(package);
                        db.SaveChanges();
                        #endregion
                        #region add item to the package_product_supplier
                        foreach (DataGridViewRow row in dgvProductSuppliers.SelectedRows)
                        {
                            PackagesProductsSupplier packagesProductsSupplier = new PackagesProductsSupplier();
                            packagesProductsSupplier.PackageId = package.PackageId;
                            packagesProductsSupplier.ProductSupplierId = ((DGVItem)row.DataBoundItem).ID;
                            db.PackagesProductsSuppliers.Add(packagesProductsSupplier);
                        }
                        db.SaveChanges();
                        #endregion
                    }

                    else if (!isAdd && package != null)
                    {
                        Package dbPackage = db.Packages.Find(package.PackageId)!;
                        //DisplayPackage();

                        var confirmEdit = MessageBox.Show("Are you sure you want to edit package?",
                                                            "Confirm", MessageBoxButtons.YesNo);
                        if (confirmEdit == DialogResult.Yes)
                        {
                            db.Packages.Find(package.PackageId).PkgName = txtPackageName.Text;
                            db.Packages.Find(package.PackageId).PkgDesc = txtDesc.Text;
                            db.Packages.Find(package.PackageId).PkgStartDate = dtpPackageStartDate.Value;
                            db.Packages.Find(package.PackageId).PkgEndDate = dtpPackageEndDate.Value;
                            db.Packages.Find(package.PackageId).PkgBasePrice = Convert.ToDecimal(txtPackageBasePrice.Text);
                            db.Packages.Find(package.PackageId).PkgAgencyCommission = Convert.ToDecimal(txtAgencyCommission.Text);

                            List<int> pkgProductSuppliers = new TravelExpertsContext()
                                .PackagesProductsSuppliers
                                .Where(pps => pps.PackageId == package.PackageId)
                                .Select(pps => pps.ProductSupplierId)
                                .ToList();

                            foreach (DataGridViewRow row in dgvProductSuppliers.SelectedRows)
                            {
                                PackagesProductsSupplier packagesProductsSupplier = new PackagesProductsSupplier();
                                packagesProductsSupplier.PackageId = package.PackageId;
                                if (pkgProductSuppliers.Contains(((DGVItem)row.DataBoundItem).ID))
                                {
                                    continue;
                                }
                                packagesProductsSupplier.ProductSupplierId = ((DGVItem)row.DataBoundItem).ID;
                                db.PackagesProductsSuppliers.Add(packagesProductsSupplier);
                            }

                            db.SaveChanges();
                            this.Close();
                            Actions.Actions.openFormInPanel(frmMainForm.ActiveForm, new frmPackages());

                        }

                    }
                    else return;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding package." + ex.Message,
                    ex.GetType().ToString());
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the current frmAddModifyPackages form
            this.Close();
            Actions.Actions.openFormInPanel(frmMainForm.ActiveForm, new frmPackages());
        }

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
