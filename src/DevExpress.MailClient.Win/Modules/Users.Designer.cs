namespace DevExpress.MailClient.Win
{
    partial class Users
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.icEditors = new DevExpress.Utils.ImageCollection(this.components);
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.lcList = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ilColumns = new System.Windows.Forms.ImageList(this.components);
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEditors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Unread", 0, 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Read", 1, 2)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            this.repositoryItemImageComboBox2.SmallImages = this.icEditors;
            // 
            // icEditors
            // 
            this.icEditors.ImageSize = new System.Drawing.Size(13, 13);
            this.icEditors.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icEditors.ImageStream")));
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(1651, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 768);
            // 
            // lcList
            // 
            this.lcList.Control = this.gridControl1;
            this.lcList.CustomizationFormText = "layoutControlItem1";
            this.lcList.Location = new System.Drawing.Point(0, 0);
            this.lcList.Name = "lcList";
            this.lcList.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcList.Size = new System.Drawing.Size(1651, 768);
            this.lcList.Text = "lcList";
            this.lcList.TextSize = new System.Drawing.Size(0, 0);
            this.lcList.TextToControlDistance = 0;
            this.lcList.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 6);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.repositoryItemImageComboBox3,
            this.repositoryItemImageComboBox4});
            this.gridControl1.Size = new System.Drawing.Size(1651, 768);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcID,
            this.gcUserName,
            this.gcRealName,
            this.gcSex,
            this.gcPhone,
            this.gcEmail,
            this.gcDeptName,
            this.gcState});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = 0;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupFormat = "[#image]{1} {2}";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Subject", null, "({0} items)")});
            this.gridView1.Images = this.ilColumns;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsPrint.PrintHorzLines = false;
            this.gridView1.OptionsPrint.PrintVertLines = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // gcID
            // 
            this.gcID.FieldName = "ID";
            this.gcID.Name = "gcID";
            this.gcID.OptionsColumn.AllowEdit = false;
            this.gcID.Visible = true;
            this.gcID.VisibleIndex = 0;
            this.gcID.Width = 142;
            // 
            // gcUserName
            // 
            this.gcUserName.Caption = "登录帐户";
            this.gcUserName.FieldName = "UserName";
            this.gcUserName.Name = "gcUserName";
            this.gcUserName.OptionsColumn.AllowEdit = false;
            this.gcUserName.OptionsColumn.AllowFocus = false;
            this.gcUserName.Visible = true;
            this.gcUserName.VisibleIndex = 1;
            this.gcUserName.Width = 236;
            // 
            // gcRealName
            // 
            this.gcRealName.Caption = "姓名";
            this.gcRealName.FieldName = "RealName";
            this.gcRealName.Name = "gcRealName";
            this.gcRealName.OptionsColumn.AllowEdit = false;
            this.gcRealName.Visible = true;
            this.gcRealName.VisibleIndex = 2;
            this.gcRealName.Width = 209;
            // 
            // gcSex
            // 
            this.gcSex.Caption = "性别";
            this.gcSex.FieldName = "Sex";
            this.gcSex.Name = "gcSex";
            this.gcSex.OptionsColumn.AllowEdit = false;
            this.gcSex.Visible = true;
            this.gcSex.VisibleIndex = 3;
            this.gcSex.Width = 209;
            // 
            // gcPhone
            // 
            this.gcPhone.Caption = "手机";
            this.gcPhone.FieldName = "PhoneNumber";
            this.gcPhone.Name = "gcPhone";
            this.gcPhone.OptionsColumn.AllowEdit = false;
            this.gcPhone.Visible = true;
            this.gcPhone.VisibleIndex = 4;
            this.gcPhone.Width = 209;
            // 
            // gcEmail
            // 
            this.gcEmail.Caption = "电子邮件";
            this.gcEmail.FieldName = "Email";
            this.gcEmail.Name = "gcEmail";
            this.gcEmail.OptionsColumn.AllowEdit = false;
            this.gcEmail.Visible = true;
            this.gcEmail.VisibleIndex = 5;
            this.gcEmail.Width = 209;
            // 
            // gcDeptName
            // 
            this.gcDeptName.Caption = "部门";
            this.gcDeptName.FieldName = "DeptName";
            this.gcDeptName.Name = "gcDeptName";
            this.gcDeptName.OptionsColumn.AllowEdit = false;
            this.gcDeptName.Visible = true;
            this.gcDeptName.VisibleIndex = 6;
            this.gcDeptName.Width = 209;
            // 
            // gcState
            // 
            this.gcState.Caption = "状态";
            this.gcState.FieldName = "State";
            this.gcState.Name = "gcState";
            this.gcState.OptionsColumn.AllowEdit = false;
            this.gcState.Visible = true;
            this.gcState.VisibleIndex = 7;
            this.gcState.Width = 226;
            // 
            // ilColumns
            // 
            this.ilColumns.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilColumns.ImageStream")));
            this.ilColumns.TransparentColor = System.Drawing.Color.Transparent;
            this.ilColumns.Images.SetKeyName(0, "Importance.png");
            this.ilColumns.Images.SetKeyName(1, "Icon.png");
            this.ilColumns.Images.SetKeyName(2, "Attach.png");
            this.ilColumns.Images.SetKeyName(3, "Whatched.png");
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Medium", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, 1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.icEditors;
            // 
            // repositoryItemImageComboBox3
            // 
            this.repositoryItemImageComboBox3.AutoHeight = false;
            this.repositoryItemImageComboBox3.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemImageComboBox3.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Attachment", 1, 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Empty", 0, -1)});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            this.repositoryItemImageComboBox3.SmallImages = this.icEditors;
            // 
            // repositoryItemImageComboBox4
            // 
            this.repositoryItemImageComboBox4.AutoHeight = false;
            this.repositoryItemImageComboBox4.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemImageComboBox4.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Read", 1, 6),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Unread", 0, 5)});
            this.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4";
            this.repositoryItemImageComboBox4.SmallImages = this.icEditors;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcList,
            this.splitterItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1668, 780);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomizationMenu = false;
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(694, 412, 450, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1668, 780);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(1668, 780);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEditors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XtraLayout.SplitterItem splitterItem1;
        private XtraLayout.LayoutControlItem lcList;
        private XtraGrid.GridControl gridControl1;
        private XtraGrid.Views.Grid.GridView gridView1;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private Utils.ImageCollection icEditors;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private XtraGrid.Columns.GridColumn gcUserName;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox4;
        private System.Windows.Forms.ImageList ilColumns;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraGrid.Columns.GridColumn gcID;
        private XtraGrid.Columns.GridColumn gcRealName;
        private XtraGrid.Columns.GridColumn gcSex;
        private XtraGrid.Columns.GridColumn gcPhone;
        private XtraGrid.Columns.GridColumn gcEmail;
        private XtraGrid.Columns.GridColumn gcDeptName;
        private XtraGrid.Columns.GridColumn gcState;

    }
}
