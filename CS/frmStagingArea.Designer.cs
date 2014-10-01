namespace ARAMCO.Client
{
    partial class frmStagingArea
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
            this.pnlMain = new Resco.UIElements.UIPanel();
            this.uiElementPanelControl1 = new Resco.UIElements.Controls.UIElementPanelControl();
            this.btnBack = new Resco.Controls.OutlookControls.ImageButton();
            this.uiElementPanelControl1.SuspendLayout();
            this.uiElementPanelControl1.SuspendElementLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Navy;
            this.pnlMain.BackgroundGradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Navy, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.pnlMain.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 0, 0, 0, 0, 240, 320);
            this.pnlMain.Name = "pnlMain";
            // 
            // uiElementPanelControl1
            // 
            this.uiElementPanelControl1.Children.Add(this.pnlMain);
            this.uiElementPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiElementPanelControl1.Name = "uiElementPanelControl1";
            this.uiElementPanelControl1.Size = new System.Drawing.Size(240, 320);
            // 
            // btnBack
            // 
            this.btnBack.BorderColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderCornerSize = 0;
            this.btnBack.ButtonStyle = Resco.Controls.OutlookControls.ImageButton.ButtonType.GradientImageButton;
            this.btnBack.DisabledForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnBack.FocusedBorderColor = System.Drawing.Color.Blue;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.GradientColors = new Resco.Controls.OutlookControls.GradientColor(System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(163)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(86)))), ((int)(((byte)(146))))), System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(52)))), ((int)(((byte)(112))))), System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(167))))), 50, 50, Resco.Controls.OutlookControls.FillDirection.Vertical);
            this.btnBack.GradientColorsPressed = new Resco.Controls.OutlookControls.GradientColor(System.Drawing.Color.SkyBlue, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.LightGray, 50, 50, Resco.Controls.OutlookControls.FillDirection.Horizontal);
            this.btnBack.Location = new System.Drawing.Point(2, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 22);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "<<";
            // 
            // frmStagingArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.uiElementPanelControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmStagingArea";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.uiElementPanelControl1.ResumeLayout(false);
            this.uiElementPanelControl1.ResumeElementLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Resco.UIElements.UIPanel pnlMain;
        private Resco.UIElements.Controls.UIElementPanelControl uiElementPanelControl1;
        private Resco.Controls.OutlookControls.ImageButton btnBack;
    }
}