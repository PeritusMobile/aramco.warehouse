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
    public partial class frmLoadCustomer : Form
    {
        public frmLoadCustomer()
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

                        clsGlobals.gfLoadCustomer.Close();
                        clsGlobals.gfLoadCustomer.Dispose();
                        clsGlobals.gfLoadCustomer = null;
                    }
                    else
                    {
                        clsGlobals.gfMainMenuForm.Show();

                        clsGlobals.gfLoadCustomer.Close();
                        clsGlobals.gfLoadCustomer.Dispose();
                        clsGlobals.gfLoadCustomer = null;

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

        private void btnComplete_Click(object sender, EventArgs e)
        {
            //complete the process
            Cursor.Current = Cursors.WaitCursor;
            #region //TODO: process for conpleting the trasactional units for completion stage
            MessageBox.Show("COMPLETE PROCESS TO BE COMPLETED....", "COMPLETE PROCESS", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            #endregion
            Cursor.Current = Cursors.Default;
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
                MessageBox.Show("Error encountered during loadlinehaul image up load " + ex.Message);

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

            #region //COMMAND ADD
            try
            {
                //BUTTON Add
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.AddUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnAdd.ImageDefault = i;
                i = null;
                bmpimg = null;

                //BUTTON  VIEW ASN DOWN
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.AddDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnAdd.ImagePressed = i;
                i = null;
                bmpimg = null;

                //BUTTON ADD     DISABLED
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.AddDisabled.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnAdd.ImageDisabled = i;
                i = null;
                bmpimg = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered during view asn image up load " + ex.Message);

                return;
            }
            #endregion

            #region //COMMAND REMOVE
            try
            {
                //BUTTON  VIEW PACKAGE UP
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.RemoveUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnRemove.ImageDefault = i;
                i = null;
                bmpimg = null;

                //BUTTON  VIEW PACKAGE DOWN
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.RemoveDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnRemove.ImagePressed = i;
                i = null;
                bmpimg = null;

                //BUTTON  VIEW PACKAGE DISABLED
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.RemoveDisabled.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnRemove.ImageDisabled = i;
                i = null;
                bmpimg = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered during view REMOVE image up load " + ex.Message);

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

                ////BUTTON  PRINT DISABLED
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

            #region //SEARCH ITEMS
            try
            {
                //SEARCH UP
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.SearchItemsUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnSearch.ImageDefault = i;
                i = null;
                bmpimg = null;

                //SEARCH DOWN
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.SearchItemsDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnSearch.ImagePressed = i;
                i = null;
                bmpimg = null;

                //BUTTON  VIEW PACKAGE DISABLED
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.SearchItemDisabled.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnSearch.ImageDisabled = i;
                i = null;
                bmpimg = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered during view PACKAGE image up load " + ex.Message);

                return;
            }
            #endregion
        }

        private void frmLoadCustomer_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
              LoadMenuBtns();

            //set the first panel to instruct user to scan FO
              pnlMain.SendToBack();
              pnlInitMsg.BringToFront();
              pnlInitMsg.Visible = true;

              btnDiscrepancy.Enabled = false;
              btnAdd.Enabled = false;
              btnComplete.Enabled = false;
              btnPrint.Enabled = false;
              btnRemove.Enabled = false;

              tbCMain.SelectedIndex = 0;

            Cursor.Current = Cursors.Default;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //complete the process
            Cursor.Current = Cursors.WaitCursor;
            #region //TODO: process for conpleting the trasactional units for completion stage
            MessageBox.Show("SEARCH FUNCTION TO BE COMPLETED....", "SEARCH FUNCTION",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            #endregion
            Cursor.Current = Cursors.Default;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnMockUpScan_Click(object sender, EventArgs e)
        {
            pnlInitMsg.SendToBack();
            pnlInitMsg.Visible = false;
            pnlMain.BringToFront();


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void frmLoadCustomer_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void advlstPackage_RowSelect(object sender, Resco.Controls.AdvancedList.RowEventArgs e)
        {

            btnDiscrepancy.Enabled = true;
            btnSearch.Enabled = true;
            btnAdd.Enabled = true;
            btnRemove.Enabled = true;
            btnPrint.Enabled = true;

        }

        private void advancedLstStop_RowSelect(object sender, Resco.Controls.AdvancedList.RowEventArgs e)
        {
            btnAdd.Enabled = true;
            btnRemove.Enabled = true;
            btnPrint.Enabled = true;
            btnComplete.Enabled = true;
            btnDiscrepancy.Enabled = true;
            btnSearch.Enabled = true;
        }


    }
}