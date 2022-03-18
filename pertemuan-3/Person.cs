namespace Pertemuan3
{
    class Person
    {
        public string name;
        private int age;
        //constructor atau fungsi yang dijalankan ketika kelas dibuat
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
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


    }
}