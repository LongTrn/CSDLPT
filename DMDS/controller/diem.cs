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
    public class DiemController
    {
        private static DiemController instance;

        public static DiemController Instance
        {
            get { if (instance == null) instance = new DiemController(); return instance; }
            private set { instance = value; }
        }

        private DiemController() { }

        public Diemm GetDiemByMamh(string mamh)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Diem WHERE mamh = @mamh", new object[] { "CSDL" });

            foreach (DataRow item in data.Rows)
            {
                return new Diemm(item);

            }

            return null;
        }

        public Diemm GetDiemByMasv(string masv)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Diem WHERE masv = like N'%@masv%'", new object[] { "08VTA101" });

            foreach (DataRow item in data.Rows)
            {
                return new Diemm(item);

            }

            return null;
        }

        public DataTable GetListDiem()
        {

            string qr = "SELECT masv, mamh, lan, diem FROM dbo.Diem";

            return DataProvider.Instance.ExecuteQuery(qr);

        }

        public List<Diemm> GetDiemList()
        {
            List<Diemm> list = new List<Diemm>();

            string qr = "SELECT * FROM dbo.Diem";

            DataTable data = DataProvider.Instance.ExecuteQuery(qr);

            foreach (DataRow item in data.Rows)
            {
                Diemm monhoc = new Diemm(item);

                list.Add(monhoc);

            }

            return list;

        }

        public List<Diemm> SearchSinhvienByDiem(string operation, float diem)
        {
            List<Diemm> list = new List<Diemm>();

            string qr = string.Format("SELECT * FROM dbo.Diem WHERE diem {0} {1}", operation, diem);

            DataTable data = DataProvider.Instance.ExecuteQuery(qr);

            foreach (DataRow item in data.Rows)
            {
                Diemm account = new Diemm(item);

                list.Add(account);

            }

            return list;

        }

        public bool InsertDiem (string masv, string mamh, float diem)
        {
            string qr = string.Format("INSERT dbo.Diem ( masv, mamh, diem) VALUES( @masv , @mamh , @diem )");

            int result = DataProvider.Instance.ExecuteNonQuery(qr, new object[] { masv, mamh, diem });

            return result > 0;

        }

        public bool UpdateMonhocByMamh(string mamhmoi, string mamh)
        {
            string qr = string.Format("UPDATE dbo.Diem SET mamh = @mamhmoi WHERE mamh = @mamh ");

            int result = DataProvider.Instance.ExecuteNonQuery(qr, new object[] { "mamhmoi", "mamh" });

            return result > 0;

        }

        public bool UpdateMonhocByTenmh(string tenmh, string mamh)
        {
            string qr = "UPDATE dbo.Diem SET Tenmh = @tenmh WHERE mamh = @mamh ";

            int result = DataProvider.Instance.ExecuteNonQuery(qr, new object[] { "Cơ Sở Dữ liệu1", "CSDL" });

            return result > 0;

        }

        public bool DeleteDiem(string mamh)
        {
            string qr = string.Format("DELETE dbo.Diem WHERE mamh = @mamh ");

            int result = DataProvider.Instance.ExecuteNonQuery(qr, new object[] { mamh });

            return result > 0;

        }

        public bool ResetPassword(int id)
        {
            string qr = string.Format("UPDATE dbo.Diem SET Password = N'20720532132149213101239102231223249249135100218' WHERE id = {0}", id);

            int result = DataProvider.Instance.ExecuteNonQuery(qr);

            return result > 0;

        }

    }
}