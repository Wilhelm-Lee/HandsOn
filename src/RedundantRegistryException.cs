namespace HandsOn;

public class RedundantRegistryException : Exception
{
    public RedundantRegistryException() : base("username is already taken")
    {
    }

    public RedundantRegistryException(string? message) : base(message)
    {
    }
}