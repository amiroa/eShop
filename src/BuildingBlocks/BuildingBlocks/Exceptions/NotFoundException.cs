namespace BuildingBlocks.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException() : base("Resource not found!")
    {
    }

    public NotFoundException(string message) : base(message)
    {
    }

    public NotFoundException(string name, object key)
        : base($"Entity '{name}' with key '{key}' not found.")
    {
    }
}
