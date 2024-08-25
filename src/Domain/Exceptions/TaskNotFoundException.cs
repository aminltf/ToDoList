namespace Domain.Exceptions;

public class TaskNotFoundException : Exception
{
    public TaskNotFoundException() { }
    
    public TaskNotFoundException(string message) : base(message) { }

    public TaskNotFoundException(string message, Exception innerException) : base(message, innerException) { }

    public TaskNotFoundException(Guid taskId) : base($"Task with ID '{taskId}' was not found.") { }
}
