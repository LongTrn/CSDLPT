
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
        private string STATEFORM = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set enable or disable
            disableAllButtonForm();
        }

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
                lbDepartment.Visible = true;
                lbClass.Visible = true;

                txtDepartment.Visible = true;
                txtClass.Visible = true;

                // Get data from comboBox to assign to Code and Class value
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

                lbLastName.Visible = true;
                lbPlace.Visible = true;
                lbAddress.Visible = true;
                txtAddress.Visible = true;
                txtLastName.Visible = true;
                txtLastName.ReadOnly = true;
                txtPlace.Visible = true;
                txtPlace.ReadOnly = true;

                lbPlace.Text = "Môn học";
                lbAddress.Text = "Điểm";

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
            cbStudent.SelectedIndex = 1;


            LoadSinhvien();
        }

        DataTable addAllCategory(DataTable table, string keyma, string ma, string keyten, string ten)
        {
            DataRow allItem = table.NewRow();
            
            allItem[keyma] = ma;
            allItem[keyten] = ten;
            
            table.Rows.InsertAt(allItem, 0);
            
            return table;
        }

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
            // Hoàn tác btn
            simpleButton5.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Default;
            simpleButton5.Enabled = true;
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
            // Hoàn tác btn
            simpleButton5.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton5.Enabled = false;
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
                txtCode.ReadOnly = false;
                txtName.ReadOnly = false;
                txtPlace.ReadOnly = false;
                txtLastName.ReadOnly = false;
            }
            else
            {
                cbStudent.Visible = true;
                lbStudent.Visible = true;
                
                txtLastName.ReadOnly = true;
                txtPlace.ReadOnly = true;
                txtCode.ReadOnly = true;
                txtName.ReadOnly = true;
            }

            enableActionButtonCreateNewForm();
            disableNonActionButtonCreateNewForm();
            layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void closeForm()
        {
            disableActionButtonCreateNewForm();
            enableNonActionButtonCreateNewForm();
            layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void hideForm()
        {
            layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            
            lbStudent.Visible = false;
            lbDepartment.Visible = false;
            lbClass.Visible = false;
            lbGender.Visible = false;
            lbAddress.Visible = false;
            lbLastName.Visible = false;
            lbPlace.Visible = false;
            lbBirthday.Visible = false;

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
            TABLE = "KHOA";
            if (TABLE == "KHOA")
            {
                gridControl1.DataSource = KhoaController.Instance.GetListKhoa();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Lop 
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
            TABLE = "SINHVIEN";
            if (TABLE == "SINHVIEN")
            {
                LoadSinhvien();
                string malop = comboBox211.SelectedValue != null? comboBox211.SelectedValue.ToString() : "ALLCLASS";

                gridControl1.DataSource = SinhvienController.Instance.GetListSinhvienByMalop(malop, "ALLDEPARTMENT");
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Mon Hoc 
            TABLE = "MONHOC";
            if (TABLE == "MONHOC")
            { 
                gridControl1.DataSource = MonhocController.Instance.GetListMonhoc();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Diem
            TABLE = "DIEM";
            if (TABLE == "DIEM")
            {
                LoadDiem();

                gridControl1.DataSource = DiemController.Instance.GetListDiem();
            }
        }

        #endregion

        #region Bao Cao Cac Bang

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.DataSource = KhoaController.Instance.GetKhoaList();
            gridControl1.ShowRibbonPrintPreview();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.DataSource = LopController.Instance.GetLopList();
            gridControl1.ShowRibbonPrintPreview();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.DataSource = SinhvienController.Instance.GetListSinhvien();
            gridControl1.ShowRibbonPrintPreview();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.DataSource = MonhocController.Instance.GetListMonhoc();
            gridControl1.ShowRibbonPrintPreview();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.DataSource = DiemController.Instance.GetDiemList();
            gridControl1.ShowRibbonPrintPreview();
        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            STATEFORM = "OPENFORM";
            openForm();
            txtCode.Focus();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            string text = "";
            //string fields = "";
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

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            string ma = txtCode.Text;
            string ten = txtName.Text;
            string khoa = txtDepartment.Text;
            string lop = txtClass.Text;
            string diachi = txtAddress.Text;
            string ho = txtLastName.Text;
            string noisinh = txtPlace.Text;
            string ngaysinh = txtBirthday.Text;
            bool gioitinh = radGender != null && radGender.SelectedIndex > 0 ? radGender.Properties.Items[radGender.SelectedIndex].Value.ToString() == "True" : false;

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
                    else if (TABLE == "LOP" && khoa != "")
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
                    else if (TABLE == "SINHVIEN")
                    {
                        if (khoa != "" && lop != "" && khoa != "ALLDEPARTMENT" && lop != "ALLCLASS" && diachi != "" && ho != "" && noisinh != "" && ngaysinh != "")
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
                        success = DiemController.Instance.InsertDiem(ma, noisinh, float.Parse(diachi));
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
                    else { }

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

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            STATEFORM = "CLOSEFORM";
            closeForm();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = gridControl1.DataSource;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            STATEFORM = "CLOSEFORM";
            closeForm();
        }


        #region Filter lần lượt Lớp Với Sinh viên theo điều kiện Khoa và Lớp

        void filterDiemTable (string makh, string malop, string mamh, int lan)
        {
            DataTable Diem = DiemController.Instance.GetListDiem();

            if (mamh == "ALLSUBJECT" && makh == "ALLDEPARTMENT" && malop == "ALLCLASS")
            {
                Diem = DiemController.Instance.GetListDiemByLan(lan);
            }
            else if (mamh != "ALLSUBJECT" && makh == "ALLDEPARTMENT" && malop == "ALLCLASS" )
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
            else if (mamh != "ALLSUBJECT" && makh != "ALLDEPARTMENT" && malop == "ALLCLASS" )
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TABLE == "KHOA")
            {
                string makh = comboBox2.SelectedValue.ToString();

                gridControl1.DataSource = LopController.Instance.GetListLopByMakh(makh);
            }
            else if (TABLE == "DIEM")
            {
                string mamh = comboBox2.SelectedValue.ToString();
                string makh = comboBox21.SelectedValue != null ? comboBox21.SelectedValue.ToString() : "ALLDEPARTMENT";
                string malop = comboBox211.SelectedValue != null ? comboBox211.SelectedValue.ToString() : "ALLCLASS";
                int lan = 0;
                filterDiemTable(makh, malop, mamh, lan);
            }
        }

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
                int lan = 0;
                filterDiemTable(makh, malop, mamh, lan);
            }
        }

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
                int lan = 0;

                filterDiemTable(makh, malop, mamh, lan);
            }


        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private void cbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string masv = cbStudent.SelectedValue.ToString();
            if (masv != "")
            {
                if (masv != "System.Data.DataRowView")
                {
                    Sinhvien sinhvien = SinhvienController.Instance.GetSinhvienByMasv(masv);
                    txtCode.Text = masv;
                    txtName.Text = sinhvien.Ten;
                    txtLastName.Text = sinhvien.Ho;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên");
            }
        }
    }
}