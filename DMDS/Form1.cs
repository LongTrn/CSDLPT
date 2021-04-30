
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
        BindingSource bindingData = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set enable or disable
            disableActionButtonCreateNewForm();
            LoadKhoa();
        }

        private void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.AutoPopulateColumns = false;
            gridView1.PopulateColumns();
            gridView1.BestFitColumns();
            bsiRecordsCount.Caption = "RECORDS : " + gridView1.RowCount;
        }
        
        void LoadKhoa()
        {
            List<Khoa> listKhoa = KhoaController.Instance.GetKhoaList();
            //MessageBox.Show(listKhoa.Count.ToString());
            //comboBoxEdit1. = listCategory.ToArray();
            //comboBoxEdit1.DisplayMember = "nameCategory";
        }
         

        private void enableActionButtonCreateNewForm()
        {
            // Accept btn
            simpleButton9.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Default;
            simpleButton9.Enabled = true;
            // Cancel btn
            simpleButton10.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Default;
            simpleButton10.Enabled = true;
            // Làm Mới btn
            simpleButton11.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton11.Enabled = false;
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
            // Xóa btn
            simpleButton8.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton8.Enabled = false;
        }
        
        #region Danh Sach Cac Bang

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Khoa
            gridControl1.DataSource = KhoaController.Instance.GetListKhoa();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Lop 
            gridControl1.DataSource = LopController.Instance.GetListLop();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Sinh Vien 
            gridControl1.DataSource = SinhvienController.Instance.GetListSinhvien();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Mon Hoc 
            gridControl1.DataSource = MonhocController.Instance.GetListMonhoc();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Diem
            gridControl1.DataSource = DiemController.Instance.GetListDiem();
        }

        #endregion

        #region Bao Cao Cac Bang

        #endregion

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

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetRowCellValue(e.RowHandle, "rowguid", Guid.NewGuid());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            //gridView1.AddNewRow();

            enableActionButtonCreateNewForm();
            disableNonActionButtonCreateNewForm();
            txtCode.Focus();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            gridControl1.RefreshDataSource();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            enableNonActionButtonCreateNewForm();
            disableActionButtonCreateNewForm();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            string text = "";
            string fields = "";
            string ma = gridView1.GetFocusedDataRow().ItemArray[0].ToString();
            if (ma != null)
            {
                int cols = gridView1.GetFocusedDataRow().ItemArray.Length;
                for (int col = 0; col < cols; col++)
                {
                    fields += gridView1.Columns[col].ToString();
                    text += gridView1.GetFocusedDataRow().ItemArray[col].ToString();
                }

                //MonhocController.Instance.DeleteMonhoc(ma);
                //gridView1.DeleteRow(gridView1.FocusedRowHandle);
            
                MessageBox.Show("Đã xóa ${table}:# " + fields);
                MessageBox.Show("Đã xóa hàng:\t" + text);
                MessageBox.Show("Đã xóa hàng:\t" + ma);
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            string test = "";
            string ma = txtCode.Text;
            string ten = txtName.Text;
            //test += gridView1.FocusedRowHandle;
            test += ma;
            test += ten;
            if (gridControl1.DataSource == null)
            {
                MessageBox.Show("Chọn 1 bảng");
            }
            else
            {
                //MonhocController.Instance.InsertMonhoc(ma, ten);
                MessageBox.Show(gridControl1.ViewCollection.ToString());

            }


        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}