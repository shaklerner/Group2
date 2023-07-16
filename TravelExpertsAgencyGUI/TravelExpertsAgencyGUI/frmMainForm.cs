namespace TravelExpertsAgencyGUI
{
    /*
     * 
     * 
     * 
     * 
     */
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        // Event handler for the "Slide" button click
        private void btnSlide_Click(object sender, EventArgs e)
        {
            // Toggle the width of the side panel between 250 and 70
            if (pnlLeftSide.Width == 250)
            {
                pnlLeftSide.Width = 70;
            }
            else
            {
                pnlLeftSide.Width = 250;
            }
        }

        // Event handler for the "Exit" icon click
        private void iconExit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        // Event handler for the "Maximize" icon click
        private void iconMaximize_Click(object sender, EventArgs e)
        {
            // Maximize the main form
            this.WindowState = FormWindowState.Maximized;

            // Switch the visibility of the maximize and reset icons
            iconReset.Visible = true;
            iconMaximize.Visible = false;
        }

        // Event handler for the "Reset" icon click
        private void iconReset_Click(object sender, EventArgs e)
        {
            // Restore the main form to its normal state (not maximized)
            this.WindowState = FormWindowState.Normal;

            // Switch the visibility of the reset and maximize icons
            iconReset.Visible = false;
            iconMaximize.Visible = true;
        }

        // Event handler for the "Minimize" icon click
        private void iconMinimize_Click(object sender, EventArgs e)
        {
            // Minimize the main form
            this.WindowState = FormWindowState.Minimized;
        }

        // Method to open a form inside the panel "pnlMainContent"
        private void openFormInPanel(object subForm)
        {
            // Check if the input object is a Form
            if (subForm is not Form form)
            {
                // If it's not a Form, return
                return;
            }

            // Check if the panel "pnlMainContent" has any child controls
            if (this.pnlMainContent.Controls.Count > 0)
            {
                // Remove the first child control from the panel
                this.pnlMainContent.Controls.RemoveAt(0);
            }

            // Set properties of the subForm
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            // Add the subForm to the main panel's controls
            this.pnlMainContent.Controls.Add(form);

            // Set the tag of the main panel to the subForm (optional)
            this.pnlMainContent.Tag = form;

            // Show the subForm
            form.Show();
        }

        // Event handler for the "Packages" button click
        private void btnPackages_Click(object sender, EventArgs e)
        {
            // Open the "frmPackages" form inside the panel
            openFormInPanel(new frmPackages());
        }

        // Event handler for the "Products" button click
        private void btnProducts_Click(object sender, EventArgs e)
        {
            // Open the "frmProducts" form inside the panel
            openFormInPanel(new frmProducts());
        }

        // Event handler for the "Suppliers" button click
        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            // Open the "frmSuppliers" form inside the panel
            openFormInPanel(new frmSuppliers());
        }

        // Event handler for the "Product Suppliers" button click
        private void btnProductSupplier_Click(object sender, EventArgs e)
        {
            // Open the "frmProdSuppliers" form inside the panel
            openFormInPanel(new frmProdSuppliers());
        }
    }
}