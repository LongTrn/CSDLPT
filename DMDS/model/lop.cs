using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DMDS.model
{
    public class Lop
    {
        public Lop(string malop, string tenlop)
        {
            this.Malop = malop;
            this.Tenlop = tenlop;

        }

        public Lop(DataRow row)
        {
            this.Malop = row["malop"].ToString();
            this.Tenlop = row["tenlop"].ToString();

        }

        private string malop;

        private string tenlop;

        public string Malop { get => malop; set => malop = value; }

        public string Tenlop { get => tenlop; set => tenlop = value; }
    }
}
