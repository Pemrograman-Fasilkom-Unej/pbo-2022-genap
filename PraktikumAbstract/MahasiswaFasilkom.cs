using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumAbstract
{
    internal class MahasiswaFasilkom : Mahasiswa, AnakIT
    {
        public string[]? bahasaYangDikuasai;

        public MahasiswaFasilkom(string namaInstitusi, string nama, string NIM, string[]? bahasaYangDikuasai=null) : base(namaInstitusi, nama, NIM)
        {
            this.bahasaYangDikuasai = bahasaYangDikuasai;
        }

        public void sedangNgoding()
        {
            if (bahasaYangDikuasai == null)
            {
                throw new GakBisaNgodingException($"Waduh, {nama} gak bisa ngoding nih.");
            } else
            {
                foreach (string bahasa in bahasaYangDikuasai)
                {
                    Console.WriteLine($"{nama} sedang mengoding menggunakan bahasa {bahasa}");
                }
            }
        }
    }
}
