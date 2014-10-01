using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ARAMCO.Client
{
    public partial class frmSetStatus : Form
    {
        public frmSetStatus()
        {
            InitializeComponent();
        }

        private void transparentLabel1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void uiElementPanelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {

        }

        private void cboSetStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSetStatus_Load(object sender, EventArgs e)
        {
            cboSetStatus.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Do you want to save the selected status", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            //Check if Main Menu Screen exists, 
            //then load and close current screen

            if (clsGlobals.gfMainMenuForm != null)
            {
                clsGlobals.gfMainMenuForm.Show();
                clsGlobals.gfSetStatusForm.Close();

                clsGlobals.gfSetStatusForm.Dispose();
                clsGlobals.gfSetStatusForm = null;

            }
            else
            {
                clsGlobals.gfMainMenuForm = new frmMainMenu();
                clsGlobals.gfMainMenuForm.Show();
                clsGlobals.gfSetStatusForm.Close();

                clsGlobals.gfSetStatusForm.Dispose();
                clsGlobals.gfSetStatusForm = null;


            }
                
        }
    }
}