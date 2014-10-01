using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ARAMCO.Client
{
    public partial class frmDiscrepancy : Form
    {
        private bool _bdatachanged = false;

        public frmDiscrepancy()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            if (_bdatachanged)
            {
                if (MessageBox.Show("This discrepancy report is not complete, Are you sure you want to exit ? ", "Exit process?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (clsGlobals.gfMainMenuForm != null)
                    {
                        clsGlobals.gfMainMenuForm.Show();
                        clsGlobals.gfDiscrepancy.Close();
                        clsGlobals.gfDiscrepancy.Dispose();
                    }
                    else
                    {
                        clsGlobals.gfMainMenuForm = new frmMainMenu();
                        clsGlobals.gfMainMenuForm.Show();

                        clsGlobals.gfDiscrepancy.Close();
                        clsGlobals.gfDiscrepancy.Dispose();
                        clsGlobals.gfDiscrepancy = null;
                    }
                }
            }
            else
            {
                if (clsGlobals.gfMainMenuForm != null)
                {
                    clsGlobals.gfMainMenuForm.Show();
                    clsGlobals.gfDiscrepancy.Close();
                    clsGlobals.gfDiscrepancy.Dispose();
                }
                else
                {
                    clsGlobals.gfMainMenuForm = new frmMainMenu();
                    clsGlobals.gfMainMenuForm.Show();

                    clsGlobals.gfDiscrepancy.Close();
                    clsGlobals.gfDiscrepancy.Dispose();
                    clsGlobals.gfDiscrepancy = null;
                }
            }
        }

        private void txtbxNotes_GotFocus(object sender, EventArgs e)
        {
            keyboardPro1.Show(true);
        }
    }
}