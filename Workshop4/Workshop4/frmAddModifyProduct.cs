using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop4.Models;

namespace Workshop4
{
    public partial class frmAddModifyProduct : Form
    {
        public frmAddModifyProduct()
        {
            InitializeComponent();
        }

        public bool isAdd;
        public Product? product;
        public int? selectedSupplier;

        private void frmAddModifyProduct_Load(object sender, EventArgs e)
        {
            getSupplierList();
        }

        private void getSupplierList()
        {
            if (!isAdd)
            {
                // fill product name textbox
            }
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    cmbSuppliers.DataSource = db.Suppliers.ToList();
                    cmbSuppliers.DisplayMember = "SupName";
                    cmbSuppliers.ValueMember = "SupplierId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving list of suppliers" + ex.Message,
                    ex.GetType().ToString());
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (true) // validation placeholder
            {
                if (isAdd)
                {
                    product = new Product();
                }
                else return;

                if (product != null)
                {
                    product.ProdName = txtProdName.Text;
                    selectedSupplier = (int) cmbSuppliers.SelectedValue;
                }
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
