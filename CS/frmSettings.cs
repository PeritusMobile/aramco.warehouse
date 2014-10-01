using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ARAMCO.Client
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {

        }

        private void btnDiscrepancy_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {

        }

        private void btnDeliveryInfo_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {

        }

        private void btnStagingInventory_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {

        }

        private void btnDeconsolidate_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {

        }

        private void btnConsolidate_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {

        }

        private void btnUnloadSupplier_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {

        }

        private void btnLoadSupplier_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {

        }

        private void LoadBtnImage()
        {
            #region //Load images
            try
            {
                Assembly asm = Assembly.GetExecutingAssembly();
                Bitmap bmpimg = null; //bitmap holder
                Image i = null; //image holder

                //BUTTON Logon image UP
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.BackUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnBack.ImageDefault = i;
                i = null;
                bmpimg = null;

                //BUTTON Logon image DOWN
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.BackDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnBack.ImagePressed = i;
                i = null;
                bmpimg = null;

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered during logon image intance " + ex.Message);

                return;
            }
            #endregion


        }
        private void uiButton1_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {

        }

        private void btnSwitchLanguage_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (clsGlobals.gfMainMenuForm != null)
            {
                clsGlobals.gfMainMenuForm.Show();

                clsGlobals.gfSettingsForm.Close();
                clsGlobals.gfSettingsForm.Dispose();
                clsGlobals.gfSettingsForm = null;

            }
        }

        private void btnSwitchLanguage_Click_1(object sender, Resco.UIElements.UIMouseEventArgs e)
        {

        }
    }
}