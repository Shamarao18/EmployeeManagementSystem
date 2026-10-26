class Manager : FullTimeEmployee
{
    private double bonus;

    public Manager(int id, string name, string department, double salary, double bonus) : base(id, name, department, salary)
    {
        this.bonus = bonus;
    }

    public override double CalculateSalary()
    {
        return base.CalculateSalary() + bonus;
    }

    public override string GetRole()
    {
        return "Manager";
    }
}