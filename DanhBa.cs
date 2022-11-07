using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDFDemo
{
    internal class DanhBa
    {
        public string Ten { get; set; }
        public string SoDT { get; set; }
    }

    internal class Demo
    {
        static public List<DanhBa> DanhBa = new List<DanhBa>
        {
            new DanhBa {Ten = "A", SoDT = "1"},
            new DanhBa {Ten = "B", SoDT = "2"},
            new DanhBa {Ten = "C", SoDT = "3"},
            new DanhBa {Ten = "D", SoDT = "4"},
        };
    }
}
