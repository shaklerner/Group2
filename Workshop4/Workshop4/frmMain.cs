using Workshop4.Models;

namespace Workshop4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Blue);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 35.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        // PRODUCTS TAB
        // --------------------------------------------------------------------------------------------- //
        Product? currentProduct = null;

        private void DisplayProducts()
        {
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    lstProducts.DataSource = db.Products.ToList();
                    txtProdCount.Text = db.Products.Count().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving products: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            frmAddModifyProduct secondProductForm = new frmAddModifyProduct();
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
                catch (Exception ex )
                {
                    MessageBox.Show("Error while adding product: " + 
                        ex.Message, ex.GetType().ToString());
                    return;
                }
                DisplayProducts();


            }

        }
    }
}