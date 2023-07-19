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
        private void btnExitPackages_Click(object sender, EventArgs e)
        {
            // Close the current frmAddModifyPackages form
            this.Close();
        }
    }
}
