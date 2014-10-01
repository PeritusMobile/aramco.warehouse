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

        #region//local forms declaration
        static Form _gfmainmenu = null;
        static Form _gfload = null;
        static Form _gfunloadsupplier = null;
        static Form _gflogin = null;
        static Form _gfassignvehicle = null;
        static Form _gfsetstatus = null;
        #endregion

        #region//local string accesors
        private static string _empid = null;
        private static string _uid = null;
        private static string _pwd = null;
        #endregion

        #region //User Interface Global Accessor
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

        //Set Status Form
        public static Form gfSetStatusForm
        {
            get
            {
                return _gfsetstatus;
            }
            set
            {
                _gfsetstatus = value;
            }

        }
        
        //Assign Vehicle Form
        public static Form gfAssignVehicleForm
        {
            get
            {
                return _gfassignvehicle;
            }
            set
            {
                _gfassignvehicle = value;
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
        #region
        //Login Form
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
