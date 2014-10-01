using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ARAMCO.Client
{
    public partial class frmUnloadSupplier : Form
    {
        public frmUnloadSupplier()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to exit", "Exit process?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (clsGlobals.gfMainMenuForm == null)
                    {
                        clsGlobals.gfMainMenuForm = new frmMainMenu();
                        clsGlobals.gfMainMenuForm.Show();

                        clsGlobals.gfUnLoadSupplierForm.Close();
                        clsGlobals.gfUnLoadSupplierForm = null;
                        clsGlobals.gfUnLoadSupplierForm.Dispose();
                    }
                    else
                    {
                        clsGlobals.gfMainMenuForm.Show();

                        clsGlobals.gfUnLoadSupplierForm.Close();
                        clsGlobals.gfUnLoadSupplierForm.Dispose();
                        clsGlobals.gfUnLoadSupplierForm = null;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error was encountered during back button click ");
            }
        }

        private void imageButton2_Click(object sender, EventArgs e)
        {

        }

    }
}