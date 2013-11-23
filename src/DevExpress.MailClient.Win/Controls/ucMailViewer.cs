using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.Utils.Menu;
using DevExpress.XtraRichEdit;

namespace DevExpress.MailClient.Win {
    public partial class ucMailViewer : BaseControl {
        public ucMailViewer() {
            InitializeComponent();
            lcTitle.Text = string.Empty;
            recMessage.Text = string.Empty;
        }
        public void SetMenuManager(IDXMenuManager manager) {
            recMessage.MenuManager = manager;
        }
        protected override void LookAndFeelStyleChanged() {
            base.LookAndFeelStyleChanged();
            Color windowColor = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("Window");
            Color windowTextColor = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("WindowText");
            lcTitle.Appearance.BackColor = windowColor;
            lcTitle.Appearance.ForeColor = windowTextColor;
        }

        internal void ShowMessage(Message message) {
            if(message == null) return;
            lcTitle.Text = string.Format("<size=+3><b>{0}<br><br></b><size=-4>{3}: <size=+2>{1}<br><size=-2>{4}: <size=+2>{2:g}<br>", message.Subject, message.From, message.Date, GetFromString(message.MailType), Properties.Resources.Date);
            recMessage.HtmlText = message.Text;
        }
        private string GetFromString(MailType mailType) {
            if(mailType == MailType.Inbox) return Properties.Resources.FromInbox;
            if(mailType == MailType.Deleted) return Properties.Resources.FromDeleted;
            return Properties.Resources.FromOutbox;
        }
        internal void ShowMessagesInfo(List<Message> messages) {
            lcTitle.Text = string.Format("<size=+7> <size=-3><b>{0}</b> <size=-3>{1}", messages.Count, StringResources.GetMessagesString(messages.Count));
            string text =  StringResources.Get("MessageTile");
            foreach(Message message in messages) {
                text += string.Format(StringResources.Get("MessageTileEx"), message.From, message.Date, message.Subject);
            }
            text += StringResources.Get("MessageTileEnd");
            recMessage.HtmlText = text;
        }
        internal void ShowFeed(FeedItem feed, bool showUrl) {
            linkView.Visible = showUrl;
            linkView.Text = feed.Url;
            lcTitle.Text = string.Format("<size=+3><b>{0}<br><br></b><size=-4>{3}: <size=+2>{1}<br><size=-2>{4}: <size=+2>{2:g}<br>", feed.Title, feed.From, feed.Date, Properties.Resources.From, Properties.Resources.Date);
            recMessage.HtmlText = feed.Description;
        }
        internal void ClearInfo() {
            lcTitle.Text = string.Empty;
            recMessage.Text = string.Empty;
            linkView.Visible = false;
        }
        public float ZoomFactor {
            get { return recMessage.Views.SimpleView.ZoomFactor; }
            set { recMessage.Views.SimpleView.ZoomFactor = value; }
        }
        public RichEditControl RichEdit { get { return recMessage; } }
    }
}
