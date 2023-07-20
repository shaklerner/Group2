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
    public partial class frmAddModifyProducts : Form
    {
        public bool isAdd;
        public Product? product;
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        public frmAddModifyProducts()
        {
            InitializeComponent();
        }

        private void DisplayProduct()
        {
            if (product != null)
            {
                txtProductId.Text = product.ProductId.ToString();
                txtProductName.Text = product.ProdName;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Actions.Actions.openFormInPanel(frmMainForm.ActiveForm, new frmProducts());
        }

        private void frmAddModifyProducts_Load(object sender, EventArgs e)
        {
            DisplayProduct();
            if (!isAdd)
            {
                btnAddProducts.Text = "Update";
            }
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtProductName.Text)) // validator placeholder
            {
                if (isAdd)
                {
                    product = new Product();
                }

                if (product != null)
                {
                    product.ProdName = textInfo.ToTitleCase(txtProductName.Text);
                }
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

                else if (!isAdd)
                {
                    var confirmEdit = MessageBox.Show("Are you sure you want to edit product?",
                        "Confirm", MessageBoxButtons.YesNo);
                    if (confirmEdit == DialogResult.Yes)
                    {
                        try
                        {
                            using (TravelExpertsContext db = new TravelExpertsContext())
                            {
                                db.Products.Find(product.ProductId).ProdName = textInfo.ToTitleCase(txtProductName.Text);
                                db.SaveChanges();
                            }
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
