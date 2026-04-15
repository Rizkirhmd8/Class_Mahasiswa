using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMahasiswa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //membuat object class Mahasiswa
            Mahasiswa mahasiswa1 = new Mahasiswa();
            Mahasiswa mahasiswa2 = new Mahasiswa();

            //mengeset nilai properties object saya dan kamu
            mahasiswa1.nim = "6513";
            mahasiswa1.nama = "Rizki Rahmadi";
            mahasiswa1.ipk = 3.95f;

            mahasiswa2.nim = "2522";
            mahasiswa2.nama = "Rizki Tanjung";
            mahasiswa2.ipk = 2.80f;

            //memangil method register dan isi krs
            mahasiswa1.Registrasi();
            mahasiswa1.IsiKrs();

            mahasiswa2.Registrasi();
            mahasiswa2.IsiKrs();

            Console.ReadKey();
        }
    }
}
