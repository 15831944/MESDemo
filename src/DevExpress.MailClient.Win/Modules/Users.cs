using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraRichEdit;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraRichEdit.API.Native;

namespace DevExpress.MailClient.Win
{
    public partial class Users : BaseModule
    {
        //User currentMessage;
        User currentMessage;
        PopupMenu priorityMenu, dateFilterMenu;
        RibbonControl ribbon;
        FindControlManager findControlManager = null;
        FilterCriteriaManager filterCriteriaManager = null;
        Timer messageReadTimer;
        int focusedRowHandle = 0;
        bool lockUpdateCurrentMessage = true;
        public override string ModuleName { get { return "Users"; } }
        public Users()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            gridControl1.DataSource = DataHelper.User;
        }
        protected override DevExpress.XtraGrid.GridControl Grid { get { return gridControl1; } }
        internal override void HideModule()
        {
            lockUpdateCurrentMessage = true;
            focusedRowHandle = gridView1.FocusedRowHandle;
        }
        protected override void LookAndFeelStyleChanged()
        {
            base.LookAndFeelStyleChanged();
            ColorHelper.UpdateColor(ilColumns, gridControl1.LookAndFeel);
        }
        void ShowMessageMenu(Point location)
        {
            OwnerForm.ShowMessageMenu(location);
        }
        PopupMenu PriorityMenu
        {
            get
            {
                if (priorityMenu == null)
                    priorityMenu = new PriorityMenu(ribbon.Manager, gridView1, Properties.Resources.Low16x16, Properties.Resources.High16x16);
                return priorityMenu;
            }
        }
        PopupMenu DateFilterMenu
        {
            get
            {
                if (dateFilterMenu == null)
                    dateFilterMenu = new DateFilterMenu(ribbon.Manager, gridView1, filterCriteriaManager);
                return dateFilterMenu;
            }
        }

        private void gridView1_RowCellClick(object sender, XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
                EditMessage(e.RowHandle);
        }

        private void EditMessage(int rowHandle)
        {
            if (rowHandle < 0) return;
            Message message = gridView1.GetRow(rowHandle) as Message;
            if (message != null)
                EditMessage(message, false, "");
        }
        void EditMessage(Message message, bool newMessage, string caption)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmEditMail form = new frmEditMail(message, newMessage, caption);
            form.Load += OnEditMailFormLoad;
            form.FormClosed += OnEditMailFormClosed;
            form.Location = new Point(OwnerForm.Left + (OwnerForm.Width - form.Width) / 2, OwnerForm.Top + (OwnerForm.Height - form.Height) / 2);
            form.Show();
            Cursor.Current = Cursors.Default;
        }

        private void OnEditMailFormClosed(object sender, FormClosedEventArgs e)
        {
            frmEditMail form = sender as frmEditMail;
            if (form != null)
                form.SaveMessage -= OnEditMailFormSaveMessage;
        }

        private void OnEditMailFormSaveMessage(object sender, EventArgs e)
        {
            frmEditMail form = sender as frmEditMail;
            if (form == null)
                return;

            if (!DataHelper.Messages.Contains(form.SourceMessage))
                DataHelper.Messages.Add(form.SourceMessage);
            //RaiseUpdateTreeViewMessages();
        }

        private void OnEditMailFormLoad(object sender, EventArgs e)
        {
            frmEditMail form = sender as frmEditMail;
            if (form != null)
                form.SaveMessage += OnEditMailFormSaveMessage;
        }
    }
}

