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
	public partial class frmAddModifyPackage : Form
	{
		public frmAddModifyPackage()
		{
			InitializeComponent();
		}
		private bool isadd = false;
		public bool isAdd { get; set; }
		public Package? package;
		public int? selectedSupplier;
		public int? selectedProduct;

		private void frmAddModifyPackage_Load(object sender, EventArgs e)
		{
			getProductNSupplierList();
		}

		private void getProductNSupplierList()
		{
			if (!isAdd)
			{
				// fill product name textbox
			}
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					cboSupp.DataSource = db.Suppliers.ToList();
					cboSupp.DisplayMember = "SupName";
					cboSupp.ValueMember = "SupplierId";

					cboProd.DataSource = db.Products.ToList();
					cboProd.DisplayMember = "ProdName";
					cboProd.ValueMember = "ProductId";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while retrieving list of suppliers" + ex.Message,
					ex.GetType().ToString());
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (true) // validation placeholder
			{
				if (isAdd)
				{
					package = new Package();
				}
				else return;

				if (package != null)
				{
					package.PkgName = txtName.Text;
					package.PkgStartDate = dtStart.Value;
					package.PkgEndDate = dtEnd.Value;
					package.PkgDesc = txtDesc.Text;
					package.PkgBasePrice = Convert.ToInt32(txtPrice.Text);
					package.PkgAgencyCommission = Convert.ToInt32(txtCommission.Text);

					selectedProduct = (int)cboProd.SelectedValue;
					selectedSupplier = (int)cboSupp.SelectedValue;


				}
				this.DialogResult = DialogResult.OK;
			}
		}


	}
}
