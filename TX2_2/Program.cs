namespace TX2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            List<Employee> employees = new List<Employee>();
            int choice;
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Add Customer");
                Console.WriteLine("3. Display Employee with highest salary");
                Console.WriteLine("4. Display Customer with lowest balance");
                Console.WriteLine("5. Search Employee by name");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddEmployee(employees);
                        break;
                    case 2:
                        AddCustomer(customers);
                        break;
                    case 3:
                        DisplayHighestSalaryEmployee(employees);
                        break;
                    case 4:
                        DisplayLowestBalanceCustomer(customers);
                        break;
                    case 5:
                        SearchEmployeeByName(employees);
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        private static void AddEmployee(List<Employee> employees)
        {
            try
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine(); 
                if (name == null || name.Trim() == "")
                {
                    throw new FormatException() ;

                }
                Console.Write("Enter address: ");
                string address = Console.ReadLine();
                Console.Write("Enter salary: ");
               int salary = int.Parse(Console.ReadLine());
                employees.Add(new Employee(name, address, salary));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter correct data.");
            }
        }

        private static void AddCustomer(List<Customer> customers)
        {
            try
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                if (name == null || name.Trim() == "")
                {
                    throw new FormatException();

                }
                Console.Write("Enter address: ");
                string address = Console.ReadLine();
                Console.Write("Enter balance: ");
               int balance = int.Parse(Console.ReadLine());
                customers.Add(new Customer(name, address, balance));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter correct data.");
            }
        }

        private static void DisplayHighestSalaryEmployee(List<Employee> employees)
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees available.");
                return;
            }
            //trả về phần tử đầu tiên của mảng đã sort từ lớn -> bé
            var highestPaidEmp = employees.OrderByDescending(e => e.GetSalary()).FirstOrDefault();
            if(highestPaidEmp != null)
            {
                Console.WriteLine("Highest Paid Employee: ");
                foreach (var emp in employees)//loop để in nếu như có nhiều employee cùng có salary cao nhất
                {
                    if (emp.GetSalary() == highestPaidEmp.GetSalary())
                        emp.display();
                }

            }
            return;
        }

        private static void DisplayLowestBalanceCustomer(List<Customer> customers)
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No customers available.");
                return;
            }
            //trả về phần tử cuối cùng của mảng đã sort từ lớn -> bé
            var lowestBalanceCus = customers.OrderByDescending(cus => cus.getBalance()).LastOrDefault();
            if (lowestBalanceCus != null)
            {
                Console.WriteLine("Lowest balance customer is");
                foreach (var customer in customers)//loop để in nếu như có nhiều customer cùng có balance thấp nhất
                {
                    if(customer.getBalance()==lowestBalanceCus.getBalance())
                        customer.display();
                }
            }
            return;
        }

        private static void SearchEmployeeByName(List<Employee> employees)
        {
            Console.Write("Enter employee name to search: ");
            string name = Console.ReadLine();

            var emp = employees.Where(e=>e.getName().Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
            if (emp.Count > 0)
            {
                Console.WriteLine("Employees found:");
                foreach (var employee in emp)
                {
                    employee.display();
                }
            }
            else
            {
                Console.WriteLine("No employees found with the name " + name);
            }
        }

    }
}

