namespace DevExpress.MailClient.Win {
    partial class ucMailViewer {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMailViewer));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.recMessage = new DevExpress.XtraRichEdit.RichEditControl();
            this.linkView = new DevExpress.XtraEditors.HyperLinkEdit();
            this.lcTitle = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkView.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.recMessage);
            this.panelControl1.Controls.Add(this.linkView);
            this.panelControl1.Controls.Add(this.lcTitle);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // recMessage
            // 
            this.recMessage.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.recMessage.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            resources.ApplyResources(this.recMessage, "recMessage");
            this.recMessage.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.recMessage.Name = "recMessage";
            this.recMessage.ReadOnly = true;
            // 
            // linkView
            // 
            resources.ApplyResources(this.linkView, "linkView");
            this.linkView.Name = "linkView";
            this.linkView.Properties.AllowFocused = false;
            this.linkView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.linkView.Properties.Caption = resources.GetString("linkView.Properties.Caption");
            this.linkView.Properties.StartLinkOnClickingEmptySpace = false;
            // 
            // lcTitle
            // 
            this.lcTitle.AllowHtmlString = true;
            this.lcTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.lcTitle.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            resources.ApplyResources(this.lcTitle, "lcTitle");
            this.lcTitle.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lcTitle.LineVisible = true;
            this.lcTitle.Name = "lcTitle";
            // 
            // ucMailViewer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucMailViewer";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.linkView.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraRichEdit.RichEditControl recMessage;
        private DevExpress.XtraEditors.LabelControl lcTitle;
        private DevExpress.XtraEditors.HyperLinkEdit linkView;
    }
}
