

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

        public void addAge(string inputWord)
        {
            Console.WriteLine("input word : " + inputWord);
        }

        //override : overriding method yang sama di parent class
        public override void tes()
        {
            Console.WriteLine("OVERRIDING IN MAHASISWA CLASS!! " + this.name);
        }

        public new void tes2()
        {
            Console.WriteLine("overriding without permission");

        }
    }


}