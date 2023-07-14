namespace TravelExpertsGUI
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (pnlLeftSide.Width == 250)
            {
                pnlLeftSide.Width = 70;
            }
            else
                pnlLeftSide.Width = 250;

        }

        private void iconCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizer_Click_1(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            iconReset.Visible = true;
            iconMaximizer.Visible = false;
        }

        private void iconReset_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconReset.Visible = false;
            iconMaximizer.Visible = true;
        }

        private void iconMinimizer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void openFormInPanel(object subForm)
        {
            if (this.pnlMainContent.Controls.Count > 0)
                this.pnlMainContent.Controls.RemoveAt(0);
            Form form = subForm as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlMainContent.Controls.Add(form);
            this.pnlMainContent.Tag = form;
            form.Show();

        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            openFormInPanel(new Packages());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            openFormInPanel(new frmProducts());
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            openFormInPanel(new frmSuppliers());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFormInPanel(new frmProductsSuppliers());
        }       
    }
}