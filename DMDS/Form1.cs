
using DMDS.controller;
using DMDS.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Globalization;

namespace DMDS
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private string TABLE = "";
        private string REPORT = "";
        private string STATEFORM = "";
        private DevExpress.XtraGrid.GridControl ReportData = new DevExpress.XtraGrid.GridControl();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set enable or disable
            disableAllButtonForm();
            HideList();
        }

        #region Application Method

        #region Danh Sach
        
        bool LoadList()
        {
            TABLE = "";
            REPORT = "";
            layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem20.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem22.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem23.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            return true;

        }

        bool HideList()
        {
            TABLE = "";
            REPORT = "";
            hideForm();
            layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem20.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem22.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem23.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            return true;

        }

        #endregion

        #region Báo Cáo
        
        bool LoadReport()
        {
            TABLE = "";
            openFormReport();

            // Finding DataSource
            DataTable KhoaData = KhoaController.Instance.GetListKhoa();
            DataTable LopData = LopController.Instance.GetListLop();

            // Bindings
            KhoaData = addAllCategory(KhoaData, "makh", "ALLDEPARTMENT", "tenkh", "Tất Cả Khoa");
            LopData = addAllCategory(LopData, "malop", "ALLCLASS", "tenlop", "Tất Cả Lớp");

            cbKhoaRP.DataSource = KhoaData;
            cbKhoaRP.DisplayMember = "tenkh";
            cbKhoaRP.ValueMember = "makh";

            cbLopRP.DataSource = LopData;
            cbLopRP.DisplayMember = "tenlop";
            cbLopRP.ValueMember = "malop";


            txtCodeDepartment.Text = cbKhoaRP.SelectedValue.ToString() == "ALLDEPARTMENT" ? "" : cbKhoaRP.SelectedValue.ToString();
            txtCodeClass.Text = cbLopRP.SelectedValue.ToString() == "ALLCLASS" ? "" : cbLopRP.SelectedValue.ToString();

            if (REPORT == "DSSV")
            {
                lbMonhocRP.Visible = false;
                lbCodeSubject.Visible = false;
                lbTimesRP.Visible = false;

                cbMonhocRP.Visible = false;
                txtCodeSubject.Visible = false;
                txtTimesRP.Visible = false;
            }
            else if (REPORT == "PDSV")
            {
                lbMonhocRP.Text = "Sinh Viên";
                lbCodeSubject.Text = "Mã Sinh Viên";

                cbMonhocRP.Text = "Chọn Sinh Viên";

                DataTable SinhvienData = SinhvienController.Instance.GetListSinhvien();

                // merge masv, ho, ten column
                SinhvienData.Columns.Add(
                            "masvhoten",
                            typeof(string),
                            "masv + ' ' + ho + ' ' + ten");

                cbMonhocRP.DataSource = SinhvienData;
                cbMonhocRP.DisplayMember = "masvhoten";
                cbMonhocRP.ValueMember = "masv";

                txtCodeSubject.Text = cbMonhocRP.SelectedValue != null ? cbMonhocRP.SelectedValue.ToString() : "";
            }
            else if (REPORT == "DSLH")
            {
                lbMonhocRP.Visible = false;
                lbCodeSubject.Visible = false;
                lbTimesRP.Visible = false;

                cbMonhocRP.Visible = false;
                txtCodeSubject.Visible = false;
                txtTimesRP.Visible = false;
            }
            else if (REPORT == "PDLH")
            {
                lbMonhocRP.Visible = false;
                lbCodeSubject.Visible = false;
                lbTimesRP.Visible = false;

                cbMonhocRP.Visible = false;
                txtCodeSubject.Visible = false;
                txtTimesRP.Visible = false;
            }
            else if (REPORT == "DSDMH")
            {
                lbMonhocRP.Text = "Môn Học";
                lbCodeSubject.Text = "Mã Môn Học";

                cbMonhocRP.Text = "Chọn Môn Học";

                DataTable MonhocData = MonhocController.Instance.GetListMonhoc();

                // merge masv, ho, ten column
                MonhocData = addAllCategory(MonhocData, "mamh", "", "tenmh", "Tất Cả Môn Học");
                MonhocData.Columns.Add(
                            "mh",
                            typeof(string),
                            "mamh + ' ' + tenmh");

                cbMonhocRP.DataSource = MonhocData;
                cbMonhocRP.DisplayMember = "mh";
                cbMonhocRP.ValueMember = "mamh";

                txtCodeSubject.Text = cbMonhocRP.SelectedValue.ToString() == "" ? "" : cbMonhocRP.SelectedValue.ToString();
            }
            return true;
        }

        bool HideReport()
        {
            TABLE = "";
            REPORT = "";
            closeFormReport();
            
            return true;
        }

        #endregion

        #endregion

        #region Báo Cáo functions
        
        // Mở Form
        void openFormReport ()
        {
            formReport.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

            lbKhoaRP.Visible = true;
            lbLopRP.Visible = true;
            lbMonhocRP.Visible = true;
            lbCodeDepartment.Visible = true;
            lbCodeClass.Visible = true;
            lbCodeSubject.Visible = true;
            lbTimesRP.Visible = true;

            cbKhoaRP.Visible = true;
            cbLopRP.Visible = true;
            cbMonhocRP.Visible = true;
            txtCodeDepartment.Visible = true;
            txtCodeClass.Visible = true;
            txtCodeSubject.Visible = true;
            txtTimesRP.Visible = true;

            btnPreview.Visible = true;
            btnCancelPreview.Visible = true;
        }
        
        // Đóng Form
        void closeFormReport()
        {
            formReport.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            lbKhoaRP.Visible = false;
            lbLopRP.Visible = false;
            lbMonhocRP.Visible = false;
            lbCodeDepartment.Visible = false;
            lbCodeClass.Visible = false;
            lbCodeSubject.Visible = false;
            lbTimesRP.Visible = false;

            cbKhoaRP.Visible = false;
            cbLopRP.Visible = false;
            cbMonhocRP.Visible = false;
            txtCodeDepartment.Visible = false;
            txtCodeClass.Visible = false;
            txtCodeSubject.Visible = false;
            txtTimesRP.Visible = false;

            btnPreview.Visible = false;
            btnCancelPreview.Visible = false;
        }

        // Report Danh sách Các Sinh Viên theo Lớp, Khoa
        void LoadDSSV(string makh, string malop)
        {
            if (makh == "" && malop == "")
            {
                makh = "ALLDEPARTMENT";
                malop = "ALLCLASS";
            }
            else if (makh != "" && malop == "")
            {
                malop = "ALLCLASS";
            }

            DataTable DSSV =  SinhvienController.Instance.GetListSinhvienByMalop(malop, makh);
            
            gridControl1.DataSource = DSSV;
            gridControl1.ShowRibbonPrintPreview();
        }

        // Report Phiếu Điểm của Sinh Viên
        void LoadPDSV(string masv, int lan)
        {
            DataTable PDSV = DiemController.Instance.GetListDiemByMasv(masv, lan);

            gridControl1.DataSource = PDSV;
            gridControl1.ShowRibbonPrintPreview();
        }

        // Report Danh Sách Lớp theo Khoa
        void LoadDSLH(string makh)
        {
            if (makh == "")
            {
                makh = "ALLDEPARTMENT";
            }

            DataTable DSLH = LopController.Instance.GetListLopByMakh(makh);

            gridControl1.DataSource = DSLH;
            gridControl1.ShowRibbonPrintPreview();
        }

        // Report Phiếu Điểm cảu Lớp cụ thể
        void LoadPDLH(string malop)
        {
            if (malop == "")
            {
                MessageBox.Show("Chọn một Lớp cụ thể");
            }
            else
            {
                gridControl1.DataSource = DiemController.Instance.GetListDiemByMalop(malop, 0);
                gridControl1.ShowRibbonPrintPreview();
            }
        }

        // Report Danh sach Điểm Môn Học Theo Khoa, Lớp và Môn học
        void LoadDSDMH(string makh, string malop, string mamh, int lan)
        {
            DataTable Diem = DiemController.Instance.GetListDiem();

            if (mamh == "ALLSUBJECT" && makh == "ALLDEPARTMENT" && malop == "ALLCLASS")
            {
                Diem = DiemController.Instance.GetListDiemByLan(lan);
            }
            else if (mamh != "ALLSUBJECT" && makh == "ALLDEPARTMENT" && malop == "ALLCLASS")
            {
                if (mamh != "")
                {
                    Diem = DiemController.Instance.GetListDiemByMamh(mamh, lan);
                }
                else
                {
                    MessageBox.Show("Chọn Môn Học cụ thể");
                }
            }
            else if (mamh == "ALLSUBJECT" && makh != "ALLDEPARTMENT" && malop == "ALLCLASS")
            {
                if (makh != "")
                {
                    Diem = DiemController.Instance.GetListDiemByMakh(makh, lan);
                }
                else
                {
                    MessageBox.Show("Chọn Khoa cụ thể");
                }
            }
            else if (mamh == "ALLSUBJECT" && makh == "ALLDEPARTMENT" && malop != "ALLCLASS")
            {
                if (malop != "")
                {
                    Diem = DiemController.Instance.GetListDiemByMalop(malop, lan);
                }
                else
                {
                    MessageBox.Show("Chọn Lớp cụ thể");
                }
            }
            else if (mamh != "ALLSUBJECT" && makh != "ALLDEPARTMENT" && malop == "ALLCLASS")
            {
                if (mamh != "" && makh != "")
                {
                    Diem = DiemController.Instance.GetListDiemByMakhMamh(makh, mamh, lan);
                }
                else
                {
                    MessageBox.Show("Chọn Môn Học hay Khoa cụ thể");
                }
            }
            else if (mamh == "ALLSUBJECT" && makh != "ALLDEPARTMENT" && malop != "ALLCLASS")
            {
                if (makh != "" && malop != "")
                {
                    Diem = DiemController.Instance.GetListDiemByMakhMalop(makh, malop, lan);
                }
                else
                {
                    MessageBox.Show("Chọn Khoa hay Lớp cụ thể");
                }
            }
            else if (mamh != "ALLSUBJECT" && makh == "ALLDEPARTMENT" && malop != "ALLCLASS")
            {
                if (malop != "" && mamh != "")
                {
                    Diem = DiemController.Instance.GetListDiemByMalopMamh(malop, mamh, lan);
                }
                else
                {
                    MessageBox.Show("Chọn Môn Học hay Lớp cụ thể");
                }
            }
            else if (mamh != "ALLSUBJECT" && makh != "ALLDEPARTMENT" && malop != "ALLCLASS" && mamh != "" && makh != "" && malop != "")
            {
                if (makh != "" && mamh != "" && malop != "")
                {
                    Diem = DiemController.Instance.GetListDiemByMakhMalopMamh(makh, malop, mamh, lan);
                }
                else
                {
                    MessageBox.Show("Chọn Môn Học hay Khoa, Lớp cụ thể");
                }
            }
            gridControl1.DataSource = Diem;
            //DataTable DSDMH = DiemController.Instance.get
        }
        #endregion

        #region Danh Sach functions

        private void changeStateForm ()
        {
            if (layoutControlGroup2.Visibility.ToString() == "Never")
            {
                layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else if (layoutControlGroup2.Visibility.ToString() == "Always")
            {
                layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.AutoPopulateColumns = false;
            gridView1.PopulateColumns();
            gridView1.BestFitColumns();
            bsiRecordsCount.Caption = "RECORDS : " + gridView1.RowCount;

            hideForm();

            if (TABLE != "")
            {
                enableNonActionButtonCreateNewForm();
            }

            if (TABLE == "LOP")
            {
                lbDepartment.Visible = true;

                txtDepartment.Visible = true;
                
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                
                string textDepartment = comboBox2.SelectedValue.ToString();
                
                if (textDepartment == "ALLDEPARTMENT")
                {
                    textDepartment = "";
                }
                
                txtDepartment.Text = textDepartment;

            }
            else if (TABLE == "SINHVIEN")
            {   
                lbDepartment.Visible = true;
                lbClass.Visible = true;
                lbGender.Visible = true;
                lbAddress.Visible = true;
                lbLastName.Visible = true;
                lbPlace.Visible = true;
                lbBirthday.Visible = true;

                txtDepartment.Visible = true;
                txtClass.Visible = true;
                radGender.Visible = true;
                txtAddress.Visible = true;
                txtLastName.Visible = true;
                txtPlace.Visible = true;
                txtBirthday.Visible = true;

                // Get data from comboBox to assign to Code and Class value
                layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                string textDepartment = comboBox21.SelectedValue.ToString();
                string textClass = comboBox211.SelectedValue.ToString();
                
                if (textDepartment == "ALLDEPARTMENT")
                {
                    textDepartment = "";
                }
                
                if (textClass == "ALLCLASS")
                {
                    textClass = "";
                }
                
                txtDepartment.Text = textDepartment;
                txtClass.Text = textClass;
            }
            else if ( TABLE == "DIEM")
            {
                // Get data from comboBox to assign to Code and Class value
                layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                string textDepartment = comboBox21.SelectedValue != null?comboBox21.SelectedValue.ToString() : "";
                string textClass = comboBox211.SelectedValue != null?comboBox211.SelectedValue.ToString(): "";

                if (textDepartment == "ALLDEPARTMENT")
                {
                    textDepartment = "";
                }

                if (textClass == "ALLCLASS")
                {
                    textClass = "";
                }

                txtDepartment.Text = textDepartment;
                txtClass.Text = textClass;

                string textSubject = comboBox2.SelectedValue.ToString();
                if (textSubject == "ALLSUBJECT")
                {
                    textSubject = "";
                }
                txtPlace.Text = textSubject;
            }

            if (STATEFORM == "OPENFORM")
            {
                openForm();
            }
            else
            {
                closeForm();
            }


        }
        
        void LoadLop()
        {
            layoutControlItem3.Text = "KHOA"; 
            DataTable Khoa = KhoaController.Instance.GetListKhoa();
            Khoa = addAllCategory(Khoa, "makh", "ALLDEPARTMENT", "tenkh", "Tất Cả Khoa");

            comboBox2.DataSource = Khoa;

            comboBox2.DisplayMember = "tenkh";
            comboBox2.ValueMember = "makh";
        }

        void LoadSinhvien()
        {
            DataTable Khoa = KhoaController.Instance.GetListKhoa();
            Khoa = addAllCategory(Khoa, "makh", "ALLDEPARTMENT", "tenkh", "Tất Cả Khoa");

            DataTable Lop = LopController.Instance.GetListLopByMakh("ALLDEPARTMENT");
            Lop = addAllCategory(Lop, "malop", "ALLCLASS", "tenlop", "Tất Cả Lớp");

            comboBox21.DataSource = Khoa;
            comboBox211.DataSource = Lop;
            
            comboBox21.DisplayMember = "tenkh";
            comboBox211.DisplayMember = "tenlop";
            
            comboBox21.ValueMember = "makh";
            comboBox211.ValueMember = "malop";
        }

        void LoadDiem()
        {
            layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem3.Text = "MÔN HỌC";
            DataTable Monhoc = MonhocController.Instance.GetListMonhoc();
            Monhoc = addAllCategory(Monhoc, "mamh", "ALLSUBJECT", "tenmh", "Tất Cả Môn học");

            comboBox2.DataSource = Monhoc;
            comboBox2.DisplayMember = "tenmh";
            comboBox2.ValueMember = "mamh";

            string makh = comboBox21.SelectedValue != null ? comboBox21.SelectedValue.ToString() : "ALLDEPARTMENT";
            string malop = comboBox211.SelectedValue != null ? comboBox211.SelectedValue.ToString() : "ALLCLASS";

            DataTable Sinhvien = SinhvienController.Instance.GetListSinhvienByMalop(malop, makh);

            Sinhvien.Columns.Add(
                "hotenmasv",
                typeof(string),
                "ho + ' ' + ten + ' ' + masv");
            cbStudent.DataSource = Sinhvien;
            cbStudent.DisplayMember = "hotenmasv";
            cbStudent.ValueMember = "masv";
            cbStudent.SelectedIndex = 0;

            lbTimes.Visible = true;
            txtTimes.Visible = true;

            LoadSinhvien();
        }

        DataTable addAllCategory(DataTable table, string keyma, string ma, string keyten, string ten)
        {
            DataRow row = table.NewRow();

            row[keyma] = ma;
            row[keyten] = ten;
            
            table.Rows.InsertAt(row, 0);
            
            return table;
        }
        
        #endregion

        #region Danh Sach Menu
        
        #region Form Actions

        private void enableActionButtonCreateNewForm()
        {
            // Accept btn
            simpleButton9.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Default;
            simpleButton9.Enabled = true;
            // Cancel btn
            simpleButton10.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Default;
            simpleButton10.Enabled = true;

            // Thoát ra btn
            simpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Default;
            simpleButton4.Enabled = true;
        }

        private void enableNonActionButtonCreateNewForm()
        {
            // Sửa btn
            simpleButton6.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Default;
            simpleButton6.Enabled = true;
            // Thêm btn
            simpleButton7.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Default;
            simpleButton7.Enabled = true;
            // Xóa btn
            simpleButton8.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Default;
            simpleButton8.Enabled = true;
            // Làm Mới btn
            simpleButton11.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Default;
            simpleButton11.Enabled = true;
        }

        private void disableActionButtonCreateNewForm()
        {
            // Accept btn
            simpleButton9.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton9.Enabled = false;
            // Cancel btn
            simpleButton10.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton10.Enabled = false;
            // Thoát ra btn
            simpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton4.Enabled = false;
        }

        private void disableNonActionButtonCreateNewForm()
        {
            // Sửa btn
            simpleButton6.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton6.Enabled = false;
            // Thêm btn
            simpleButton7.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton7.Enabled = false;
            // Làm Mới btn
            simpleButton11.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton11.Enabled = false;
            // Xóa btn
            simpleButton8.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton8.Enabled = false;
        }

        private void disableAllButtonForm()
        {
            disableActionButtonCreateNewForm();
            disableNonActionButtonCreateNewForm();
        }

        private void openForm()
        {
            if (TABLE != "DIEM")
            {
                lbPlace.Text = "Nơi sinh";
                lbAddress.Text = "Địa chỉ";
                txtCode.ReadOnly = false;
                txtName.ReadOnly = false;
                txtPlace.ReadOnly = false;
                txtLastName.ReadOnly = false;
            }
            else
            {

                txtAddress.Visible = true;
                txtLastName.Visible = true;
                txtLastName.ReadOnly = true;
                txtPlace.Visible = true;
                txtPlace.ReadOnly = true;

                lbPlace.Text = "Môn học";
                lbAddress.Text = "Điểm";

                lbDepartment.Visible = true;
                lbClass.Visible = true;

                txtDepartment.Visible = true;
                txtClass.Visible = true;

                lbLastName.Visible = true;
                lbPlace.Visible = true;
                lbAddress.Visible = true;

                cbStudent.Visible = true;
                lbStudent.Visible = true;

                lbPlace.Text = "Môn học";
                lbAddress.Text = "Điểm";

                txtLastName.ReadOnly = true;
                txtPlace.ReadOnly = true;
                txtCode.ReadOnly = true;
                txtName.ReadOnly = true;

            }
            lbName.Visible = true;
            lbCode.Visible = true;

            txtName.Visible = true;
            txtCode.Visible = true;

            enableActionButtonCreateNewForm();
            disableNonActionButtonCreateNewForm();
            layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void closeForm()
        {
            disableActionButtonCreateNewForm();
            enableNonActionButtonCreateNewForm();
            layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            if (TABLE == "DIEM")
            {
                layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }

        private void hideForm()
        {
            layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            lbName.Visible = false;
            lbCode.Visible = false;
            lbStudent.Visible = false;
            lbDepartment.Visible = false;
            lbClass.Visible = false;
            lbGender.Visible = false;
            lbAddress.Visible = false;
            lbLastName.Visible = false;
            lbPlace.Visible = false;
            lbBirthday.Visible = false;

            txtName.Visible = false;
            txtCode.Visible = false;
            cbStudent.Visible = false;
            txtDepartment.Visible = false;
            txtClass.Visible = false;
            radGender.Visible = false;
            txtAddress.Visible = false;
            txtLastName.Visible = false;
            txtPlace.Visible = false;
            txtBirthday.Visible = false;
        }

        #endregion

        #region Danh Sach Cac Bang

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Khoa
            HideReport();
            LoadList();
            TABLE = "KHOA";
            if (TABLE == "KHOA")
            {
                gridControl1.DataSource = KhoaController.Instance.GetListKhoa();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Lop 
            HideReport();
            LoadList();
            TABLE = "LOP";
            if (TABLE == "LOP")
            {
                LoadLop();
                string makh = comboBox2.SelectedValue.ToString();

                gridControl1.DataSource = LopController.Instance.GetListLopByMakh(makh);
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Sinh Vien 
            HideReport();
            LoadList();
            TABLE = "SINHVIEN";
            if (TABLE == "SINHVIEN")
            {
                LoadSinhvien();
                string malop = comboBox211.SelectedValue != null ? comboBox211.SelectedValue.ToString() : "ALLCLASS";

                gridControl1.DataSource = SinhvienController.Instance.GetListSinhvienByMalop(malop, "ALLDEPARTMENT");
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Mon Hoc 
            HideReport();
            LoadList();
            TABLE = "MONHOC";
            if (TABLE == "MONHOC")
            {
                gridControl1.DataSource = MonhocController.Instance.GetListMonhoc();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Diem
            HideReport();
            LoadList();
            TABLE = "DIEM";
            if (TABLE == "DIEM")
            {
                LoadDiem();

                gridControl1.DataSource = DiemController.Instance.GetListDiem();
            }
        }

        #endregion

        #region Action Buttons

        // Add button open form
        private void simpleButton7_Click(object sender, EventArgs e)
        {
            STATEFORM = "OPENFORM";
            if (STATEFORM == "OPENFORM")
            {
                openForm();
                txtCode.Focus();
            }
        }

        // Edit button
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            string qr = "EXEC ";
            string text = "";
            DataRow row = gridView1.GetFocusedDataRow();
            List<string> fields = new List<string>();
            List<string> parameters = new List<string>();
            
            for (int i = 0; i < row.ItemArray.Length; i++)
            {
                fields.Add(row.Table.Columns[i].ColumnName);
                parameters.Add(row.ItemArray[i].ToString());

                text +=(row.Table.Columns[i].ColumnName + " " + row.ItemArray[i].ToString()) + " ";
            }


            if (TABLE == "KHOA")
            {
                qr += "SP_UPDATE_KHOA @" + String.Join(" , @", fields);
                
                // list to array <object>
                object[] obj = parameters.Cast<object>().ToArray();
                int result = DataProvider.Instance.ExecuteNonQuery(qr, obj);
                if (result > 0)
                {
                    MessageBox.Show(" Sửa Đổi Khoa Thành Công");
                }
                else
                {
                    MessageBox.Show("Sửa Đổi Khoa Thất Bại");
                }
            }
            else if (TABLE == "LOP")
            {
                qr += "SP_UPDATE_LOP @" + String.Join(" , @", fields);

                // list to array <object>
                object[] obj = parameters.Cast<object>().ToArray();
                int result = DataProvider.Instance.ExecuteNonQuery(qr, obj);
                if (result > 0)
                {
                    MessageBox.Show(" Sửa Đổi Lớp Thành Công");
                }
                else
                {
                    MessageBox.Show("Sửa Đổi Lớp Thất Bại");
                }
            }
            else if (TABLE == "SINHVIEN")
            {
                qr += "SP_UPDATE_SINHVIEN @" + String.Join(" , @", fields);

                // list to array <object>
                object[] obj = parameters.Cast<object>().ToArray();
                int result = DataProvider.Instance.ExecuteNonQuery(qr, obj);
                if (result > 0)
                {
                    MessageBox.Show(" Sửa Đổi Sinh Viên Thành Công");
                }
                else
                {
                    MessageBox.Show("Sửa Đổi Sinh Viên Thất Bại");
                }
            }
            else if (TABLE == "MONHOC")
            {
                qr += "SP_UPDATE_MONHOC @" + String.Join(" , @", fields);

                // list to array <object>
                object[] obj = parameters.Cast<object>().ToArray();
                int result = DataProvider.Instance.ExecuteNonQuery(qr, obj);
                if (result > 0)
                {
                    MessageBox.Show(" Sửa Đổi Môn Học Thành Công");
                }
                else
                {
                    MessageBox.Show("Sửa Đổi Môn Học Thất Bại");
                }
            }
            else if (TABLE == "DIEM")
            {
                qr += "SP_UPDATE_DIEM @" + String.Join(" , @", fields);

                // list to array <object>
                object[] obj = parameters.Cast<object>().ToArray();
                int result = DataProvider.Instance.ExecuteNonQuery(qr, obj);
                if (result > 0)
                {
                    MessageBox.Show(" Sửa Đổi Điểm Thành Công");
                }
                else
                {
                    MessageBox.Show("Sửa Đổi Điểm Thất Bại");
                }
            }

        }

        // Delete button
        private void simpleButton8_Click(object sender, EventArgs e)
        {
            string text = "";
            string ma = gridView1.GetFocusedDataRow().ItemArray[0].ToString();
            if (ma != null)
            {
                int cols = gridView1.GetFocusedDataRow().ItemArray.Length;
                for (int col = 0; col < cols; col++)
                {
                    //fields += gridView1.Columns[col].ToString();
                    text += gridView1.GetFocusedDataRow().ItemArray[col].ToString();
                }

                if (TABLE == "KHOA")
                {
                    KhoaController.Instance.DeleteKhoa(ma);
                }
                else if (TABLE == "LOP")
                {
                    LopController.Instance.DeleteLop(ma);
                }
                else if (TABLE == "SINHVIEN")
                {
                    bool success = SinhvienController.Instance.DeleteSinhvien(ma);
                    if (success)
                    {
                        // Reload DataSource
                        LoadSinhvien();
                        string malop = comboBox211.SelectedValue != null ? comboBox211.SelectedValue.ToString() : "ALLCLASS";

                        gridControl1.DataSource = SinhvienController.Instance.GetListSinhvienByMalop(malop, "ALLDEPARTMENT");
                    }

                }
                else if (TABLE == "MONHOC")
                {
                    MonhocController.Instance.DeleteMonhoc(ma);
                }
                else if (TABLE == "DIEM")
                {
                    DiemController.Instance.DeleteDiem(ma);
                }
                else { }

                gridView1.DeleteRow(gridView1.FocusedRowHandle);

                MessageBox.Show("Đã xóa hàng:\t" + text);
            }
        }

        // Accept Button
        private void simpleButton9_Click(object sender, EventArgs e)
        {
            string ma = txtCode.Text;
            string ten = txtName.Text;
            string khoa = txtDepartment.Text;
            string lop = txtClass.Text;
            int lan = Convert.ToInt32(Math.Round(txtTimes.Value, 0));
            bool gioitinh = radGender != null && radGender.SelectedIndex > 0 ? radGender.Properties.Items[radGender.SelectedIndex].Value.ToString() == "True" : false;
            string diachi = txtAddress.Text;
            string ho = txtLastName.Text;
            string noisinh = txtPlace.Text;
            string ngaysinh = txtBirthday.Text;

            bool success = false;

            if (ma != "" && ten != "")
            {
                //test += gridView1.FocusedRowHandle;
                if (gridControl1.DataSource == null)
                {
                    MessageBox.Show("Chọn 1 bảng");
                }
                else
                {
                    if (TABLE == "KHOA")
                    {
                        success = KhoaController.Instance.InsertKhoa(ma, ten);
                        if (success)
                        {
                            MessageBox.Show("Thêm Khoa mới thành công");

                            gridControl1.DataSource = KhoaController.Instance.GetListKhoa();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Khoa mới thất bại");
                        }
                    }
                    else if (TABLE == "LOP")
                    {
                        if (khoa != "")
                        {
                            success = LopController.Instance.InsertLop(ma, ten, khoa);
                            if (success)
                            {
                                MessageBox.Show("Thêm Lớp mới thành công");

                                LoadLop();
                                string makh = comboBox2.SelectedValue.ToString();

                                gridControl1.DataSource = LopController.Instance.GetListLopByMakh(makh);
                            }
                            else
                            {
                                MessageBox.Show("Thêm Lớp mới thất bại");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Chọn Khoa cụ thể");
                        }
                    }
                    else if (TABLE == "SINHVIEN")
                    {
                        if (khoa != "" && lop != "" && khoa != "ALLDEPARTMENT" && lop != "ALLCLASS" )
                        {
                            if (diachi != "" && ho != "" && noisinh != "" && ngaysinh != "")
                            {
                                success = SinhvienController.Instance.InsertSinhvien(ma, ho, ten, lop, gioitinh, ngaysinh, noisinh, diachi);
                                if (success)
                                {
                                    MessageBox.Show("Thêm Sinh Viên mới thành công");

                                    // Reload DataSource
                                    LoadSinhvien();
                                    string malop = comboBox211.SelectedValue != null ? comboBox211.SelectedValue.ToString() : "ALLCLASS";

                                    gridControl1.DataSource = SinhvienController.Instance.GetListSinhvienByMalop(malop, "ALLDEPARTMENT");
                                }
                                else
                                {
                                    MessageBox.Show("Thêm Sinh Viên mới thất bại");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Điền các ô trống hợp lệ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Chọn Khoa hoặc Lớp cụ thể");
                        }
                    }
                    else if (TABLE == "MONHOC")
                    {
                        success = MonhocController.Instance.InsertMonhoc(ma, ten);
                        if (success)
                        {
                            MessageBox.Show("Thêm Môn học mới thành công");

                            gridControl1.DataSource = MonhocController.Instance.GetListMonhoc();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Môn học mới thất bại");
                        }
                    }
                    else if (TABLE == "DIEM")
                    {
                        if (ma != "" && noisinh != "" && diachi != "")
                        {
                            if (lan <= 0) 
                            {
                                MessageBox.Show("Chọn lần thi");
                            }
                            else
                            {
                                //int solan = DiemController.Instance.get
                                success = DiemController.Instance.InsertDiem(ma, noisinh, lan, float.Parse(diachi));
                                if (success)
                                {
                                    MessageBox.Show("Thêm Điểm mới thành công");

                                    gridControl1.DataSource = DiemController.Instance.GetListDiem();
                                }
                                else
                                {
                                    MessageBox.Show("Thêm Điểm mới thất bại");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Điển các ô trống hợp lệ");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Không Xác Định Được Bảng");
                    }

                    gridView1.RefreshData();
                    STATEFORM = "CLOSEFORM";
                    if (STATEFORM == "CLOSEFORM")
                    {
                        closeForm();
                    }

                }
            }
            else
            {
                MessageBox.Show("Nhập dữ liệu vào các ô trống");
            }

        }

        // Deny Button close form
        private void simpleButton10_Click(object sender, EventArgs e)
        {
            STATEFORM = "CLOSEFORM";
            closeForm();
        }

        // Refresh Button close form
        private void simpleButton11_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = gridControl1.DataSource;
        }

        // Exit Button exit Application
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            STATEFORM = "CLOSEFORM";
            closeForm();
        }

        #endregion

        #region Filter lần lượt Lớp Với Sinh viên theo điều kiện Khoa và Lớp

        // filter in those selections of Diem opening form
        void filterDiemTable(string makh, string malop, string mamh, int lan)
        {
            DataTable Diem = DiemController.Instance.GetListDiem();

            if (mamh == "ALLSUBJECT" && makh == "ALLDEPARTMENT" && malop == "ALLCLASS")
            {
                Diem = DiemController.Instance.GetListDiemByLan(lan);
            }
            else if (mamh != "ALLSUBJECT" && makh == "ALLDEPARTMENT" && malop == "ALLCLASS")
            {
                if (mamh != "")
                {
                    Diem = DiemController.Instance.GetListDiemByMamh(mamh, lan);
                }
                else
                {
                    MessageBox.Show("Chọn Môn Học cụ thể");
                }
            }
            else if (mamh == "ALLSUBJECT" && makh != "ALLDEPARTMENT" && malop == "ALLCLASS")
            {
                if (makh != "")
                {
                    Diem = DiemController.Instance.GetListDiemByMakh(makh, lan);
                }
                else
                {
                    MessageBox.Show("Chọn Khoa cụ thể");
                }
            }
            else if (mamh == "ALLSUBJECT" && makh == "ALLDEPARTMENT" && malop != "ALLCLASS")
            {
                if (malop != "")
                {
                    Diem = DiemController.Instance.GetListDiemByMalop(malop, lan);
                }
                else
                {
                    MessageBox.Show("Chọn Lớp cụ thể");
                }
            }
            else if (mamh != "ALLSUBJECT" && makh != "ALLDEPARTMENT" && malop == "ALLCLASS")
            {
                if (mamh != "" && makh != "")
                {
                    Diem = DiemController.Instance.GetListDiemByMakhMamh(makh, mamh, lan);
                }
                else
                {
                    MessageBox.Show("Chọn Môn Học hay Khoa cụ thể");
                }
            }
            else if (mamh == "ALLSUBJECT" && makh != "ALLDEPARTMENT" && malop != "ALLCLASS")
            {
                if (makh != "" && malop != "")
                {
                    Diem = DiemController.Instance.GetListDiemByMakhMalop(makh, malop, lan);
                }
                else
                {
                    MessageBox.Show("Chọn Khoa hay Lớp cụ thể");
                }
            }
            else if (mamh != "ALLSUBJECT" && makh == "ALLDEPARTMENT" && malop != "ALLCLASS")
            {
                if (malop != "" && mamh != "")
                {
                    Diem = DiemController.Instance.GetListDiemByMalopMamh(malop, mamh, lan);
                }
                else
                {
                    MessageBox.Show("Chọn Môn Học hay Lớp cụ thể");
                }
            }
            else if (mamh != "ALLSUBJECT" && makh != "ALLDEPARTMENT" && malop != "ALLCLASS" && mamh != "" && makh != "" && malop != "")
            {
                if (makh != "" && mamh != "" && malop != "")
                {
                    Diem = DiemController.Instance.GetListDiemByMakhMalopMamh(makh, malop, mamh, lan);
                }
                else
                {
                    MessageBox.Show("Chọn Môn Học hay Khoa, Lớp cụ thể");
                }
            }
            gridControl1.DataSource = Diem;
        }

        // Khoa selection in Lop opening Form

        // Mon hoc selection in Diem opening Form
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TABLE == "LOP")
            {
                string makh = comboBox2.SelectedValue.ToString();

                txtDepartment.Text = makh;
                gridControl1.DataSource = LopController.Instance.GetListLopByMakh(makh);
            }
            else if (TABLE == "DIEM")
            {
                string mamh = comboBox2.SelectedValue.ToString();
                string makh = comboBox21.SelectedValue != null ? comboBox21.SelectedValue.ToString() : "ALLDEPARTMENT";
                string malop = comboBox211.SelectedValue != null ? comboBox211.SelectedValue.ToString() : "ALLCLASS";
                int lan = Convert.ToInt32(txtTimes.Value);
                filterDiemTable(makh, malop, mamh, lan);
            }
        }

        // Khoa selection in Sinh vien and Diem opening Form
        private void comboBox21_SelectedValueChanged(object sender, EventArgs e)
        {
            if (TABLE == "SINHVIEN")
            {
                string makh = comboBox21.SelectedValue.ToString();

                DataTable Lop = LopController.Instance.GetListLopByMakh(makh);
                Lop = addAllCategory(Lop, "malop", "ALLCLASS", "tenlop", "Tất Cả Lớp");
                comboBox211.DataSource = Lop;
            }
            else if (TABLE == "DIEM")
            {
                string makh = comboBox21.SelectedValue.ToString();

                DataTable Lop = LopController.Instance.GetListLopByMakh(makh);
                Lop = addAllCategory(Lop, "malop", "ALLCLASS", "tenlop", "Tất Cả Lớp");
                comboBox211.DataSource = Lop;

                string mamh = comboBox2.SelectedValue.ToString();
                string malop = comboBox211.SelectedValue != null ? comboBox211.SelectedValue.ToString() : "ALLCLASS";
                int lan = Convert.ToInt32(txtTimes.Value);
                filterDiemTable(makh, malop, mamh, lan);
            }
        }

        // Lop selection in Sinh vien and Diem opening Form
        private void comboBox211_SelectedValueChanged(object sender, EventArgs e)
        {
            if (TABLE == "SINHVIEN")
            {
                string makh = comboBox21.SelectedValue.ToString();
                string malop = comboBox211.SelectedValue.ToString();
                gridControl1.DataSource = SinhvienController.Instance.GetListSinhvienByMalop(malop, makh);
            }
            else if (TABLE == "DIEM")
            {
                string mamh = comboBox2.SelectedValue.ToString();
                string makh = comboBox21.SelectedValue != null ? comboBox21.SelectedValue.ToString() : "ALLDEPARTMENT";
                string malop = comboBox211.SelectedValue != null ? comboBox211.SelectedValue.ToString() : "ALLCLASS";
                int lan = Convert.ToInt32(txtTimes.Value);

                DataTable Sinhvien = SinhvienController.Instance.GetListSinhvienByMalop(malop, makh);

                if (Sinhvien.Rows.Count <= 0)
                {
                    cbStudent.DataSource = null;
                    cbStudent.SelectedItem = null;
                    cbStudent.SelectedText = "--Không Tồn Tại Sinh Viên--";
                    //cbStudent.Text = "--Không Tồn Tại Sinh Viên--";
                }
                else
                {
                    Sinhvien.Columns.Add(
                        "hotenmasv",
                        typeof(string),
                        "ho + ' ' + ten + ' ' + masv");
                    cbStudent.DataSource = Sinhvien;
                    cbStudent.DisplayMember = "hotenmasv";
                    cbStudent.ValueMember = "masv";

                }
                filterDiemTable(makh, malop, mamh, lan);
            }


        }

        // Gioi tinh selection in Sinhvien opening Form
        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // Sinh vien selection in Diem opening Form
        private void cbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string masv = "";
            if (masv == "")
            {
                if (cbStudent.SelectedValue != null)
                {
                    masv = cbStudent.SelectedValue.ToString();
                    if (masv != "System.Data.DataRowView")
                    {
                        Sinhvien sinhvien = SinhvienController.Instance.GetSinhvienByMasv(masv);
                        txtCode.Text = masv;
                        txtName.Text = sinhvien.Ten;
                        txtLastName.Text = sinhvien.Ho;
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên");
            }
        }

        // So lan thi selection in Diem opening Form
        private void txtTimes_ValueChanged(object sender, EventArgs e)
        {
            string mamh = comboBox2.SelectedValue.ToString();
            string makh = comboBox21.SelectedValue != null ? comboBox21.SelectedValue.ToString() : "ALLDEPARTMENT";
            string malop = comboBox211.SelectedValue != null ? comboBox211.SelectedValue.ToString() : "ALLCLASS";
            int lan = Convert.ToInt32(txtTimes.Value);
            filterDiemTable(makh, malop, mamh, lan);
        }
        #endregion

        #endregion

        #region Bao Cao Menu

        #region Bao Cao Cac Bang
        
        // Report Danh Sách Khoa
        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isHide = HideList();
            if (isHide)
            {
                gridControl1.DataSource = KhoaController.Instance.GetKhoaList();
                gridControl1.ShowRibbonPrintPreview();
            }
        }

        // Report Danh Sách Lớp
        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isHide = HideList();
            if (isHide)
            {
                gridControl1.DataSource = LopController.Instance.GetLopList();
                gridControl1.ShowRibbonPrintPreview();
            }
        }

        // Report Danh Sách Sinh Viên
        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isHide = HideList();
            if (isHide)
            {
                gridControl1.DataSource = SinhvienController.Instance.GetListSinhvien();
                gridControl1.ShowRibbonPrintPreview();
            }
        }

        // Report Danh Sách Môn Học
        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isHide = HideList();
            if (isHide)
            {
                gridControl1.DataSource = MonhocController.Instance.GetListMonhoc();
                gridControl1.ShowRibbonPrintPreview();
            }
        }

        // Report Danh Sách Điểm
        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isHide = HideList();
            if (isHide)
            {
                gridControl1.DataSource = DiemController.Instance.GetDiemList();
                gridControl1.ShowRibbonPrintPreview();
            }
        }

        // Report Danh Sách Phiếu Danh Sách Sinh Viên
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isHide = HideList();
            if (isHide)
            {
                REPORT = "DSSV";
                LoadReport();
            }
        }

        // Report Danh Sách Phiếu Danh Sách Lớp
        private void barButtonItem5_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            bool isHide = HideList();
            if (isHide)
            {
                REPORT = "DSLH";
                LoadReport();
                //ReportData.DataSource = 
            }
        }

        // Report Danh Sách Phiếu Điểm Sinh Viên
        private void barButtonItem3_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            bool isHide = HideList();
            if (isHide)
            {
                REPORT = "PDSV";
                LoadReport();
                //ReportData.DataSource = 
            }
        }

        // Report Danh Sách Phiếu Điểm Lớp
        private void barButtonItem4_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            bool isHide = HideList();
            if (isHide)
            {
                REPORT = "PDLH";
                LoadReport();
                //ReportData.DataSource = 
            }
        }

        // Report Danh Sách Phiếu Điểm Môn Học
        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            bool isHide = HideList();
            if (isHide)
            {
                REPORT = "DSDMH";
                LoadReport();
                //ReportData.DataSource = 
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ReportData.ShowRibbonPrintPreview();
        }

        private void btnCancelPreview_Click(object sender, EventArgs e)
        {
            closeFormReport();
        }

        #endregion

        #region Binding Các Bảng
        
        // Khoa selection in opening Report Form
        private void cbKhoaRP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makh = cbKhoaRP.SelectedValue.ToString();
            txtCodeDepartment.Text = makh == "ALLDEPARTMENT" ? "" : makh;
            DataTable LopData = LopController.Instance.GetListLopByMakh(makh);

            // Bindings
            LopData = addAllCategory(LopData, "malop", "ALLCLASS", "tenlop", "Tất Cả Lớp");

            cbLopRP.DataSource = LopData;
            cbLopRP.DisplayMember = "tenlop";
            cbLopRP.ValueMember = "malop";

            txtCodeClass.Text = cbLopRP.SelectedValue.ToString() == "ALLCLASS" ? "" : cbLopRP.SelectedValue.ToString();
        }

        // Lop selection in opening Report Form
        private void cbLopRP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makh = cbKhoaRP.SelectedValue.ToString();
            string malop = cbLopRP.SelectedValue.ToString();
            txtCodeClass.Text = malop;
            if (REPORT == "PDSV")
            {
                DataTable SinhvienData = SinhvienController.Instance.GetListSinhvienByMalop(malop, makh);

                // Bindings
            
                // merge masv, ho, ten column
                SinhvienData.Columns.Add(
                            "masvhoten",
                            typeof(string),
                            "masv + ' ' + ho + ' ' + ten");

                cbMonhocRP.DataSource = SinhvienData;
                cbMonhocRP.DisplayMember = "masvhoten";
                cbMonhocRP.ValueMember = "masv";

                txtCodeSubject.Text = cbMonhocRP.SelectedValue != null? cbMonhocRP.SelectedValue.ToString() : "";
            }
            else if(REPORT == "DSDMH")
            {
                DataTable MonhocData = MonhocController.Instance.GetListMonhoc();

                // Bindings

                // merge ho, ten column
                MonhocData = addAllCategory(MonhocData, "mamh", "", "tenmh", "Tất Cả Môn Học");
                MonhocData.Columns.Add(
                            "mh",
                            typeof(string),
                            "mamh + ' ' + tenmh");

                cbMonhocRP.DataSource = MonhocData;
                cbMonhocRP.DisplayMember = "mh";
                cbMonhocRP.ValueMember = "mamh";

                txtCodeSubject.Text = cbMonhocRP.SelectedValue != null ? cbMonhocRP.SelectedValue.ToString() : "";
            }

        }

        // Monhoc or Sinhvine selection in PDSV or DSDMH opening Report Form
        private void cbMonhocRP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = cbMonhocRP.SelectedValue.ToString();
            txtCodeSubject.Text = ma == "ALLSUBJECT" ? "" : ma;
        }

        // Preview Report
        private void btnPreview_Click_1(object sender, EventArgs e)
        {
            int lan = Convert.ToInt32(txtTimesRP.Value);
            string makh = txtCodeDepartment.Text;
            string mamh = txtCodeSubject.Text;
            string malop = txtCodeClass.Text;

            if (REPORT == "DSSV")
            {
                LoadDSSV(makh, malop);
            }
            else if (REPORT == "PDSV")
            {
                LoadPDSV(mamh, lan);
            }
            else if (REPORT == "DSLH")
            {
                LoadDSLH(malop);
            }
            else if (REPORT == "PDLH")
            {
                LoadPDLH(malop);
            }
            else if (REPORT == "DSDMH")
            {
                LoadDSDMH(makh, malop, mamh, lan);
            }
        }
        
        #endregion
        
        #endregion
    }
}