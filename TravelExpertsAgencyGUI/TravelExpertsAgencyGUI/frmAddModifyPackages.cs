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
    public partial class frmAddModifyPackages : Form
    {


        public frmAddModifyPackages()
        {
            InitializeComponent();

        }
        private void frmAddModifyPackages_Load(object sender, EventArgs e)
        {

        }

        private void btnExitPackages_Click_1(object sender, EventArgs e)
        {

            // Close the current frmAddModifyPackages form
            this.Close();
        }
    }
}
