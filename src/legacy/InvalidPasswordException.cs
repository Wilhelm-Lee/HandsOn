namespace HandsOn;

public class InvalidPasswordException : Exception
{
    public InvalidPasswordException() : base("password is invalid")
    {
    }
}