using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ARAMCO.Client
{
    public partial class frmAssignVehicle : Form
    {
        public frmAssignVehicle()
        {
            InitializeComponent();
        }

        private void frmAssignVehicle_Load(object sender, EventArgs e)
        {

        }

        private void transparentLabel1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show( "Saved ");

            clsGlobals.gfMainMenuForm.Show();

        }

        private void cboVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (clsGlobals.gfMainMenuForm != null)
            {
                clsGlobals.gfMainMenuForm.Show();
                clsGlobals.gfAssignVehicleForm.Close();
            }
            else
            {
                clsGlobals.gfMainMenuForm = new frmMainMenu();
                clsGlobals.gfMainMenuForm.Show();

                clsGlobals.gfAssignVehicleForm.Close();
            }
        }

        private void uiElementPanelControl1_Click(object sender, EventArgs e)
        {

        }


    }
}