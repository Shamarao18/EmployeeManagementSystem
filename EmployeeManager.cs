namespace EmployeeManagementSystem;

public class EmployeeManager
{
    private Employee[] employees = new Employee[10];
    private int count = 0;

    public void AddEmployee()
    {
        if (count >= employees.Length)
        {
            Console.WriteLine("Employee storage is full!");
            return;
        }

        Console.Write("Enter ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            if (employees[i].empId == id)
            {
                Console.WriteLine("ID already exists!");
                return;
            }
        }

        Console.Write("Enter Name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Enter Department: ");
        string department = Console.ReadLine() ?? "";

        Console.Write("Enter Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Employee emp = new Employee(id, name, department, salary);

        employees[count] = emp;
        count++;

        Console.WriteLine("Employee added successfully!");
    }

    public void ViewEmployees()
    {
        if (count == 0)
        {
            Console.WriteLine("No employees found.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("            Employee Details        ");
            Console.WriteLine("ID: " + employees[i].empId);
            Console.WriteLine("Name: " + employees[i].empName);
            Console.WriteLine("Department: " + employees[i].empDept);
            Console.WriteLine("Salary: " + employees[i].Salary);
        }
    }

    public void SearchEmployee()
    {
        Console.Write("Enter employee ID to search: ");
        int id = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            if (employees[i].empId == id)
            {
                Console.WriteLine("            Employee Found!          ");
                Console.WriteLine("ID: " + employees[i].empId);
                Console.WriteLine("Name: " + employees[i].empName);
                Console.WriteLine("Department: " + employees[i].empDept);
                Console.WriteLine("Salary: " + employees[i].Salary);
                return;
            }
        }

        Console.WriteLine("Employee not found.");
    }
}