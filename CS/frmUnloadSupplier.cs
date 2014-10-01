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
                        clsGlobals.gfUnLoadSupplierForm.Dispose();
                        clsGlobals.gfUnLoadSupplierForm = null;
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


        private void btnDiscrepancy_Click(object sender, EventArgs e)
        {

        }

        private void btnViewASN_Click(object sender, EventArgs e)
        {

        }

        private void btnViewPackage_Click(object sender, EventArgs e)
        {

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
        private void LoadTabBtns()
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            #region //COMMAND REPORT DISCREPANCY
            try
            {
                #region //Vendor tab
                //TAB VENDOR UP
                tbPgVendor.TabItem.ImageDefault = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.TabVendorUp.jpg"));

                //TAB VENDOR DOWN
                tbPgVendor.TabItem.ImagePressed = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.TabVendorDown.jpg"));
                #endregion

                #region //ASN tab
                //TAB VENDOR UP
                tbPgASN.TabItem.ImageDefault = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.TabASNUp.jpg"));
                
                //TAB VENDOR DOWN
                tbPgASN.TabItem.ImagePressed = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.TabASNDown.jpg"));

                //TAB VENDOR DISABLED
                tbPgASN.TabItem.ImageDisabled = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.TabASNDisabled.jpg"));
                #endregion

                #region //Package tab
                //TAB PACKAGE UP
                tbPgPackage.TabItem.ImageDefault = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.TabPackageUp.jpg"));

                //TAB PACKAGE DOWN
                tbPgPackage.TabItem.ImagePressed = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.TabPackageDown.jpg"));

                //TAB PACKAGE DISABLED
                tbPgPackage.TabItem.ImageDisabled = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.TabPackageDisabled.jpg"));
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered during tab image loading " + ex.Message);

                Cursor.Current = Cursors.Default;
                return;
            }
            #endregion

        }



        private void LoadMenuBtns()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Bitmap bmpimg = null; //bitmap holder
            Image i = null; //image holder

            #region //COMMAND REPORT DISCREPANCY
            try
            {
                //BUTTON REPORT DISCREPANCY UP
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.ReportDiscrepancyUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnDiscrepancy.ImageDefault = i;
                i = null;
                bmpimg = null;

                //BUTTON REPORT DISCREPANCY DOWN
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.ReportDiscrepancyDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnDiscrepancy.ImagePressed = i;
                i = null;
                bmpimg = null;

                //BUTTON REPORT DISCREPANCY DISABLED
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.ReportDiscrepancyDisabled.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnDiscrepancy.ImageDisabled = i;
                i = null;
                bmpimg = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered during report  image " + ex.Message);

                return;
            }
            #endregion

            #region //COMMAND BACK
            try
            {
                //BUTTON BACK UP
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.BackUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnBack.ImageDefault = i;
                i = null;
                bmpimg = null;

                //BUTTON BACK DOWN
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.BackDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnBack.ImagePressed = i;
                i = null;
                bmpimg = null;

                ////BUTTON  VIEW PACKAGE DISABLED
                //bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.ViewPackageDisabled.jpg"));

                //////cast to image
                //i = (Image)bmpimg;
                //////assign image to button
                //btnRemove.ImageDisabled = i;
                //i = null;
                //bmpimg = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered during view PACKAGE image up load " + ex.Message);

                return;
            }
            #endregion

            #region //COMMAND COMPLETE
            try
            {
                //BUTTON COMPLETE UP
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.LoadCompleteUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnComplete.ImageDefault = i;
                i = null;
                bmpimg = null;

                //BUTTON COMPLETE DOWN
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.LoadCompleteDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnComplete.ImagePressed = i;
                i = null;
                bmpimg = null;

                //BUTTON COMPLETE DISABLED
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.LoadCompleteDisabled.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnComplete.ImageDisabled = i;
                i = null;
                bmpimg = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered during loadlinehaul image up load " + ex.Message);

                return;
            }
            #endregion

            #region //COMMAND SEARCH
            try
            {
                //BUTTON SEARCH UP
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.SearchItemsUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnSearch.ImageDefault = i;
                i = null;
                bmpimg = null;

                //BUTTON SEARCH DOWN
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.SearchItemsDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnSearch.ImagePressed = i;
                i = null;
                bmpimg = null;

                //BUTTON SEARCH DISABLED
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.SearchItemsDisabled.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnSearch.ImageDisabled = i;
                i = null;
                bmpimg = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered during SEARCH Item image up load " + ex.Message);

                return;
            }
            #endregion

            #region //COMMAND SELECT ALL
            try
            {
                //BUTTON  SELECT ALL UP
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.SelAllUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnSelAll.ImageDefault = i;
                i = null;
                bmpimg = null;

                //BUTTON  SELECT ALL DOWN
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.SelAllDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnSelAll.ImagePressed = i;
                i = null;
                bmpimg = null;

                //BUTTON  SELECT ALL DISABLED
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.SelAllDisabled.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnSelAll.ImageDisabled = i;
                i = null;
                bmpimg = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered during SELECT ALL image load " + ex.Message);

                return;
            }
            #endregion

            #region //COMMAND DESELECT ALL
            try
            {
                //BUTTON  DESELECT UP
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.DeSelAllUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnDeSelAll.ImageDefault = i;
                i = null;
                bmpimg = null;

                //BUTTON  DESELECT DOWN
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.DeSelAllDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnDeSelAll.ImagePressed = i;
                i = null;
                bmpimg = null;

                //BUTTON  VIEW PACKAGE DISABLED
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.DeSelAllDisabled.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnDeSelAll.ImageDisabled = i;
                i = null;
                bmpimg = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered during view deselect all load " + ex.Message);

                return;
            }
            #endregion

            #region //COMMAND PRINT
            try
            {
                //BUTTON BACK UP
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.PrintUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnPrint.ImageDefault = i;
                i = null;
                bmpimg = null;

                //BUTTON BACK DOWN
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.PrintDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnPrint.ImagePressed = i;
                i = null;
                bmpimg = null;

                //BUTTON PRINT DISABLED
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.PrintDisabled.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnPrint.ImageDisabled = i;
                i = null;
                bmpimg = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered during view Print image up load " + ex.Message);

                return;
            }
            #endregion

        }

        private void frmUnloadSupplier_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            //load the initial message prompt for scanning;
            pnlInitMsg.BringToFront();
        


                //load the button images
                LoadMenuBtns();

                LoadTabBtns();

                //set the tab selected index
                tbCMain.SelectedIndex = 0;

                //btnSelAll.Enabled = false;
                //btnDeSelAll.Enabled = false;

                tbPgPackage.TabItem.Enabled = false;
                tbPgASN.TabItem.Enabled = false;


                



            Cursor.Current = Cursors.Default;
        }

        private void tbCMain_Click(object sender, EventArgs e)
        {

        }

        private void advancedLstStop_RowSelect(object sender, Resco.Controls.AdvancedList.RowEventArgs e)
        {
            tbPgASN.TabItem.Enabled = true;
            //tbPgPackage.Enabled = true;

        }

        private void advancedLstASN_RowSelect(object sender, Resco.Controls.AdvancedList.RowEventArgs e)
        {
            tbPgPackage.TabItem.Enabled = true;
        }

        private void tbCMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbCMain.SelectedIndex == 0)
            {
                tbPgPackage.TabItem.Enabled = false;
            }
        }

        private void pnlInitMsg_GotFocus(object sender, EventArgs e)
        {

        }


        private void btnMockUpScan_Click(object sender, EventArgs e)
        {
            pnlMain.BringToFront();
            pnlInitMsg.Visible = false;

        }



    }
}