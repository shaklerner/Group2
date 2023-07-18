using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsAgencyGUI.Actions
{
    public static class Actions
    {
        public static void openFormInPanel(Form mainForm, object subForm)
        {
            // Check if the input object is a Form
            if (subForm is not Form form)
            {
                // If it's not a Form, return
                return;
            }

            Panel panel = mainForm.Controls.Find("pnlMainContent", true).FirstOrDefault() as Panel;

            // Check if the panel "pnlMainContent" has any child controls
            if (panel.Controls.Count > 0)
            {
                // Remove the first child control from the panel
                panel.Controls.RemoveAt(0);
            }

            // Set properties of the subForm
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            // Add the subForm to the main panel's controls
            panel.Controls.Add(form);

            // Set the tag of the main panel to the subForm (optional)
            panel.Tag = form;

            // Show the subForm
            form.Show();
        }
    }
}
