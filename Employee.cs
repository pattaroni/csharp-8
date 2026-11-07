namespace Csharp8;

public abstract class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    protected Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public abstract decimal CalculateSalary();

    public void PrintSalary()
    {
        Console.WriteLine(GetType().Name + " " + Name + ": ставка " + Salary
            + " грн, до виплати " + CalculateSalary() + " грн");
    }
}
