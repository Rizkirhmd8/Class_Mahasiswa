using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject6513
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dosen dosen1 = new Dosen();
            Dosen dosen2 = new Dosen();

            //mengisi nilai untuk object dosen1
            dosen1.nik = "190302526";
            dosen1.nama = "Novi";

            //memanggil method mengajar dan menulis
            dosen1.Mengajar();
            dosen1.Menulis();

            //mengisi nilai untuk object dosen2
            dosen2.nik = "123456";
            dosen2.nama = "Nova";

            //memanggil method mengajar dan menulis
            dosen2.Mengajar();
            dosen2.Menulis();
        }
    }
}
