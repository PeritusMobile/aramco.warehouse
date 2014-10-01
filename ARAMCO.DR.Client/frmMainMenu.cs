using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ARAMCO.Client
{
    public partial class frmMainMenu : Form
    {
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

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                lblEmpID.Text = clsGlobals.gEmpId;
                lblUser.Text = clsGlobals.gUID.ToUpper();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnLogout_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            try
            {
                if (clsGlobals.gfLogin != null)
                {
                    clsGlobals.gfLogin.Show();

                    this.Hide();
                }
                else
                {
                    clsGlobals.gfLogin = new frmLogin();
                    clsGlobals.gfLogin.Show();

                    this.Hide();
                }
            }
            catch (Exception ex)
            {

            }
            Cursor.Current = Cursors.Default;
        }



        private void btnDiscrepancy_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Current = Cursors.Default;
        }

        private void btnConsolidate_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Current = Cursors.Default;
        }

        private void btnDeconsolidate_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Current = Cursors.Default;
        }

        private void btnStagingInventory_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Current = Cursors.Default;
        }

        private void btnSettings_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
                Application.Exit();
            Cursor.Current = Cursors.Default;
        }

        private void btnUnloadSupplier_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            try
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
            catch (Exception ex)
            {

            }
        }

        private void UIButton_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            if (clsGlobals.gfAssignVehicleForm == null)
            {
                clsGlobals.gfAssignVehicleForm = new frmAssignVehicle();

                clsGlobals.gfAssignVehicleForm.Show();
            }
            else
            {
                clsGlobals.gfAssignVehicleForm.Show();

            }


        }

        private void btnViewMissionList_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            if (clsGlobals.gfLoadForm == null)
            {
                clsGlobals.gfLoadForm = new frmLoad();

                clsGlobals.gfLoadForm.Show();

                
            }
            else
            {
                clsGlobals.gfLoadForm.Show();

            }
        }

        private void btnSetStatus_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (clsGlobals.gfSetStatusForm != null)
            {
                clsGlobals.gfSetStatusForm.Show();
                clsGlobals.gfMainMenuForm.Hide();
            }
            else
            {
                clsGlobals.gfSetStatusForm = new frmSetStatus();
                clsGlobals.gfSetStatusForm.Show();
                clsGlobals.gfMainMenuForm.Hide();
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnLogOff_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            //lets logg out of this screen
            if (clsGlobals.gfLogin != null)
            {
                clsGlobals.gfLogin.Show();
                clsGlobals.gfMainMenuForm.Close();

                clsGlobals.gfMainMenuForm.Dispose();
                clsGlobals.gfMainMenuForm = null;
            }
            else
            {
                clsGlobals.gfLogin = new frmLogin();
                clsGlobals.gfLogin.Show();

                clsGlobals.gfMainMenuForm.Close();

                clsGlobals.gfMainMenuForm.Dispose();
                clsGlobals.gfMainMenuForm = null;


            }


        }


    }
}