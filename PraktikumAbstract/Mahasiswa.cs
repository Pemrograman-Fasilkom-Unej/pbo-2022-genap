using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumAbstract
{
    internal class Mahasiswa : Civitas
    {
        public string NIM;
        public Mahasiswa(string namaInstitusi, string nama, string NIM) : base(namaInstitusi, nama)
        {
            this.NIM = NIM;
        }

        public override void cetakNamaInstitusi()
        {
            Console.WriteLine($"{nama} dengan NIM {NIM} adalah warga dari {namaInstitusi}");
        }
    }
}
