

namespace Pertemuan4
{
    class Person : Object
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
            Console.WriteLine("overloading addAge in person class with int parameter");
        }

        public void addAge()
        {
            Console.WriteLine("overloading addAge in person class");
        }

        public void addAge(int a, int b)
        {
            Console.WriteLine("overloading addAge in person class with 2 int parameters" + "  a: " + a + "  b: " + b);
        }

        //virtual : memperbolehkan child class nya unutk nge overriding method tersebut
        public virtual void tes()
        {
            Console.WriteLine("tes method in parent class " + this.name);
        }

        public void tes2()
        {
            Console.WriteLine("tes2 method");
        }


    }
}
