namespace ARAMCO.Client
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.pnlMain = new Resco.UIElements.UIPanel();
            this.pnlLoad = new Resco.UIElements.UIPanel();
            this.btnLoadCustomer = new Resco.UIElements.UIButton();
            this.btnLoadVendor = new Resco.UIElements.UIButton();
            this.btnBackLoad = new Resco.UIElements.UIButton();
            this.uiImage1 = new Resco.UIElements.UIImage();
            this.lblHeaderLoad = new Resco.UIElements.UILabel();
            this.btnDiscrepancy = new Resco.UIElements.UIButton();
            this.btnDeliveryInfo = new Resco.UIElements.UIButton();
            this.btnStagingInventory = new Resco.UIElements.UIButton();
            this.btnDeconsolidate = new Resco.UIElements.UIButton();
            this.btnConsolidate = new Resco.UIElements.UIButton();
            this.btnLogout = new Resco.UIElements.UIButton();
            this.btnSettings = new Resco.UIElements.UIButton();
            this.lblHeader = new Resco.UIElements.UILabel();
            this.lblUser = new Resco.UIElements.UILabel();
            this.btnUnload = new Resco.UIElements.UIButton();
            this.btnLoad = new Resco.UIElements.UIButton();
            this.uiElementPanelControl1 = new Resco.UIElements.Controls.UIElementPanelControl();
            this.pnlUnload = new Resco.UIElements.UIPanel();
            this.btnUnloadVendor = new Resco.UIElements.UIButton();
            this.btnUnloadWarehouse = new Resco.UIElements.UIButton();
            this.btnUnloadLinehaul = new Resco.UIElements.UIButton();
            this.btnBackUnload = new Resco.UIElements.UIButton();
            this.btnUnloadPort = new Resco.UIElements.UIButton();
            this.imgIcon = new Resco.UIElements.UIImage();
            this.uiLabel1 = new Resco.UIElements.UILabel();
            this.uiElementPanelControl1.SuspendElementLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Navy;
            this.pnlMain.BackgroundGradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Navy, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.DarkGreen, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.pnlMain.BorderColor = System.Drawing.Color.Green;
            this.pnlMain.Children.Add(this.pnlLoad);
            this.pnlMain.Children.Add(this.btnDiscrepancy);
            this.pnlMain.Children.Add(this.btnDeliveryInfo);
            this.pnlMain.Children.Add(this.btnStagingInventory);
            this.pnlMain.Children.Add(this.btnDeconsolidate);
            this.pnlMain.Children.Add(this.btnConsolidate);
            this.pnlMain.Children.Add(this.btnLogout);
            this.pnlMain.Children.Add(this.btnSettings);
            this.pnlMain.Children.Add(this.lblHeader);
            this.pnlMain.Children.Add(this.lblUser);
            this.pnlMain.Children.Add(this.btnUnload);
            this.pnlMain.Children.Add(this.btnLoad);
            this.pnlMain.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, -1, 0, 0, 0, 240, 320);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.TabIndex = 15;
            // 
            // pnlLoad
            // 
            this.pnlLoad.BackColor = System.Drawing.Color.Navy;
            this.pnlLoad.BackgroundGradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Navy, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.pnlLoad.Children.Add(this.btnLoadCustomer);
            this.pnlLoad.Children.Add(this.btnLoadVendor);
            this.pnlLoad.Children.Add(this.btnBackLoad);
            this.pnlLoad.Children.Add(this.uiImage1);
            this.pnlLoad.Children.Add(this.lblHeaderLoad);
            this.pnlLoad.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Stretch, Resco.UIElements.VAlignment.Stretch, 0, 0, 0, 0, 240, 320);
            this.pnlLoad.Name = "pnlLoad";
            this.pnlLoad.TabIndex = 13;
            this.pnlLoad.Visible = false;
            // 
            // btnLoadCustomer
            // 
            this.btnLoadCustomer.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnLoadCustomer.BorderThickness = 2;
            this.btnLoadCustomer.FocusedBackground.BorderColor = System.Drawing.Color.White;
            this.btnLoadCustomer.FocusedBackground.BorderThickness = 1;
            this.btnLoadCustomer.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnLoadCustomer.ForeColor = System.Drawing.Color.White;
            this.btnLoadCustomer.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 65, 48, 0, 0, 111, 38);
            this.btnLoadCustomer.Name = "btnLoadCustomer";
            this.btnLoadCustomer.PressedBackground.Gradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Silver, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightSteelBlue, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.btnLoadCustomer.PressedImage.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadCustomer.PressedImage.Image")));
            this.btnLoadCustomer.TabIndex = 12;
            this.btnLoadCustomer.TextImageRelation = Resco.UIElements.TextImageRelation.Overlay;
            this.btnLoadCustomer.TextPadding = new Resco.UIElements.Thickness(2, 0, 0, 0);
            this.btnLoadCustomer.Click += new Resco.UIElements.UIMouseEventHandler(this.btnLoadCustomer_Click);
            // 
            // btnLoadVendor
            // 
            this.btnLoadVendor.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnLoadVendor.BorderThickness = 2;
            this.btnLoadVendor.FocusedBackground.BorderColor = System.Drawing.Color.White;
            this.btnLoadVendor.FocusedBackground.BorderThickness = 1;
            this.btnLoadVendor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnLoadVendor.ForeColor = System.Drawing.Color.White;
            this.btnLoadVendor.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 65, 91, 0, 0, 111, 38);
            this.btnLoadVendor.Name = "btnLoadVendor";
            this.btnLoadVendor.PressedBackground.Gradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Silver, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightSteelBlue, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.btnLoadVendor.TabIndex = 13;
            this.btnLoadVendor.Click += new Resco.UIElements.UIMouseEventHandler(this.btnLoadVendor_Click);
            // 
            // btnBackLoad
            // 
            this.btnBackLoad.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnBackLoad.FocusedBackground.BorderColor = System.Drawing.Color.Transparent;
            this.btnBackLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnBackLoad.Image")));
            this.btnBackLoad.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 4, 2, 0, 0, 49, 22);
            this.btnBackLoad.Name = "btnBackLoad";
            this.btnBackLoad.TabIndex = 13;
            this.btnBackLoad.Click += new Resco.UIElements.UIMouseEventHandler(this.btnBackLoad_Click);
            // 
            // uiImage1
            // 
            this.uiImage1.BackColor = System.Drawing.Color.White;
            this.uiImage1.Image = ((System.Drawing.Image)(resources.GetObject("uiImage1.Image")));
            this.uiImage1.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 209, 3, 0, 0, 30, 16);
            this.uiImage1.Name = "uiImage1";
            this.uiImage1.TabIndex = 14;
            // 
            // lblHeaderLoad
            // 
            this.lblHeaderLoad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblHeaderLoad.ForeColor = System.Drawing.Color.White;
            this.lblHeaderLoad.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 83, 2, 0, 0, 76, 18);
            this.lblHeaderLoad.Name = "lblHeaderLoad";
            this.lblHeaderLoad.TabIndex = 1;
            this.lblHeaderLoad.Text = "LOAD MENU";
            // 
            // btnDiscrepancy
            // 
            this.btnDiscrepancy.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnDiscrepancy.FocusedBackground.BorderColor = System.Drawing.Color.White;
            this.btnDiscrepancy.FocusedBackground.BorderThickness = 1;
            this.btnDiscrepancy.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnDiscrepancy.ForeColor = System.Drawing.Color.White;
            this.btnDiscrepancy.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Right, Resco.UIElements.VAlignment.Top, 0, 185, 6, 0, 111, 38);
            this.btnDiscrepancy.Name = "btnDiscrepancy";
            this.btnDiscrepancy.PressedBackground.Gradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Silver, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightSteelBlue, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.btnDiscrepancy.TabIndex = 8;
            this.btnDiscrepancy.Click += new Resco.UIElements.UIMouseEventHandler(this.btnDiscrepancy_Click);
            // 
            // btnDeliveryInfo
            // 
            this.btnDeliveryInfo.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnDeliveryInfo.FocusedBackground.BorderColor = System.Drawing.Color.White;
            this.btnDeliveryInfo.FocusedBackground.BorderThickness = 1;
            this.btnDeliveryInfo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnDeliveryInfo.ForeColor = System.Drawing.Color.White;
            this.btnDeliveryInfo.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 123, 142, 0, 0, 111, 38);
            this.btnDeliveryInfo.Name = "btnDeliveryInfo";
            this.btnDeliveryInfo.PressedBackground.Gradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Silver, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightSteelBlue, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.btnDeliveryInfo.TabIndex = 6;
            this.btnDeliveryInfo.Click += new Resco.UIElements.UIMouseEventHandler(this.btnDeliveryInfo_Click);
            // 
            // btnStagingInventory
            // 
            this.btnStagingInventory.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnStagingInventory.FocusedBackground.BorderColor = System.Drawing.Color.White;
            this.btnStagingInventory.FocusedBackground.BorderThickness = 1;
            this.btnStagingInventory.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnStagingInventory.ForeColor = System.Drawing.Color.White;
            this.btnStagingInventory.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 7, 142, 0, 0, 111, 38);
            this.btnStagingInventory.Name = "btnStagingInventory";
            this.btnStagingInventory.PressedBackground.Gradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Silver, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightSteelBlue, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.btnStagingInventory.TabIndex = 5;
            this.btnStagingInventory.Click += new Resco.UIElements.UIMouseEventHandler(this.btnStagingInventory_Click);
            // 
            // btnDeconsolidate
            // 
            this.btnDeconsolidate.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnDeconsolidate.FocusedBackground.BorderColor = System.Drawing.Color.White;
            this.btnDeconsolidate.FocusedBackground.BorderThickness = 1;
            this.btnDeconsolidate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnDeconsolidate.ForeColor = System.Drawing.Color.White;
            this.btnDeconsolidate.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 123, 99, 0, 0, 111, 38);
            this.btnDeconsolidate.Name = "btnDeconsolidate";
            this.btnDeconsolidate.PressedBackground.Gradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Silver, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightSteelBlue, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.btnDeconsolidate.TabIndex = 4;
            this.btnDeconsolidate.Click += new Resco.UIElements.UIMouseEventHandler(this.btnDeconsolidate_Click);
            // 
            // btnConsolidate
            // 
            this.btnConsolidate.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnConsolidate.FocusedBackground.BorderColor = System.Drawing.Color.White;
            this.btnConsolidate.FocusedBackground.BorderThickness = 1;
            this.btnConsolidate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnConsolidate.ForeColor = System.Drawing.Color.White;
            this.btnConsolidate.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 7, 99, 0, 0, 111, 38);
            this.btnConsolidate.Name = "btnConsolidate";
            this.btnConsolidate.PressedBackground.Gradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Silver, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightSteelBlue, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.btnConsolidate.TabIndex = 3;
            this.btnConsolidate.Click += new Resco.UIElements.UIMouseEventHandler(this.btnConsolidate_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnLogout.FocusedBackground.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FocusedBackground.BorderThickness = 1;
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 7, 185, 0, 0, 111, 38);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedBackground.Gradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Silver, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightSteelBlue, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Click += new Resco.UIElements.UIMouseEventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnSettings.FocusedBackground.BorderColor = System.Drawing.Color.White;
            this.btnSettings.FocusedBackground.BorderThickness = 1;
            this.btnSettings.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 7, 228, 0, 0, 111, 38);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.PressedBackground.Gradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Silver, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightSteelBlue, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Click += new Resco.UIElements.UIMouseEventHandler(this.btnSettings_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 54, 1, 0, 0, 150, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "MDC \\ MSC - Main Menu";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 81, 29, 0, 0, 79, 18);
            this.lblUser.Name = "lblUser";
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "[User Name]";
            // 
            // btnUnload
            // 
            this.btnUnload.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnUnload.FocusedBackground.BorderColor = System.Drawing.Color.White;
            this.btnUnload.FocusedBackground.BorderThickness = 1;
            this.btnUnload.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnUnload.ForeColor = System.Drawing.Color.White;
            this.btnUnload.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 7, 56, 0, 0, 111, 38);
            this.btnUnload.Name = "btnUnload";
            this.btnUnload.PressedBackground.Gradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Silver, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightSteelBlue, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.btnUnload.PressedImage.Image = ((System.Drawing.Image)(resources.GetObject("btnUnload.PressedImage.Image")));
            this.btnUnload.TabIndex = 1;
            this.btnUnload.TextImageRelation = Resco.UIElements.TextImageRelation.Overlay;
            this.btnUnload.TextPadding = new Resco.UIElements.Thickness(2, 0, 0, 0);
            this.btnUnload.Click += new Resco.UIElements.UIMouseEventHandler(this.btnUnloadSupplier_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnLoad.FocusedBackground.BorderColor = System.Drawing.Color.White;
            this.btnLoad.FocusedBackground.BorderThickness = 1;
            this.btnLoad.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 123, 56, 0, 0, 111, 38);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.PressedBackground.Gradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Silver, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightSteelBlue, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.btnLoad.PressedImage.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.PressedImage.Image")));
            this.btnLoad.TabIndex = 2;
            this.btnLoad.TextImageRelation = Resco.UIElements.TextImageRelation.Overlay;
            this.btnLoad.TextPadding = new Resco.UIElements.Thickness(2, 0, 0, 0);
            this.btnLoad.Click += new Resco.UIElements.UIMouseEventHandler(this.btnLoadSupplier_Click);
            // 
            // uiElementPanelControl1
            // 
            this.uiElementPanelControl1.Children.Add(this.pnlUnload);
            this.uiElementPanelControl1.Children.Add(this.pnlMain);
            this.uiElementPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiElementPanelControl1.Name = "uiElementPanelControl1";
            this.uiElementPanelControl1.Size = new System.Drawing.Size(240, 320);
            // 
            // pnlUnload
            // 
            this.pnlUnload.BackColor = System.Drawing.Color.Navy;
            this.pnlUnload.BackgroundGradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Navy, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.pnlUnload.Children.Add(this.btnUnloadVendor);
            this.pnlUnload.Children.Add(this.btnUnloadWarehouse);
            this.pnlUnload.Children.Add(this.btnUnloadLinehaul);
            this.pnlUnload.Children.Add(this.btnBackUnload);
            this.pnlUnload.Children.Add(this.btnUnloadPort);
            this.pnlUnload.Children.Add(this.imgIcon);
            this.pnlUnload.Children.Add(this.uiLabel1);
            this.pnlUnload.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Stretch, Resco.UIElements.VAlignment.Stretch, 0, 0, 0, 0, 240, 320);
            this.pnlUnload.Name = "pnlUnload";
            this.pnlUnload.TabIndex = 14;
            this.pnlUnload.Visible = false;
            // 
            // btnUnloadVendor
            // 
            this.btnUnloadVendor.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnUnloadVendor.BorderThickness = 2;
            this.btnUnloadVendor.FocusedBackground.BorderColor = System.Drawing.Color.White;
            this.btnUnloadVendor.FocusedBackground.BorderThickness = 1;
            this.btnUnloadVendor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnUnloadVendor.ForeColor = System.Drawing.Color.White;
            this.btnUnloadVendor.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 65, 48, 0, 0, 111, 38);
            this.btnUnloadVendor.Name = "btnUnloadVendor";
            this.btnUnloadVendor.PressedBackground.Gradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Silver, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightSteelBlue, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.btnUnloadVendor.PressedImage.Image = ((System.Drawing.Image)(resources.GetObject("btnUnloadVendor.PressedImage.Image")));
            this.btnUnloadVendor.TabIndex = 1;
            this.btnUnloadVendor.TextImageRelation = Resco.UIElements.TextImageRelation.Overlay;
            this.btnUnloadVendor.TextPadding = new Resco.UIElements.Thickness(2, 0, 0, 0);
            this.btnUnloadVendor.Click += new Resco.UIElements.UIMouseEventHandler(this.btnUnloadVendor_Click);
            // 
            // btnUnloadWarehouse
            // 
            this.btnUnloadWarehouse.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnUnloadWarehouse.BorderThickness = 2;
            this.btnUnloadWarehouse.FocusedBackground.BorderColor = System.Drawing.Color.White;
            this.btnUnloadWarehouse.FocusedBackground.BorderThickness = 1;
            this.btnUnloadWarehouse.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnUnloadWarehouse.ForeColor = System.Drawing.Color.White;
            this.btnUnloadWarehouse.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 65, 92, 0, 0, 111, 38);
            this.btnUnloadWarehouse.Name = "btnUnloadWarehouse";
            this.btnUnloadWarehouse.PressedBackground.Gradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Silver, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightSteelBlue, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.btnUnloadWarehouse.TabIndex = 2;
            this.btnUnloadWarehouse.Click += new Resco.UIElements.UIMouseEventHandler(this.btnUnloadWarehouse_Click);
            // 
            // btnUnloadLinehaul
            // 
            this.btnUnloadLinehaul.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnUnloadLinehaul.BorderThickness = 2;
            this.btnUnloadLinehaul.FocusedBackground.BorderColor = System.Drawing.Color.White;
            this.btnUnloadLinehaul.FocusedBackground.BorderThickness = 1;
            this.btnUnloadLinehaul.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnUnloadLinehaul.ForeColor = System.Drawing.Color.White;
            this.btnUnloadLinehaul.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 65, 135, 0, 0, 111, 38);
            this.btnUnloadLinehaul.Name = "btnUnloadLinehaul";
            this.btnUnloadLinehaul.PressedBackground.Gradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Silver, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightSteelBlue, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.btnUnloadLinehaul.TabIndex = 3;
            this.btnUnloadLinehaul.Click += new Resco.UIElements.UIMouseEventHandler(this.btnUnloadLinehaul_Click);
            // 
            // btnBackUnload
            // 
            this.btnBackUnload.BorderColor = System.Drawing.Color.White;
            this.btnBackUnload.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 2, 2, 0, 0, 48, 22);
            this.btnBackUnload.Name = "btnBackUnload";
            this.btnBackUnload.TabIndex = 5;
            this.btnBackUnload.Click += new Resco.UIElements.UIMouseEventHandler(this.btnBackUnload_Click);
            // 
            // btnUnloadPort
            // 
            this.btnUnloadPort.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnUnloadPort.BorderThickness = 2;
            this.btnUnloadPort.FocusedBackground.BorderColor = System.Drawing.Color.White;
            this.btnUnloadPort.FocusedBackground.BorderThickness = 1;
            this.btnUnloadPort.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnUnloadPort.ForeColor = System.Drawing.Color.White;
            this.btnUnloadPort.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 65, 178, 0, 0, 111, 38);
            this.btnUnloadPort.Name = "btnUnloadPort";
            this.btnUnloadPort.PressedBackground.Gradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Silver, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightSteelBlue, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.btnUnloadPort.TabIndex = 4;
            this.btnUnloadPort.Click += new Resco.UIElements.UIMouseEventHandler(this.btnUnloadPort_Click);
            // 
            // imgIcon
            // 
            this.imgIcon.BackColor = System.Drawing.Color.White;
            this.imgIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgIcon.Image")));
            this.imgIcon.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 208, 3, 0, 0, 30, 16);
            this.imgIcon.Name = "imgIcon";
            this.imgIcon.TabIndex = 14;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 72, 3, 0, 0, 95, 18);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "UNLOAD MENU";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.uiElementPanelControl1);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmMainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMainMenu_KeyDown);
            this.uiElementPanelControl1.ResumeElementLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Resco.UIElements.UIPanel pnlMain;
        private Resco.UIElements.Controls.UIElementPanelControl uiElementPanelControl1;
        private Resco.UIElements.UIButton btnDiscrepancy;
        private Resco.UIElements.UIButton btnDeliveryInfo;
        private Resco.UIElements.UIButton btnStagingInventory;
        private Resco.UIElements.UIButton btnDeconsolidate;
        private Resco.UIElements.UIButton btnConsolidate;
        private Resco.UIElements.UIButton btnLogout;
        private Resco.UIElements.UIButton btnSettings;
        private Resco.UIElements.UILabel lblHeader;
        private Resco.UIElements.UILabel lblUser;
        private Resco.UIElements.UIButton btnUnload;
        private Resco.UIElements.UIButton btnLoad;
        private Resco.UIElements.UIPanel pnlLoad;
        private Resco.UIElements.UIButton btnLoadCustomer;
        private Resco.UIElements.UIButton btnLoadVendor;
        private Resco.UIElements.UIButton btnBackLoad;
        private Resco.UIElements.UIPanel pnlUnload;
        private Resco.UIElements.UIButton btnUnloadVendor;
        private Resco.UIElements.UIButton btnUnloadWarehouse;
        private Resco.UIElements.UIButton btnUnloadLinehaul;
        private Resco.UIElements.UIButton btnBackUnload;
        private Resco.UIElements.UIButton btnUnloadPort;
        private Resco.UIElements.UIImage imgIcon;
        private Resco.UIElements.UIImage uiImage1;
        private Resco.UIElements.UILabel uiLabel1;
        private Resco.UIElements.UILabel lblHeaderLoad;

    }
}