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
            this.gcIcon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.icEditors = new DevExpress.Utils.ImageCollection(this.components);
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.lcList = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.gcAttachment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.gcSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcRead = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ilColumns = new System.Windows.Forms.ImageList(this.components);
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
            // gcIcon
            // 
            this.gcIcon.Caption = "Read";
            this.gcIcon.ColumnEdit = this.repositoryItemImageComboBox2;
            this.gcIcon.FieldName = "Read";
            this.gcIcon.ImageIndex = 1;
            this.gcIcon.Name = "gcIcon";
            this.gcIcon.OptionsColumn.AllowEdit = false;
            this.gcIcon.OptionsColumn.AllowFocus = false;
            this.gcIcon.OptionsColumn.AllowSize = false;
            this.gcIcon.OptionsColumn.FixedWidth = true;
            this.gcIcon.OptionsColumn.ShowCaption = false;
            this.gcIcon.ToolTip = "Icon";
            this.gcIcon.Visible = true;
            this.gcIcon.VisibleIndex = 1;
            this.gcIcon.Width = 35;
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
            this.gcPriority,
            this.gcIcon,
            this.gcAttachment,
            this.gcSubject,
            this.gcFrom,
            this.gcDate,
            this.gcRead});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.gcIcon;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = 0;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
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
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcDate, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridView1_CustomDrawGroupRow);
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
            // 
            // gcPriority
            // 
            this.gcPriority.Caption = "Priority";
            this.gcPriority.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gcPriority.FieldName = "Priority";
            this.gcPriority.ImageIndex = 0;
            this.gcPriority.Name = "gcPriority";
            this.gcPriority.OptionsColumn.AllowFocus = false;
            this.gcPriority.OptionsColumn.AllowSize = false;
            this.gcPriority.OptionsColumn.FixedWidth = true;
            this.gcPriority.OptionsColumn.ShowCaption = false;
            this.gcPriority.ToolTip = "Importance";
            this.gcPriority.Visible = true;
            this.gcPriority.VisibleIndex = 0;
            this.gcPriority.Width = 35;
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
            // gcAttachment
            // 
            this.gcAttachment.Caption = "Attachment";
            this.gcAttachment.ColumnEdit = this.repositoryItemImageComboBox3;
            this.gcAttachment.FieldName = "Attachment";
            this.gcAttachment.ImageIndex = 2;
            this.gcAttachment.Name = "gcAttachment";
            this.gcAttachment.OptionsColumn.AllowEdit = false;
            this.gcAttachment.OptionsColumn.AllowFocus = false;
            this.gcAttachment.OptionsColumn.AllowSize = false;
            this.gcAttachment.OptionsColumn.FixedWidth = true;
            this.gcAttachment.OptionsColumn.ShowCaption = false;
            this.gcAttachment.ToolTip = "Attachment";
            this.gcAttachment.Visible = true;
            this.gcAttachment.VisibleIndex = 2;
            this.gcAttachment.Width = 35;
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
            // gcSubject
            // 
            this.gcSubject.Caption = "Subject";
            this.gcSubject.FieldName = "Subject";
            this.gcSubject.Name = "gcSubject";
            this.gcSubject.OptionsColumn.AllowFocus = false;
            this.gcSubject.Visible = true;
            this.gcSubject.VisibleIndex = 3;
            this.gcSubject.Width = 341;
            // 
            // gcFrom
            // 
            this.gcFrom.Caption = "From";
            this.gcFrom.FieldName = "From";
            this.gcFrom.Name = "gcFrom";
            this.gcFrom.OptionsColumn.AllowFocus = false;
            this.gcFrom.Visible = true;
            this.gcFrom.VisibleIndex = 4;
            this.gcFrom.Width = 150;
            // 
            // gcDate
            // 
            this.gcDate.Caption = "Received";
            this.gcDate.FieldName = "Date";
            this.gcDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
            this.gcDate.Name = "gcDate";
            this.gcDate.OptionsColumn.AllowFocus = false;
            this.gcDate.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateAlt;
            this.gcDate.Visible = true;
            this.gcDate.VisibleIndex = 5;
            this.gcDate.Width = 123;
            // 
            // gcRead
            // 
            this.gcRead.ColumnEdit = this.repositoryItemImageComboBox4;
            this.gcRead.FieldName = "Read";
            this.gcRead.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gcRead.ImageIndex = 3;
            this.gcRead.Name = "gcRead";
            this.gcRead.OptionsColumn.AllowEdit = false;
            this.gcRead.OptionsColumn.AllowFocus = false;
            this.gcRead.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcRead.OptionsColumn.AllowShowHide = false;
            this.gcRead.OptionsColumn.AllowSize = false;
            this.gcRead.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gcRead.OptionsColumn.FixedWidth = true;
            this.gcRead.OptionsColumn.ShowCaption = false;
            this.gcRead.OptionsFilter.AllowAutoFilter = false;
            this.gcRead.OptionsFilter.AllowFilter = false;
            this.gcRead.Visible = true;
            this.gcRead.VisibleIndex = 6;
            this.gcRead.Width = 25;
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
            // ilColumns
            // 
            this.ilColumns.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilColumns.ImageStream")));
            this.ilColumns.TransparentColor = System.Drawing.Color.Transparent;
            this.ilColumns.Images.SetKeyName(0, "Importance.png");
            this.ilColumns.Images.SetKeyName(1, "Icon.png");
            this.ilColumns.Images.SetKeyName(2, "Attach.png");
            this.ilColumns.Images.SetKeyName(3, "Whatched.png");
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
        private XtraGrid.Columns.GridColumn gcPriority;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private Utils.ImageCollection icEditors;
        private XtraGrid.Columns.GridColumn gcIcon;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private XtraGrid.Columns.GridColumn gcAttachment;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private XtraGrid.Columns.GridColumn gcSubject;
        private XtraGrid.Columns.GridColumn gcFrom;
        private XtraGrid.Columns.GridColumn gcDate;
        private XtraGrid.Columns.GridColumn gcRead;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox4;
        private System.Windows.Forms.ImageList ilColumns;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControl layoutControl1;

    }
}
