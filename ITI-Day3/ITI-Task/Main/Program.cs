namespace Main;

public class Program
{
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[200];
        int ctr = 0;
        string choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add new employee");
            Console.WriteLine("2. Get all employees");
            Console.WriteLine("3. Update employee info");
            Console.WriteLine("4. Get Employee By ID");
            Console.WriteLine("5. Exit");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1": AddNewEmployee(); break;
                case "2": GetAllEmployees(); break;
                case "3": UpdateEmployee(); break;
                case "4": GetEmployeeById(); break;
                case "5": Console.WriteLine("Exiting..."); break;
                default: Console.WriteLine("Invalid choice"); break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        } while (choice != "5");

        void AddNewEmployee()
        {
            Console.WriteLine("Enter Number of employees you want to add: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (ctr + n > 200)
            {
                Console.WriteLine($"Cannot add {n} employees. Only {200 - ctr} slots available.");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Employee #{i + 1} ---");

                int id;
                bool exists;
                do
                {
                    exists = false;
                    Console.Write("Enter ID: ");
                    id = Convert.ToInt32(Console.ReadLine());

                    for (int j = 0; j < ctr; j++)
                    {
                        if (employees[j].ID == id)
                        {
                            exists = true;
                            Console.WriteLine("Error: This ID already exists. Please enter a different ID.");
                            break;
                        }
                    }
                } while (exists);

                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter department: ");
                string department = Console.ReadLine();

                Console.Write("Enter salary: ");
                int salary = int.Parse(Console.ReadLine());
                employees[ctr++] = new Employee(id, name, salary, department);
                Console.WriteLine("Employee added successfully.");
            }
        }

        void GetAllEmployees()
        {
            if (ctr == 0)
            {
                Console.WriteLine("No employees to show.");
                return;
            }

            Console.WriteLine("=== Employee List ===");
            for (int i = 0; i < ctr; i++)
            {
                if (employees[i] != null)
                {
                    employees[i].Display();
                    Console.WriteLine("=================");
                }
            }
        }

        void UpdateEmployee()
        {
            Console.Write("Enter the ID of the employee to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ctr; i++)
            {
                if (employees[i] != null && employees[i].ID == id)
                {
                    Console.WriteLine("\nEmployee found.");
                    string choice;

                    do
                    {
                        Console.WriteLine("\nWhat would you like to update?");
                        Console.WriteLine("1. Name");
                        Console.WriteLine("2. Department");
                        Console.WriteLine("3. Salary");
                        Console.WriteLine("4. ID");
                        Console.WriteLine("5. Back to main menu");
                        choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1":
                                Console.Write("Enter new name: ");
                                employees[i].Name = Console.ReadLine();
                                Console.WriteLine("Name updated.");
                                break;

                            case "2":
                                Console.Write("Enter new department: ");
                                employees[i].Department = Console.ReadLine();
                                Console.WriteLine("Department updated.");
                                break;

                            case "3":
                                Console.Write("Enter new salary: ");
                                employees[i].salary = int.Parse(Console.ReadLine());
                                Console.WriteLine("Salary updated.");
                                break;
                            case "4":
                                while (true)
                                {
                                    Console.Write("Enter new ID: ");
                                    int newId = Convert.ToInt32(Console.ReadLine());
                                    bool exists = false;

                                    for (int j = 0; j < ctr; j++)
                                    {
                                        if (j != i && employees[j] != null && employees[j].ID == newId)
                                        {
                                            Console.WriteLine("This ID already exists. Please enter another one.");
                                            exists = true;
                                            break;
                                        }
                                    }

                                    if (!exists)
                                    {
                                        employees[i].ID = newId;
                                        Console.WriteLine("ID updated.");
                                        break;
                                    }
                                }
                                break;
                            case "5":
                                break;
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }

                    } while (choice != "5");
                    return;
                }
            }
            Console.WriteLine("Employee not found.");
        }

        void GetEmployeeById()
        {
            Console.Write("Enter employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ctr; i++)
            {
                if (employees[i] != null && employees[i].ID == id)
                {
                    Console.WriteLine("\nEmployee found:");
                    employees[i].Display();
                    return;
                }
            }
            Console.WriteLine("Employee not found.");
        }
    }
}

