using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_Class
{
    // Kelas turunan 2
   
    public class PersegiPanjang : Bentuk
    {
        public override double HitungLuas()
        {
            double panjang = 4;
            double lebar = 5;

            return panjang * lebar;
        }
    }
}
