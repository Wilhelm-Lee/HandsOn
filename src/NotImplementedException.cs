namespace HandsOn;

public class NotimplementedException : Exception
{
    public NotimplementedException() : base("Not Implement IPlayable Interface")
    {}
}