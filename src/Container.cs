namespace HandsOn;

public class Container<T>
{
    protected T[]? content { get; set; }

    public Container(T[]? content)
    {
        if (content is null)
        {
            return;
        }
        
        this.content = content;
    }
}

public class LiteralContainer : Container<string>
{
    readonly Exception LiteralContainerException = new ApplicationException("");
    
    public LiteralContainer(string[]? content) : base(content)
    {
        this.content = content ?? throw this.LiteralContainerException;
    }

    public string[] GetContent()
    {
        return this.content;
    }
}