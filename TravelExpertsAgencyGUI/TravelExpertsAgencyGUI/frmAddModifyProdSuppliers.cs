using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsAgencyGUI
{
    public partial class frmAddModifyProdSuppliers : Form
    {
       

        // Constructor for modification mode
        public frmAddModifyProdSuppliers() 
        {
            InitializeComponent();

        }

        private void btnAddProdSup_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Actions.Actions.openFormInPanel(frmMainForm.ActiveForm, new frmProdSuppliers());
        }
    }
}
