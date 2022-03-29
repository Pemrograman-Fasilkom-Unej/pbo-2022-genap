

namespace Pertemuan4
{
    class Person
    {
        public string name;
        public int age;

        public string adress;

        private bool isDead;

        public static int countPerson;

        //constructor atau fungsi yang dijalankan ketika kelas dibuat
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.adress = "jl jalan jalan";
            countPerson++;
        }

        // nilaiKembalian namaMethod(parameter...)
        // void == tidak mengembalikan nilai
        public void greeting()
        {
            Console.WriteLine($"Hello, my name is {this.name}. Umur saya {this.age}");
        }

        public void addAge(int amount)
        {
            if (amount > 0)
            {
                this.age = this.age + amount;
            }
        }

        public void tes()
        {
            Console.WriteLine("tes method in parent class " + this.name);
        }


    }
}
