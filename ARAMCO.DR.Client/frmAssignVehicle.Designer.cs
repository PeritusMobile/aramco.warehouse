namespace ARAMCO.Client
{
    partial class frmAssignVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssignVehicle));
            this.touchPanel1 = new Resco.Controls.CommonControls.TouchPanel();
            this.cboVehicleCode = new System.Windows.Forms.ComboBox();
            this.btnBack = new Resco.Controls.OutlookControls.ImageButton();
            this.uiElementPanelControl1 = new Resco.UIElements.Controls.UIElementPanelControl();
            this.uiImage1 = new Resco.UIElements.UIImage();
            this.lblHeader = new Resco.Controls.CommonControls.TransparentLabel();
            this.touchPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.uiElementPanelControl1.SuspendElementLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // touchPanel1
            // 
            this.touchPanel1.Controls.Add(this.cboVehicleCode);
            this.touchPanel1.Controls.Add(this.btnBack);
            this.touchPanel1.Controls.Add(this.uiElementPanelControl1);
            this.touchPanel1.Controls.Add(this.lblHeader);
            this.touchPanel1.GradientBackColor = new Resco.Controls.CommonControls.GradientColor(System.Drawing.Color.MidnightBlue, System.Drawing.Color.Green, Resco.Controls.CommonControls.FillDirection.Horizontal);
            this.touchPanel1.Location = new System.Drawing.Point(0, 0);
            this.touchPanel1.Name = "touchPanel1";
            this.touchPanel1.Size = new System.Drawing.Size(240, 320);
            // 
            // cboVehicleCode
            // 
            this.cboVehicleCode.Location = new System.Drawing.Point(27, 81);
            this.cboVehicleCode.Name = "cboVehicleCode";
            this.cboVehicleCode.Size = new System.Drawing.Size(187, 22);
            this.cboVehicleCode.TabIndex = 14;
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
            this.btnBack.TabIndex = 12;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // uiElementPanelControl1
            // 
            this.uiElementPanelControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiElementPanelControl1.BackgroundImage")));
            this.uiElementPanelControl1.Children.Add(this.uiImage1);
            this.uiElementPanelControl1.Location = new System.Drawing.Point(215, 3);
            this.uiElementPanelControl1.Name = "uiElementPanelControl1";
            this.uiElementPanelControl1.Size = new System.Drawing.Size(22, 14);
            this.uiElementPanelControl1.TabIndex = 1;
            this.uiElementPanelControl1.Click += new System.EventHandler(this.uiElementPanelControl1_Click);
            // 
            // uiImage1
            // 
            this.uiImage1.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 186, 8, 0, 0, 100, 100);
            this.uiImage1.Name = "uiImage1";
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblHeader.Location = new System.Drawing.Point(69, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(102, 22);
            this.lblHeader.Text = "Assign Vehicle";
            this.lblHeader.ParentChanged += new System.EventHandler(this.transparentLabel1_ParentChanged);
            // 
            // frmAssignVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.ControlBox = false;
            this.Controls.Add(this.touchPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimizeBox = false;
            this.Name = "frmAssignVehicle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAssignVehicle_Load);
            this.touchPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.uiElementPanelControl1.ResumeElementLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Resco.Controls.CommonControls.TouchPanel touchPanel1;
        private Resco.Controls.CommonControls.TransparentLabel lblHeader;
        private Resco.UIElements.Controls.UIElementPanelControl uiElementPanelControl1;
        private Resco.UIElements.UIImage uiImage1;
        private Resco.Controls.OutlookControls.ImageButton btnBack;
        private System.Windows.Forms.ComboBox cboVehicleCode;


    }
}