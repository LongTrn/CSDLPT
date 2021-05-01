
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
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                
                lbDepartment.Visible = true;

                txtDepartment.Visible = true;
                
                string textDepartment = comboBox2.SelectedValue.ToString();
                
                if (textDepartment == "ALLDEPARTMENT")
                {
                    textDepartment = "";
                }
                
                txtDepartment.Text = textDepartment;

            }
            else if (TABLE == "SINHVIEN")
            {
                layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                
                lbDepartment.Visible = true;
                lbClass.Visible = true;

                txtDepartment.Visible = true;
                txtClass.Visible = true;
                
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

            lbDepartment.Visible = false;
            lbClass.Visible = false;

            txtClass.Visible = false;
            txtDepartment.Visible = false;
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
            //gridView1.AddNewRow();
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
                        KhoaController.Instance.InsertKhoa(ma, ten);
                    }
                    else if (TABLE == "LOP" && khoa != "")
                    {
                        LopController.Instance.InsertLop(ma, ten, khoa);
                    }
                    else if (TABLE == "SINHVIEN" && khoa != "" && lop != "")
                    {
                        bool success = SinhvienController.Instance.InsertSinhvien(ma, "ho", ten, lop, true);
                        if (success)
                        {
                            MessageBox.Show("Insert isSuccessful: " + success);
                            
                            // Reload DataSource
                            LoadSinhvien();
                            string malop = comboBox211.SelectedValue != null ? comboBox211.SelectedValue.ToString() : "ALLCLASS";

                            gridControl1.DataSource = SinhvienController.Instance.GetListSinhvienByMalop(malop, "ALLDEPARTMENT");
                        }

                    }
                    else if (TABLE == "MONHOC")
                    {
                        MonhocController.Instance.InsertMonhoc(ma, ten);
                    }
                    else if (TABLE == "DIEM")
                    {
                        DiemController.Instance.InsertDiem("masv", "mamh", 0);
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makh = comboBox2.SelectedValue.ToString();

            gridControl1.DataSource = LopController.Instance.GetListLopByMakh(makh);
        }

        private void comboBox21_SelectedValueChanged(object sender, EventArgs e)
        {
            string makh = comboBox21.SelectedValue.ToString();

            DataTable Lop = LopController.Instance.GetListLopByMakh(makh);
            Lop = addAllCategory(Lop, "malop", "ALLCLASS", "tenlop", "Tất Cả Lớp");
            comboBox211.DataSource = Lop;
        }

        private void comboBox211_SelectedValueChanged(object sender, EventArgs e)
        {
            string makh = comboBox21.SelectedValue.ToString();
            string malop = comboBox211.SelectedValue.ToString();
            gridControl1.DataSource = SinhvienController.Instance.GetListSinhvienByMalop(malop, makh);
            
        }

        #endregion

        
    }
}