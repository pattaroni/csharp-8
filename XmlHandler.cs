namespace Csharp8;

public class XmlHandler : AbstractHandler
{
    public XmlHandler(string fileName) : base(fileName)
    {
    }

    public override void Open()
    {
        Console.WriteLine("Відкриття XML-документа " + FileName + ": зчитування дерева тегів.");
    }

    public override void Create()
    {
        Console.WriteLine("Створення XML-документа " + FileName + " з кореневим елементом <root>.");
    }

    public override void Change()
    {
        Console.WriteLine("Редагування XML-документа " + FileName + ": зміна значень вузлів.");
    }

    public override void Save()
    {
        Console.WriteLine("Збереження XML-документа " + FileName + " у кодуванні UTF-8.");
    }
}
