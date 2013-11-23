using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.MailClient.Win
{
    public partial class PlanList : BaseModule
    {
        public PlanList()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            gridControl1.DataSource = DataHelper.PlanTable;
        }

        RepositoryItemProgressBar progress = new RepositoryItemProgressBar();
        private void gridView1_CustomRowCellEdit(object sender, XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            progress.LookAndFeel.SkinName = "Money Twins";
            progress.LookAndFeel.UseDefaultLookAndFeel = false;
            progress.ShowTitle = true;
            //progress.StartColor = Color.Green;
            //progress.EndColor = Color.Red;
            if (e.Column.Caption == "订单进度")
            {
                e.RepositoryItem = progress;
            }
        }

        private void gridView1_RowCellStyle(object sender, XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.Caption == "订单状态")
            {
                if (e.CellValue.ToString() == "正常")
                    e.Appearance.BackColor = Color.Green;
                else
                    e.Appearance.BackColor = Color.Red;
            }
        }

        private void gridView1_RowClick(object sender, XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            frmPlanDetail frm = new frmPlanDetail();
            frm.ShowDialog();
        }
    }
}
