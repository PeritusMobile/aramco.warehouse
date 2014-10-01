using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Reflection;


namespace ARAMCO.Client
{
    public partial class frmMainMenu : Form
    {

        private bool bArabic = false;

        public enum iPanelSwitch
        {
            mPanel = 0, //main menu
            LPanel = 1, //load menu
            UPanel = 2, //unload menu

        }
        public frmMainMenu()
        {
            InitializeComponent();
        }

        ///// <summary>
        ///// Application main
        ///// </summary>
        static void Main()
        {
            if ((clsGlobals.gfMainMenuForm == null))
            {
                clsGlobals.gfMainMenuForm = new frmMainMenu();
            }

            Application.Run(clsGlobals.gfMainMenuForm);
        }

        private void txtEmpID_GotFocus(object sender, EventArgs e)
        {

        }

        private void txtEmpID_LostFocus(object sender, EventArgs e)
        {

        }

        private void txtUserName_GotFocus(object sender, EventArgs e)
        {

        }

        private void txtUserName_LostFocus(object sender, EventArgs e)
        {

        }

        private void txtPwd_GotFocus(object sender, EventArgs e)
        {

        }

        private void txtPwd_LostFocus(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (clsGlobals.gfLoadForm == null)
                {
                    clsGlobals.gfLoadForm = new frmLoad();
                    clsGlobals.gfLoadForm.Show();

                    this.Hide();
                }
                else
                {
                    clsGlobals.gfLoadForm.Show();

                    this.Hide();
                }
            }
            catch(Exception ex)
            {


            }

            Cursor.Current = Cursors.Default;
        }



