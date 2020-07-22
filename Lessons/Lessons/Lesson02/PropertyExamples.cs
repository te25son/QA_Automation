using System;

namespace Lessons.Lesson02
{
    using static Console;

    class PropertyExamples
    {
        public static void Run()
        {
            var employee = new Employee("John", "Doe");

            WriteLine(employee.FirstName);
            WriteLine(employee.LastName);
            WriteLine(employee.Id);

            employee.FirstName = "Bill";

            WriteLine(employee.FirstName);

            var item = new SaleItem { Name = "Item", Price = 8.90 };
            WriteLine(item.Name);
            WriteLine(item.Price);
        }
    }

    public class Employee
    {
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }

    public class SaleItem
    {
        // Auto-implemented properties.
        public string Name { get; set; }

        public double Price { get; set; }
    }
}
