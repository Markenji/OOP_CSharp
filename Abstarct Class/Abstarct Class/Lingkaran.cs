using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_Class
{
    // Kelas turunan 1
    public class Lingkaran : Bentuk
    {
        public override double HitungLuas()
        {
            double jarijari = 5;

            return Math.PI * jarijari * jarijari;
        }
    }
  
}
