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
    public partial class Station : BaseModule
    {
        User currentMessage;
        PopupMenu priorityMenu, dateFilterMenu;
        RibbonControl ribbon;
        FindControlManager findControlManager = null;
        FilterCriteriaManager filterCriteriaManager = null;
        Timer messageReadTimer;
        int focusedRowHandle = 0;
        bool lockUpdateCurrentMessage = true;
        public override string ModuleName { get { return "Users"; } }
        public Station()
        {
            InitializeComponent();
            //this.panelControl1.auto
            InitData();
        }

        private void InitData()
        {
            //gridControl1.DataSource = DataHelper.User;
        }
        //protected override DevExpress.XtraGrid.GridControl Grid { get { return gridControl1; } }
        internal override void HideModule()
        {
            lockUpdateCurrentMessage = true;
            //focusedRowHandle = gridView1.FocusedRowHandle;
        }
        protected override void LookAndFeelStyleChanged()
        {
            base.LookAndFeelStyleChanged();
        }
        void ShowMessageMenu(Point location)
        {
            OwnerForm.ShowMessageMenu(location);
        }
    }
}
