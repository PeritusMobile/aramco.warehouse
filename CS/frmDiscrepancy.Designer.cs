namespace ARAMCO.Client
{
    partial class frmDiscrepancy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiscrepancy));
            this.pnlMain = new Resco.UIElements.UIPanel();
            this.uiImage1 = new Resco.UIElements.UIImage();
            this.txtbxNotes = new Resco.UIElements.UITextBox();
            this.uiTextBoxButton2 = new Resco.UIElements.UITextBoxButton();
            this.lblHeader = new Resco.UIElements.UILabel();
            this.btnBack = new Resco.UIElements.UIButton();
            this.btnSubmit = new Resco.UIElements.UIButton();
            this.cboReason = new Resco.UIElements.UIComboBox();
            this.btnBrowse = new Resco.UIElements.UIButton();
            this.btnClear = new Resco.UIElements.UIButton();
            this.uiLabel1 = new Resco.UIElements.UILabel();
            this.imgbxIcon = new Resco.UIElements.UIImage();
            this.uiElementPanelControl1 = new Resco.UIElements.Controls.UIElementPanelControl();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.keyboardPro1 = new Resco.Controls.KeyboardPro.KeyboardPro(this, this.components);
            this.uiElementPanelControl1.SuspendElementLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlMain.BackgroundGradient = new Resco.Drawing.GradientColor(System.Drawing.Color.DarkBlue, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 50, 50, Resco.Drawing.FillDirection.Vertical);
            this.pnlMain.Children.Add(this.uiImage1);
            this.pnlMain.Children.Add(this.txtbxNotes);
            this.pnlMain.Children.Add(this.lblHeader);
            this.pnlMain.Children.Add(this.btnBack);
            this.pnlMain.Children.Add(this.btnSubmit);
            this.pnlMain.Children.Add(this.cboReason);
            this.pnlMain.Children.Add(this.btnBrowse);
            this.pnlMain.Children.Add(this.btnClear);
            this.pnlMain.Children.Add(this.uiLabel1);
            this.pnlMain.Children.Add(this.imgbxIcon);
            this.pnlMain.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 0, 0, 0, 0, 240, 320);
            this.pnlMain.Name = "pnlMain";
            // 
            // uiImage1
            // 
            this.uiImage1.BorderColor = System.Drawing.Color.White;
            this.uiImage1.BorderThickness = 1;
            this.uiImage1.Image = ((System.Drawing.Image)(resources.GetObject("uiImage1.Image")));
            this.uiImage1.ImageSizeMode = Resco.UIElements.ImageSizeMode.StretchImage;
            this.uiImage1.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 6, 78, 0, 0, 228, 70);
            this.uiImage1.Name = "uiImage1";
            // 
            // txtbxNotes
            // 
            this.txtbxNotes.Buttons.Add(this.uiTextBoxButton2);
            this.txtbxNotes.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 7, 184, 0, 0, 226, 62);
            this.txtbxNotes.Multiline = true;
            this.txtbxNotes.Name = "txtbxNotes";
            this.txtbxNotes.TabIndex = 1;
            this.txtbxNotes.Text = "This is the text box description notes to enable the text field entry of notes ab" +
                "out the discrepancies..";
            this.txtbxNotes.TextAlignment = Resco.Drawing.Alignment.TopLeft;
            this.txtbxNotes.GotFocus += new System.EventHandler(this.txtbxNotes_GotFocus);
            // 
            // uiTextBoxButton2
            // 
            this.uiTextBoxButton2.Action = Resco.UIElements.TextBoxAction.Clear;
            this.uiTextBoxButton2.BackColor = System.Drawing.Color.Transparent;
            this.uiTextBoxButton2.BorderThickness = 0;
            this.uiTextBoxButton2.HorizontalAlignment = Resco.UIElements.HAlignment.Right;
            this.uiTextBoxButton2.Name = "uiTextBoxButton2";
            this.uiTextBoxButton2.PressedBackground.BackColor = System.Drawing.Color.Transparent;
            this.uiTextBoxButton2.Size = new System.Drawing.Size(18, 18);
            this.uiTextBoxButton2.StateIcon = Resco.UIElements.StateIcon.Delete;
            this.uiTextBoxButton2.VisibleMode = Resco.UIElements.UITextBoxButtonVisibleMode.WhileEditing;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 60, 2, 0, 0, 138, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Report Discrepancy";
            // 
            // btnBack
            // 
            this.btnBack.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 2, 4, 0, 0, 49, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<<";
            this.btnBack.Click += new Resco.UIElements.UIMouseEventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 64, 250, 0, 0, 111, 38);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "SUBMIT";
            // 
            // cboReason
            // 
            this.cboReason.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 5, 49, 0, 0, 230, 23);
            this.cboReason.Name = "cboReason";
            this.cboReason.TabIndex = 5;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 153, 155, 0, 0, 80, 20);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "browse...";
            // 
            // btnClear
            // 
            this.btnClear.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 71, 155, 0, 0, 80, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 3, 26, 0, 0, 97, 22);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.TabIndex = 8;
            this.uiLabel1.Text = "Reason Code:";
            // 
            // imgbxIcon
            // 
            this.imgbxIcon.DefaultImage = ((System.Drawing.Image)(resources.GetObject("imgbxIcon.DefaultImage")));
            this.imgbxIcon.Layout = new Resco.UIElements.ElementLayout(Resco.UIElements.HAlignment.Left, Resco.UIElements.VAlignment.Top, 212, 7, 0, 0, 22, 14);
            this.imgbxIcon.Name = "imgbxIcon";
            this.imgbxIcon.TabIndex = 9;
            // 
            // uiElementPanelControl1
            // 
            this.uiElementPanelControl1.Children.Add(this.pnlMain);
            this.uiElementPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiElementPanelControl1.Name = "uiElementPanelControl1";
            this.uiElementPanelControl1.Size = new System.Drawing.Size(240, 294);
            // 
            // frmDiscrepancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.uiElementPanelControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.Name = "frmDiscrepancy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.uiElementPanelControl1.ResumeElementLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Resco.UIElements.UIPanel pnlMain;
        private Resco.UIElements.Controls.UIElementPanelControl uiElementPanelControl1;
        private Resco.UIElements.UIImage uiImage1;
        private Resco.UIElements.UITextBox txtbxNotes;
        private Resco.UIElements.UITextBoxButton uiTextBoxButton2;
        private Resco.UIElements.UILabel lblHeader;
        private Resco.UIElements.UIButton btnBack;
        private Resco.UIElements.UIButton btnSubmit;
        private Resco.UIElements.UIComboBox cboReason;
        private Resco.UIElements.UIButton btnBrowse;
        private Resco.UIElements.UIButton btnClear;
        private Resco.UIElements.UILabel uiLabel1;
        private Resco.UIElements.UIImage imgbxIcon;
        private System.Windows.Forms.MainMenu mainMenu1;
        private Resco.Controls.KeyboardPro.KeyboardPro keyboardPro1;

    }
}