namespace ARAMCO.Client
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.mainPnl = new Resco.UIElements.UIPanel();
            this.btnSettings = new Resco.UIElements.UIButton();
            this.lblHeader = new Resco.UIElements.UILinkLabel();
            this.uiImage1 = new Resco.UIElements.UIImage();
            this.uiElementPanelControl1 = new Resco.UIElements.Controls.UIElementPanelControl();
            this.btnBack = new Resco.Controls.OutlookControls.ImageButton();
            this.btnSwitchLanguage = new Resco.UIElements.UIButton();
            this.uiElementPanelControl1.SuspendLayout();
            this.uiElementPanelControl1.SuspendElementLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPnl
            // 
            this.mainPnl.BackColor = System.Drawing.Color.Navy;
            this.mainPnl.BackgroundGradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Navy, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.DarkGreen, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.mainPnl.Children.Add(this.btnSettings);
            this.mainPnl.Children.Add(this.lblHeader);
            this.mainPnl.Children.Add(this.uiImage1);
            this.mainPnl.Children.Add(this.btnSwitchLanguage);
            this.mainPnl.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 0, 0, 0, 0, 240, 320);
            this.mainPnl.Name = "mainPnl";
            // 
            // btnSettings
            // 
            this.btnSettings.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.btnSettings.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 63, 274, 0, 0, 111, 38);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.PressedBackground.Gradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Silver, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightSteelBlue, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.btnSettings.TabIndex = 4;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 91, 3, 0, 0, 62, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "SETTINGS";
            // 
            // uiImage1
            // 
            this.uiImage1.BackColor = System.Drawing.Color.White;
            this.uiImage1.BackgroundGradient = new Resco.Drawing.GradientColor(System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Color.White, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.uiImage1.Image = ((System.Drawing.Image)(resources.GetObject("uiImage1.Image")));
            this.uiImage1.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 208, 3, 0, 0, 30, 16);
            this.uiImage1.Name = "uiImage1";
            this.uiImage1.TabIndex = 1;
            // 
            // uiElementPanelControl1
            // 
            this.uiElementPanelControl1.Children.Add(this.mainPnl);
            this.uiElementPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiElementPanelControl1.Name = "uiElementPanelControl1";
            this.uiElementPanelControl1.Size = new System.Drawing.Size(240, 320);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BorderColor = System.Drawing.Color.White;
            this.btnBack.BorderCornerSize = 0;
            this.btnBack.DisabledForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnBack.FocusedBorderColor = System.Drawing.Color.Blue;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.GradientColors = new Resco.Controls.OutlookControls.GradientColor(System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(163)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(86)))), ((int)(((byte)(146))))), System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(112))))), System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(167))))), 50, 50, Resco.Controls.OutlookControls.FillDirection.Vertical);
            this.btnBack.GradientColorsPressed = new Resco.Controls.OutlookControls.GradientColor(System.Drawing.Color.SkyBlue, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightGray, 50, 50, Resco.Controls.OutlookControls.FillDirection.Horizontal);
            this.btnBack.Location = new System.Drawing.Point(2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 22);
            this.btnBack.TabIndex = 17;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnSwitchLanguage
            // 
            this.btnSwitchLanguage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSwitchLanguage.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnSwitchLanguage.BorderThickness = 2;
            this.btnSwitchLanguage.FocusedBackground.BorderColor = System.Drawing.Color.White;
            this.btnSwitchLanguage.FocusedBackground.BorderThickness = 1;
            this.btnSwitchLanguage.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular);
            this.btnSwitchLanguage.ForeColor = System.Drawing.Color.White;
            this.btnSwitchLanguage.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 61, 72, 0, 0, 111, 38);
            this.btnSwitchLanguage.Name = "btnSwitchLanguage";
            this.btnSwitchLanguage.PressedBackground.Gradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Silver, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightSteelBlue, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.btnSwitchLanguage.TabIndex = 4;
            this.btnSwitchLanguage.Text = "Change - Language";
            this.btnSwitchLanguage.Click += new Resco.UIElements.UIMouseEventHandler(this.btnSwitchLanguage_Click_1);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.ControlBox = false;
            this.Controls.Add(this.uiElementPanelControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.uiElementPanelControl1.ResumeLayout(false);
            this.uiElementPanelControl1.ResumeElementLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Resco.UIElements.UIPanel mainPnl;
        private Resco.UIElements.Controls.UIElementPanelControl uiElementPanelControl1;
        private Resco.UIElements.UIButton btnSettings;
        private Resco.UIElements.UILinkLabel lblHeader;
        private Resco.UIElements.UIImage uiImage1;
        private Resco.Controls.OutlookControls.ImageButton btnBack;
        private Resco.UIElements.UIButton btnSwitchLanguage;
    }
}