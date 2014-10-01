using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ARAMCO.Client
{
    //*********************************************
    //
    //
    //
    /// <summary>
    /// Developer: Edwin Ramos .SAP Mobile Project
    /// Saudi Aramco
    /// </summary>


    public static class clsGlobals
    {

        //boolean
        static string callingformUnVendor = "UnloadVendor";
        static string callingformUnWarehouse = "UnloadWarehouse";
        static string callingformUnLinehaul = "UnloadLinehaul";
        static string callingformUnPort = "UnloadPort";
        static string callingformMainMenu = "MainMenu";
        static string callingformLoadCustomer = "LoadCustomer";
        static string callingformDeliveryInfo = "DeliveryInfo";


        //boolean
        static Boolean _bappbeenloaded = false;

        public static Boolean bAppBeenLoaded
        {
            get
            {
                return _bappbeenloaded;
            }
            set
            {
                _bappbeenloaded = value;
            }
        }
        //flag to remember the calling form for discrepancy report
        static string _scallingFormDiscepancy = null;

        #region //local forms declaration
        static Form _gfmainmenu = null;
        static Form _gfload = null;
        static Form _gfunloadsupplier = null;
        static Form _gfunloadlinehaul = null;
        static Form _gfunloadwarehouse = null;
        static Form _gflogin = null;
        static Form _gfsettings = null;
        static Form _gfconsolidate = null;
        static Form _gfdeconsolidate = null;
        static Form _gfloadcustomer = null;
        static Form _gfdiscrepancy = null;
        #endregion

        #region//local string accesors
        private static string _empid = null;
        private static string _uid = null;
        private static string _pwd = null;
        #endregion

        //Calling Form for Discrepancy report
        public static string gICallingFormDiscrepancy
        {
            get
            {
                return _scallingFormDiscepancy;
            }
            set
            {
                _scallingFormDiscepancy = value;
            }

        }

        #region //User Interface Global Accessor
        //Unload From Warehouse Form
        public static Form gfUnLoadWarehouseForm
        {
            get
            {
                return _gfunloadwarehouse;
            }
            set
            {
                _gfunloadwarehouse = value;
            }

        }

        //Main Menu Form
        public static Form gfMainMenuForm

        {
            get
            {
                return _gfmainmenu;
            }
            set
            {
                _gfmainmenu = value;
            }

        }
        //Main Menu Form
        public static Form gfDiscrepancy
        {
            get
            {
                return _gfdiscrepancy;
            }
            set
            {
                _gfdiscrepancy = value;
            }

        }
        //Load Customer Form
        public static Form gfLoadCustomer
        {
            get
            {
                return _gfloadcustomer;
            }
            set
            {
                _gfloadcustomer = value;
            }

        }

        //DeConsolidate Form
        public static Form gfDeConsolidate
        {
            get
            {
                return _gfdeconsolidate;
            }
            set
            {
                _gfdeconsolidate = value;
            }

        }
        //Consolidate Form
        public static Form gfConsolidate
        {
            get
            {
                return _gfconsolidate;
            }
            set
            {
                _gfconsolidate = value;
            }

        }
        //Load Truck Form
        public static Form gfLoadForm
        {
            get
            {
                return _gfload;
            }
            set
            {
                _gfload = value;
            }

        }
        //Unload Settings Form
        public static Form gfSettingsForm
        {
            get
            {
                return _gfsettings;
            }
            set
            {
                _gfsettings = value;
            }

        }
        //Unload From Linehaul Form
        public static Form gfUnLoadLinehaulForm
        {
            get
            {
                return _gfunloadlinehaul;
            }
            set
            {
                _gfunloadlinehaul = value;
            }

        }

        //Unload From Supplier Form
        public static Form gfUnLoadSupplierForm
        {
            get
            {
                return _gfunloadsupplier;
            }
            set
            {
                _gfunloadsupplier = value;
            }

        }

        #endregion
        #region //Login Form
        public static Form gfLogin
        {
            get
            {
                return _gflogin;
            }
            set
            {
                _gflogin = value;
            }

        }
        #endregion

        //global string accessors

        //Employee ID 
        //STRING VALUES
        public static string gEmpId
        {
            get
            {
                return _empid;
            }
            set
            {
                _empid = value;
            }
        }

        //User ID
        //STRING VALUES
        public static string gUID
        {
            get
            {
                return _uid;
            }
            set
            {
                _uid = value;
            }
        }

    }




}
