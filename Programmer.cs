namespace Csharp8;

public class Programmer : Employee
{
    public int LinesOfCode { get; set; }

    public Programmer(string name, decimal salary, int linesOfCode)
        : base(name, salary)
    {
        LinesOfCode = linesOfCode;
    }

    public override decimal CalculateSalary()
    {
        int thousands = LinesOfCode / 1000;
        return Salary + thousands * 100;
    }
}
