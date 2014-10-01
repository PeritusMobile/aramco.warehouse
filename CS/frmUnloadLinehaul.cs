using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Runtime;
using System.Windows;
using Resco.Controls.AdvancedList;
using Resco.Controls;
using System.Collections.Generic;
using System.Reflection;

namespace ARAMCO.Client
{
    public partial class frmUnloadLinehaul : Form
    {
      
        //barcode holder for RollPallett
        private string _sRollPalletBarcode = "";
        private string _sIndividualPackageBarcode = "";
        private string _sASNSelBarcode = "";
        private string _sPackageType = "";
        private string _sNotes = "";

        private enum enPackType { RPT, PCK };

        
        private string[] _2dimensionValues = new string[2]; //holder for values with 2 dimensions
        private string[] _2dimensionMappingNames = new string[2]; //holder for mapping names with 2 dimensions
        private Resco.Controls.AdvancedList.Row _newListRow = null; //row insert call to Resco.Controls.Advancelinst
        private Resco.Controls.AdvancedList.Mapping _columnNames; 

        private string[] _4dimensionValues = new string[4];//holder for values with 4 dimensions
        private string[] _4dimensionMappingNames = new string[4];//holder for mapping names with 4 dimensons
        private string[] _6dimensionValues = new string[6];//holder for values with 4 dimensions
        private string[] _6dimensionMappingNames = new string[6];//holder for mapping names with 4 dimensons

        /////// <summary>
        /////// Application main
        /////// </summary>
        //static void Main()
        //{

        //    Application.Run(new frmLoad());
        //}

        public frmUnloadLinehaul()
        {
            Cursor.Current = Cursors.WaitCursor;

            InitializeComponent();
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
                //bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.SelAllUp.jpg"));

                //////cast to image
                //i = (Image)bmpimg;
                //////assign image to button
                //btnSelAll.ImageDefault = i;
                //i = null;
                //bmpimg = null;

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
                //bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.DeSelAllUp.jpg"));

                //////cast to image
                //i = (Image)bmpimg;
                //////assign image to button
                //btnDeSelAll.ImageDefault = i;
                //i = null;
                //bmpimg = null;

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

        private void frmLoad_Load(object sender, EventArgs e)
        {

            //force the user to scan the
            //freight oder to obtain data
            //from SMP server...

            pnlInitMsg.BringToFront();
            pnlInitMsg.Visible = true;

            //EnableDisableRelevantControls(false);

            //load the menu buttons images
            LoadMenuBtns();
            

            //force the repaint of the screen
            pnlMain.Refresh();
            this.Refresh();


            //fist grid should be the package grid
            tbCMain.SelectedIndex = 0;
            Cursor.Current = Cursors.Default;

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

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
                        clsGlobals.gfLoadForm = null;
                        clsGlobals.gfLoadForm.Dispose();
                    }
                    else
                    {
                        clsGlobals.gfMainMenuForm.Show();

                        clsGlobals.gfLoadForm.Close();
                        clsGlobals.gfLoadForm = null;
                        clsGlobals.gfLoadForm.Dispose();

                    }
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
            }

            Cursor.Current = Cursors.Default;
        }

        private void frmLoad_KeyDown(object sender, KeyEventArgs e)
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




        #region //List items loader functions for the relevant advancelist controls
        private void LoadGridPackageItems()
        {





        }