        private void btnDeliveryInfo_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Current = Cursors.Default;
        }

        private void TogglePanels(int isel)
        {
            //toggle the selected panel based on user
            //menu and submenu choice
            int iPanel = isel;
            
            switch (iPanel)
            {
                case 0: //main

                    //disable
                    pnlLoad.SendToBack();
                    pnlLoad.Visible = false;

                    //disable
                    pnlUnload.SendToBack();
                    pnlUnload.Visible = false;
                    //enable
                    pnlMain.BringToFront();
                    pnlMain.Visible = true;
                    break;

                case 1: //submenu load

                    //disable
                    pnlMain.SendToBack();
                    pnlMain.Visible = false;

                    //disable
                    pnlLoad.BringToFront();
                    pnlLoad.Visible = true;

                    //disable
                    //pnlUnload.SendToBack();
                    //pnlUnload.Visible = false;


                    break;

                case 2: //submenu unload


                    //disable
                    pnlMain.SendToBack();
                    pnlMain.Visible = false;
                    ////disable
                    //pnlLoad.SendToBack();
                    //pnlLoad.Visible = false;

                    //enable
                    pnlUnload.BringToFront();
                    pnlUnload.Visible = true;


                    break;

            }

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                //lblEmpID.Text = clsGlobals.gEmpId;
                lblUser.Text = clsGlobals.gUID.ToUpper();

                LoadMenuBtns(bArabic);
                LoadSubMenuBtns(bArabic);

                TogglePanels((int)iPanelSwitch.mPanel);
            }
            catch (Exception ex)
            {

            }
        }

        private void LoadMenuBtns(bool _LangArabic)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Bitmap bmpimg = null; //bitmap holder
            Image i = null; //image holder

            switch (_LangArabic)
            {
                case false:

                    #region //LOAD BUTTON
                    try
                    {
                        //BUTTON LOADLINEHAUL UP
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.LoadUp.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnLoad.Image = i;
                        i = null;
                        bmpimg = null;

                        //BUTTON LOADLINEHAUL DOWN
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.LoadDown.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnLoad.PressedImage.Image = i;
                        i = null;
                        bmpimg = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error encountered during load image up load " + ex.Message);

                        return;
                    }
                    #endregion

                    #region //UNLOAD BUTTON
                    try
                    {
                        //BUTTON UNLOAD UP
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.UnloadUp.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnUnload.Image = i;
                        i = null;
                        bmpimg = null;

                        //BUTTON UNLOAD DOWN
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.UnloadDown.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnUnload.PressedImage.Image = i;
                        i = null;
                        bmpimg = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error encountered during unload image " + ex.Message);

                        return;
                    }
                    #endregion

                    #region //CONSOLIDATE BUTTON
                    try
                    {
                        //BUTTON CONSOLIDATE UP
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.ConsolidateUp.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnConsolidate.Image = i;
                        i = null;
                        bmpimg = null;

                        //BUTTON CONSOLIDATE DOWN
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.ConsolidateDown.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnConsolidate.PressedImage.Image = i;
                        i = null;
                        bmpimg = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error encountered during consolidate image " + ex.Message);

                        return;
                    }
                    #endregion

                    #region //DE-CONSOLIDATE BUTTON
                    try
                    {
                        //BUTTON CONSOLIDATE UP
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.DeConsolidateUp.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnDeconsolidate.Image = i;
                        i = null;
                        bmpimg = null;


                        //BUTTON CONSOLIDATE DOWN
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.DeConsolidateDown.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnDeconsolidate.PressedImage.Image = i;
                        i = null;
                        bmpimg = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error encountered during Deconsolidate image " + ex.Message);

                        return;
                    }
                    #endregion

                    #region //STAGING AREA INVENTORY BUTTON
                    try
                    {
                        //BUTTON CONSOLIDATE UP
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.StagingAreaInvUp.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnStagingInventory.Image = i;
                        i = null;
                        bmpimg = null;

                        //BUTTON CONSOLIDATE DOWN
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.StagingAreaInvDown.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnStagingInventory.PressedImage.Image = i;
                        i = null;
                        bmpimg = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error encountered during Deconsolidate image instance load " + ex.Message);

                        return;
                    }
                    #endregion

                    #region //DELIVERY INFORMATION BUTTON
                    try
                    {
                        //BUTTON DELIVERY INFORMATION  UP
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.DeliveryInfoUp.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnDeliveryInfo.Image = i;
                        i = null;
                        bmpimg = null;

                        //BUTTON DELIVERY INFORMATION DOWN
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.DeliveryInfoDown.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnDeliveryInfo.PressedImage.Image = i;
                        i = null;
                        bmpimg = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error encountered during delivery informatio instance " + ex.Message);

                        return;
                    }
                    #endregion

                    #region //DISCREPANCY BUTTON
                    try
                    {
                        //BUTTON DISCREPANCY UP
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.DiscrepancyUp.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnDiscrepancy.Image = i;
                        i = null;
                        bmpimg = null;

                        //BUTTON DISCREPANCY DOWN
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.DiscrepancyDown.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnDiscrepancy.PressedImage.Image = i;
                        i = null;
                        bmpimg = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error encountered during discrepancy instance " + ex.Message);

                        return;
                    }
                    #endregion

                    #region //LOG-OFF BUTTON
                    try
                    {
                        //BUTTON LOGOFF UP
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.LogOffUp.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnLogout.Image = i;
                        i = null;
                        bmpimg = null;

                        //BUTTON LOGOFF DOWN
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.LogOffDown.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnLogout.PressedImage.Image = i;
                        i = null;
                        bmpimg = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error encountered during log off instance " + ex.Message);

                        return;
                    }
                    #endregion

                    #region //SETTINGS BUTTON
                    try
                    {
                        //BUTTON SETTINGS UP
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.mSettingsUp.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnSettings.Image = i;
                        i = null;
                        bmpimg = null;

                        //BUTTON SETTINGS DOWN
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.mSettingsDown.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnSettings.PressedImage.Image = i;
                        i = null;
                        bmpimg = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error encountered during settings image instance " + ex.Message);

                        return;
                    }
                    #endregion
                    break;

                case true:

                    #region //LOAD BUTTON
                    try
                    {
                        //BUTTON LOAD CUSTOMER UP
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.LoadCustomerArabicUp.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnLoad.Image = i;
                        i = null;
                        bmpimg = null;

                        //BUTTON LOAD DOWN
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.LoadCustomerArabicDown.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnLoad.PressedImage.Image = i;
                        i = null;
                        bmpimg = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error encountered during load customer image instance" + ex.Message);

                        return;
                    }
                    #endregion

                    #region //UNLOAD BUTTON
                    try
                    {
                        //BUTTON UNLOAD VENDOR UP
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.UnLoadVendorArabicUp.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnUnload.Image = i;
                        i = null;
                        bmpimg = null;

                        //BUTTON UNLOAD VENDOR DOWN
                        bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.UnloadVendorDownArabic.jpg"));

                        ////cast to image
                        i = (Image)bmpimg;
                        ////assign image to button
                        btnUnload.PressedImage.Image = i;
                        i = null;
                        bmpimg = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error encountered during unload vendor image " + ex.Message);

                        return;
                    }
                    #endregion
                    break;

            }


        

        }

        private void LoadSubMenuBtns(bool _LangArabic)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Bitmap bmpimg = null; //bitmap holder
            Image i = null; //image holder

            switch (_LangArabic)
            {
                case false:
                    #region //UNLOAD VENDOR BUTTON
                    //BUTTON UNLOAD VENDOR UP
                    bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.Un_VendorUp.jpg"));

                    ////cast to image
                    i = (Image)bmpimg;
                    ////assign image to button
                    btnUnloadVendor.Image = i;
                    i = null;
                    bmpimg = null;

                    //BUTTON UNLOAD VENDOR DOWN
                    bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.Un_VendorDown.jpg"));

                    ////cast to image
                    i = (Image)bmpimg;
                    ////assign image to button
                    btnUnloadVendor.PressedImage.Image = i;
                    i = null;
                    bmpimg = null;
                #endregion //UNLOAD VENDOR

                #region //BACK BUTTON
                    //BUTTON Back
                    bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.BackUp.jpg"));

                    ////cast to image
                    i = (Image)bmpimg;
                    ////assign image to button
                    btnBackLoad.Image = i;
                    i = null;
                    bmpimg = null;

                    //BUTTON Back
                    bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.BackDown.jpg"));

                    ////cast to image
                    i = (Image)bmpimg;
                    ////assign image to button
                    btnBackLoad.PressedImage.Image = i;
                    i = null;
                    bmpimg = null;
                    #endregion //back button

                #region //BACK BUTTON
                //BUTTON Back
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.BackUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnBackUnload.Image = i;
                i = null;
                bmpimg = null;

                //BUTTON Back
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.BackDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnBackUnload.PressedImage.Image = i;
                i = null;
                bmpimg = null;
                #endregion //back button

                #region //LOADING FOR CUSTOMER
                //load for customer
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.LoadForCustomerUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnLoadCustomer.Image = i;
                i = null;
                bmpimg = null;

                //BUTTON load customer
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.LoadForCustomerDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnLoadCustomer.PressedImage.Image = i;
                i = null;
                bmpimg = null;
                #endregion //back button

                #region //LOADING FOR VENDOR
                //load for customer
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.LoadForLineHaulUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnLoadVendor.Image = i;
                i = null;
                bmpimg = null;

                //BUTTON load customer
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.LoadForLineHaulDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnLoadVendor.PressedImage.Image = i;
                i = null;
                bmpimg = null;

                #endregion //

                #region //UNLOADING FOR WAREHOUSE
                //load for warehouse
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.Un_WarehouseUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnUnloadWarehouse.Image = i;
                i = null;
                bmpimg = null;

                //BUTTON load warehouse
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.Un_WarehouseDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnUnloadWarehouse.PressedImage.Image = i;
                i = null;
                bmpimg = null;

                #endregion //

                #region //UNLOADING FOR LINEHAUL
                //load for warehouse
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.Un_LineHaulUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnUnloadLinehaul.Image = i;
                i = null;
                bmpimg = null;

                //BUTTON load warehouse
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.Un_LineHaulDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnUnloadLinehaul.PressedImage.Image = i;
                i = null;
                bmpimg = null;

                #endregion //


                #region //UNLOADING FOR PORT
                //load for warehouse
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.Un_PortUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnUnloadPort.Image = i;
                i = null;
                bmpimg = null;

                //BUTTON load warehouse
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.Un_PortDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnUnloadPort.PressedImage.Image = i;
                i = null;
                bmpimg = null;

                #endregion //
                break;
                case true:

                    break;
                    
            }
        }

        private void btnLogout_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            try
            {
                //load login screen
                if (clsGlobals.gfLogin != null)
                {
                    clsGlobals.gfLogin.Show();

                    //hide the main menu screen
                    this.Hide();
                }
                else
                {
                    clsGlobals.gfLogin = new frmLogin();
                    clsGlobals.gfLogin.Show();

                    //hide the main menu screen
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured during switch back to logon screen " + ex.Message);
                return;
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnUnloadLinehaul_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (clsGlobals.gfUnLoadLinehaulForm == null)
            {
                clsGlobals.gfUnLoadLinehaulForm = new frmUnloadLinehaul();
                clsGlobals.gfUnLoadLinehaulForm.Show();

                clsGlobals.gfMainMenuForm.Hide();
            }
            else
            {
                clsGlobals.gfUnLoadLinehaulForm.Show();
                clsGlobals.gfMainMenuForm.Hide();

            }

            Cursor.Current = Cursors.Default;
        }

        private void btnDiscrepancy_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (clsGlobals.gfDiscrepancy == null)
            {
                clsGlobals.gfDiscrepancy = new frmDiscrepancy();

                clsGlobals.gfDiscrepancy.Show();

                clsGlobals.gfMainMenuForm.Hide();
            }






            Cursor.Current = Cursors.Default;
        }

        private void btnConsolidate_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

                if (clsGlobals.gfConsolidate == null)
                {
                    clsGlobals.gfConsolidate = new frmConsolidate();
                    clsGlobals.gfConsolidate.Show();

                    clsGlobals.gfMainMenuForm.Hide();
                }

            Cursor.Current = Cursors.Default;
        }

        private void btnDeconsolidate_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (clsGlobals.gfDeConsolidate == null)
            {
                clsGlobals.gfDeConsolidate = new frmConsolidate();
                clsGlobals.gfDeConsolidate.Show();

                clsGlobals.gfMainMenuForm.Hide();
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnStagingInventory_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Current = Cursors.Default;
        }

        private void btnSettings_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            //set the cursor
            Cursor.Current = Cursors.WaitCursor;

            //load the relevant screen and hide the main menu scr
            if (clsGlobals.gfSettingsForm == null)
            {
                clsGlobals.gfSettingsForm = new frmSettings();
                clsGlobals.gfSettingsForm.Show();

                clsGlobals.gfMainMenuForm.Hide();
            }
            else
            {
                clsGlobals.gfSettingsForm.Show();
                clsGlobals.gfMainMenuForm.Hide();
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnUnloadSupplier_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            try
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              {
                Cursor.Current = Cursors.WaitCursor;

                TogglePanels((int)iPanelSwitch.UPanel);
                //pnlUnload.Visible = true;
                //pnlUnload.BringToFront();

                //pnlMain.SendToBack();
                Cursor.Current = Cursors.Default;

            }
            catch (Exception ex)
            {

            }
        }

        private void frmMainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        private void btnLoadSupplier_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            //TogglePanels((int)iPanelSwitch.LPanel);
            pnlLoad.Visible = true;
            pnlLoad.BringToFront();

            pnlMain.SendToBack();

            Cursor.Current = Cursors.Default;

        }

        private void btnSwitchLanguage_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            //toggle the language between arabic and english
            if (bArabic == false)
            {
                bArabic = true;

                //arabic
                LoadMenuBtns(bArabic);
            }
            else
            {
                //non arabic
                bArabic = false;

                LoadMenuBtns(bArabic);
            }
        }

        private void btnBackLoad_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            TogglePanels(0);
        }

        private void btnBackUnload_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            //change the z order of the panel to main panel
            TogglePanels(0);
        }

        private void btnLoadCustomer_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

                if (clsGlobals.gfLoadCustomer == null)
                {
                    clsGlobals.gfLoadCustomer = new frmLoadCustomer();
                    clsGlobals.gfLoadCustomer.Show();

                    clsGlobals.gfMainMenuForm.Hide();
                }
                else
                {
                    clsGlobals.gfLoadCustomer.Show();

                    clsGlobals.gfMainMenuForm.Hide();
                }
            Cursor.Current = Cursors.Default;
        }

        private void btnLoadVendor_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            if (clsGlobals.gfLoadForm == null)
            {
                clsGlobals.gfLoadForm = new frmLoad();
                clsGlobals.gfLoadForm.Show();

                clsGlobals.gfMainMenuForm.Hide();
            }
            else
            {
                clsGlobals.gfLoadCustomer.Show();

                clsGlobals.gfMainMenuForm.Hide();
            }
        }

        private void btnUnloadWarehouse_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (clsGlobals.gfUnLoadWarehouseForm == null)
            {
                clsGlobals.gfUnLoadWarehouseForm = new frmUnloadWarehouse();
                clsGlobals.gfUnLoadWarehouseForm.Show();

                clsGlobals.gfMainMenuForm.Hide();
            }
            else
            {
                clsGlobals.gfUnLoadWarehouseForm.Show();
                clsGlobals.gfMainMenuForm.Hide();
            }

            Cursor.Current = Cursors.Default;

        }

        private void btnUnloadPort_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {

        }

        private void btnUnloadVendor_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

                if (clsGlobals.gfUnLoadSupplierForm == null)
                {
                    clsGlobals.gfUnLoadSupplierForm = new frmUnloadSupplier();
                    clsGlobals.gfUnLoadSupplierForm.Show();

                    clsGlobals.gfMainMenuForm.Hide();
                }
                else
                {
                    clsGlobals.gfUnLoadSupplierForm.Show();
                    clsGlobals.gfMainMenuForm.Hide();
                }

            Cursor.Current = Cursors.Default;

        }







    }
}