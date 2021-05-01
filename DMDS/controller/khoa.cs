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
    public class KhoaController
    {
        private static KhoaController instance;

        public static KhoaController Instance
        {
            get { if (instance == null) instance = new KhoaController(); return instance; }
            private set { instance = value; }
        }

        private KhoaController() { }

        public Khoa GetKhoaByMakh(string makh)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT makh, tenkh FROM dbo.Khoa WHERE makh = @makh", new object[] { makh });

            foreach (DataRow item in data.Rows)
            {
                return new Khoa(item);

            }

            return null;
        }

        public DataTable GetListKhoa()
        {

            string qr = "SELECT makh, tenkh from dbo.Khoa";

            return DataProvider.Instance.ExecuteQuery(qr);

        }

        public List<Khoa> GetKhoaList()
        {
            List<Khoa> list = new List<Khoa>();

            string qr = "SELECT makh, tenkh FROM dbo.Khoa";

            DataTable data = DataProvider.Instance.ExecuteQuery(qr);

            foreach (DataRow item in data.Rows)
            {
                Khoa monhoc = new Khoa(item);

                list.Add(monhoc);

            }

            return list;

        }

        public List<Khoa> SearchKhoaByMakhoa(string makh)
        {
            List<Khoa> list = new List<Khoa>();

            string qr = string.Format("SELECT makh, tenkh FROM dbo.Khoa WHERE makh = ", makh);

            DataTable data = DataProvider.Instance.ExecuteQuery(qr);

            foreach (DataRow item in data.Rows)
            {
                Khoa account = new Khoa(item);

                list.Add(account);

            }

            return list;

        }

        public List<Khoa> SearchLopByMakhoa(string makh)
        {
            List<Khoa> list = new List<Khoa>();

            string qr = string.Format("SELECT malop, tenlop, makh FROM dbo.Lop WHERE makh = ", makh);

            DataTable data = DataProvider.Instance.ExecuteQuery(qr);

            foreach (DataRow item in data.Rows)
            {
                Khoa account = new Khoa(item);

                list.Add(account);

            }

            return list;

        }

        public bool InsertKhoa(string makh, string tenkh)
        {
            string qr = string.Format("EXEC SP_INSERT_KHOA @makh , @tenkh ");

            int result = DataProvider.Instance.ExecuteNonQuery(qr, new object[] { makh, tenkh });

            return result > 0;

        }

        public bool UpdateKhoaByMakh(string makh, string tenkh)
        {
            string qr = string.Format("UPDATE dbo.Khoa SET makh = @makh, tenkh = @tenkh WHERE makh = @makh");

            int result = DataProvider.Instance.ExecuteNonQuery(qr, new object[] { makh });

            return result > 0;

        }

        public bool DeleteKhoa(string makh)
        {
            string qr = string.Format("DELETE dbo.Khoa WHERE makh = @makh");

            int result = DataProvider.Instance.ExecuteNonQuery(qr, new object[] { makh });

            return result > 0;

        }
    }
}