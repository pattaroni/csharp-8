namespace Csharp8;

public class DocHandler : AbstractHandler
{
    public DocHandler(string fileName) : base(fileName)
    {
    }

    public override void Open()
    {
        Console.WriteLine("Відкриття документа Word " + FileName + ": завантаження тексту і стилів.");
    }

    public override void Create()
    {
        Console.WriteLine("Створення документа Word " + FileName + " на основі шаблону.");
    }

    public override void Change()
    {
        Console.WriteLine("Редагування документа Word " + FileName + ": зміна тексту і форматування.");
    }

    public override void Save()
    {
        Console.WriteLine("Збереження документа Word " + FileName + " у форматі DOC.");
    }
}
