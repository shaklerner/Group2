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
    public partial class frmAddModifySuppliers : Form
    {
        public frmAddModifySuppliers()
        {
            InitializeComponent();
        }

        private void btnExitSuppliers_Click(object sender, EventArgs e)
        {
            this.Close();
            Actions.Actions.openFormInPanel(frmMainForm.ActiveForm, new frmSuppliers());
        }
    }
}
