namespace Csharp8;

public class Salesperson : Employee
{
    public decimal SalesVolume { get; set; }

    public Salesperson(string name, decimal salary, decimal salesVolume)
        : base(name, salary)
    {
        SalesVolume = salesVolume;
    }

    public override decimal CalculateSalary()
    {
        return Salary + SalesVolume;
    }
}
