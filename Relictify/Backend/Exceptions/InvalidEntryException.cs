namespace Relictify.Backend.Exceptions;

public class InvalidEntryException : Exception
{
    public InvalidEntryException(string message) : base(message)
    {
    }

    public InvalidEntryException(string message, Exception inner) : base(message, inner)
    {
    }
}