using System;

abstract class Employee : IPayable
{
    private int id;
    private string name;
    private string department;

    public static int count = 0;

    public Employee(int id, string name, string department)
    {
        this.id = id;
        this.name = name;
        this.department = department;
        count++;
    }

    public int GetId()
    {
        return id;
    }

    public string GetName()
    {
        return name;
    }

    public string GetDepartment()
    {
        return department;
    }

    public abstract double CalculateSalary();

    public abstract string GetRole();

    public virtual void Display()
    {
        Console.WriteLine(id + " | " + name + " | " + department + " | " + GetRole() + " | Salary: " + CalculateSalary());
    }
}