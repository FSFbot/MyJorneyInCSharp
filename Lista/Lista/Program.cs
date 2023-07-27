using System.Globalization;

namespace Lista {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("How mant emplyees will be registred?");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i <= n; i++) {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncresesSalary(percentage);
            } else {
                Console.WriteLine("This id does exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employee:");
            foreach(Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}