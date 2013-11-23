using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Design;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.Skins;
using DevExpress.XtraTreeList;

namespace DevExpress.MailClient.Win.Controls
{
    public partial class ucBufferTree : BaseControl
    {
        public event DataSourceChangedEventHandler DataSourceChanged;
        public event MouseEventHandler ShowMenu;
        bool allowDataSourceChanged = false;

        public ucBufferTree()
        {
            InitializeComponent();
            InitData();
            //treeList1.RowHeight = Math.Max(Convert.ToInt32(treeList1.Font.GetHeight()), icFolders.ImageSize.Height) + 5;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignTimeTools.IsDesignMode)
                treeList1.FocusedNode = treeList1.Nodes[0].Nodes[0];
        }
        void InitData()
        {
            TreeListNode tlBuffer = treeList1.AppendNode(new object[] { Properties.Resources.BufferManage, MailType.Inbox, MailFolder.Announcements, 5 }, null);
            treeList1.AppendNode(new object[] { Properties.Resources.Buffer, MailType.Inbox, MailFolder.Announcements }, tlBuffer);
            //treeList1.AppendNode(new object[] { Properties.Resources.RuleManage, MailType.Sent, MailFolder.Announcements, 1 }, tlBuffer);
            //treeList1.AppendNode(new object[] { Properties.Resources.RoleManage, MailType.Draft, MailFolder.Announcements, 2 }, tlBuffer);
            //treeList1.AppendNode(new object[] { Properties.Resources.DeptManage, MailType.Sent, MailFolder.All, 2 }, tlBuffer);
            //TreeListNode tlPerson = treeList1.AppendNode(new object[] { Properties.Resources.OwnerName, MailType.Inbox, MailFolder.All, 4 }, null);
            //TreeListNode tlPersonInbox = treeList1.AppendNode(new object[] { Properties.Resources.Inbox, MailType.Inbox, MailFolder.All }, tlPerson);
            //treeList1.AppendNode(new object[] { Properties.Resources.ASP, MailType.Inbox, MailFolder.ASP, 6 }, tlPersonInbox);
            //treeList1.AppendNode(new object[] { Properties.Resources.WinForms, MailType.Inbox, MailFolder.WinForms, 9 }, tlPersonInbox);
            //treeList1.AppendNode(new object[] { Properties.Resources.IDETools, MailType.Inbox, MailFolder.IDETools, 7 }, tlPersonInbox);
            //treeList1.AppendNode(new object[] { Properties.Resources.Frameworks, MailType.Inbox, MailFolder.Frameworks, 8 }, tlPersonInbox);
            //treeList1.AppendNode(new object[] { Properties.Resources.SentItems, MailType.Sent, MailFolder.All, 1 }, tlPerson);
            //treeList1.AppendNode(new object[] { Properties.Resources.DeletedItems, MailType.Deleted, MailFolder.All, 2 }, tlPerson);
            //treeList1.AppendNode(new object[] { Properties.Resources.Drafts, MailType.Draft, MailFolder.All, 3 }, tlPerson);

            treeList1.ExpandAll();
            if (!DesignTimeTools.IsDesignMode)
                CreateMessagesList(treeList1.Nodes);
            allowDataSourceChanged = true;
        }

        void CreateMessagesList(TreeListNodes nodes)
        {
            foreach (TreeListNode node in nodes)
            {
                CreateMessagesForNode(node);
                CreateMessagesList(node.Nodes);
            }
        }
        void CreateMessagesForNode(TreeListNode node)
        {
            List<Message> messages = new List<Message>();
            MailType mailType = (MailType)node.GetValue(colType);
            MailFolder mailFolder = (MailFolder)node.GetValue(colFolder);
            foreach (Message message in DataHelper.Messages)
            {
                if (message.MailType == mailType &&
                    (message.MailFolder == mailFolder || mailFolder == MailFolder.All) &&
                    !message.Deleted)
                    messages.Add(message);
            }
            node.SetValue(colData, messages);
        }
        protected override void LookAndFeelStyleChanged()
        {
            base.LookAndFeelStyleChanged();
            Color controlColor = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("Control");
            treeList1.Appearance.Empty.BackColor = controlColor;
            treeList1.Appearance.Row.BackColor = controlColor;
        }
        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            RaiseDataSourceChanged(e.Node);
        }
        void RaiseDataSourceChanged(TreeListNode node)
        {
            if (DataSourceChanged != null && allowDataSourceChanged)
                DataSourceChanged(treeList1, new DataSourceChangedEventArgs(GetNodeCaption(node), node.GetValue(colData), node.GetValue(colType)));
        }
        string GetNodeCaption(TreeListNode node)
        {
            string ret = string.Format("{0}", node.GetValue(colName));
            while (node.ParentNode != null)
            {
                node = node.ParentNode;
                ret = string.Format("{0} - {1}", node.GetValue(colName), ret);
            }
            return ret;
        }
        private void treeList1_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (DesignTimeTools.IsDesignMode) return;
            if (e.Column == colName)
            {
                string textColor = GetHtmlTextColor(treeList1.FocusedNode.Equals(e.Node));
                object textValue = e.Node.GetValue(colName);
                e.CellText = string.Format("<Color={1}>{0}", textValue, textColor);
                if (e.Node.ParentNode == null || !(DataHelper.ShowAllMessageCount || DataHelper.ShowUnreadMessageCount)) return;
                List<Message> list = e.Node.GetValue(colData) as List<Message>;
                int unread = GetUnreadMessagesCount(list);
                if (unread > 0 && DataHelper.ShowUnreadMessageCount)
                {
                    if (DataHelper.ShowAllMessageCount)
                        e.CellText = string.Format("<Color={5}><b>{0}</b><Size=-1><Color={2}> [{1}/<Color={4}>{3}<Color={2}>]", textValue, unread, ColorHelper.HtmlQuestionColor, list.Count, ColorHelper.HtmlWarningColor, textColor);
                    else
                        e.CellText = string.Format("<Color={3}><b>{0}</b><Size=-1><Color={2}> [{1}]", textValue, unread, ColorHelper.HtmlQuestionColor, textColor);
                }
                else
                {
                    if (DataHelper.ShowAllMessageCount && list.Count > 0)
                        e.CellText = string.Format("<Color={3}>{0}<Size=-1><Color={2}> [{1}]", textValue, list.Count, ColorHelper.HtmlWarningColor, textColor);
                }
            }
        }
        static string GetHtmlTextColor(bool focused)
        {
            if (focused)
                return ColorHelper.HtmlHighlightTextColor;
            return ColorHelper.HtmlControlTextColor;
        }
        int GetUnreadMessagesCount(List<Message> list)
        {
            return list.Count(p => p.IsUnread);
        }
        internal void RefreshTreeList()
        {
            treeList1.LayoutChanged();
        }
        private void treeList1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && ShowMenu != null) ShowMenu(sender, e);
        }

        internal void UpdateTreeViewMessages()
        {
            CreateMessagesList(treeList1.Nodes);
            RefreshTreeList();
            RaiseDataSourceChanged(treeList1.FocusedNode);
        }
    }
}
