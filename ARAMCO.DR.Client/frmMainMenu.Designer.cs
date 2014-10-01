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
            this.btnSetStatus = new Resco.UIElements.UIButton();
            this.btnDeconsolidate = new Resco.UIElements.UIButton();
            this.lblMainHeader = new Resco.UIElements.UILabel();
            this.uiImage1 = new Resco.UIElements.UIImage();
            this.lblEmpID = new Resco.UIElements.UILabel();
            this.lblUser = new Resco.UIElements.UILabel();
            this.btnViewMissionList = new Resco.UIElements.UIButton();
            this.btnAssignVehicle = new Resco.UIElements.UIButton();
            this.uiElementPanelControl1 = new Resco.UIElements.Controls.UIElementPanelControl();
            this.btnLogOff = new Resco.UIElements.UIButton();
            this.uiElementPanelControl1.SuspendElementLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Navy;
            this.pnlMain.Children.Add(this.btnSetStatus);
            this.pnlMain.Children.Add(this.btnDeconsolidate);
            this.pnlMain.Children.Add(this.lblMainHeader);
            this.pnlMain.Children.Add(this.uiImage1);
            this.pnlMain.Children.Add(this.lblEmpID);
            this.pnlMain.Children.Add(this.lblUser);
            this.pnlMain.Children.Add(this.btnViewMissionList);
            this.pnlMain.Children.Add(this.btnAssignVehicle);
            this.pnlMain.Children.Add(this.btnLogOff);
            this.pnlMain.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 0, 0, 0, 0, 240, 320);
            this.pnlMain.Name = "pnlMain";
            // 
            // btnSetStatus
            // 
            this.btnSetStatus.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.btnSetStatus.FocusedBackground.BorderColor = System.Drawing.Color.Black;
            this.btnSetStatus.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnSetStatus.ForeColor = System.Drawing.Color.Black;
            this.btnSetStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnSetStatus.Image")));
            this.btnSetStatus.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 8, 95, 0, 0, 109, 37);
            this.btnSetStatus.Name = "btnSetStatus";
            this.btnSetStatus.TabIndex = 3;
            this.btnSetStatus.Click += new Resco.UIElements.UIMouseEventHandler(this.btnSetStatus_Click);
            // 
            // btnDeconsolidate
            // 
            this.btnDeconsolidate.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.btnDeconsolidate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnDeconsolidate.ForeColor = System.Drawing.Color.Black;
            this.btnDeconsolidate.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 125, 136, 0, 0, 109, 37);
            this.btnDeconsolidate.Name = "btnDeconsolidate";
            this.btnDeconsolidate.TabIndex = 6;
            this.btnDeconsolidate.Text = "Settings";
            this.btnDeconsolidate.Visible = false;
            this.btnDeconsolidate.Click += new Resco.UIElements.UIMouseEventHandler(this.btnDeconsolidate_Click);
            // 
            // lblMainHeader
            // 
            this.lblMainHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.lblMainHeader.ForeColor = System.Drawing.Color.White;
            this.lblMainHeader.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 58, 1, 0, 0, 127, 20);
            this.lblMainHeader.Name = "lblMainHeader";
            this.lblMainHeader.TabIndex = 1;
            this.lblMainHeader.Text = "Driver - Main Menu";
            // 
            // uiImage1
            // 
            this.uiImage1.ImageSizeMode = Resco.UIElements.ImageSizeMode.StretchImage;
            this.uiImage1.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 215, 3, 0, 0, 22, 14);
            this.uiImage1.Name = "uiImage1";
            this.uiImage1.TabIndex = 8;
            // 
            // lblEmpID
            // 
            this.lblEmpID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEmpID.ForeColor = System.Drawing.Color.White;
            this.lblEmpID.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 12, 24, 0, 0, 98, 20);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.TabIndex = 1;
            this.lblEmpID.Text = "[Employee ID]";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 137, 24, 0, 0, 87, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "[User Name]";
            // 
            // btnViewMissionList
            // 
            this.btnViewMissionList.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.btnViewMissionList.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnViewMissionList.ForeColor = System.Drawing.Color.White;
            this.btnViewMissionList.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMissionList.Image")));
            this.btnViewMissionList.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Right, Resco.UIElements.VAlignment.Top, 0, 53, 6, 0, 109, 37);
            this.btnViewMissionList.Name = "btnViewMissionList";
            this.btnViewMissionList.PressedImage.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMissionList.PressedImage.Image")));
            this.btnViewMissionList.TabIndex = 2;
            this.btnViewMissionList.Click += new Resco.UIElements.UIMouseEventHandler(this.btnViewMissionList_Click);
            // 
            // btnAssignVehicle
            // 
            this.btnAssignVehicle.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.btnAssignVehicle.FocusedBackground.BorderColor = System.Drawing.Color.Transparent;
            this.btnAssignVehicle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnAssignVehicle.ForeColor = System.Drawing.Color.White;
            this.btnAssignVehicle.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignVehicle.Image")));
            this.btnAssignVehicle.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 8, 53, 0, 0, 109, 37);
            this.btnAssignVehicle.Name = "btnAssignVehicle";
            this.btnAssignVehicle.PressedImage.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignVehicle.PressedImage.Image")));
            this.btnAssignVehicle.TabIndex = 3;
            this.btnAssignVehicle.Click += new Resco.UIElements.UIMouseEventHandler(this.UIButton_Click);
            // 
            // uiElementPanelControl1
            // 
            this.uiElementPanelControl1.Children.Add(this.pnlMain);
            this.uiElementPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiElementPanelControl1.Name = "uiElementPanelControl1";
            this.uiElementPanelControl1.Size = new System.Drawing.Size(240, 320);
            // 
            // btnLogOff
            // 
            this.btnLogOff.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogOff.FocusedBackground.BorderColor = System.Drawing.Color.Black;
            this.btnLogOff.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btnLogOff.ForeColor = System.Drawing.Color.Black;
            this.btnLogOff.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOff.Image")));
            this.btnLogOff.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 125, 95, 0, 0, 109, 37);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.PressedImage.Image = ((System.Drawing.Image)(resources.GetObject("uiButton1.PressedImage.Image")));
            this.btnLogOff.TabIndex = 3;
            this.btnLogOff.Click += new Resco.UIElements.UIMouseEventHandler(this.btnLogOff_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.uiElementPanelControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmMainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.uiElementPanelControl1.ResumeElementLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Resco.UIElements.UIPanel pnlMain;
        private Resco.UIElements.Controls.UIElementPanelControl uiElementPanelControl1;
        private Resco.UIElements.UIButton btnSetStatus;
        private Resco.UIElements.UIButton btnDeconsolidate;
        private Resco.UIElements.UILabel lblMainHeader;
        private Resco.UIElements.UIImage uiImage1;
        private Resco.UIElements.UILabel lblEmpID;
        private Resco.UIElements.UILabel lblUser;
        private Resco.UIElements.UIButton btnViewMissionList;
        private Resco.UIElements.UIButton btnAssignVehicle;
        private Resco.UIElements.UIButton btnLogOff;

    }
}