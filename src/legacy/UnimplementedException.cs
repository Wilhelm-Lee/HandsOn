namespace HandsOn;

public class UnimplementedException : Exception
{

    public UnimplementedException() : base("not implement Execute command")
    {
    }
}
