using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace responsivecolorproject.KLibrarys
{
    internal class Kforms
    {
        static Form currentForm;

        public static void OpenChildForm(Panel panel, Form child)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            currentForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(child);
            panel.Tag = child;
            child.Dock = DockStyle.Fill;
            child.BringToFront();
            child.Show();
        }
    }
}