        private void LoadGridRollPalletItems()
        {
            try
            {

                //what is the selected roll pallet show the label
                lblRollPalletID.Text = "Roll Pallet ID: " + _sRollPalletBarcode.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while showing roll pallet barcode");
                return;
            }

            try
            {
                #region
                //load the rollpallet barcode view for selected item
                _4dimensionMappingNames[0] = "dBarcode";
                _4dimensionMappingNames[1] = "dPType";
                _4dimensionMappingNames[2] = "dDestination";
                _4dimensionMappingNames[3] = "dConsignee";

                _columnNames = new Mapping(_4dimensionMappingNames);

                ////initialize an update to the advancelist control
                advancedLstRP.BeginUpdate();

                //lets do a for loop to add some dummy values
                for (int i = 1; i <= 6; i++)
                {
                    //add the items into the grid
                    _4dimensionValues[0] = i.ToString() + "00005679485886";
                    _4dimensionValues[1] = i.ToString() + "Cylinder-Box-";
                    _4dimensionValues[2] = "Hong Kong West";
                    _4dimensionValues[3] = "Johnny Walker Inc.";

                    //template id = 3 for default
                    //selected template id = 6 for selected blue

                    switch (i)
                    {
                        case 2:
                            _newListRow = new Row(1, 5, _4dimensionValues, _columnNames);
                            break;
                        case 3:
                            _newListRow = new Row(2, 5, _4dimensionValues, _columnNames);
                            break;
                        case 4:
                            _newListRow = new Row(3, 5, _4dimensionValues, _columnNames);
                            break;
                        case 5:
                            _newListRow = new Row(4, 5, _4dimensionValues, _columnNames);
                            break;

                        case 6:
                            _newListRow = new Row(1, 5, _4dimensionValues, _columnNames);
                            break;
                        default:

                            _newListRow = new Row(1, 5, _4dimensionValues, _columnNames);
                            break;
                    }

                    //ADD THE GENERATED ROW TO THE GRID CONTROL
                    advancedLstRP.DataRows.Add(_newListRow);

                }

                //COMMITT THE UPDATE TO THE ui THREAD
                advancedLstRP.EndUpdate();
                #endregion

            }
            catch (Exception ex)
            {
                Console.WriteLine("error has oocured we must capture this add to error");
                return;

            }

        }

        
        private void LoadGridASNItems()
        {
            try
            {
                #region
                //assign the lable
                switch (_sPackageType)
                {
                    case "RPT":
                        lblSelPCKorRPT.Text = "Roll Pallet ID: " + _sRollPalletBarcode;
                        lblSelPCKorRPT.BringToFront();
                        lblSelPCKorRPT.Visible = true;
                        tPnlNotes.Visible = false;
                        break;
                    case "PCK":
                        lblSelPCKorRPT.Text = "Package ID: " + _sIndividualPackageBarcode;
                        break;
                }

                //load the rollpallet barcode view for selected item
                _6dimensionMappingNames[0] = "dASNBarcode";
                _6dimensionMappingNames[1] = "dItemBarcode";
                _6dimensionMappingNames[2] = "dPackageType";
                _6dimensionMappingNames[3] = "dasnNotes";
                _6dimensionMappingNames[4] = "dDestination";
                _6dimensionMappingNames[5] = "7dConsignee";


                _columnNames = new Mapping(_6dimensionMappingNames);

                ////initialize an update to the advancelist control
                advancedLstASN.BeginUpdate();


                //lets do a for loop to add some dummy values
                for (int i = 1; i <= 6; i++)
                {
                    //add the items into the grid
                    _6dimensionValues[0] = i.ToString() + "00005679485886";
                    _6dimensionValues[1] = i.ToString() + "76874637586964";
                    _6dimensionValues[2] = "PCK";
                    _6dimensionValues[3] = "These are dummy notes captured for testing the logic of the app";
                    _6dimensionValues[4] = "Riyadh";
                    _6dimensionValues[5] = "ARAMCO EAST";

                    switch (i)
                    {
                        case 2:

                            _newListRow = new Row(1, 5, _6dimensionValues, _columnNames);
                            break;
                        case 3:
                            _newListRow = new Row(1, 5, _6dimensionValues, _columnNames);
                            break;

                        case 4:
                            _newListRow = new Row(1, 5, _6dimensionValues, _columnNames);
                            break;


                        case 5:
                            _newListRow = new Row(1, 5, _6dimensionValues, _columnNames);
                            break;

                        case 6:
                            _newListRow = new Row(1, 5, _6dimensionValues, _columnNames);
                            break;
                        default:

                            _newListRow = new Row(1, 5, _6dimensionValues, _columnNames);
                            break;
                    }


                    

                    advancedLstASN.DataRows.Add(_newListRow);


                }

                //update the relevant ASN grid
                advancedLstASN.EndUpdate();
                #endregion

            }
            catch (Exception ex)
            {
                Console.WriteLine("error has oocured we must capture this add to error");

            }
        }
         

        #endregion

        private void advlstPackage_CellClick(object sender, Resco.Controls.AdvancedList.CellEventArgs e)
        {
            MessageBox.Show("cell was clicked");
        }

