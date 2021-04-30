using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMDS.model
{
    public class Monhoc
    {
        public Monhoc(string mamh, string tenmh)
        {
            this.Mamh = mamh;
            this.Tenmh = tenmh;

        }

        public Monhoc(DataRow row)
        {
            this.Mamh = row["mamh"].ToString();
            this.Tenmh = row["tenmh"].ToString();

        }

        private string mamh;

        private string tenmh;

        public string Mamh { get => mamh; set => mamh = value; }

        public string Tenmh { get => tenmh; set => tenmh = value; }
    }
}
