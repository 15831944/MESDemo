using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.Utils.Design;
using DevExpress.XtraTreeList;

namespace DevExpress.MailClient.Win.Controls
{
    public partial class ucSystemTree : BaseControl
    {
        public event DataSourceChangedEventHandler DataSourceChanged;
        public event MouseEventHandler ShowMenu;
        bool allowDataSourceChanged = false;

        public ucSystemTree()
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
            TreeListNode tlSystem = treeList1.AppendNode(new object[] { Properties.Resources.SystemManage, MailType.Inbox, MailFolder.Announcements, 5 }, null);
            treeList1.AppendNode(new object[] { Properties.Resources.UserManage, MailType.Inbox, MailFolder.Announcements }, tlSystem);
            treeList1.AppendNode(new object[] { Properties.Resources.RuleManage, MailType.Sent, MailFolder.Announcements, 1 }, tlSystem);
            treeList1.AppendNode(new object[] { Properties.Resources.RoleManage, MailType.Draft, MailFolder.Announcements, 2 }, tlSystem);
            treeList1.AppendNode(new object[] { Properties.Resources.DeptManage, MailType.Sent, MailFolder.All, 3 }, tlSystem);
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
            List<User> users = new List<User>();
            MailType mailType = (MailType)node.GetValue(colType);
            MailFolder mailFolder = (MailFolder)node.GetValue(colFolder);
            foreach (User user in DataHelper.User)
            {
                //if (user.MailType == mailType &&
                //    (user.MailFolder == mailFolder || mailFolder == MailFolder.All) &&
                //    !user.Deleted)
                users.Add(user);
            }
            node.SetValue(colData, users);
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
            
        }
        static string GetHtmlTextColor(bool focused)
        {
            if (focused)
                return ColorHelper.HtmlHighlightTextColor;
            return ColorHelper.HtmlControlTextColor;
        }
        internal void RefreshTreeList()
        {
            treeList1.LayoutChanged();
        }
        private void treeList1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && ShowMenu != null) ShowMenu(sender, e);
            else
            {
                
            }
        }

        internal void UpdateTreeViewMessages()
        {
            CreateMessagesList(treeList1.Nodes);
            RefreshTreeList();
            RaiseDataSourceChanged(treeList1.FocusedNode);
        }
    }
}
