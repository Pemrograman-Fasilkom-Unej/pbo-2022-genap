
namespace Pertemuan4
{
    class Employee : Person
    {
        public int salary;


        public Employee(string name, int age, int salaryInput) : base(name, age)
        {
            this.salary = salaryInput;
        }

        public override string ToString()
        {
            return (name + " " + " " + age);
        }

    }
}