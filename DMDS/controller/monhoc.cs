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
    public class MonhocController
    {
        private static MonhocController instance;

        public static MonhocController Instance
        {
            get { if (instance == null) instance = new MonhocController(); return instance; }
            private set { instance = value; }
        }

        private MonhocController() { }

        public Monhoc GetMonhocByMamh(string mamh)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Monhoc WHERE mamh = @mamh", new object[] { "CSDL" });

            foreach (DataRow item in data.Rows)
            {
                return new Monhoc(item);

            }

            return null;
        }

        public Monhoc GetMonhocByTenmh(string tenmh)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Monhoc WHERE tenmh = like N'%@mamh%'", new object[] { "co so" });

            foreach (DataRow item in data.Rows)
            {
                return new Monhoc(item);

            }

            return null;
        }

        public DataTable GetListMonhoc()
        {

            string qr = "SELECT mamh, tenmh FROM dbo.Monhoc";

            return DataProvider.Instance.ExecuteQuery(qr);

        }

        public List<Monhoc> GetAccountList()
        {
            List<Monhoc> list = new List<Monhoc>();

            string qr = "SELECT * FROM dbo.Monhoc";

            DataTable data = DataProvider.Instance.ExecuteQuery(qr);

            foreach (DataRow item in data.Rows)
            {
                Monhoc monhoc = new Monhoc(item);

                list.Add(monhoc);

            }

            return list;

        }

        public List<Monhoc> SearchAccountByUserName(string name)
        {
            List<Monhoc> list = new List<Monhoc>();

            string qr = string.Format("SELECT * FROM dbo.Monhoc WHERE dbo.fuConvertToUnsign1(UserName) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(qr);

            foreach (DataRow item in data.Rows)
            {
                Monhoc account = new Monhoc(item);

                list.Add(account);

            }

            return list;

        }

        public bool InsertMonhoc(string mamh, string tenmh)
        {
            string qr = string.Format("EXEC SP_INSERT_MONHOC @mamh , @tenmh ");

            int result = DataProvider.Instance.ExecuteNonQuery(qr, new object[] { mamh, tenmh });

            return result > 0;

        }

        public bool UpdateMonhocByMamh(string mamhmoi, string mamh)
        {
            string qr = string.Format("UPDATE dbo.Monhoc SET mamh = @mamhmoi WHERE mamh = @mamh");

            int result = DataProvider.Instance.ExecuteNonQuery(qr, new object[] { "mamhmoi", "mamh" });

            return result > 0;

        }

        public bool UpdateMonhocByTenmh(string tenmh, string mamh)
        {

            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.Monhoc SET Tenmh = @tenmh WHERE mamh = @mamh", new object[] { "Cơ Sở Dữ liệu1", "CSDL" });

            return result > 0;

        }

        public bool DeleteMonhoc(string mamh)
        {
            string qr = string.Format("DELETE dbo.Monhoc WHERE mamh = @mamh");

            int result = DataProvider.Instance.ExecuteNonQuery(qr, new object[] { mamh });

            return result > 0;

        }
    }
}