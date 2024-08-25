namespace Domain.Exceptions;

public class UnauthorizedException : Exception
{
    public UnauthorizedException() { }

    public UnauthorizedException(string message) : base(message) { }
    
    public UnauthorizedException(string message, Exception innerException) : base(message, innerException) { }

    public UnauthorizedException(string action, string user) : base($"User '{user}' is not authorized to perform the action '{action}'.") { }
}