        private void LoadRollPalletSelBarcode(string sRollPalletBarcode)
        {
            try
            {
                #region
                //load the rollpallet barcode view for selected item
                _2dimensionMappingNames[0] = "RollPalletHead";
                _2dimensionMappingNames[1] = "rpActualBarcode";
                _columnNames = new Mapping(_2dimensionMappingNames);
                
                ////initialize an update to the advancelist control
                advancedLstRP.BeginUpdate();

                _2dimensionValues[0] = "Roll Pallet ID: ";
                _2dimensionValues[1] = sRollPalletBarcode;
                _newListRow = new Row(0, 0, _2dimensionValues, _columnNames);
                advancedLstRP.DataRows.Add(_newListRow);
                advancedLstRP.EndUpdate();

                #endregion

                /* NO LONGER REQUIRED AS MERGED TOGETHER
                #region //header values
                //add the HEADER also
                    //load the rollpallet data view
                    _2dimensionMappingNames[0] = "Barcode";
                    _2dimensionMappingNames[1] = "PType";
                    _columnNames = new Mapping(_2dimensionMappingNames);

                    ////initialize an update to the advancelist control
                    advancedLstRP.BeginUpdate();

                    _2dimensionValues[0] = "";
                    _2dimensionValues[1] = "";
                    _newListRow = new Row(1, 1, _2dimensionValues, _columnNames);
                    advancedLstRP.DataRows.Add(_newListRow);
                    advancedLstRP.EndUpdate();

                //require to reset the relevant listrows 
                    _newListRow = null;

                #endregion
                */
                //after add the header values for the items that will be loaded
                //relevant for the roll pallett


            }
            catch (Exception ex)
            {
                //if the update to the listview fails then notify error handler.
            }
        }

