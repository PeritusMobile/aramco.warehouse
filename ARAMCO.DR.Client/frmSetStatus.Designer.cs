namespace ARAMCO.Client
{
    partial class frmSetStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetStatus));
            this.pnlBackground = new Resco.Controls.CommonControls.TouchPanel();
            this.cboSetStatus = new System.Windows.Forms.ComboBox();
            this.btnBack = new Resco.Controls.OutlookControls.ImageButton();
            this.uiElementPanelControl1 = new Resco.UIElements.Controls.UIElementPanelControl();
            this.uiImage1 = new Resco.UIElements.UIImage();
            this.lblSetStatus = new Resco.Controls.CommonControls.TransparentLabel();
            this.btnSave = new Resco.Controls.OutlookControls.ImageButton();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.uiElementPanelControl1.SuspendElementLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblSetStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.Controls.Add(this.cboSetStatus);
            this.pnlBackground.Controls.Add(this.btnBack);
            this.pnlBackground.Controls.Add(this.uiElementPanelControl1);
            this.pnlBackground.Controls.Add(this.lblSetStatus);
            this.pnlBackground.Controls.Add(this.btnSave);
            this.pnlBackground.GradientBackColor = new Resco.Controls.CommonControls.GradientColor(System.Drawing.Color.MidnightBlue, System.Drawing.Color.Green, Resco.Controls.CommonControls.FillDirection.Horizontal);
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(240, 320);
            // 
            // cboSetStatus
            // 
            this.cboSetStatus.Items.Add("PLEASE SELECT A STATUS");
            this.cboSetStatus.Items.Add("On Route");
            this.cboSetStatus.Items.Add("Truck Broken-down");
            this.cboSetStatus.Items.Add("On A Break");
            this.cboSetStatus.Items.Add("In Traffic");
            this.cboSetStatus.Items.Add("Reached Destination");
            this.cboSetStatus.Location = new System.Drawing.Point(27, 81);
            this.cboSetStatus.Name = "cboSetStatus";
            this.cboSetStatus.Size = new System.Drawing.Size(187, 22);
            this.cboSetStatus.TabIndex = 14;
            this.cboSetStatus.SelectedIndexChanged += new System.EventHandler(this.cboSetStatus_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BorderColor = System.Drawing.Color.White;
            this.btnBack.BorderCornerSize = 0;
            this.btnBack.ButtonStyle = Resco.Controls.OutlookControls.ImageButton.ButtonType.GradientImageButton;
            this.btnBack.DisabledForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnBack.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.GradientColors = new Resco.Controls.OutlookControls.GradientColor(System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(163)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(86)))), ((int)(((byte)(146))))), System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(112))))), System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(167))))), 50, 50, Resco.Controls.OutlookControls.FillDirection.Vertical);
            this.btnBack.GradientColorsPressed = new Resco.Controls.OutlookControls.GradientColor(System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, 50, 50, Resco.Controls.OutlookControls.FillDirection.Horizontal);
            this.btnBack.ImageDefault = ((System.Drawing.Image)(resources.GetObject("btnBack.ImageDefault")));
            this.btnBack.ImagePressed = ((System.Drawing.Image)(resources.GetObject("btnBack.ImagePressed")));
            this.btnBack.Location = new System.Drawing.Point(-2, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedBackColor = System.Drawing.Color.Transparent;
            this.btnBack.PressedBorderColor = System.Drawing.Color.Azure;
            this.btnBack.PressedForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Size = new System.Drawing.Size(49, 22);
            this.btnBack.StretchImage = true;
            this.btnBack.TabIndex = 13;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // uiElementPanelControl1
            // 
            this.uiElementPanelControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiElementPanelControl1.BackgroundImage")));
            this.uiElementPanelControl1.Children.Add(this.uiImage1);
            this.uiElementPanelControl1.Location = new System.Drawing.Point(215, 3);
            this.uiElementPanelControl1.Name = "uiElementPanelControl1";
            this.uiElementPanelControl1.Size = new System.Drawing.Size(22, 14);
            this.uiElementPanelControl1.TabIndex = 2;
            // 
            // uiImage1
            // 
            this.uiImage1.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 186, 8, 0, 0, 100, 100);
            this.uiImage1.Name = "uiImage1";
            // 
            // lblSetStatus
            // 
            this.lblSetStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.lblSetStatus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSetStatus.Location = new System.Drawing.Point(62, 0);
            this.lblSetStatus.Name = "lblSetStatus";
            this.lblSetStatus.Size = new System.Drawing.Size(117, 22);
            this.lblSetStatus.Text = "Set Driver Status";
            this.lblSetStatus.ParentChanged += new System.EventHandler(this.transparentLabel1_ParentChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.btnSave.ImageDefault = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageDefault")));
            this.btnSave.ImagePressed = ((System.Drawing.Image)(resources.GetObject("btnSave.ImagePressed")));
            this.btnSave.Location = new System.Drawing.Point(65, 127);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 33);
            this.btnSave.TabIndex = 4;
            // 
            // frmSetStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBackground);
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimizeBox = false;
            this.Name = "frmSetStatus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSetStatus_Load);
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.uiElementPanelControl1.ResumeElementLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblSetStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Resco.Controls.CommonControls.TouchPanel pnlBackground;
        private Resco.Controls.CommonControls.TransparentLabel lblSetStatus;
        private Resco.UIElements.Controls.UIElementPanelControl uiElementPanelControl1;
        private Resco.UIElements.UIImage uiImage1;
        private Resco.Controls.OutlookControls.ImageButton btnBack;
        private System.Windows.Forms.ComboBox cboSetStatus;
        private Resco.Controls.OutlookControls.ImageButton btnSave;

    }
}