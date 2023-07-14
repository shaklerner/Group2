using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsGUI
{
    public partial class Packages : Form
    {
        public Packages()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void openFormInPanel(object subForm)
        //{
        //    if (this.pnlPackageContent.Controls.Count > 0)
        //        this.pnlPackageContent.Controls.RemoveAt(0);
        //    Form form = subForm as Form;
        //    form.TopLevel = false;
        //    form.Dock = DockStyle.Fill;
        //    this.pnlPackageContent.Controls.Add(form);
        //    this.pnlPackageContent.Tag = form;
        //    form.Show();

        //}

        //private void btnOpenAddPackage_Click(object sender, EventArgs e)
        //{
        //    openFormInPanel(new AddModifyPackages());
       // }
    }
}
