using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using System.IO;
using System.Threading;
using System.Windows;



namespace ARAMCO.Client
{
	/// <summary>
	/// Main form of the application
	/// </summary>
	public class frmLogin : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;

        const int kSplashUpdateInterval_ms = 200;
        private Resco.UIElements.UIPanel uiPanel1;
        private Resco.UIElements.Controls.UIElementPanelControl uiElementPanelControl1;
        private Resco.UIElements.UIImage imgIconMain;
        private Resco.UIElements.UITextBox txtUserName;
        private Resco.UIElements.UITextBoxButton uiTextBoxButton3;
        private Resco.UIElements.UITextBox txtPwd;
        private Resco.UIElements.UITextBoxButton uiTextBoxButton4;
		const int kMinAmountOfSplashTime_ms = 8000;

        //flags
        private bool btxtemp = false;
        private bool btxtuid = false;
        private Resco.UIElements.UIButton btnLogin;
        private Resco.UIElements.UITextBox txtbxdummy;
        private Resco.UIElements.UITextBoxButton uiTextBoxButton1;
        private bool btxtpwd = false;
        private bool m_InMyTextChanged = false; 

		/// <summary>
		/// Main form's contructor only calls InitializeComponent
		/// </summary>
		public frmLogin()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

		}

		/// <summary>
		/// Instance of the splash form.
		/// </summary>
		static SplashForm splash = null;

		/// <summary>
		/// Starts the splash screen on a separate thread
		/// </summary>
		static public void StartSplash()
		{
			// Instance a splash form given the image names
			splash = new SplashForm(kSplashUpdateInterval_ms);

			// Run the form
			Application.Run(splash);
		}

		/// <summary>
		/// Clean up
		/// </summary>
		/// <param name="disposing"></param>
		protected override void Dispose( bool disposing )
		{
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.uiPanel1 = new Resco.UIElements.UIPanel();
            this.txtUserName = new Resco.UIElements.UITextBox();
            this.uiTextBoxButton3 = new Resco.UIElements.UITextBoxButton();
            this.txtPwd = new Resco.UIElements.UITextBox();
            this.uiTextBoxButton4 = new Resco.UIElements.UITextBoxButton();
            this.btnLogin = new Resco.UIElements.UIButton();
            this.txtbxdummy = new Resco.UIElements.UITextBox();
            this.uiTextBoxButton1 = new Resco.UIElements.UITextBoxButton();
            this.uiElementPanelControl1 = new Resco.UIElements.Controls.UIElementPanelControl();
            this.imgIconMain = new Resco.UIElements.UIImage();
            this.uiElementPanelControl1.SuspendElementLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Navy;
            this.uiPanel1.BackgroundGradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Navy, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.DarkGreen, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.uiPanel1.Children.Add(this.txtUserName);
            this.uiPanel1.Children.Add(this.txtPwd);
            this.uiPanel1.Children.Add(this.btnLogin);
            this.uiPanel1.Children.Add(this.txtbxdummy);
            this.uiPanel1.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 0, 76, 0, 0, 240, 250);
            this.uiPanel1.Name = "uiPanel1";
            // 
            // txtUserName
            // 
            this.txtUserName.Buttons.Add(this.uiTextBoxButton3);
            this.txtUserName.CharacterCasing = Resco.UIElements.UITextBoxCharacterCasing.Upper;
            this.txtUserName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtUserName.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 17, 23, 0, 0, 206, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Text = "USER NAME";
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            this.txtUserName.GotFocus += new System.EventHandler(this.txtUserName_GotFocus);
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            this.txtUserName.LostFocus += new System.EventHandler(this.txtUserName_LostFocus);
            // 
            // uiTextBoxButton3
            // 
            this.uiTextBoxButton3.Action = Resco.UIElements.TextBoxAction.Clear;
            this.uiTextBoxButton3.BackColor = System.Drawing.Color.Transparent;
            this.uiTextBoxButton3.BorderThickness = 0;
            this.uiTextBoxButton3.HorizontalAlignment = Resco.UIElements.HAlignment.Right;
            this.uiTextBoxButton3.Name = "uiTextBoxButton3";
            this.uiTextBoxButton3.PressedBackground.BackColor = System.Drawing.Color.Transparent;
            this.uiTextBoxButton3.Size = new System.Drawing.Size(18, 18);
            this.uiTextBoxButton3.StateIcon = Resco.UIElements.StateIcon.Delete;
            this.uiTextBoxButton3.VisibleMode = Resco.UIElements.UITextBoxButtonVisibleMode.WhileEditing;
            // 
            // txtPwd
            // 
            this.txtPwd.Buttons.Add(this.uiTextBoxButton4);
            this.txtPwd.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPwd.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 17, 67, 0, 0, 206, 26);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.TabIndex = 4;
            this.txtPwd.Text = "PASSWORD";
            this.txtPwd.GotFocus += new System.EventHandler(this.txtPwd_GotFocus);
            this.txtPwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            this.txtPwd.ButtonClick += new Resco.UIElements.UITextBoxButtonEventHandler(this.txtPwd_ButtonClick);
            this.txtPwd.LostFocus += new System.EventHandler(this.txtPwd_LostFocus);
            // 
            // uiTextBoxButton4
            // 
            this.uiTextBoxButton4.Action = Resco.UIElements.TextBoxAction.Clear;
            this.uiTextBoxButton4.BackColor = System.Drawing.Color.Transparent;
            this.uiTextBoxButton4.BorderThickness = 0;
            this.uiTextBoxButton4.HorizontalAlignment = Resco.UIElements.HAlignment.Right;
            this.uiTextBoxButton4.Name = "uiTextBoxButton4";
            this.uiTextBoxButton4.PressedBackground.BackColor = System.Drawing.Color.Transparent;
            this.uiTextBoxButton4.Size = new System.Drawing.Size(18, 18);
            this.uiTextBoxButton4.StateIcon = Resco.UIElements.StateIcon.Delete;
            this.uiTextBoxButton4.VisibleMode = Resco.UIElements.UITextBoxButtonVisibleMode.WhileEditing;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderColor = System.Drawing.Color.Green;
            this.btnLogin.Enabled = false;
            this.btnLogin.FocusedBackground.BorderColor = System.Drawing.Color.Green;
            this.btnLogin.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Center, Resco.UIElements.VAlignment.Top, 0, 121, 0, 0, 111, 38);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedImage.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.PressedImage.Image")));
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Click += new Resco.UIElements.UIMouseEventHandler(this.btnLogin_Click);
            // 
            // txtbxdummy
            // 
            this.txtbxdummy.Buttons.Add(this.uiTextBoxButton1);
            this.txtbxdummy.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 2, 230, 0, 0, 28, 12);
            this.txtbxdummy.Name = "txtbxdummy";
            this.txtbxdummy.TabIndex = 5;
            this.txtbxdummy.Visible = false;
            // 
            // uiTextBoxButton1
            // 
            this.uiTextBoxButton1.Action = Resco.UIElements.TextBoxAction.Clear;
            this.uiTextBoxButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiTextBoxButton1.BorderThickness = 0;
            this.uiTextBoxButton1.HorizontalAlignment = Resco.UIElements.HAlignment.Right;
            this.uiTextBoxButton1.Name = "uiTextBoxButton1";
            this.uiTextBoxButton1.PressedBackground.BackColor = System.Drawing.Color.Transparent;
            this.uiTextBoxButton1.Size = new System.Drawing.Size(18, 18);
            this.uiTextBoxButton1.StateIcon = Resco.UIElements.StateIcon.Delete;
            this.uiTextBoxButton1.VisibleMode = Resco.UIElements.UITextBoxButtonVisibleMode.WhileEditing;
            // 
            // uiElementPanelControl1
            // 
            this.uiElementPanelControl1.Children.Add(this.uiPanel1);
            this.uiElementPanelControl1.Children.Add(this.imgIconMain);
            this.uiElementPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiElementPanelControl1.Name = "uiElementPanelControl1";
            this.uiElementPanelControl1.ScrollBarsMode = Resco.UIElements.ScrollBarsMode.Default;
            this.uiElementPanelControl1.ScrollBarsVisibility = System.Windows.Forms.ScrollBars.None;
            this.uiElementPanelControl1.Size = new System.Drawing.Size(240, 320);
            // 
            // imgIconMain
            // 
            this.imgIconMain.BackColor = System.Drawing.Color.Navy;
            this.imgIconMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgIconMain.BackgroundImage")));
            this.imgIconMain.BackgroundImageLayout = Resco.UIElements.ImageLayout.Fit;
            this.imgIconMain.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 0, 0, 0, 0, 240, 76);
            this.imgIconMain.Name = "imgIconMain";
            this.imgIconMain.TabIndex = 1;
            this.imgIconMain.Click += new Resco.UIElements.UIMouseEventHandler(this.imgIconMain_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.ControlBox = false;
            this.Controls.Add(this.uiElementPanelControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.uiElementPanelControl1.ResumeElementLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        /// <summary>
        /// Application main
        /// </summary>
        static void Main()
        {
            if (clsGlobals.gfLogin == null)
            {
                clsGlobals.gfLogin = new frmLogin();
            }
            Application.Run(clsGlobals.gfLogin);
        }

		/// <summary>
		/// Paint the form only if the splash screen is gone
		/// </summary>
		/// <param name="e">Paint event arguments</param>
		protected override void OnPaint(PaintEventArgs e)
		{
			if (splash != null)
				return;

			base.OnPaint (e);
		}

		/// <summary>
		/// Paint the form background only if the splash screen is gone
		/// </summary>
		/// <param name="e">Paint event arguments</param>
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			if (splash != null)
				return;

			base.OnPaintBackground (e);
		}

		/// <summary>
		/// Shuts down and cleans up the splash screen
		/// </summary>
		private void CloseSplash()
		{
			if (splash == null)
				return;

			// Shut down the splash screen
			splash.Invoke(new EventHandler(splash.KillMe));
			splash.Dispose();
			splash = null;
		}

		/// <summary>
		/// The form is ready so do our application specific loading and
		/// initialization
		/// </summary>
		/// <param name="sender">Sender of the event</param>
		/// <param name="e">Event arguments</param>
		private void MainForm_Load(object sender, System.EventArgs e)
		{
            //load the button images
            LoadBtnImage();

            if (!clsGlobals.bAppBeenLoaded)
            {

                // Create a new thread from which to start the splash screen form
                Thread splashThread = new Thread(new ThreadStart(StartSplash));
                splashThread.Start();

                // Pretend that our application is doing a bunch of loading and
                // initialization
                Thread.Sleep(kMinAmountOfSplashTime_ms / 2);

                // Sit and spin while we wait for the minimum timer interval if
                // the interval has not already passed
                while (splash.GetUpMilliseconds() < kMinAmountOfSplashTime_ms)
                {
                    Thread.Sleep(kSplashUpdateInterval_ms / 4);
                }

                // Close the splash screen
                CloseSplash();

                clsGlobals.bAppBeenLoaded = true;

                //connect to the database
                DoLocalDBConnect();



            }

            //set the focus to the dummy control
            //when the form starts up
            txtbxdummy.Focus();
            //txtEmpID.ForeColor = SystemColors.InactiveBorder;
		}

		/// <summary>
		/// Ensures that if the form is somehow closed before loading is complete,
		/// the splash form will be closed and released as well.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
		{
			// Make sure the splash screen is closed
			CloseSplash();

			base.OnClosing (e);
		}

        private void txtEmpID_GotFocus(object sender, EventArgs e)
        {
            //default bool status is false
            if (btxtemp == false)
            {
                //txtEmpID.Text = "";
                //txtEmpID.ForeColor = SystemColors.ControlText;
            }

        }
        private void txtEmpID_LostFocus(object sender, EventArgs e)
        {
            //if nothing has been entered yet. then
            if (btxtemp == false)
            {
                //if the textbox is empty then
                //if (txtEmpID.Text == "")
                //{
                //    txtEmpID.Text = "Employee ID";
                //    txtEmpID.ForeColor = SystemColors.InactiveBorder;
                //}
                //else
                //{
                //    //employee id has been entered
                //    btxtemp = true;
                //}
            }

        }

        private void DoLocalDBConnect()
        {
            clsDBMgrMain.Init();
        }

        private void txtPwd_LostFocus(object sender, EventArgs e)
        {
            //if nothing has been yet... then
            if (btxtpwd == false)
            {
                if (txtPwd.Text == "")
                {
                    txtPwd.Text = "Password";
                    txtPwd.ForeColor = SystemColors.InactiveBorder;
                }
                else
                {
                    btxtpwd = true;
                }

            }
            else
            {
                if((btxtpwd == true) && (txtPwd.Text == ""))
                {
                    btxtpwd = false;
                }
            }

            if (CheckTheButtonState())
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }

        }


        private void txtPwd_GotFocus(object sender, EventArgs e)
        {
            if (btxtpwd == false)
            {
                txtPwd.Text = "";
                txtPwd.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtUserName_GotFocus(object sender, EventArgs e)
        {
            if (btxtuid == false)
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = SystemColors.ControlText;
            }

            if (txtUserName.Text == "USER NAME")
            {
                txtUserName.Text = "";
            }
        }

        private void txtUserName_LostFocus(object sender, EventArgs e)
        {
            //if nothing has been entered yet.. then
            if (btxtuid == false)
            {
                if (txtUserName.Text == "")
                {
                    txtUserName.Text = "User Name";
                    txtUserName.ForeColor = SystemColors.InactiveBorder;
                }
                else
                {
                    btxtuid = true;
                }

            }

        }

        private void txtPwd_ButtonClick(object sender, Resco.UIElements.UITextBoxButtonEventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void DoAuthenticate()
        {

            clsGlobals.gUID = txtUserName.Text;
            //clsGlobals.gEmpId = txtEmpID.Text;

        }


        private void btnLogin_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                //set the values of the user name and employee id
                //clsGlobals.gEmpId = txtEmpID.Text.ToUpper();
                clsGlobals.gUID = txtUserName.Text.ToUpper();

                #region //TODO: LOGON PROCESSS AGAINST AUTHENTICATION MECHANISM......
                /**
                -
                -
                -
                -
                -
                -
                -
                -
                **/
                //load the main menu screen
                #endregion

                if (clsGlobals.gfMainMenuForm == null)
                {
                    //assign a new instance of the form
                    clsGlobals.gfMainMenuForm = new frmMainMenu();
                    clsGlobals.gfMainMenuForm.Show();


                }
                else
                {
                    //load the screen
                    clsGlobals.gfMainMenuForm.Show();

                    //hide the current screen
                    this.Hide();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured during log-on process " + ex.Message);
                return;
            }

            Cursor.Current = Cursors.Default;
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            if ((txtPwd.Text.Length >= 5)
                 && (txtPwd.Text != "Password"))
            {
                //if length of text is larger than
                //minimum then change the boolean value
                btxtpwd = true;

                //check state of the button bool values
                if (CheckTheButtonState())
                {
                    btnLogin.Enabled = true;
                }
            }
            else
            {
                btxtpwd = false;
                btnLogin.Enabled = false;
            }
        }

        private bool CheckTheButtonState()
        {
            bool bret = false;

            //the the various text boxes to see if the login
            //buton needs to be enabled;
            if ((btxtuid == true) && (btxtpwd == true))
            {
                bret = true;
            }
            else
            {
                bret = false;
            }

            //lets return
            return bret;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((txtUserName.Text.Length >= 5)
                     && (txtUserName.Text != "User Name"))
                {
                    //if length of text is larger than
                    //minimum then change the boolean value
                    btxtuid = true;

                    if (CheckTheButtonState())
                    {
                        btnLogin.Enabled = true;
                    }
                }
                else
                {
                    btxtuid = false;
                    btnLogin.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                return;
            }

            try
            {
                if (m_InMyTextChanged)
                    return; // Recursive!  We can bail quickly.  

                m_InMyTextChanged = true; // Prevent recursion when we change it.
                int selectionStart = txtUserName.SelectionStart;
                int selectionLength = txtUserName.SelectionLength;
                string originalText = txtUserName.Text;
                string newText = originalText.ToUpper();
                if (newText != originalText)
                {
                    txtUserName.Text = newText; // Will cause a new TextChanged event.
                    // Set the selection back *after* the assignment, which has reset them.
                    txtUserName.SelectionStart = selectionStart;
                    txtUserName.SelectionLength = selectionLength;
                }
                m_InMyTextChanged = false; // Allow it for next time.
            }
            catch (Exception ex)
            {
                return;
            }
        }

        
        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if ((txtEmpID.Text.Length >= 5) && (txtEmpID.Text != "Employee ID"))
                //{
                //    //if length of text is larger than
                //    //minimum then change the boolean value
                //    btxtemp = true;

                //    if (CheckTheButtonState())
                //    {
                //        btnLogin.Enabled = true;
                //    }
                //}
                //else
                //{
                //    btxtemp = false;
                //    btnLogin.Enabled = false;
                //}
            }
            catch (Exception ex)
            {


            }
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
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.mLogOnUp.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnLogin.Image = i;
                i = null;
                bmpimg = null;

                //BUTTON Logon image DOWN
                bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.mLogOnDown.jpg"));

                ////cast to image
                i = (Image)bmpimg;
                ////assign image to button
                btnLogin.PressedImage.Image = i;
                i = null;
                bmpimg = null;

                try
                {
                    bmpimg = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".img.mLogOnDisabled.jpg"));

                    //cast to image holder
                    i = (Image)bmpimg;
                    btnLogin.DisabledImage.Image = i;

                    i = null;
                    bmpimg = null;
                }
                catch (NullReferenceException nu)
                {
                    MessageBox.Show("error encountered during disabled image loadig instance");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered during logon image intance " + ex.Message);

                return;
            }
            #endregion


        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUserName.ForeColor = SystemColors.ControlText;
        }

        private void imgIconMain_Click(object sender, Resco.UIElements.UIMouseEventArgs e)
        {

        }
            
	}
}
