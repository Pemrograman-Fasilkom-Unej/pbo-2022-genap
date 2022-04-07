using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumAbstract
{
    internal abstract class Civitas
    {
        public string namaInstitusi;
        public string nama;

        public Civitas(string namaInstitusi, string nama)
        {
            this.namaInstitusi = namaInstitusi;
            this.nama = nama;
        }

        public abstract void cetakNamaInstitusi();


        //{
        //    Console.WriteLine($"{nama} adalah warga dari {namaInstitusi}");
        //}
    }
}
