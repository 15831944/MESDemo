using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.MailClient.Win
{
    public partial class frmPlanDetail : RibbonForm
    {
        public frmPlanDetail()
        {
            InitializeComponent();

            progressBarControl1.Properties.Maximum = 100;
            progressBarControl1.Properties.Minimum = 20;
            progressBarControl1.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
        }
    }
}