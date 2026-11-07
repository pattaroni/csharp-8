namespace Csharp8;

static class Program
{
    static void Main()
    {
        Task1();
        Task2To5();
    }

    // завдання 1
    static void Task1()
    {
        Console.WriteLine("Завдання 1");

        while (true)
        {
            Console.Write("Введіть ім'я файлу (або Enter, щоб перейти далі): ");
            string fileName = Console.ReadLine() ?? "";

            if (fileName == "")
            {
                break;
            }

            AbstractHandler? handler = GetHandler(fileName);

            if (handler == null)
            {
                Console.WriteLine("Невідомий формат документа.");
                Console.WriteLine();
                continue;
            }

            handler.Open();
            handler.Create();
            handler.Change();
            handler.Save();
            Console.WriteLine();
        }
    }

    // визначення формату документа за розширенням
    static AbstractHandler? GetHandler(string fileName)
    {
        string name = fileName.ToLower();

        if (name.EndsWith(".xml"))
        {
            return new XmlHandler(fileName);
        }
        else if (name.EndsWith(".txt"))
        {
            return new TxtHandler(fileName);
        }
        else if (name.EndsWith(".doc"))
        {
            return new DocHandler(fileName);
        }

        return null;
    }

    // завдання 2-5
    static void Task2To5()
    {
        Console.WriteLine("Завдання 2-5");

        Employee[] employees = new Employee[3];
        employees[0] = new Manager("Олександр", 30000, 5);
        employees[1] = new Salesperson("Марина", 20000, 15000);
        employees[2] = new Programmer("Дмитро", 40000, 25500);

        foreach (Employee employee in employees)
        {
            employee.PrintSalary();
        }
    }
}
