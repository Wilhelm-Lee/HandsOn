namespace HandsOn;

public class InvalidUsernameException : Exception
{
    public InvalidUsernameException() : base("username is invalid")
    {
    }
}