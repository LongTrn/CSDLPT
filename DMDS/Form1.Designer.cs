namespace DMDS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSGV = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSLH = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSDS = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelPreview = new DevExpress.XtraEditors.SimpleButton();
            this.lbTimesRP = new System.Windows.Forms.Label();
            this.txtTimesRP = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cbKhoaRP = new System.Windows.Forms.ComboBox();
            this.lbKhoaRP = new System.Windows.Forms.Label();
            this.txtCodeDepartment = new DevExpress.XtraEditors.TextEdit();
            this.lbCodeDepartment = new System.Windows.Forms.Label();
            this.lbLopRP = new System.Windows.Forms.Label();
            this.lbCodeClass = new System.Windows.Forms.Label();
            this.lbMonhocRP = new System.Windows.Forms.Label();
            this.lbCodeSubject = new System.Windows.Forms.Label();
            this.txtCodeClass = new DevExpress.XtraEditors.TextEdit();
            this.txtCodeSubject = new DevExpress.XtraEditors.TextEdit();
            this.cbLopRP = new System.Windows.Forms.ComboBox();
            this.cbMonhocRP = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbStudent = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbPlace = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.txtBirthday = new DevExpress.XtraEditors.DateEdit();
            this.txtPlace = new DevExpress.XtraEditors.TextEdit();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.radGender = new DevExpress.XtraEditors.RadioGroup();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.lbClass = new System.Windows.Forms.Label();
            this.txtClass = new DevExpress.XtraEditors.TextEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtDepartment = new DevExpress.XtraEditors.TextEdit();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.lbTimes = new System.Windows.Forms.Label();
            this.txtTimes = new System.Windows.Forms.NumericUpDown();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox21 = new System.Windows.Forms.ComboBox();
            this.comboBox211 = new System.Windows.Forms.ComboBox();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem24 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.formReport = new DevExpress.XtraLayout.LayoutControlItem();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSVDataSet = new DMDS.DSVDataSet();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.kHOATableAdapter = new DMDS.DSVDataSetTableAdapters.KHOATableAdapter();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new DMDS.DSVDataSetTableAdapters.GIANGVIENTableAdapter();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new DMDS.DSVDataSetTableAdapters.LOPTableAdapter();
            this.sINHVIENTableAdapter = new DMDS.DSVDataSetTableAdapters.SINHVIENTableAdapter();
            this.dSVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new DMDS.DSVDataSetTableAdapters.MONHOCTableAdapter();
            this.dIEMTableAdapter = new DMDS.DSVDataSetTableAdapters.DIEMTableAdapter();
            this.colrowguid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimesRP)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh,
            this.btnDSGV,
            this.btnDSLH,
            this.btnDSSV,
            this.btnDSMH,
            this.btnDSDS,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.btnDSKhoa,
            this.barButtonItem12,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 42;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(790, 126);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiNew
            // 
            this.bbiNew.Id = 33;
            this.bbiNew.Name = "bbiNew";
            // 
            // bbiEdit
            // 
            this.bbiEdit.Id = 34;
            this.bbiEdit.Name = "bbiEdit";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Id = 35;
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // btnDSGV
            // 
            this.btnDSGV.Id = 32;
            this.btnDSGV.Name = "btnDSGV";
            // 
            // btnDSLH
            // 
            this.btnDSLH.Caption = "Lớp Học";
            this.btnDSLH.Id = 21;
            this.btnDSLH.ImageOptions.SvgImage = global::DMDS.Properties.Resources.actions_bookmark;
            this.btnDSLH.Name = "btnDSLH";
            this.btnDSLH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnDSSV
            // 
            this.btnDSSV.Caption = "Sinh Viên";
            this.btnDSSV.Id = 22;
            this.btnDSSV.ImageOptions.SvgImage = global::DMDS.Properties.Resources.bo_employee2;
            this.btnDSSV.Name = "btnDSSV";
            this.btnDSSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnDSMH
            // 
            this.btnDSMH.Caption = "Môn Học";
            this.btnDSMH.Id = 23;
            this.btnDSMH.ImageOptions.SvgImage = global::DMDS.Properties.Resources.bo_note;
            this.btnDSMH.Name = "btnDSMH";
            this.btnDSMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // btnDSDS
            // 
            this.btnDSDS.Caption = "Điểm Số";
            this.btnDSDS.Id = 24;
            this.btnDSDS.ImageOptions.SvgImage = global::DMDS.Properties.Resources.bo_task;
            this.btnDSDS.Name = "btnDSDS";
            this.btnDSDS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Khoa ";
            this.barButtonItem6.Id = 25;
            this.barButtonItem6.ImageOptions.SvgImage = global::DMDS.Properties.Resources.actions_book1;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Id = 36;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Lớp Học";
            this.barButtonItem8.Id = 27;
            this.barButtonItem8.ImageOptions.SvgImage = global::DMDS.Properties.Resources.actions_bookmark1;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Sinh Viên";
            this.barButtonItem9.Id = 28;
            this.barButtonItem9.ImageOptions.SvgImage = global::DMDS.Properties.Resources.actions_user;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Môn Học";
            this.barButtonItem10.Id = 29;
            this.barButtonItem10.ImageOptions.SvgImage = global::DMDS.Properties.Resources.bo_note1;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // btnDSKhoa
            // 
            this.btnDSKhoa.Caption = "Khoa";
            this.btnDSKhoa.Id = 30;
            this.btnDSKhoa.ImageOptions.SvgImage = global::DMDS.Properties.Resources.actions_book;
            this.btnDSKhoa.Name = "btnDSKhoa";
            this.btnDSKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Điểm Số";
            this.barButtonItem12.Id = 31;
            this.barButtonItem12.ImageOptions.SvgImage = global::DMDS.Properties.Resources.bo_task1;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem12_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Danh Sách Sinh Viên";
            this.barButtonItem1.Id = 37;
            this.barButtonItem1.ImageOptions.SvgImage = global::DMDS.Properties.Resources.bo_department2;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Danh Sách Điểm Môn";
            this.barButtonItem2.Id = 38;
            this.barButtonItem2.ImageOptions.SvgImage = global::DMDS.Properties.Resources.bo_report;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick_1);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Phiếu Điểm Sinh Viên";
            this.barButtonItem3.Id = 39;
            this.barButtonItem3.ImageOptions.SvgImage = global::DMDS.Properties.Resources.bo_contact;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick_1);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Phiếu Điểm Lớp";
            this.barButtonItem4.Id = 40;
            this.barButtonItem4.ImageOptions.SvgImage = global::DMDS.Properties.Resources.grid;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick_1);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Danh Sách Lớp Học";
            this.barButtonItem5.Id = 41;
            this.barButtonItem5.ImageOptions.SvgImage = global::DMDS.Properties.Resources.richeditbookmark;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick_1);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản Trị";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDSKhoa);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDSLH);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDSSV);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDSMH);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDSDS);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Danh Sách";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thông Tin";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem12);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem5, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Báo Cáo";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 734);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(790, 27);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tableLayoutPanel2);
            this.layoutControl1.Controls.Add(this.comboBox2);
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Controls.Add(this.simpleButton11);
            this.layoutControl1.Controls.Add(this.simpleButton10);
            this.layoutControl1.Controls.Add(this.simpleButton9);
            this.layoutControl1.Controls.Add(this.simpleButton8);
            this.layoutControl1.Controls.Add(this.simpleButton7);
            this.layoutControl1.Controls.Add(this.simpleButton6);
            this.layoutControl1.Controls.Add(this.simpleButton4);
            this.layoutControl1.Controls.Add(this.windowsUIButtonPanel1);
            this.layoutControl1.Controls.Add(this.buttonEdit1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.checkEdit1);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.simpleButton3);
            this.layoutControl1.Controls.Add(this.comboBox21);
            this.layoutControl1.Controls.Add(this.comboBox211);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem6,
            this.layoutControlItem5});
            this.layoutControl1.Location = new System.Drawing.Point(0, 126);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(781, 212, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(790, 608);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayout, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 457);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.71831F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.28169F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(766, 139);
            this.tableLayoutPanel2.TabIndex = 40;
            // 
            // tableLayout
            // 
            this.tableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout.ColumnCount = 6;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayout.Controls.Add(this.btnPreview, 3, 0);
            this.tableLayout.Controls.Add(this.btnCancelPreview, 4, 0);
            this.tableLayout.Controls.Add(this.lbTimesRP, 1, 0);
            this.tableLayout.Controls.Add(this.txtTimesRP, 2, 0);
            this.tableLayout.Location = new System.Drawing.Point(3, 99);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 1;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout.Size = new System.Drawing.Size(760, 37);
            this.tableLayout.TabIndex = 39;
            // 
            // btnPreview
            // 
            this.btnPreview.ImageOptions.SvgImage = global::DMDS.Properties.Resources.trackingchanges_accept1;
            this.btnPreview.Location = new System.Drawing.Point(459, 3);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(108, 31);
            this.btnPreview.StyleController = this.layoutControl1;
            this.btnPreview.TabIndex = 28;
            this.btnPreview.Text = "Xem";
            this.btnPreview.Visible = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click_1);
            // 
            // btnCancelPreview
            // 
            this.btnCancelPreview.ImageOptions.SvgImage = global::DMDS.Properties.Resources.trackingchanges_reject1;
            this.btnCancelPreview.Location = new System.Drawing.Point(573, 3);
            this.btnCancelPreview.Name = "btnCancelPreview";
            this.btnCancelPreview.Size = new System.Drawing.Size(108, 31);
            this.btnCancelPreview.StyleController = this.layoutControl1;
            this.btnCancelPreview.TabIndex = 29;
            this.btnCancelPreview.Text = "Thêm";
            this.btnCancelPreview.Visible = false;
            // 
            // lbTimesRP
            // 
            this.lbTimesRP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimesRP.AutoSize = true;
            this.lbTimesRP.Location = new System.Drawing.Point(231, 0);
            this.lbTimesRP.Name = "lbTimesRP";
            this.lbTimesRP.Size = new System.Drawing.Size(108, 37);
            this.lbTimesRP.TabIndex = 33;
            this.lbTimesRP.Text = "Số Lần";
            this.lbTimesRP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTimesRP.Visible = false;
            // 
            // txtTimesRP
            // 
            this.txtTimesRP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimesRP.Location = new System.Drawing.Point(345, 8);
            this.txtTimesRP.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtTimesRP.Name = "txtTimesRP";
            this.txtTimesRP.Size = new System.Drawing.Size(108, 20);
            this.txtTimesRP.TabIndex = 34;
            this.txtTimesRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimesRP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTimesRP.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.cbKhoaRP, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbKhoaRP, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtCodeDepartment, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbCodeDepartment, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbLopRP, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbCodeClass, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbMonhocRP, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbCodeSubject, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtCodeClass, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtCodeSubject, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.cbLopRP, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbMonhocRP, 2, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(760, 90);
            this.tableLayoutPanel3.TabIndex = 38;
            // 
            // cbKhoaRP
            // 
            this.cbKhoaRP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoaRP.FormattingEnabled = true;
            this.cbKhoaRP.Location = new System.Drawing.Point(155, 3);
            this.cbKhoaRP.Name = "cbKhoaRP";
            this.cbKhoaRP.Size = new System.Drawing.Size(298, 21);
            this.cbKhoaRP.TabIndex = 21;
            this.cbKhoaRP.Visible = false;
            this.cbKhoaRP.SelectedIndexChanged += new System.EventHandler(this.cbKhoaRP_SelectedIndexChanged);
            // 
            // lbKhoaRP
            // 
            this.lbKhoaRP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbKhoaRP.AutoSize = true;
            this.lbKhoaRP.Location = new System.Drawing.Point(79, 0);
            this.lbKhoaRP.Name = "lbKhoaRP";
            this.lbKhoaRP.Size = new System.Drawing.Size(70, 27);
            this.lbKhoaRP.TabIndex = 22;
            this.lbKhoaRP.Text = "Khoa";
            this.lbKhoaRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbKhoaRP.Visible = false;
            // 
            // txtCodeDepartment
            // 
            this.txtCodeDepartment.Location = new System.Drawing.Point(535, 3);
            this.txtCodeDepartment.MenuManager = this.ribbonControl;
            this.txtCodeDepartment.Name = "txtCodeDepartment";
            this.txtCodeDepartment.Properties.ReadOnly = true;
            this.txtCodeDepartment.Size = new System.Drawing.Size(146, 20);
            this.txtCodeDepartment.TabIndex = 24;
            this.txtCodeDepartment.Visible = false;
            // 
            // lbCodeDepartment
            // 
            this.lbCodeDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCodeDepartment.AutoSize = true;
            this.lbCodeDepartment.Location = new System.Drawing.Point(459, 0);
            this.lbCodeDepartment.Name = "lbCodeDepartment";
            this.lbCodeDepartment.Size = new System.Drawing.Size(70, 27);
            this.lbCodeDepartment.TabIndex = 2;
            this.lbCodeDepartment.Text = "Mã Khoa";
            this.lbCodeDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCodeDepartment.Visible = false;
            // 
            // lbLopRP
            // 
            this.lbLopRP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLopRP.AutoSize = true;
            this.lbLopRP.Location = new System.Drawing.Point(79, 27);
            this.lbLopRP.Name = "lbLopRP";
            this.lbLopRP.Size = new System.Drawing.Size(70, 27);
            this.lbLopRP.TabIndex = 25;
            this.lbLopRP.Text = "Lớp";
            this.lbLopRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbLopRP.Visible = false;
            // 
            // lbCodeClass
            // 
            this.lbCodeClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCodeClass.AutoSize = true;
            this.lbCodeClass.Location = new System.Drawing.Point(459, 27);
            this.lbCodeClass.Name = "lbCodeClass";
            this.lbCodeClass.Size = new System.Drawing.Size(70, 27);
            this.lbCodeClass.TabIndex = 26;
            this.lbCodeClass.Text = "Mã Lớp";
            this.lbCodeClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCodeClass.Visible = false;
            // 
            // lbMonhocRP
            // 
            this.lbMonhocRP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMonhocRP.AutoSize = true;
            this.lbMonhocRP.Location = new System.Drawing.Point(79, 54);
            this.lbMonhocRP.Name = "lbMonhocRP";
            this.lbMonhocRP.Size = new System.Drawing.Size(70, 36);
            this.lbMonhocRP.TabIndex = 27;
            this.lbMonhocRP.Text = "Môn Học";
            this.lbMonhocRP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbMonhocRP.Visible = false;
            // 
            // lbCodeSubject
            // 
            this.lbCodeSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCodeSubject.AutoSize = true;
            this.lbCodeSubject.Location = new System.Drawing.Point(459, 54);
            this.lbCodeSubject.Name = "lbCodeSubject";
            this.lbCodeSubject.Size = new System.Drawing.Size(70, 36);
            this.lbCodeSubject.TabIndex = 28;
            this.lbCodeSubject.Text = "Mã Môn Học";
            this.lbCodeSubject.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbCodeSubject.Visible = false;
            // 
            // txtCodeClass
            // 
            this.txtCodeClass.Location = new System.Drawing.Point(535, 30);
            this.txtCodeClass.MenuManager = this.ribbonControl;
            this.txtCodeClass.Name = "txtCodeClass";
            this.txtCodeClass.Properties.ReadOnly = true;
            this.txtCodeClass.Size = new System.Drawing.Size(146, 20);
            this.txtCodeClass.TabIndex = 29;
            this.txtCodeClass.Visible = false;
            // 
            // txtCodeSubject
            // 
            this.txtCodeSubject.Location = new System.Drawing.Point(535, 57);
            this.txtCodeSubject.MenuManager = this.ribbonControl;
            this.txtCodeSubject.Name = "txtCodeSubject";
            this.txtCodeSubject.Properties.ReadOnly = true;
            this.txtCodeSubject.Size = new System.Drawing.Size(146, 20);
            this.txtCodeSubject.TabIndex = 30;
            this.txtCodeSubject.Visible = false;
            // 
            // cbLopRP
            // 
            this.cbLopRP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLopRP.FormattingEnabled = true;
            this.cbLopRP.Location = new System.Drawing.Point(155, 30);
            this.cbLopRP.Name = "cbLopRP";
            this.cbLopRP.Size = new System.Drawing.Size(298, 21);
            this.cbLopRP.TabIndex = 31;
            this.cbLopRP.Visible = false;
            this.cbLopRP.SelectedIndexChanged += new System.EventHandler(this.cbLopRP_SelectedIndexChanged);
            // 
            // cbMonhocRP
            // 
            this.cbMonhocRP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonhocRP.FormattingEnabled = true;
            this.cbMonhocRP.Location = new System.Drawing.Point(155, 57);
            this.cbMonhocRP.Name = "cbMonhocRP";
            this.cbMonhocRP.Size = new System.Drawing.Size(298, 21);
            this.cbMonhocRP.TabIndex = 32;
            this.cbMonhocRP.Visible = false;
            this.cbMonhocRP.SelectedIndexChanged += new System.EventHandler(this.cbMonhocRP_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(52, 407);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(726, 21);
            this.comboBox2.TabIndex = 34;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.tableLayoutPanel1);
            this.layoutControl2.Location = new System.Drawing.Point(12, 246);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(833, 272, 650, 400);
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(766, 157);
            this.layoutControl2.TabIndex = 33;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.998197F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0006F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0002F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0002F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0002F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0006F));
            this.tableLayoutPanel1.Controls.Add(this.lbStudent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbGender, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbLastName, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbPlace, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbAddress, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbBirthday, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtBirthday, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPlace, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.radGender, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbStudent, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbClass, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtClass, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtCode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDepartment, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbDepartment, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTimes, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTimes, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 133);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lbStudent
            // 
            this.lbStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStudent.AutoSize = true;
            this.lbStudent.Location = new System.Drawing.Point(3, 0);
            this.lbStudent.Name = "lbStudent";
            this.lbStudent.Size = new System.Drawing.Size(68, 27);
            this.lbStudent.TabIndex = 22;
            this.lbStudent.Text = "Sinh Viên";
            this.lbStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbStudent.Visible = false;
            // 
            // lbGender
            // 
            this.lbGender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(447, 0);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(68, 27);
            this.lbGender.TabIndex = 19;
            this.lbGender.Text = "Giới tính";
            this.lbGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbGender.Visible = false;
            // 
            // lbLastName
            // 
            this.lbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(447, 53);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(68, 26);
            this.lbLastName.TabIndex = 9;
            this.lbLastName.Text = "Họ";
            this.lbLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbLastName.Visible = false;
            // 
            // lbPlace
            // 
            this.lbPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlace.AutoSize = true;
            this.lbPlace.Location = new System.Drawing.Point(447, 79);
            this.lbPlace.Name = "lbPlace";
            this.lbPlace.Size = new System.Drawing.Size(68, 26);
            this.lbPlace.TabIndex = 10;
            this.lbPlace.Text = "Nơi sinh";
            this.lbPlace.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbPlace.Visible = false;
            // 
            // lbAddress
            // 
            this.lbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(447, 27);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(68, 26);
            this.lbAddress.TabIndex = 8;
            this.lbAddress.Text = "Địa chỉ";
            this.lbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAddress.Visible = false;
            // 
            // lbBirthday
            // 
            this.lbBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(447, 105);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(68, 28);
            this.lbBirthday.TabIndex = 16;
            this.lbBirthday.Text = "Ngày sinh";
            this.lbBirthday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbBirthday.Visible = false;
            // 
            // txtBirthday
            // 
            this.txtBirthday.EditValue = null;
            this.txtBirthday.Location = new System.Drawing.Point(521, 108);
            this.txtBirthday.MenuManager = this.ribbonControl;
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBirthday.Size = new System.Drawing.Size(218, 20);
            this.txtBirthday.TabIndex = 18;
            this.txtBirthday.Visible = false;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(521, 82);
            this.txtPlace.MenuManager = this.ribbonControl;
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(218, 20);
            this.txtPlace.TabIndex = 17;
            this.txtPlace.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(521, 56);
            this.txtLastName.MenuManager = this.ribbonControl;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(218, 20);
            this.txtLastName.TabIndex = 13;
            this.txtLastName.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(521, 30);
            this.txtAddress.MenuManager = this.ribbonControl;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(218, 20);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.Visible = false;
            // 
            // radGender
            // 
            this.radGender.Location = new System.Drawing.Point(521, 3);
            this.radGender.MenuManager = this.ribbonControl;
            this.radGender.Name = "radGender";
            this.radGender.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radGender.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.radGender.Properties.Appearance.Options.UseBackColor = true;
            this.radGender.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radGender.Properties.Columns = 2;
            this.radGender.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.radGender.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Nam", true, "gioitinh", "radIsMale"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Nữ", true, "gioitinh", "radIsFemale")});
            this.radGender.Properties.Name = "radGender";
            this.radGender.Properties.Padding = new System.Windows.Forms.Padding(4, 2, 4, 4);
            this.radGender.Size = new System.Drawing.Size(218, 20);
            this.radGender.TabIndex = 20;
            this.radGender.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // cbStudent
            // 
            this.cbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(77, 3);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(216, 21);
            this.cbStudent.TabIndex = 21;
            this.cbStudent.Visible = false;
            this.cbStudent.SelectedIndexChanged += new System.EventHandler(this.cbStudent_SelectedIndexChanged);
            // 
            // lbClass
            // 
            this.lbClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(3, 105);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(68, 28);
            this.lbClass.TabIndex = 6;
            this.lbClass.Text = "Lớp";
            this.lbClass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbClass.Visible = false;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(77, 108);
            this.txtClass.MenuManager = this.ribbonControl;
            this.txtClass.Name = "txtClass";
            this.txtClass.Properties.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(216, 20);
            this.txtClass.TabIndex = 7;
            this.txtClass.Visible = false;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(77, 30);
            this.txtCode.MenuManager = this.ribbonControl;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(216, 20);
            this.txtCode.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 56);
            this.txtName.MenuManager = this.ribbonControl;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(77, 82);
            this.txtDepartment.MenuManager = this.ribbonControl;
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Properties.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(216, 20);
            this.txtDepartment.TabIndex = 5;
            this.txtDepartment.Visible = false;
            // 
            // lbDepartment
            // 
            this.lbDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Location = new System.Drawing.Point(3, 79);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(68, 26);
            this.lbDepartment.TabIndex = 4;
            this.lbDepartment.Text = "Khoa";
            this.lbDepartment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbDepartment.Visible = false;
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(3, 53);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(68, 26);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Tên";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbCode
            // 
            this.lbCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(3, 27);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(68, 26);
            this.lbCode.TabIndex = 2;
            this.lbCode.Text = "Mã";
            this.lbCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTimes
            // 
            this.lbTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimes.AutoSize = true;
            this.lbTimes.Location = new System.Drawing.Point(299, 27);
            this.lbTimes.Name = "lbTimes";
            this.lbTimes.Size = new System.Drawing.Size(68, 26);
            this.lbTimes.TabIndex = 23;
            this.lbTimes.Text = "Số Lần";
            this.lbTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTimes.Visible = false;
            // 
            // txtTimes
            // 
            this.txtTimes.Location = new System.Drawing.Point(373, 30);
            this.txtTimes.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtTimes.Name = "txtTimes";
            this.txtTimes.Size = new System.Drawing.Size(68, 20);
            this.txtTimes.TabIndex = 24;
            this.txtTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimes.Visible = false;
            this.txtTimes.ValueChanged += new System.EventHandler(this.txtTimes_ValueChanged);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Form";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem11});
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(766, 157);
            this.layoutControlGroup2.Text = "Form";
            this.layoutControlGroup2.TextVisible = false;
            this.layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.tableLayoutPanel1;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(746, 137);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // simpleButton11
            // 
            this.simpleButton11.ImageOptions.SvgImage = global::DMDS.Properties.Resources.changeview;
            this.simpleButton11.Location = new System.Drawing.Point(572, 12);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(99, 36);
            this.simpleButton11.StyleController = this.layoutControl1;
            this.simpleButton11.TabIndex = 31;
            this.simpleButton11.Text = "Làm Mới";
            this.simpleButton11.Click += new System.EventHandler(this.simpleButton11_Click);
            // 
            // simpleButton10
            // 
            this.simpleButton10.Enabled = false;
            this.simpleButton10.ImageOptions.SvgImage = global::DMDS.Properties.Resources.trackingchanges_reject;
            this.simpleButton10.Location = new System.Drawing.Point(443, 12);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton10.Size = new System.Drawing.Size(125, 36);
            this.simpleButton10.StyleController = this.layoutControl1;
            this.simpleButton10.TabIndex = 30;
            this.simpleButton10.Text = "Hủy Bỏ";
            this.simpleButton10.Click += new System.EventHandler(this.simpleButton10_Click);
            // 
            // simpleButton9
            // 
            this.simpleButton9.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton9.AppearanceDisabled.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton9.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton9.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton9.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton9.AppearanceDisabled.Options.UseBorderColor = true;
            this.simpleButton9.AppearanceDisabled.Options.UseForeColor = true;
            this.simpleButton9.AppearanceDisabled.Options.UseImage = true;
            this.simpleButton9.Enabled = false;
            this.simpleButton9.ImageOptions.SvgImage = global::DMDS.Properties.Resources.trackingchanges_accept;
            this.simpleButton9.Location = new System.Drawing.Point(323, 12);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton9.Size = new System.Drawing.Size(116, 36);
            this.simpleButton9.StyleController = this.layoutControl1;
            this.simpleButton9.TabIndex = 29;
            this.simpleButton9.Text = "Xác Nhận";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // simpleButton8
            // 
            this.simpleButton8.ImageOptions.SvgImage = global::DMDS.Properties.Resources.delete;
            this.simpleButton8.Location = new System.Drawing.Point(221, 12);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(98, 36);
            this.simpleButton8.StyleController = this.layoutControl1;
            this.simpleButton8.TabIndex = 28;
            this.simpleButton8.Text = "Xóa";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.ImageOptions.SvgImage = global::DMDS.Properties.Resources.actions_add;
            this.simpleButton7.Location = new System.Drawing.Point(12, 12);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(96, 36);
            this.simpleButton7.StyleController = this.layoutControl1;
            this.simpleButton7.TabIndex = 27;
            this.simpleButton7.Text = "Thêm";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageOptions.SvgImage = global::DMDS.Properties.Resources.actions_edit1;
            this.simpleButton6.Location = new System.Drawing.Point(112, 12);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(105, 36);
            this.simpleButton6.StyleController = this.layoutControl1;
            this.simpleButton6.TabIndex = 35;
            this.simpleButton6.Text = "Sửa";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Enabled = false;
            this.simpleButton4.ImageOptions.SvgImage = global::DMDS.Properties.Resources.paymentunpaid;
            this.simpleButton4.Location = new System.Drawing.Point(675, 12);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton4.Size = new System.Drawing.Size(103, 36);
            this.simpleButton4.StyleController = this.layoutControl1;
            this.simpleButton4.TabIndex = 24;
            this.simpleButton4.Text = "Thoát Ra";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton()});
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(12, 12);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(766, 55);
            this.windowsUIButtonPanel1.TabIndex = 10;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(502, 12);
            this.buttonEdit1.MenuManager = this.ribbonControl;
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Size = new System.Drawing.Size(83, 20);
            this.buttonEdit1.StyleController = this.layoutControl1;
            this.buttonEdit1.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 52);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(766, 190);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DataSourceChanged += new System.EventHandler(this.gridControl1_DataSourceChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colMAMH,
            this.colLAN,
            this.colDIEM});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Top";
            this.gridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 2;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 3;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(397, 12);
            this.checkEdit1.MenuManager = this.ribbonControl;
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "checkEdit1";
            this.checkEdit1.Size = new System.Drawing.Size(381, 20);
            this.checkEdit1.StyleController = this.layoutControl1;
            this.checkEdit1.TabIndex = 8;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 71);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(766, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 97);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(766, 22);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 12;
            this.simpleButton2.Text = "simpleButton2";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(12, 97);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(766, 22);
            this.simpleButton3.StyleController = this.layoutControl1;
            this.simpleButton3.TabIndex = 13;
            this.simpleButton3.Text = "simpleButton3";
            // 
            // comboBox21
            // 
            this.comboBox21.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Location = new System.Drawing.Point(52, 432);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(267, 21);
            this.comboBox21.TabIndex = 34;
            this.comboBox21.SelectedValueChanged += new System.EventHandler(this.comboBox21_SelectedValueChanged);
            // 
            // comboBox211
            // 
            this.comboBox211.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox211.FormattingEnabled = true;
            this.comboBox211.Location = new System.Drawing.Point(363, 432);
            this.comboBox211.Name = "comboBox211";
            this.comboBox211.Size = new System.Drawing.Size(415, 21);
            this.comboBox211.TabIndex = 34;
            this.comboBox211.SelectedValueChanged += new System.EventHandler(this.comboBox211_SelectedValueChanged);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.buttonEdit1;
            this.layoutControlItem4.Location = new System.Drawing.Point(385, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(192, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(50, 20);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.checkEdit1;
            this.layoutControlItem1.CustomizationFormText = "actionLayout";
            this.layoutControlItem1.Location = new System.Drawing.Point(385, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(385, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.simpleButton2;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 85);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(770, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.simpleButton3;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 85);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(770, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 59);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(770, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.windowsUIButtonPanel1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(770, 59);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem9,
            this.layoutControlItem20,
            this.layoutControlItem21,
            this.layoutControlItem22,
            this.layoutControlItem23,
            this.layoutControlItem24,
            this.layoutControlItem25,
            this.layoutControlItem10,
            this.layoutControlItem3,
            this.layoutControlItem13,
            this.layoutControlItem16,
            this.formReport});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(790, 608);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.CustomizationFormText = "datagrid";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(770, 194);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.simpleButton4;
            this.layoutControlItem9.Location = new System.Drawing.Point(663, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(107, 40);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.simpleButton6;
            this.layoutControlItem20.Location = new System.Drawing.Point(100, 0);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(109, 40);
            this.layoutControlItem20.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem20.TextVisible = false;
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.simpleButton7;
            this.layoutControlItem21.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(100, 40);
            this.layoutControlItem21.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem21.TextVisible = false;
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.Control = this.simpleButton8;
            this.layoutControlItem22.Location = new System.Drawing.Point(209, 0);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(102, 40);
            this.layoutControlItem22.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem22.TextVisible = false;
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.Control = this.simpleButton9;
            this.layoutControlItem23.Location = new System.Drawing.Point(311, 0);
            this.layoutControlItem23.Name = "layoutControlItem23";
            this.layoutControlItem23.Size = new System.Drawing.Size(120, 40);
            this.layoutControlItem23.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem23.TextVisible = false;
            // 
            // layoutControlItem24
            // 
            this.layoutControlItem24.Control = this.simpleButton10;
            this.layoutControlItem24.Location = new System.Drawing.Point(431, 0);
            this.layoutControlItem24.Name = "layoutControlItem24";
            this.layoutControlItem24.Size = new System.Drawing.Size(129, 40);
            this.layoutControlItem24.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem24.TextVisible = false;
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.Control = this.simpleButton11;
            this.layoutControlItem25.Location = new System.Drawing.Point(560, 0);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Size = new System.Drawing.Size(103, 40);
            this.layoutControlItem25.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem25.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.layoutControl2;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 234);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(770, 161);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.comboBox2;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 395);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(770, 25);
            this.layoutControlItem3.Text = "KHOA";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(28, 13);
            this.layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.comboBox21;
            this.layoutControlItem13.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem13.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 420);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(311, 25);
            this.layoutControlItem13.Text = "KHOA";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(28, 13);
            this.layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.comboBox211;
            this.layoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem16.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem16.Location = new System.Drawing.Point(311, 420);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(459, 25);
            this.layoutControlItem16.Text = "LỚP";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(28, 13);
            this.layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // formReport
            // 
            this.formReport.Control = this.tableLayoutPanel2;
            this.formReport.Location = new System.Drawing.Point(0, 445);
            this.formReport.Name = "formReport";
            this.formReport.Size = new System.Drawing.Size(770, 143);
            this.formReport.Text = "form Report";
            this.formReport.TextSize = new System.Drawing.Size(0, 0);
            this.formReport.TextVisible = false;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DSVConnectionString";
            msSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows;
            msSqlConnectionParameters1.DatabaseName = "DSV";
            msSqlConnectionParameters1.ServerName = "LONGTRNN\\MSSQLSERVER01";
            this.sqlDataSource1.ConnectionParameters = msSqlConnectionParameters1;
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_INSERT_DIEM";
            queryParameter1.Name = "@MASV";
            queryParameter1.Type = typeof(string);
            queryParameter2.Name = "@MAMH";
            queryParameter2.Type = typeof(string);
            queryParameter3.Name = "@LAN";
            queryParameter3.Type = typeof(short);
            queryParameter3.ValueInfo = "0";
            queryParameter4.Name = "@DIEM";
            queryParameter4.Type = typeof(double);
            queryParameter4.ValueInfo = "0";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.StoredProcName = "SP_INSERT_DIEM";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlNQX0lOU0VSVF9ESUVNIiAvP" +
    "jwvRGF0YVNldD4=";
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.dSVDataSet;
            // 
            // dSVDataSet
            // 
            this.dSVDataSet.DataSetName = "DSVDataSet";
            this.dSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.dSVDataSet;
            // 
            // dIEMBindingSource
            // 
            this.dIEMBindingSource.DataMember = "DIEM";
            this.dIEMBindingSource.DataSource = this.dSVDataSet;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 0;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 1;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 2;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(724, 326);
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.dSVDataSet;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dSVDataSet;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // dSVDataSetBindingSource
            // 
            this.dSVDataSetBindingSource.DataSource = this.dSVDataSet;
            this.dSVDataSetBindingSource.Position = 0;
            // 
            // sINHVIENBindingSource1
            // 
            this.sINHVIENBindingSource1.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource1.DataSource = this.dSVDataSet;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dSVDataSet;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // colrowguid
            // 
            this.colrowguid.FieldName = "rowguid";
            this.colrowguid.Name = "colrowguid";
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(746, 142);
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(50, 20);
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.Location = new System.Drawing.Point(0, 59);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Size = new System.Drawing.Size(746, 17);
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(50, 20);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 761);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimesRP)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarButtonItem btnDSGV;
        private DevExpress.XtraBars.BarButtonItem btnDSLH;
        private DevExpress.XtraBars.BarButtonItem btnDSSV;
        private DevExpress.XtraBars.BarButtonItem btnDSMH;
        private DevExpress.XtraBars.BarButtonItem btnDSDS;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraBars.BarButtonItem btnDSKhoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DSVDataSet dSVDataSet;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private DSVDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private DSVDataSetTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSVDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DSVDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource dSVDataSetBindingSource;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource1;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSVDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource dIEMBindingSource;
        private DSVDataSetTableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colrowguid;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem24;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private System.Windows.Forms.ComboBox comboBox2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.ComboBox comboBox21;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private System.Windows.Forms.ComboBox comboBox211;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbDepartment;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label lbName;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtDepartment;
        private DevExpress.XtraEditors.TextEdit txtClass;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbPlace;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbBirthday;
        private DevExpress.XtraEditors.DateEdit txtBirthday;
        private DevExpress.XtraEditors.TextEdit txtPlace;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.RadioGroup radGender;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private System.Windows.Forms.Label lbStudent;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.Label lbTimes;
        private System.Windows.Forms.NumericUpDown txtTimes;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.SimpleButton btnCancelPreview;
        private System.Windows.Forms.Label lbTimesRP;
        private System.Windows.Forms.NumericUpDown txtTimesRP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cbKhoaRP;
        private System.Windows.Forms.Label lbKhoaRP;
        private DevExpress.XtraEditors.TextEdit txtCodeDepartment;
        private System.Windows.Forms.Label lbCodeDepartment;
        private System.Windows.Forms.Label lbLopRP;
        private System.Windows.Forms.Label lbCodeClass;
        private System.Windows.Forms.Label lbMonhocRP;
        private System.Windows.Forms.Label lbCodeSubject;
        private DevExpress.XtraEditors.TextEdit txtCodeClass;
        private DevExpress.XtraEditors.TextEdit txtCodeSubject;
        private System.Windows.Forms.ComboBox cbLopRP;
        private System.Windows.Forms.ComboBox cbMonhocRP;
        private DevExpress.XtraLayout.LayoutControlItem formReport;
    }
}