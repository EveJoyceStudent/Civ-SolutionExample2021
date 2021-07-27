using System;
using ProjectPersonClasses;
using ProjectCarClass;

namespace ProjectOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Jon";
            p1.Id = 12345;

            System.Console.WriteLine(p1.Name);

            Car c1 = new Car("abc123", 12345);

            System.Console.WriteLine(c1.rego);
            System.Console.WriteLine(c1.odometer);
        }
    }
}
