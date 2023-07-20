using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
			#region add action on frmAddModifyProduct
			if (thisDialogForm.GetType() == typeof(frmAddModifyProduct))
			{
				Product? currentProduct = null!;
				var secondProductForm = (frmAddModifyProduct)thisDialogForm;
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

			}//form Add/Modify Products
			#endregion
			#region add action on frmAddModifyPackage
			else if (thisDialogForm.GetType() == typeof(frmAddModifyPackage))
			{
				Package? currentPackage = null!;
				var secondPackageForm = (frmAddModifyPackage)thisDialogForm;
				secondPackageForm.isAdd = true;
				secondPackageForm.package = null;
				DialogResult result = secondPackageForm.ShowDialog();
				if (result == DialogResult.OK)
				{
					currentPackage = secondPackageForm.package;

					try
					{
						using (TravelExpertsContext db = new TravelExpertsContext())
						{
							if (currentPackage != null)
							{

								var lastProdId	= secondPackageForm.selectedProduct;
								var lastSupId	= secondPackageForm.selectedSupplier;
								if (true) //if this is a new productsSupplier item
								{
								#region Add item to the productsSupplier
								ProductsSupplier productsSupplier	= new ProductsSupplier();
								productsSupplier.ProductId			= lastProdId;
								productsSupplier.SupplierId			= lastSupId;
								db.ProductsSuppliers.Add(productsSupplier);
								#endregion
								#region add item to the Package table
								db.Packages.Add(currentPackage);
								db.SaveChanges();
									#endregion
									#region add item to the package_product_supplier
									if (true)//if this is a new package_product_supplier item
								{
									PackagesProductsSupplier packagesProductsSupplier = new PackagesProductsSupplier();
									packagesProductsSupplier.PackageId = currentPackage.PackageId;
									packagesProductsSupplier.ProductSupplierId = productsSupplier.ProductSupplierId;
									db.PackagesProductsSuppliers.Add(packagesProductsSupplier);
									db.SaveChanges();
									}
								else//if this item is already existed in the package_product_supplier
								{

								}
								#endregion


									
								}
								else //if this item is already existed in productsSupplier 
								{
								}
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error while adding product: " +
							ex.Message, ex.GetType().ToString());
					}
					currentObject = currentPackage;
				}//
			#endregion
			}//form Add/Modify Packages
		}


	}//class
}//namespace
