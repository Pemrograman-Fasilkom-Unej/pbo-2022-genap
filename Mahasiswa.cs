

namespace Pertemuan4
{
    //namaChild : ParentClass
    class Mahasiswa : Person
    {
        public int ipk;
        // public string universityName;

        public Mahasiswa(string name, int age, int ipkInput) : base(name, age)
        {
            this.name = name;
            this.age = age;
            this.ipk = ipkInput;
            Console.WriteLine("constructor Mahasiswa");
            // countPerson++;
        }
    }


}