using EmployeeManagementSystem;

EmployeeManager manager = new EmployeeManager();

int choice;

do
{
    Console.WriteLine("******  Employee Management System  ******");
    Console.WriteLine("1. Add Employee");
    Console.WriteLine("2. View Employees");
    Console.WriteLine("3. Search Employee");
    Console.WriteLine("4. Exit");

    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        manager.AddEmployee();
    }
    else if (choice == 2)
    {
        manager.ViewEmployees();
    }
    else if (choice == 3)
    {
        manager.SearchEmployee();
    }
    else if (choice == 4)
    {
        Console.WriteLine("Exiting program...");
    }
    else
    {
        Console.WriteLine("Invalid choice!");
    }

} while (choice != 4);