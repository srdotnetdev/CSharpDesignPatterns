namespace GoF.DesignPatterns.Proxy;

public interface IDocument
{
    string GetContent();
    void SetContent(string content);
}

public class Document : IDocument
{
    private string _content = "Secure Data";
    
    public string GetContent()
    {
        return _content;
    }

    public void SetContent(string content)
    {
        _content = content;
    }
}