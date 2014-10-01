namespace ARAMCO.Client
{
    partial class frmConsolidate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsolidate));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.pnlMain = new Resco.UIElements.UIPanel();
            this.lblHeader = new Resco.UIElements.UILinkLabel();
            this.uiImage1 = new Resco.UIElements.UIImage();
            this.btnBack = new Resco.UIElements.UIButton();
            this.uiElementPanelControl1 = new Resco.UIElements.Controls.UIElementPanelControl();
            this.uiElementPanelControl1.SuspendElementLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Navy;
            this.pnlMain.BackgroundGradient = new Resco.Drawing.GradientColor(System.Drawing.Color.Navy, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.DarkGreen, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.pnlMain.Children.Add(this.lblHeader);
            this.pnlMain.Children.Add(this.uiImage1);
            this.pnlMain.Children.Add(this.btnBack);
            this.pnlMain.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 0, 0, 0, 0, 245, 320);
            this.pnlMain.Name = "pnlMain";
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 81, 3, 0, 0, 92, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Text = "CONSOLIDATE";
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
            // btnBack
            // 
            this.btnBack.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 2, 2, 0, 0, 49, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.TabIndex = 2;
            this.btnBack.Click += new Resco.UIElements.UIMouseEventHandler(this.btnBack_Click);
            // 
            // uiElementPanelControl1
            // 
            this.uiElementPanelControl1.Children.Add(this.pnlMain);
            this.uiElementPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiElementPanelControl1.Name = "uiElementPanelControl1";
            this.uiElementPanelControl1.Size = new System.Drawing.Size(240, 320);
            // 
            // frmConsolidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.uiElementPanelControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmConsolidate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.uiElementPanelControl1.ResumeElementLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Resco.UIElements.UIPanel pnlMain;
        private Resco.UIElements.Controls.UIElementPanelControl uiElementPanelControl1;
        private Resco.UIElements.UILinkLabel lblHeader;
        private Resco.UIElements.UIImage uiImage1;
        private Resco.UIElements.UIButton btnBack;
    }
}