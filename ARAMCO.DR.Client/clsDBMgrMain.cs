using System;
using System.Collections.Generic;
using System.Text;
using iAnywhere.Data.UltraLite;
using System.Windows.Forms;

namespace ARAMCO.Client
{
    static class clsDBMgrMain
    {
        private static ULConnection _conn;


        public static void Init()
        {
            try
            {
                // Open a connection to the database
                ULConnectionParms openParms = new ULConnectionParms();
                openParms.ConnectionName = "ulsap";
                openParms.DatabaseOnDevice = GetInstallDir() + "ulsap.udb";
                try
                {
                    _conn = new ULConnection(openParms.ToString());
                    _conn.Open();
                }
                catch (ULException ex)
                {
                    MessageBox.Show("Cannot connect to database: " + ex.Message);
                    throw ex;
                }

            }
            catch (Exception ex)
            {

            }

        }


        public static string GetInstallDir()
        {
            string t = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            int pos = t.LastIndexOf("\\");
            if (pos >= 0)
            {
                return t.Substring(0, pos + 1);
            }
            else
            {
                return "";
            }
        }

        public static string testaccess()
        {
            string sret = "";


            return sret;

        }
    }
}
