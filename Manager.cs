namespace Csharp8;

public class Manager : Employee
{
    private const decimal BonusPerSubordinate = 1000;

    public int SubordinatesCount { get; set; }

    public Manager(string name, decimal salary, int subordinatesCount)
        : base(name, salary)
    {
        SubordinatesCount = subordinatesCount;
    }

    public override decimal CalculateSalary()
    {
        return Salary + SubordinatesCount * BonusPerSubordinate;
    }
}
