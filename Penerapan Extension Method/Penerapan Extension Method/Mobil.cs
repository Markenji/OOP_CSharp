using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penerapan_Extension_Method
{
    public class Mobil
    {
        public string Merek { get; set; }
        public string Model { get; set; }
        public int Tahun { get; set; }

        public Mobil(string merek, string model, int tahun)
        {
            Merek = merek;
            Model = model;
            Tahun = tahun;
        }
    }
}
