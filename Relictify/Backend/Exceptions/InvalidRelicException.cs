namespace Relictify.Backend.Exceptions;

public class InvalidRelicException : Exception
{
    public InvalidRelicException(string message) : base(message)
    {
    }

    public InvalidRelicException(string message, Exception inner) : base(message, inner)
    {
    }
}