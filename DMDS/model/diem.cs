using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DMDS.model
{
    public class Diemm
    {
        public Diemm (string masv, string mamh, int lan, int diem)
        {
            this.Masv = masv;
            this.Mamh = mamh;
            this.Lan = lan;
            this.Diem = diem;

        }

        public Diemm (DataRow row)
        {
            this.Masv = row["masv"].ToString();
            this.Mamh = row["mamh"].ToString();
            this.Lan = (int)row["lan"];
            this.Diem = (int)row["diem"];

        }

        private string masv;

        private string mamh;

        private int lan;

        private int diem;
        
        public string Masv { get => masv; set => masv = value; }

        public string Mamh { get => mamh; set => mamh = value; }
        
        public int Lan { get => lan; set => lan = value; }
        
        public int Diem { get => diem; set => diem = value; }
    }
}
