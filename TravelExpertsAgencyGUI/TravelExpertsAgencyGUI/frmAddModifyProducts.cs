using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsAgencyGUI.Models;

namespace TravelExpertsAgencyGUI
{
    /*
     * This class allows for Products to be added and modified in the database
     * In the case that a product is to be added, entered product name is validated
     * to the specified parameters in the database.
     * If a user clicks Modify, the text fields are populated with ID and product name
     * of selected product from the main Products form.
     * When: July 24, 2023
     * Author: Amka Tsendjargal
     */
    public partial class frmAddModifyProducts : Form
    {
        public bool isAdd; // Add/Modify boolean
        public Product? product; // product to be added or modified
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo; // needed for titlecase conversion

        public frmAddModifyProducts()
        {
            InitializeComponent();
        }

        // Display information of selected product in case of modification
        // null if user clicked Add, so nothing happens
        private void DisplayProduct()
        {
            if (product != null)
            {
                txtProductId.Text = product.ProductId.ToString();
                txtProductName.Text = product.ProdName;
            }
        }

        // Close current form and open Product form in the main panel of the Main form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Actions.Actions.openFormInPanel(frmMainForm.ActiveForm, new frmProducts());
        }

        // If user clicked modify, change the Add button label to Modify
        private void frmAddModifyProducts_Load(object sender, EventArgs e)
        {
            DisplayProduct();
            if (!isAdd)
            {
                txtProductId.ReadOnly = true;
                btnAddProducts.Text = "Update";
            }
            else if (isAdd)
            {
                label3.Visible = false;
                txtProductId.Visible = false;
            }
        }

        // Handles adding and modifying product
        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtProductName) &&
                Validator.IsValidProductName(txtProductName)) // validate
            {
                if (isAdd) // if user clicked add, create new product instance
                {
                    product = new Product();
                }

                if (product != null)
                {
                    // Change input product name to titlecase for better display
                    product.ProdName = textInfo.ToTitleCase(txtProductName.Text);
                }
                // Add product to database and update
                // close the current form if successful
                if (isAdd)
                {
                    try
                    {
                        using (TravelExpertsContext db = new TravelExpertsContext())
                        {
                            db.Products.Add(product);
                            db.SaveChanges();
                        }
                        this.Close();
                        Actions.Actions.openFormInPanel(frmMainForm.ActiveForm, new frmProducts());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding product." + ex.Message,
                            ex.GetType().ToString());
                    }
                }

                // Modify product information and update
                else if (!isAdd)
                {
                    // Confirm modification
                    var confirmEdit = MessageBox.Show("Are you sure you want to edit product?",
                        "Confirm", MessageBoxButtons.YesNo);
                    if (confirmEdit == DialogResult.Yes)
                    {
                        try
                        {
                            using (TravelExpertsContext db = new TravelExpertsContext())
                            {
                                db.Products.Find(product.ProductId).ProdName = textInfo.ToTitleCase         (txtProductName.Text);
                                db.SaveChanges();
                            }
                            // close current form if successful
                            this.Close();
                            Actions.Actions.openFormInPanel(frmMainForm.ActiveForm, new frmProducts());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while editing product." + ex.Message,
                                ex.GetType().ToString());
                        }
                    }
                    else return;
                }

            }
        }
    }
}
