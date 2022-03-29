using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person orang1 = new Person("hadi", 1);

            Mahasiswa amiroh = new Mahasiswa("amiroh", 1, 4);
            amiroh.greeting();
            Console.WriteLine(amiroh.age);
            Console.WriteLine(amiroh.adress);


            Employee tono = new Employee("tono", 40, 3000000);

            amiroh.tes();
            tono.tes();

            Console.WriteLine(Person.countPerson);

            // initialize parents based on existed child variable
            Person orang2;
            Employee budi = new Employee("budi", 50, 3000000);
            orang2 = budi;
            Console.WriteLine(orang2.name);


        }
    }
}