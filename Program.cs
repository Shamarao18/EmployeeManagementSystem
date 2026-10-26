using System;

class Program
{
    static Employee[] list = new Employee[20];
    static int total = 0;

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== Employee Management =====");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View All");
            Console.WriteLine("3. Search by ID");
            Console.WriteLine("4. Search by Name");
            Console.WriteLine("5. Show Payroll");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddEmployee();
                    break;
                case 2:
                    ViewAll();
                    break;
                case 3:
                    Console.Write("Enter id: ");
                    Search(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 4:
                    Console.Write("Enter name: ");
                    Search(Console.ReadLine());
                    break;
                case 5:
                    ShowPayroll();
                    break;
                case 0:
                    Console.WriteLine("Bye!");
                    break;
                default:
                    Console.WriteLine("Wrong choice.");
                    break;
            }
        } while (choice != 0);
    }

    static void AddEmployee()
    {
        if (total == 20)
        {
            Console.WriteLine("List is full.");
            return;
        }

        Console.Write("Type (1 = Full-Time, 2 = Part-Time, 3 = Manager): ");
        int type = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter department: ");
        string dept = Console.ReadLine();

        int id = Employee.count + 1;

        if (type == 1)
        {
            Console.Write("Enter salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            list[total] = new FullTimeEmployee(id, name, dept, salary);
        }
        else if (type == 2)
        {
            Console.Write("Enter hourly rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter hours worked: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            list[total] = new PartTimeEmployee(id, name, dept, rate, hours);
        }
        else
        {
            Console.Write("Enter salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter bonus: ");
            double bonus = Convert.ToDouble(Console.ReadLine());
            list[total] = new Manager(id, name, dept, salary, bonus);
        }

        total++;
        Console.WriteLine("Employee added. ID = " + id);
    }

    static void ViewAll()
    {
        if (total == 0)
        {
            Console.WriteLine("No employees yet.");
            return;
        }

        for (int i = 0; i < total; i++)
        {
            list[i].Display();
        }
    }

    static void Search(int id)
    {
        bool found = false;

        for (int i = 0; i < total; i++)
        {
            if (list[i].GetId() == id)
            {
                list[i].Display();
                found = true;
            }
        }

        if (found == false)
        {
            Console.WriteLine("Employee not found.");
        }
    }

    static void Search(string name)
    {
        bool found = false;

        for (int i = 0; i < total; i++)
        {
            if (list[i].GetName().ToLower() == name.ToLower())
            {
                list[i].Display();
                found = true;
            }
        }

        if (found == false)
        {
            Console.WriteLine("Employee not found.");
        }
    }

    static void ShowPayroll()
    {
        double sum = 0;

        for (int i = 0; i < total; i++)
        {
            IPayable p = list[i];
            sum = sum + p.CalculateSalary();
        }

        Console.WriteLine("Total employees: " + Employee.count);
        Console.WriteLine("Total payroll: " + sum);
    }
}