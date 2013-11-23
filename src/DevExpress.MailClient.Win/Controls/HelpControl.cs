using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;

namespace DevExpress.MailClient.Win.Controls {
    public partial class HelpControl : RibbonApplicationUserControl {
        Form aboutPanel;
        public HelpControl() {
            InitializeComponent();
            aboutPanel = new AboutForm12(new DevExpress.Utils.About.ProductInfo(string.Empty, typeof(frmMain), DevExpress.Utils.About.ProductKind.DemoWin));
            aboutPanel.TopLevel = false;
            aboutPanel.Parent = splitContainer1.Panel2;
            aboutPanel.Show();
            splitContainer1.Panel2.Resize += new EventHandler(Panel2_Resize);
        }

        void Panel2_Resize(object sender, EventArgs e) {
            Panel pnl = sender as Panel;
            aboutPanel.Location = new Point((pnl.Width - aboutPanel.Width) / 2, (pnl.Height - aboutPanel.Height) / 2);
        }

        private void galleryControlGallery1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e) {
            string link = string.Format("{0}", e.Item.Tag);
            if(!string.IsNullOrEmpty(link)) ObjectHelper.StartProcess(link);
        }
    }
}
