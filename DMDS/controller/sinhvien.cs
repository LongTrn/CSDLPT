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

        public Sinhvien GetSinhvienByMasv(string masv)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Sinhvien WHERE masv = @masv ", new object[] { masv });
            
            foreach (DataRow item in data.Rows)
            {
                return new Sinhvien(item);

            }

            return null;
        }

        public DataTable GetListSinhvien()
        {

            string qr = "SELECT masv, ho, ten, malop, phai, ngaysinh, noisinh, diachi, ghichu, nghihoc  from dbo.Sinhvien ";

            return DataProvider.Instance.ExecuteQuery(qr);

        }

        public DataTable GetListSinhvienByMalop(string malop, string makh)
        {
            string qr = "";
            
            if (malop == "ALLCLASS" && makh == "ALLDEPARTMENT")
            {
                qr = "SELECT masv, ho, ten, malop, phai, ngaysinh, noisinh, diachi, ghichu, nghihoc  from dbo.Sinhvien ";

                return DataProvider.Instance.ExecuteQuery(qr);
            }
            else if (malop == "ALLCLASS" && makh != "ALLDEPARTMENT")
            {
                qr = @"SELECT masv, ho, ten, LOP.malop, phai, ngaysinh, noisinh, diachi, ghichu, nghihoc   from dbo.Sinhvien 
                        INNER JOIN  DBO.LOP AS LOP ON SINHVIEN.MALOP = LOP.MALOP  
                        WHERE makh = @makh ";

                return DataProvider.Instance.ExecuteQuery(qr, new object[] { makh });
            }
            else
            {
                qr = @"SELECT masv, ho, ten, malop, phai, ngaysinh, noisinh, diachi, ghichu, nghihoc  from dbo.Sinhvien  
                        WHERE malop = @malop ";

                return DataProvider.Instance.ExecuteQuery(qr, new object[] { malop });
            }
        }

        public List<Diemm> GetDiemList()
        {
            List<Diemm> list = new List<Diemm>();

            string qr = "SELECT masv, ho, ten, malop, phai, ngaysinh, noisinh, diachi, ghichu, nghihoc  FROM dbo.Sinhvien";

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

            string qr = string.Format("SELECT * FROM dbo.Sinhvien WHERE malop = {0}", malop);

            DataTable data = DataProvider.Instance.ExecuteQuery(qr);

            foreach (DataRow item in data.Rows)
            {
                Diemm account = new Diemm(item);

                list.Add(account);

            }

            return list;

        }

        public bool InsertSinhvien(string masv, string ho, string ten, string malop, bool gioitinh, string ngaysinh, string noisinh, string diachi)
        {
            int phai = gioitinh ? 1 : 0;
            
            string qr = string.Format(@"INSERT dbo.Sinhvien ( masv, ho, ten, malop, phai, ngaysinh, noisinh, diachi, ghichu, nghihoc) " +
                "                       VALUES( @masv , @ho , @ten , @malop , @phai , @ngaysinh , @noisinh , @diachi , '', 'false')");

            int result = DataProvider.Instance.ExecuteNonQuery(qr, new object[] { masv, ho, ten, malop, phai, ngaysinh, noisinh, diachi });

            return result > 0;

        }

        public bool UpdateMonhocByMamh(string masv, string ho, string ten, string malop, bool phai, DateTime ngaysinh, string noisinh, string diachi, string ghichu, bool nghihoc)
        {
            string qr = string.Format(@"UPDATE dbo.Sinhvien SET mamh = @mamhmoi, ho = @ho, ten = @ten, malop = @malop, phai = @phai , ngaysinh = @ngaysinh , noisinh = @noisinh , diachi = @diachi , ghichu = @ghichu , nghihoc = @nghihoc WHERE mamh = @mamh ");

            int result = DataProvider.Instance.ExecuteNonQuery(qr, new object[] { masv, ho, ten, malop, phai, ngaysinh, noisinh, diachi, ghichu, nghihoc });

            return result > 0;

        }

        public bool DeleteSinhvien(string masv)
        {
            string qr = string.Format("DELETE dbo.Sinhvien WHERE masv = @masv ");

            int result = DataProvider.Instance.ExecuteNonQuery(qr, new object[] { masv });

            return result > 0;

        }
    }
}