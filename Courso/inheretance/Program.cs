using System;
using System.Globalization;
using System.Collections.Generic;
using inheretance.entitites;

namespace inheretance
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of employee: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee#{i} data:");
                Console.WriteLine("Outsourced (y/n)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Hours");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per Hour");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Additional charge");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
                Console.WriteLine();
                Console.WriteLine("PAYMENT");
                foreach (Employee emp in list)
                {
                    Console.WriteLine(emp.Name+" -$"+ emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                }

            }
        }
    }
}