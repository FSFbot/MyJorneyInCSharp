using polimorph.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace polimorph
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> lis = new List<TaxPayer>();

            Console.Write("Enter the number of Tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<= n; i++) {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual ou company (i/c)");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double income = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (type == 'i')
                {
                    Console.WriteLine("Health expenditure: ");
                    double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lis.Add(new Individual(name, income, healthExpenditure));
                }
                else {
                    Console.WriteLine("Number of Employee");
                    int numberOfEmployee = int.Parse(Console.ReadLine());
                    lis.Add(new Company(name, income, numberOfEmployee));
                }
            }
            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("Tax Paid");
            foreach (TaxPayer tp in lis) {
                double tax = tp.Tax();
                Console.WriteLine($"{tp.Name}: $ {tax.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}