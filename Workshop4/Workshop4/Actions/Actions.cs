using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop4.Models;

namespace Workshop4
{
	public static class Actions
	{
		/// <summary>
		/// based on the type of Entity that could be (any of our Table objects), and
		/// the Form that includes controll properties this class generate an
		/// Add button for the form with ability to add data on DBContext
		/// </summary>
		/// <param name="thisEntity">Tables in folder Models</param>
		/// <param name="thisDialogForm">Designed Form that including this button</param>
		public static void AddHandler(Type thisEntity, Form thisDialogForm)
		{

			object? currentObject = null!;
			if (thisDialogForm.GetType() == typeof(frmAddModifyProduct))
			{
				Product? currentProduct = null!;
				var secondProductForm = (frmAddModifyProduct)thisDialogForm;
				secondProductForm.isAdd = true;
				secondProductForm.isAdd = true;
				secondProductForm.product = null;
				DialogResult result = secondProductForm.ShowDialog();
				if (result == DialogResult.OK)
				{
					currentProduct = secondProductForm.product;

					try
					{
						using (TravelExpertsContext db = new TravelExpertsContext())
						{
							if (currentProduct != null)
							{
								db.Products.Add(currentProduct);
								db.SaveChanges();
								var lastProdId = currentProduct.ProductId;
								var lastSupId = secondProductForm.selectedSupplier;
								ProductsSupplier productsSupplier = new ProductsSupplier();
								productsSupplier.ProductId = lastProdId;
								productsSupplier.SupplierId = lastSupId;
								db.ProductsSuppliers.Add(productsSupplier);
								db.SaveChanges();
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error while adding product: " +
							ex.Message, ex.GetType().ToString());
					}
					currentObject = currentProduct;
				}

			}
		}//Add Action


	}//class
}//namespace
