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
    public class LopController
    {
        private static LopController instance;

        public static LopController Instance
        {
            get { if (instance == null) instance = new LopController(); return instance; }
            private set { instance = value; }
        }

        private LopController() { }

        public Lop GetLopByMaLop(string malop)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT malop, tenlop FROM dbo.Lop WHERE malop = @malop", new object[] { malop });

            foreach (DataRow item in data.Rows)
            {
                return new Lop(item);

            }

            return null;
        }

        public DataTable GetListLop()
        {

            string qr = "SELECT malop, tenlop, makh from dbo.Lop";

            return DataProvider.Instance.ExecuteQuery(qr);

        }

        public List<Lop> GetLopList()
        {
            List<Lop> list = new List<Lop>();

            string qr = "SELECT malop, tenlop, makh FROM dbo.Lop";

            DataTable data = DataProvider.Instance.ExecuteQuery(qr);

            foreach (DataRow item in data.Rows)
            {
                Lop monhoc = new Lop(item);

                list.Add(monhoc);

            }

            return list;

        }

        public DataTable GetListLopByMakh(string makh)
        {
            string qr = "";

            if (makh == "ALLDEPARTMENT")
            {
                qr = "SELECT malop, tenlop, makh from dbo.Lop";

                return DataProvider.Instance.ExecuteQuery(qr);
            }
            else
            {
                qr = "SELECT malop, tenlop, makh from dbo.Lop WHERE makh = @makh";

                return DataProvider.Instance.ExecuteQuery(qr, new object[] { makh });
            }
        }

        public List<Lop> SearchLopByMaLop(string malop)
        {
            List<Lop> list = new List<Lop>();

            string qr = string.Format("SELECT * FROM dbo.Lop WHERE malop = ", malop);

            DataTable data = DataProvider.Instance.ExecuteQuery(qr);

            foreach (DataRow item in data.Rows)
            {
                Lop account = new Lop(item);

                list.Add(account);

            }

            return list;

        }

        public bool InsertLop(string malop, string tenlop, string makh)
        {
            string qr = string.Format("EXEC SP_INSERT_LOP @malop , @tenlop , @makh");

            int result = DataProvider.Instance.ExecuteNonQuery(qr, new object[] { malop, tenlop, makh });

            return result > 0;

        }

        public bool UpdateLopByMalop(string malop, string tenlop)
        {
            string qr = string.Format("UPDATE dbo.Lop SET malop = @malop, tenlop = @tenlop WHERE mamh = @mamh");

            int result = DataProvider.Instance.ExecuteNonQuery(qr, new object[] { malop, tenlop });

            return result > 0;

        }

        public bool DeleteLop(string malop)
        {
            string qr = string.Format("DELETE dbo.Lop WHERE malop = @malop");

            int result = DataProvider.Instance.ExecuteNonQuery(qr, new object[] { malop });

            return result > 0;

        }
    }
}