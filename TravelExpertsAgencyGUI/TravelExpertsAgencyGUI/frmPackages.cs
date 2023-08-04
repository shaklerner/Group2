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
    public partial class frmPackages : Form
    {
        //private TravelExpertsContext dbContext;
        public static int cellSelectedPackageId;

        public Package? currentPackage;
        public frmPackages()
        {
            // dbContext = new TravelExpertsContext();
            InitializeComponent();
        }

        // Event handler for the "Add Packages" button click
        private void btnAddPackages_Click(object sender, EventArgs e)
        {
            // Create the frmAddModifyPackages form and set its ParentForm property to this instance
            frmAddModifyPackages addForm = new frmAddModifyPackages();
            // Open the frmAddModifyPackages form in the same panel (pnlMainContent)

            addForm.isAdd = true;
            Actions.Actions.
                openFormInPanel(this.ParentForm, addForm);

            //Tasks(typeof(Package), addForm);

        }

        // Event handler for the "frmPackages" form load event
        private void frmPackages_Load(object sender, EventArgs e)
        {
            getProductNSupplierList();
        }

        private void getProductNSupplierList()
        {

            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    // Retrieve and display packages data in the DataGridView
                    dgvPackages.DataSource = db.Packages
                        .Select(p => new
                        {
                            p.PackageId,
                            p.PkgName,
                            PkgStartDate = p.PkgStartDate.GetValueOrDefault().ToShortDateString(), // Custom format for start date
                            PkgEndDate = p.PkgEndDate.GetValueOrDefault().ToShortDateString(),     // Custom format for end date
                            p.PkgDesc,
                            p.PkgBasePrice,
                            p.PkgAgencyCommission
                        }).ToList();

                    // Format the grid
                    dgvPackages.EnableHeadersVisualStyles = false;
                    dgvPackages.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 73, 107);
                    dgvPackages.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvPackages.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 73, 107);
                    dgvPackages.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvPackages.DefaultCellStyle.BackColor = Color.White;
                    dgvPackages.DefaultCellStyle.ForeColor = Color.Black;
                    dgvPackages.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(225, 225, 225);
                    dgvPackages.Font = new Font("Segoe UI", 9);

                    // Change header text
                    dgvPackages.Columns[0].HeaderText = "Package Id";
                    dgvPackages.Columns[1].HeaderText = "Name";
                    dgvPackages.Columns[2].HeaderText = "Start Date";
                    dgvPackages.Columns[3].HeaderText = "End Date";
                    dgvPackages.Columns[4].HeaderText = "Description";
                    dgvPackages.Columns[5].HeaderText = "Base Price";
                    dgvPackages.Columns[5].DefaultCellStyle.Format = "C2";
                    dgvPackages.Columns[6].HeaderText = "Agency Commission";
                    dgvPackages.Columns[6].DefaultCellStyle.Format = "C2";

                    // Alignments
                    dgvPackages.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving list of suppliers" + ex.Message,
                    ex.GetType().ToString());
            }
        }

        // Event handler for the "Exit" button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPackages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure that a valid row is clicked
            {
                DataGridViewRow row = dgvPackages.Rows[e.RowIndex];
                cellSelectedPackageId = Convert.ToInt32(row.Cells["PackageId"].Value);

            }
        }

        public void getSelectedPackage()
        {
            if (dgvPackages.SelectedRows.Count >= 0 || dgvPackages.SelectedCells.Count >= 0)
            {
                try
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        currentPackage = db.Packages.Find(cellSelectedPackageId);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while processing selected package for editing." + ex.Message,
                        ex.GetType().ToString());
                }
            }
            else return;
        }

        private void btnUpdatePackages_Click(object sender, EventArgs e)
        {
            frmAddModifyPackages editForm = new frmAddModifyPackages();
            // Open the frmAddModifyPackages form in the same panel (pnlMainContent)
            editForm.isAdd = false;
            getSelectedPackage();
            editForm.package = currentPackage;
            Actions.Actions.
                openFormInPanel(this.ParentForm, editForm);




        }

        private void dgvPackages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void Tasks(Type Entity, Form form)
        //{
        //    Actions.Actions.
        //        AddHandler(Entity, form);

        //}



    }//class
}//namespace