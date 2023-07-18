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
    public partial class frmAddModifyProducts : Form
    {
        public frmAddModifyProducts()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Actions.Actions.openFormInPanel(frmMainForm.ActiveForm, new frmProducts());
        }

        private void frmAddModifyProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
