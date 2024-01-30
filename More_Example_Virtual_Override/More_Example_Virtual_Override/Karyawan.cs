using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Example_Virtual_Override
{
    // Kelas dasar (base class) untuk karyawan
    class Karyawan
    {
        public string Nama { get; set; }
        public double GajiPokok { get; set; }

        // Metode virtual untuk menghitung gaji total
        public virtual double HitungGajiTotal()
        {
            return GajiPokok;
        }
    }

    // Kelas turunan (derived class) untuk karyawan dengan bonus
    class KaryawanDenganBonus : Karyawan
    {
        public double Bonus { get; set; }

        // Meng-override metode HitungGajiTotal dari kelas dasar
        public override double HitungGajiTotal()
        {
            return GajiPokok + Bonus;
        }
    }

    // Kelas turunan (derived class) untuk karyawan dengan tunjangan
    class KaryawanDenganTunjangan : Karyawan
    {
        public double Tunjangan { get; set; }

        // Meng-override metode HitungGajiTotal dari kelas dasar
        public override double HitungGajiTotal()
        {
            return GajiPokok + Tunjangan;
        }
    }

}
