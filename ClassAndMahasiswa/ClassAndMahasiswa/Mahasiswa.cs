using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMahasiswa
{
    internal class Mahasiswa
    {
        //properties
        public string nim { get; set; }
        public string nama { get; set; }
        public string ipk { get; set; }

        //method
        public void Registrasi()
        {
            Console.WriteLine("Nama : {0}", nama);
            Console.WriteLine("NIM : {0}", nim);
            Console.WriteLine("IPK : {0}", ipk);
            Console.WriteLine("\nTelah Melakukan registrasi");
        }
        public void IsiKrs()
        {
            Console.WriteLine("{0} sedang melakukan proses Krs", nama);
        }

    }
}
