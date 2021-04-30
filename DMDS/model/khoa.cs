using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DMDS.model
{
    public class Khoa
    {
        public Khoa(string makh, string tenkh)
        {
            this.Makh = makh;
            this.Tenkh = tenkh;

        }

        public Khoa(DataRow row)
        {
            this.Makh = row["makh"].ToString();
            this.Tenkh = row["tenkh"].ToString();

        }

        private string makh;

        private string tenkh;

        public string Makh { get => makh; set => makh = value; }

        public string Tenkh { get => tenkh; set => tenkh = value; }
    }
}
