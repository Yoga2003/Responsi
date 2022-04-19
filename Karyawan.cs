using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4353
{
    class Karyawan
    {
        public Karyawan()
        {

        }
        public Karyawan(string nama, string nik, int gajibulanan)
        {
            NAMA = nama;
            NIK = nik;
            GajiBulanan = gajibulanan;
        }
        public string NAMA { get; set; }
        public string NIK { get; set; }
        public int GajiBulanan { get; set; }

    }
}
