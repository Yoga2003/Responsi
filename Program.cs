using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4353
{
    class Program
    {
        static void Main(string[] args)
        {
            //Karyawan 1
            Karyawan karyawan1 = new Karyawan();

            //properties karyawan 1
            karyawan1.NIK = "21114353";
            karyawan1.NAMA = "Yoga";
            karyawan1.GajiBulanan = 3000000;

            // Karyawan 2
            Karyawan karyawan2 = new Karyawan();

            //properties karyawan 2
            karyawan2.NIK = "21112222";
            karyawan2.NAMA = "Susena";
            karyawan2.GajiBulanan = 2000000;

            //pemanggilan method
            Console.WriteLine("No Nik/Nama\t\t\tGaji Bulanan");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1.{0} {1}\t\t\t{2}", karyawan1.NIK, karyawan1.NAMA, karyawan1.GajiBulanan);
            Console.WriteLine("2.{0} {1}\t\t{2}", karyawan2.NIK, karyawan2.NAMA, karyawan2.GajiBulanan);
            Console.WriteLine(" ");
            Console.WriteLine("Kenaikan Gaji 10%!! ");
            Console.WriteLine(" ");
            Console.WriteLine("No Nik/Nama\t\t\tGaji Bulanan");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1.{0} {1}\t\t\t{2}", karyawan1.NIK, karyawan1.NAMA, karyawan1.GajiBulanan + (karyawan1.GajiBulanan * 0.10));
            Console.WriteLine("2.{0} {1}\t\t{2}", karyawan2.NIK, karyawan2.NAMA, karyawan2.GajiBulanan + (karyawan2.GajiBulanan * 0.10));
            Console.ReadKey();
        }
    }
}
