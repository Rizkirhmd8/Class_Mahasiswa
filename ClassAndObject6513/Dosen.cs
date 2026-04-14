using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject6513
{
    internal class Dosen
    {
        //atribut
        public string nik { get; set; }
        public string nama {get; set;}

        //behavior
        public void Mengajar()
        {
            Console.WriteLine("{0} mengajar Kalkulus", nama);
        }

        public void Menulis()
        {
            Console.WriteLine("{0} menulis riset", nama);
        }
    }
}
