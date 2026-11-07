namespace Csharp8;

public abstract class AbstractHandler
{
    public string FileName { get; set; }

    protected AbstractHandler(string fileName)
    {
        FileName = fileName;
    }

    public abstract void Open();
    public abstract void Create();
    public abstract void Change();
    public abstract void Save();
}
