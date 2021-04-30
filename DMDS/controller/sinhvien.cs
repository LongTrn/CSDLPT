using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DMDS.model;

namespace DMDS.controller
{
    public class SinhvienController
    {
        private static SinhvienController instance;

        public static SinhvienController Instance
        {
            get { if (instance == null) instance = new SinhvienController(); return instance; }
            private set { instance = value; }
        }

        private SinhvienController() { }

        public Diemm GetDiemByMamh(string masv)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Sinhvien WHERE masv = @masv", new object[] { "08VTA101" });
            
            foreach (DataRow item in data.Rows)
            {
                return new Diemm(item);

            }

            return null;
        }

        public DataTable GetListSinhvien()
        {

            string qr = "SELECT masv, ho, ten, malop, phai, ngaysinh, noisinh, ghichu, nghihoc from dbo.Sinhvien";

            return DataProvider.Instance.ExecuteQuery(qr);

        }

        public List<Diemm> GetDiemList()
        {
            List<Diemm> list = new List<Diemm>();

            string qr = "SELECT masv, ho, ten, malop, phai, ngaysinh, noisinh, ghichu, nghihoc FROM dbo.Sinhvien";

            DataTable data = DataProvider.Instance.ExecuteQuery(qr);

            foreach (DataRow item in data.Rows)
            {
                Diemm monhoc = new Diemm(item);

                list.Add(monhoc);

            }

            return list;

        }

        public List<Diemm> SearchSinhvienByMaLop(string malop)
        {
            List<Diemm> list = new List<Diemm>();

            string qr = string.Format("SELECT * FROM dbo.Sinhvien WHERE malop = ", malop);

            DataTable data = DataProvider.Instance.ExecuteQuery(qr);

            foreach (DataRow item in data.Rows)
            {
                Diemm account = new Diemm(item);

                list.Add(account);

            }

            return list;

        }

        public bool InsertDiem(string masv, string ho, string ten, string malop, bool phai, DateTime ngaysinh, string noisinh)
        {
            string qr = string.Format("INSERT dbo.Sinhvien ( masv, ho, ten, malop, phai, ngaysinh, noisinh) VALUES(N'@masv',N'@ho', N'@ten', N'@malop', @phai, @ngaysinh, @noisinh)", new object[] { masv, ho, ten, malop, phai, ngaysinh, noisinh });

            int result = DataProvider.Instance.ExecuteNonQuery(qr);

            return result > 0;

        }

        public bool UpdateMonhocByMamh(string masv, string ho, string ten, string malop, bool phai, DateTime ngaysinh, string noisinh, string ghichu, int nghihoc)
        {
            string qr = string.Format("UPDATE dbo.Sinhvien SET mamh = @mamhmoi, ho = @ho, ten = @ten, malop = @malop, phai = @phai, ngaysinh = @ngaysinh, noisinh = @noisinh, ghichu = @ghichu, nghihoc = @nghihoc  WHERE mamh = @mamh", new object[] { masv, ho, ten, malop, phai, ngaysinh, noisinh, ghichu, nghihoc });

            int result = DataProvider.Instance.ExecuteNonQuery(qr);

            return result > 0;

        }

        public bool DeleteMonhoc(string masv)
        {
            string qr = string.Format("DELETE dbo.Sinhvien WHERE masv = @masv", new object[] { masv });

            int result = DataProvider.Instance.ExecuteNonQuery(qr);

            return result > 0;

        }
    }
}