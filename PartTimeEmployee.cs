class PartTimeEmployee : Employee
{
    private double rate;
    private int hours;

    public PartTimeEmployee(int id, string name, string department, double rate, int hours) : base(id, name, department)
    {
        this.rate = rate;
        this.hours = hours;
    }

    public override double CalculateSalary()
    {
        return rate * hours;
    }

    public override string GetRole()
    {
        return "Part-Time";
    }
}