        /*
        private void LoadASNSelBarcode(string sASNBarcode)
        {
            try
            {
                #region
                //load the rollpallet data view
                _2dimensionMappingNames[0] = "BarcodeLabel";
                _2dimensionMappingNames[1] = "BarcodeValue";
                _columnNames = new Mapping(_2dimensionMappingNames);

                ////initialize an update to the advancelist control
                advancedLstASN.BeginUpdate();

                _2dimensionValues[0] = "ASN Barcode: ";
                _2dimensionValues[1] = sASNBarcode;
                _newListRow = new Row(0, 0, _2dimensionValues, _columnNames);
                advancedLstASN.DataRows.Add(_newListRow);
                advancedLstASN.EndUpdate();

                #endregion
                //after add the header values for the items that will be loaded
                //relevant for the roll pallett


            }
            catch (Exception ex)
            {
                //if the update to the listview fails then notify error handler.
            }
        }
        */
        private void btnViewRollPallet_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                //only load the relevant values into
                //the grid if there is aseleected value for  arcode
                if ((_sRollPalletBarcode != ""))
                {
                    //add the selected roll pallet value to the row pallet grid
                    //LoadRollPalletSelBarcode(_sRollPalletBarcode);

                    //we should load the RollPallet values
                    LoadGridRollPalletItems();


                    ////enable the roll pallet tabe
                    tbPgRP.TabItem.Enabled = true;

                    ////Switch tabs to roll pallet
                    tbCMain.SelectedIndex = 1;
                    btnSelAll.Enabled = false;
                }
            }
            catch(Exception ex)
            {

                Cursor.Current = Cursors.Default;
            }

            Cursor.Current = Cursors.Default;
        }



        private void EnableDisableRelevantControls(Boolean bswitch)
        {

            //this switch controller to enable and disable
            //the controls on the forms

            if (bswitch)
            {
                btnSelAll.Enabled = true;
                btnDeSelAll.Enabled = true;

            }
            else
            {
                //disable the buttons
                btnSelAll.Enabled = false;
                btnDeSelAll.Enabled = false;

                tbPgRP.TabItem.Enabled = false;
                tbPgASN.TabItem.Enabled = false;
                tbPgPackage.TabItem.Enabled = true;

                //buttons to disable because a cell has not been
                //selected yet. is the assumption
                btnPrint.Enabled = false;
                btnComplete.Enabled = false;
                btnDiscrepancy.Enabled = false;
                btnSearch.Enabled = false;
                //clear the girds
                //advancedLstASN.DataRows.Clear();
                advancedLstRP.DataRows.Clear();

               
            }

        }

        private void advlstPackage_RowSelect(object sender, Resco.Controls.AdvancedList.RowEventArgs e)
        {
            //first check the current row that has been selected
            //if the item is a Roll Pallet then obtain the roll
            //pallet barcode

            try
            {

                //lets figure out if the item selected is a roll pallet
                _sPackageType = e.DataRow.StringData[2];

                //TOD: Edwin Ramos: obtain the selected ASN Barcode
                _sASNSelBarcode = e.DataRow.StringData[0];

                if (_sPackageType == "RPT") //its a Roll Pallet
                {
                    //if the package type is a Roll Pallet
                    //turn on the roll pallet button
                    btnSelAll.Enabled = true;

                    //obtain the actual roll pallet barcode
                    _sRollPalletBarcode = e.DataRow.StringData[0];
                    tbPgRP.TabItem.Enabled = true;

                }
                else if (_sPackageType == "PCK") //must be a pck / Package
                {
                    //obtain the package barcode for later use
                    _sIndividualPackageBarcode = e.DataRow.StringData[0];
                    //if the item is not a roll pallet 
                    //we must turn off the rolll pallet tab and button
                    btnSelAll.Enabled = false;
                    tbPgRP.TabItem.Enabled = false;
                    _sRollPalletBarcode = null;

                }

                //for either a roll pallet or a package there is an ASN assocciate]
                try
                {
                    //TODO: Load ASN Barcode
                    //LoadASNSelBarcode(_sASNSelBarcode);

                    //load the grid items for selected ASN barcode 
                    //LoadGridASNItems();

                    btnDeSelAll.Enabled = true;
                    tbPgASN.TabItem.Enabled = true;

                    //lets enable the search functionality
                    btnSearch.Enabled = true;
                    btnPrint.Enabled = true;
                    btnDiscrepancy.Enabled = true;

                }
                catch(Exception ex)
                {

                }

            }
            catch (Exception ex)
            {



            }
        }

        private void btnViewASN_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

                //once the button for selected item has been enabled
                //this allows the user to view the associcated ASN
                if (_sASNSelBarcode != "")
                {
                    //hide the notes panel
                    tPnlNotes.Visible = false;
                    lblSelPCKorRPT.Visible = true;

                    ////Switch tabs to ASN
                    tbCMain.SelectedIndex = 2;

                    //turn off the asn button
                    btnDeSelAll.Enabled = false;

                    //load the grid items
                    LoadGridASNItems();
                }

            Cursor.Current = Cursors.Default;


        }

        private void tbCMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //everytime the selected index changes we must obtain the current
            //selected barcode and assign this to the relevant grids
            switch (tbCMain.SelectedIndex)
            {
                case 0: //for Package
                    //the package tab was chose again;
                    //clear the muthf grid
                    advancedLstRP.DataRows.Clear();
                    advancedLstRP.Refresh();

                    //advancedLstASN.DataRows.Clear();
                    //advancedLstASN.Refresh();

                    
                    break;
                case 1: //for Roll Pallett

                    //only load the relevant values into
                    //the grid if there is aseleected value for  arcode
                    if (((_sRollPalletBarcode != "") || 
                        (_sRollPalletBarcode != null)))
                    {
                        //add the selected roll pallet value to the row pallet grid
                        //LoadRollPalletSelBarcode(_sRollPalletBarcode);

                        //we should load the RollPallet values
                        LoadGridRollPalletItems();

                        //if the current selected asn code is not 
                        //empty or blank then lets enable the asn tab and
                        //the view asn button
                        if((_sASNSelBarcode != "") || 
                            (_sASNSelBarcode != null))
                        {
                            btnDeSelAll.Enabled = true;
                            tbPgASN.Enabled = true;
                        }
                    }
                    break;
                case 2: //for ASN
                    if ((_sASNSelBarcode != ""))
                    {
                        //LoadASNSelBarcode(_sASNSelBarcode);

                        //load the associated items of packages for
                        //ASN
                        //LoadGridASNItems();
                        Cursor.Current = Cursors.WaitCursor;

                        //once the button for selected item has been enabled
                        //this allows the user to view the associcated ASN
                        if (_sASNSelBarcode != "")
                        {////enable the roll pallet tabe
                            //tbPgASN.TabItem.Enabled = true;

                            ////Switch tabs to ASN
                            tbCMain.SelectedIndex = 2;

                            //turn off the asn button
                            btnDeSelAll.Enabled = false;

                            //load the grid items
                            LoadGridASNItems();
                        }

                        Cursor.Current = Cursors.Default;
                        //turn on the rollpalet tab and the view rp button
                        //if there is a rollpallet barcode;
                        if ((_sRollPalletBarcode != "") || (_sRollPalletBarcode != null))
                        {
                            //enable the roll pallet tab
                            btnSelAll.Enabled = true;
                            tbPgRP.Enabled = true;

                        }

                        //turn off the view asn button
                        btnDeSelAll.Enabled = false;
                    }
                    break;
                default: //should be o
                    Console.WriteLine("No default assigned");
                    break;
            }

            //lets check first if this is a roll pallet or a package

            
            //then assign to the roll pallet grid


            //then assign to the ASN grid also
            //in order to reflect the necessary data values

            Cursor.Current = Cursors.Default;


        }

        private void tbPgPackage_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("tab page package was selected");
            //lets us clear the currrent rpws iondps=idldik]
            advancedLstRP.DataRows.Clear();


        }

        private void ViewNotesEvent()
        {




        }


        private void btnPrintReady_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Printing command submitted to Server \api");

        }

        private void tbCMain_Click(object sender, EventArgs e)
        {

        }

        private void advancedLstASN_ButtonClick(object sender, CellEventArgs e)
        {
            //hide th advancedlist grid
           // advancedLstASN.SendToBack();
            advancedLstASN.Hide();
            advancedLstASN.Visible = false;

            //show the notes text
            //tPnlNotes.BringToFront();
            tPnlNotes.Show();
            tPnlNotes.Visible = true;

            //set the value of the text box
            rcTxtNotes.Text = "Notes field here....";
            //MessageBox.Show("The button cell has been clicked");
        }

        private void advancedLstASN_CellClick(object sender, CellEventArgs e)
        {
            MessageBox.Show("The cell has been clicked");

        }

        private void tPnlNotes_GotFocus(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            //hide the panels
            //tPnlNotes.SendToBack();
            tPnlNotes.Visible = false;
            tPnlNotes.Hide();

            //show the advancedlist control
            //advancedLstASN.BringToFront();
            advancedLstASN.Show();
            advancedLstASN.Visible = true;

            //show the label
            lblSelPCKorRPT.Show();
            lblSelPCKorRPT.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {






        }

        private void advancedLstASN_ButtonClick_1(object sender, CellEventArgs e)
        {
            //hide the panels
            //tPnlNotes.SendToBack();
            tPnlNotes.Visible = true;
            tPnlNotes.Show();

            //obtain the notes into the relevant notes field
            rcTxtNotes.Text = _sNotes;

            //show the advancedlist control
            //advancedLstASN.BringToFront();
            advancedLstASN.Hide();
            advancedLstASN.Visible = false;

            //hide the lable
            lblSelPCKorRPT.Hide();
            lblSelPCKorRPT.Visible = false;
        }


        /*
        private void contextMenu1_Popup(object sender, System.EventArgs e)
        {
            this.contextMenu1.MenuItems.Clear();
            //if (this.checkBox1.Checked)
                this.contextMenu1.MenuItems.Add(this.menuItem1);
            //if (this.checkBox2.Checked)
                this.contextMenu1.MenuItems.Add(this.menuItem2);
            //if (this.checkBox3.Checked)
                this.contextMenu1.MenuItems.Add(this.menuItem3);

            // Always add the default menu 
            this.contextMenu1.MenuItems.Add(this.menuItem4);
        }
        */
        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("You selected MenuItem 1");
        }

        private void menuItem2_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("You selected MenuItem 2");
        }

        private void menuItem5_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("You selected MenuItem 3");
        }

        private void menuItem3_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("You selected MenuItem 3");
        }

        private void menuItem5_Click_1(object sender, System.EventArgs e)
        {
            MessageBox.Show("You selected Default Item 2");
        }

        private void advancedLstASN_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void advlstPackage_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("This row was double tapped; invoke the event handler");
        }

        private void advancedLstASN_RowSelect(object sender, RowEventArgs e)
        {
            //once we have selected the row
            //lets grab the notes data
            //lets figure out if the item selected is a roll pallet
            _sNotes = e.DataRow.StringData[3];

        }

        private void btnMockUpScan_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            

            pnlInitMsg.Hide();

            Cursor.Current = Cursors.Default;
        }

        private void btnDiscrepancy_Click(object sender, EventArgs e)
        {
            if (clsGlobals.gfDiscrepancy == null)
            {
                //if the discrepancy screen is not equals to null
                clsGlobals.gfDiscrepancy = new frmDiscrepancy();
                clsGlobals.gfDiscrepancy.Show();

                clsGlobals.gfUnLoadLinehaulForm.Hide();

            }
            else
            {


            }


        }

        private void btnSelAll_Click(object sender, EventArgs e)
        {

        }


       
    }
}