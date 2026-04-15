using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Mahasiswa_6513
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //membuat object class Mahasiswa
            Mahasiswa mahasiswa1 = new Mahasiswa();
            Mahasiswa mahasiswa2 = new Mahasiswa();

            //mengeset nilai properties object saya dan kamu
            mahasiswa1.Nim = "6513";
            mahasiswa1.Nama = "Rizki Rahmadi";
            mahasiswa1.Ipk = 3.95f;

            mahasiswa2.Nim = "2522";
            mahasiswa2.Nama = "Rizki Tanjung";
            mahasiswa2.Ipk = 2.80f;

            //memangil method register dan isi krs
            mahasiswa1.Registrasi();
            mahasiswa1.IsiKrs();

            mahasiswa2.Registrasi();
            mahasiswa2.IsiKrs();

            Console.ReadKey();
        }
    }
}