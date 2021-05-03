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
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Diem WHERE masv = like N'%@masv%'", new object[] { masv });

            foreach (DataRow item in data.Rows)
            {
                return new Diemm(item);

            }

            return null;
        }

        public DataTable GetListDiemByMasv(string masv, int lan)
        {
            string qr = "";
            if (lan == 0)
            {
                qr = String.Format(@"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                                FROM dbo.Diem AS d
                                INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                                INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                                INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                                INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh
                                WHERE d.masv = '{0}'", masv);

                return DataProvider.Instance.ExecuteQuery(qr);
            }
            else
            {
                qr = String.Format(@"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                                FROM dbo.Diem AS d
                                INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                                INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                                INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                                INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh
                                WHERE d.masv = '{0}'
                                AND lan = {1}", masv, lan);

                return DataProvider.Instance.ExecuteQuery(qr);
            }
        }

        public DataTable GetListDiem()
        {
            string qr = @"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                            FROM dbo.Diem AS d
                            INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                            INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                            INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                            INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh";

            return DataProvider.Instance.ExecuteQuery(qr);
        }

        public List<Diemm> GetDiemList()
        {
            List<Diemm> list = new List<Diemm>();

            string qr = @"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                            FROM dbo.Diem AS d
                            INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                            INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                            INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                            INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh";

            DataTable data = DataProvider.Instance.ExecuteQuery(qr);

            foreach (DataRow item in data.Rows)
            {
                Diemm monhoc = new Diemm(item);

                list.Add(monhoc);

            }

            return list;

        }

        public DataTable GetListDiemByLan(int lan)
        {
            if (lan > 0)
            {
                string qr = String.Format(@"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                                FROM dbo.Diem AS d
                                INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                                INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                                INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                                INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh
                                WHERE d.lan = {0}", lan);

                return DataProvider.Instance.ExecuteQuery(qr);
            }
            else
            {
                return GetListDiem();
            }
        }

        public DataTable GetListDiemByMamh(string mamh , int lan)
        {
            if (lan > 0)
            {
                string qr = string.Format(@"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                            FROM dbo.Diem AS d
                            INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                            INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                            INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                            INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh
                            WHERE d.lan = {0}
                            AND d.mamh = '{1}' ", lan, mamh);

                return DataProvider.Instance.ExecuteQuery(qr);
            }
            else
            {
                string qr = string.Format(@"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                            FROM dbo.Diem AS d
                            INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                            INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                            INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                            INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh
                            WHERE d.mamh = '{0}' ", mamh);

                return DataProvider.Instance.ExecuteQuery(qr);
            }

        }

        public DataTable GetListDiemByMakh(string makh, int lan)
        {
            if (lan > 0)
            {
                string qr = string.Format(@"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                            FROM dbo.Diem AS d
                            INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                            INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                            INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                            INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh
                            WHERE d.lan = {0}
                            AND l.makh = '{1}' ", lan, makh);

                return DataProvider.Instance.ExecuteQuery(qr);
            }
            else
            {
                string qr = string.Format(@"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                            FROM dbo.Diem AS d
                            INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                            INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                            INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                            INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh
                            WHERE l.makh = '{0}' ", makh);

                return DataProvider.Instance.ExecuteQuery(qr);
            }

        }

        public DataTable GetListDiemByMalop(string malop, int lan)
        {
            if (lan > 0)
            {
                string qr = string.Format(@"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                            FROM dbo.Diem AS d
                            INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                            INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                            INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                            INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh
                            WHERE d.lan = {0}
                            AND sv.malop = '{1}' ", lan, malop);

                return DataProvider.Instance.ExecuteQuery(qr);
            }
            else
            {
                string qr = string.Format(@"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                            FROM dbo.Diem AS d
                            INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                            INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                            INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                            INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh
                            WHERE sv.malop = '{0}' ", malop);

                return DataProvider.Instance.ExecuteQuery(qr);
            }

        }

        public DataTable GetListDiemByMakhMamh(string makh, string mamh, int lan)
        {
            if (lan > 0)
            {
                string qr = string.Format(@"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                            FROM dbo.Diem AS d
                            INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                            INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                            INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                            INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh
                            WHERE d.lan = {0}
                            AND d.mamh = '{1}'
                            AND kh.makh = '{2}' ", lan, mamh, makh);

                return DataProvider.Instance.ExecuteQuery(qr);
            }
            else
            {
                string qr = string.Format(@"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                            FROM dbo.Diem AS d
                            INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                            INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                            INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                            INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh
                            WHERE d.mamh = '{0}'
                            AND kh.makh = '{1}' ", mamh, makh);

                return DataProvider.Instance.ExecuteQuery(qr);
            }

        }

        public DataTable GetListDiemByMakhMalop(string makh, string malop, int lan)
        {
            if (lan > 0)
            {
                string qr = string.Format(@"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                            FROM dbo.Diem AS d
                            INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                            INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                            INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                            INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh
                            WHERE d.lan = {0}
                            AND sv.malop = '{1}'
                            AND kh.makh = '{2}' ", lan, malop, makh);

                return DataProvider.Instance.ExecuteQuery(qr);
            }
            else
            {
                string qr = string.Format(@"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                            FROM dbo.Diem AS d
                            INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                            INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                            INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                            INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh
                            WHERE sv.malop = '{0}'
                            AND kh.makh = '{1}' ", malop, makh);

                return DataProvider.Instance.ExecuteQuery(qr);
            }

        }

        public DataTable GetListDiemByMalopMamh(string malop, string mamh, int lan)
        {
            if (lan > 0)
            {
                string qr = string.Format(@"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                            FROM dbo.Diem AS d
                            INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                            INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                            INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                            INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh
                            WHERE d.lan = {0}
                            AND d.mamh = '{1}'
                            AND sv.malop = '{2}' ", lan, mamh, malop);

                return DataProvider.Instance.ExecuteQuery(qr);
            }
            else
            {
                string qr = string.Format(@"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                            FROM dbo.Diem AS d
                            INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                            INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                            INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                            INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh
                            WHERE d.mamh = '{0}'
                            AND sv.malop = '{1}' ", mamh, malop);

                return DataProvider.Instance.ExecuteQuery(qr);
            }

        }

        public DataTable GetListDiemByMakhMalopMamh(string makh, string malop, string mamh, int lan)
        {
            if (lan > 0)
            {
                string qr = string.Format(@"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                            FROM dbo.Diem AS d
                            INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                            INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                            INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                            INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh
                            WHERE d.lan = {0}
                            AND d.mamh = '{1}'
                            AND l.MALOP = '{2}'
                            AND kh.MAKH = '{3}' ", lan, mamh, malop, makh);

                return DataProvider.Instance.ExecuteQuery(qr);
            }
            else
            {
                string qr = string.Format(@"SELECT d.masv, sv.ho, sv.ten, sv.phai, sv.malop, l.makh, d.mamh, mh.tenmh, lan, diem 
                            FROM dbo.Diem AS d
                            INNER JOIN dbo.Sinhvien AS sv ON d.masv = sv.masv
                            INNER JOIN dbo.Lop AS l ON l.malop = sv.malop
                            INNER JOIN dbo.Khoa AS kh ON kh.makh = l.makh
                            INNER JOIN dbo.Monhoc AS mh ON mh.mamh = d.mamh
                            WHERE d.mamh = '{0}'
                            AND l.MALOP = '{1}'
                            AND kh.MAKH = '{2}' ", mamh, malop, makh);

                return DataProvider.Instance.ExecuteQuery(qr);
            }

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

        public bool InsertDiem (string masv, string mamh, int lan, float diem)
        {
            string qr = string.Format("INSERT dbo.Diem ( masv, mamh, lan, diem) VALUES( '{0}' , '{1}' , {2} , {3} )", masv, mamh, lan, diem);

            int result = DataProvider.Instance.ExecuteNonQuery(qr);

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