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
    /*
     *when : july 2023
     *Author : Kiranpal Kaur
     */
    public partial class frmAddModifyProdSuppliers : Form
    {
        private int prodSupId;
        private bool isEditMode = false; // Add a flag to track if it's in edit mode


        // Constructor for adding new record (no need for the productSupplierId parameter)      
        public frmAddModifyProdSuppliers()
        {
            InitializeComponent();

            // Load data into the cboProducts and cboSuppliers from the database
            LoadComboBoxData();

            // Hide the ProdSupplierId label and textbox (as it's auto-generated)
            lblProdSupId.Visible = false;
            txtProductSupId.Visible = false;

            // Disable the txtProductSupId textbox in both "Add" and "Edit" modes
            txtProductSupId.Enabled = false;
        }
        // Constructor for modification mode
        public frmAddModifyProdSuppliers(int productSupplierId) : this()
        {
            // Save the provided productSupplierId for later use
            prodSupId = productSupplierId;

            // Set the edit mode flag
            isEditMode = true;

            // Load data into the cboProducts and cboSuppliers from the database
            //LoadComboBoxData();

            // Load existing ProductSupplier data and display the selected values in the combo boxes
            LoadProductSupplierData(productSupplierId);
        }

        // Load data into the cboProducts and cboSuppliers from the database
        private void LoadComboBoxData()
        {
            // Load products and suppliers data from the database into the cboProducts and cboSuppliers
            using (var db = new TravelExpertsContext())
            {
                // Load products into cboProducts
                cboProduct.DataSource = db.Products.Select(p => p).ToList();
                cboProduct.DisplayMember = "ProdName";
                cboProduct.ValueMember = "ProductId"; // Set the ValueMember to the ProductId

                // Load suppliers into cboSuppliers
                cboSupplier.DataSource = db.Suppliers.Select(s => s).ToList();
                cboSupplier.DisplayMember = "SupName";
                cboSupplier.ValueMember = "SupplierId"; // Set the ValueMember to the SupplierId

            }
        }
        // Load the existing ProductSupplier data and display the selected values in the combo boxes
        private void LoadProductSupplierData(int productSupplierId)
        {
            using (var db = new TravelExpertsContext())
            {
                var productSupplier = db.ProductsSuppliers
           .Include(ps => ps.Product) // Include the Product navigation property
           .FirstOrDefault(ps => ps.ProductSupplierId == productSupplierId);
                if (productSupplier != null)
                {
                    // Show the ProdSupplierId label and display the selected ProductSupplier ID in the txtProdSupId
                    lblProdSupId.Visible = true;
                    txtProductSupId.Visible = true;
                    txtProductSupId.Text = productSupplier.ProductSupplierId.ToString();

                    // Disable the txtProductSupId textbox and cboProduct comboBox in "Edit" mode
                    txtProductSupId.Enabled = false;
                    cboProduct.Enabled = true;

                    // Display the selected product name in the cboProduct
                    cboProduct.Text = productSupplier.Product?.ProdName;
                    cboProduct.DropDownStyle = ComboBoxStyle.DropDown;



                    // Set the selected value for cboProducts and cboSuppliers
                    cboProduct.SelectedValue = productSupplier.ProductId;
                    cboSupplier.SelectedValue = productSupplier.SupplierId;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Actions.Actions.openFormInPanel(frmMainForm.ActiveForm, new frmProdSuppliers());
        }

        private void btnSaveProdSup_Click(object sender, EventArgs e)
        {
            using (var db = new TravelExpertsContext())
            {
                if (isEditMode) // Editing an existing ProductSupplier
                {
                    // Find the existing ProductSupplier by its ID
                    var existingProductSupplier = db.ProductsSuppliers.FirstOrDefault(ps => ps.ProductSupplierId == prodSupId);
                    if (existingProductSupplier != null)
                    {
                        // Update the existing ProductSupplier with the selected product and supplier
                        existingProductSupplier.ProductId = Convert.ToInt32(cboProduct.SelectedValue);
                        existingProductSupplier.SupplierId = Convert.ToInt32(cboSupplier.SelectedValue);

                        // Save the changes to the database
                        db.SaveChanges();

                        // Show a success message
                        MessageBox.Show("Product Supplier Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Close the form and return to frmProdSuppliers
                        Actions.Actions.openFormInPanel(this.ParentForm, new frmProdSuppliers());
                    }
                    else
                    {
                        MessageBox.Show("Product Supplier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Adding a new ProductSupplier
                {
                    // Create a new ProductSupplier object
                    ProductsSupplier productSupplier = new ProductsSupplier();

                    // Set the ProductId and SupplierId based on the selected items in cboProducts and cboSuppliers
                    productSupplier.ProductId = Convert.ToInt32(cboProduct.SelectedValue);
                    productSupplier.SupplierId = Convert.ToInt32(cboSupplier.SelectedValue);

                    // Add the new ProductSupplier to the database
                    db.ProductsSuppliers.Add(productSupplier);

                    // Save the changes to the database
                    db.SaveChanges();

                    // Get the generated ProductSupplierID from the added entity
                    int generatedProductSupplierId = productSupplier.ProductSupplierId;

                    // Show a success message for "Add" mode
                    MessageBox.Show($"Product Supplier Added Successfully with ID: {generatedProductSupplierId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Close the form and return to frmProdSuppliers
                    Actions.Actions.openFormInPanel(this.ParentForm, new frmProdSuppliers());


                }
            }
        }

        private void btnCancelProdSup_Click(object sender, EventArgs e)
        {
            this.Close();
            Actions.Actions.openFormInPanel(frmMainForm.ActiveForm, new frmProdSuppliers());
        }
    }
}
