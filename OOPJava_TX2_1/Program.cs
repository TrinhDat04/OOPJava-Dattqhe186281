
namespace OOPJava_TX2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            bool exit = false;

            while (!exit) {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Part-Time Employee");
                Console.WriteLine("2. Add Full-Time Employee");
                Console.WriteLine("3. Find Highest Salary Employee");
                Console.WriteLine("4. Find Employee by Name");
                Console.WriteLine("5. Exit");

                int choice;
               
                if (!int.TryParse(Console.ReadLine(), out choice))//nếu truyền vào đúng là số nguyên thì gán cho choice, không thì báo lỗi bắt nhập lại
                {
                    Console.WriteLine("Invalid choice. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddPartTimeEmployee(employees);
                        break;
                    case 2:
                        AddFullTimeEmployee(employees);
                        break;
                    case 3:
                        FindHighestSalaryEmployee(employees);
                        break;
                    case 4:
                        FindByName(employees);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        static void AddPartTimeEmployee(List<Employee> employees)
        {
            try
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter payment per hour: ");
                int paymentPerHour = int.Parse(Console.ReadLine());

                Console.Write("Enter working hours: ");
                int workingHours = int.Parse(Console.ReadLine());

                employees.Add(new PartTimeEmployee(name, paymentPerHour, workingHours));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter correct data.");
            }
        }

        static void AddFullTimeEmployee(List<Employee> employees)
        {
            try
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter payment per hour: ");
                int paymentPerHour = int.Parse(Console.ReadLine());

                employees.Add(new FullTimeEmployee(name, paymentPerHour));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter correct data.");
            }
        }

        static void FindHighestSalaryEmployee(List<Employee> employees)
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees available.");
                return;
            }

            var highestPaidFullTime = employees.OfType<FullTimeEmployee>().OrderByDescending(e => e.calculateSalary()).FirstOrDefault();
            var highestPaidPartTime = employees.OfType<PartTimeEmployee>().OrderByDescending(e => e.calculateSalary()).FirstOrDefault();

            if (highestPaidFullTime != null)
            {
                Console.WriteLine("Highest Paid Full-Time Employee: " + highestPaidFullTime);
            }
            else
            {
                Console.WriteLine("No Full-Time Employees available.");
            }

            if (highestPaidPartTime != null)
            {
                Console.WriteLine("Highest Paid Part-Time Employee: " + highestPaidPartTime);
            }
            else
            {
                Console.WriteLine("No Part-Time Employees available.");
            }
        }

        static void FindByName(List<Employee> employees)
        {
            Console.Write("Enter name to search: ");
            string name = Console.ReadLine();
            //khởi tạo biến var để chứa list các employee có cùng tên
            var foundEmployees = employees.Where(e => e.getName().Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();

            if (foundEmployees.Count > 0)
            {
                Console.WriteLine("Employees found:");
                foreach (var employee in foundEmployees)
                {
                    Console.WriteLine(employee);
                }
            }
            else
            {
                Console.WriteLine("No employees found with the name " + name);
            }
        }
    }
}
