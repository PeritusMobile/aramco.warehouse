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
    public partial class frmConsolidate : Form
    {
        public frmConsolidate()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            if (clsGlobals.gfMainMenuForm != null)
            {
                clsGlobals.gfMainMenuForm.Show();

                clsGlobals.gfConsolidate.Close();
                clsGlobals.gfConsolidate.Dispose();
                clsGlobals.gfConsolidate = null;
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
                    #region //BACK BUTTON
                    //BUTTON Back
                    bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.BackUp.jpg"));

                    ////cast to image
                    i = (Image)bmpimg;
                    ////assign image to button
                    btnBack.Image = i;
                    i = null;
                    bmpimg = null;

                    //BUTTON Back
                    bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.BackDown.jpg"));

                    ////cast to image
                    i = (Image)bmpimg;
                    ////assign image to button
                    btnBack.PressedImage.Image = i;
                    i = null;
                    bmpimg = null;
                    #endregion //back button
                    break;
                case true:

                    break;

            }
        }

    }
}