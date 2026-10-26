class FullTimeEmployee : Employee
{
    private double salary;

    public FullTimeEmployee(int id, string name, string department, double salary) : base(id, name, department)
    {
        this.salary = salary;
    }

    public override double CalculateSalary()
    {
        return salary;
    }

    public override string GetRole()
    {
        return "Full-Time";
    }
}