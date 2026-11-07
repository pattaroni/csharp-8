namespace Csharp8;

public class TxtHandler : AbstractHandler
{
    public TxtHandler(string fileName) : base(fileName)
    {
    }

    public override void Open()
    {
        Console.WriteLine("Відкриття текстового файлу " + FileName + ": зчитування рядків.");
    }

    public override void Create()
    {
        Console.WriteLine("Створення порожнього текстового файлу " + FileName + ".");
    }

    public override void Change()
    {
        Console.WriteLine("Редагування текстового файлу " + FileName + ": додавання нового рядка.");
    }

    public override void Save()
    {
        Console.WriteLine("Збереження текстового файлу " + FileName + " без форматування.");
    }
}
