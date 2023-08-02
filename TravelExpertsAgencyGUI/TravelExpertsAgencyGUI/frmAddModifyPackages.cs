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
    public partial class frmAddModifyPackages : Form
    {

        private List<Supplier> suppliersList;
        private List<Product> productsList;
        public frmAddModifyPackages()
        {
            InitializeComponent();

        }
        private bool isadd = false;
        public bool isAdd { get; set; }
        public Package? package;
        public int? selectedSupplier;
        public int? selectedProduct;

        private void frmAddModifyPackages_Load(object sender, EventArgs e)
        {

            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    suppliersList = db.Suppliers.ToList();
                    cboSupp.DataSource = suppliersList;
                    cboSupp.DisplayMember = "SupName";
                    cboSupp.ValueMember = "SupplierId";

                    productsList = db.Products.ToList();

                    cboProd.DataSource = productsList;
                    cboProd.DisplayMember = "ProdName";
                    cboProd.ValueMember = "ProductId";
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
        }

        private void btnOkPackage_Click(object sender, EventArgs e)
        {
            
            if(Validator.IsPresent(txtPackageName) &&
                Validator.IsPresent(txtDesc) &&
                Validator.IsValidEndDate(dtpPackageStartDate, dtpPackageEndDate) &&
                Validator.isValidCommissionValue(txtPackageBasePrice, txtAgencyCommission)
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

                    selectedProduct = (int)cboProd.SelectedValue;
                    selectedSupplier = (int)cboSupp.SelectedValue;

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
                        #region Add item to the productsSupplier
                        ProductsSupplier productsSupplier = new ProductsSupplier();
                        productsSupplier.ProductId = selectedProduct;
                        productsSupplier.SupplierId = selectedSupplier;
                        db.ProductsSuppliers.Add(productsSupplier);
                        db.SaveChanges();
                        #endregion
                        #region add item to the Package table
                        db.Packages.Add(package);
                        db.SaveChanges();
                        #endregion
                        #region add item to the package_product_supplier
                        PackagesProductsSupplier packagesProductsSupplier = new PackagesProductsSupplier();
                        packagesProductsSupplier.PackageId = package.PackageId;
                        packagesProductsSupplier.ProductSupplierId = productsSupplier.ProductSupplierId;
                        db.PackagesProductsSuppliers.Add(packagesProductsSupplier);
                        db.SaveChanges();
                        #endregion
                    }

                    else if (!isAdd && package != null)
                    {
                        db.Packages.Find(package.PackageId = frmPackages.cellSelectedPackageId);
                        DisplayPackage();

                        var confirmEdit = MessageBox.Show("Are you sure you want to edit package?",
                                                            "Confirm", MessageBoxButtons.YesNo);
                        if (confirmEdit == DialogResult.Yes)
                        {
                            db.Packages.Find(package.PackageId = frmPackages.cellSelectedPackageId).PkgName = txtPackageName.Text;
                            db.Packages.Find(package.PackageId = frmPackages.cellSelectedPackageId).PkgDesc = txtDesc.Text;
                            db.Packages.Find(package.PackageId = frmPackages.cellSelectedPackageId).PkgStartDate = dtpPackageStartDate.Value;
                            db.Packages.Find(package.PackageId = frmPackages.cellSelectedPackageId).PkgEndDate = dtpPackageEndDate.Value;
                            db.Packages.Find(package.PackageId = frmPackages.cellSelectedPackageId).PkgBasePrice = Convert.ToDecimal(txtPackageBasePrice.Text);
                            db.Packages.Find(package.PackageId = frmPackages.cellSelectedPackageId).PkgAgencyCommission = Convert.ToDecimal(txtAgencyCommission.Text);
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


        private void GetSupplierAndProductIds(int packageId)
        {
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    var packagesProductsSupplier = db.PackagesProductsSuppliers
                        .FirstOrDefault(p => p.PackageId == packageId);

                    var productSupplier = db.ProductsSuppliers.FirstOrDefault(p => p.ProductSupplierId == packagesProductsSupplier.ProductSupplierId);

                    if (productSupplier != null)
                    {
                        selectedSupplier = productSupplier.SupplierId;
                        selectedProduct = productSupplier.ProductId;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving SupplierId and ProductId: " +
                    ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayPackage()
        {
            if (package != null)
            {
                txtPackageName.Text = package.PackageId.ToString();
                txtPackageName.Text = package.PkgName;
                txtPackageBasePrice.Text = package.PkgBasePrice.ToString();
                txtDesc.Text = package.PkgDesc;
                txtAgencyCommission.Text = package.PkgAgencyCommission.ToString();
                dtpPackageStartDate.Value = Convert.ToDateTime(package.PkgStartDate);
                dtpPackageEndDate.Value = Convert.ToDateTime(package.PkgEndDate);
                // Call the method to retrieve SupplierId and ProductId based on PackageId
                GetSupplierAndProductIds(package.PackageId);

                // Set the selected value for ComboBox controls based on selectedSupplier and selectedProduct
                cboSupp.DataSource = suppliersList;
                cboSupp.SelectedValue = selectedSupplier;
                cboProd.DataSource = productsList;
                cboProd.SelectedValue = selectedProduct;
                //deactive ComboBoxes
                cboProd.Enabled = false;
                cboSupp.Enabled = false;
            }
        }
    }
}
