using Enums_exemple.Entities;
using Enums_exemple.Entities.Enums;
using System.Globalization;
namespace Enums_exemple {
    class Program { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter with Departament Name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level: (Junior / MidLevel/ Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary");

            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament();
            Worker worker = new Worker(name,level,baseSalary,dept);

            Console.WriteLine("How many contracts to this worker? ");

            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i<= n; i++)
            {
                Console.WriteLine($"Enter{i} contract data: ");
                Console.WriteLine("Date (DD/MM/YYYY)");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration(hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income(MM/YYYY): ");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0,2));
            int year = int.Parse(monthYear.Substring(3));
            Console.WriteLine("Name: "+worker.Name);
            Console.WriteLine("Departament: "+ worker.Departament.Name);
            Console.WriteLine("Income for" + monthYear+" :"+ worker.Income(year, month).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}