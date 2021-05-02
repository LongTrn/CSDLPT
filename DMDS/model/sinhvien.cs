using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DMDS.model
{
    public class Sinhvien
    {
        public Sinhvien(string masv, string ho, string ten, string malop, bool phai, DateTime ngaysinh, string noisinh, string ghichu, bool nghihoc)
        {
            this.Masv = masv;
            this.Ho = ho;
            this.Ten = ten;
            this.Malop = malop;
            this.Phai = phai;
            this.Ngaysinh = ngaysinh;
            this.Noisinh = noisinh;
            this.Ghichu = ghichu;
            this.Nghihoc = nghihoc;

        }

        public Sinhvien(DataRow row)
        {
            this.Masv = row["masv"].ToString();
            this.Ho = row["ho"].ToString();
            this.Ten = row["ten"].ToString();
            this.Malop = row["malop"].ToString();
            this.Phai = (bool)row["phai"];
            this.Ngaysinh = (DateTime)row["ngaysinh"];
            this.Noisinh = row["noisinh"].ToString();
            this.Ghichu = row["ghichu"].ToString();
            this.Nghihoc = (bool)row["nghihoc"];

        }

        private string masv;

        private string ho;

        private string ten;

        private string malop;

        private bool phai;

        private DateTime ngaysinh;

        private string noisinh;

        private string ghichu;
        
        private bool nghihoc;


        public string Masv { get => masv; set => masv = value; }

        public string Ho { get => ho; set => ho = value; }

        public string Ten { get => ten; set => ten = value; }

        public string Malop { get => malop; set => malop = value; }

        public bool Phai { get => phai; set => phai = value; }

        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }

        public string Noisinh { get => noisinh; set => noisinh = value; }

        public string Ghichu { get => ghichu; set => ghichu = value; }

        public bool Nghihoc { get => nghihoc; set => nghihoc = value; }
    }
}
