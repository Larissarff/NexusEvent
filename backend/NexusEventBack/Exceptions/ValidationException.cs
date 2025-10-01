namespace NexusEventBack.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) { }
    }

    public class ServiceException : Exception
    {
        public ServiceException(string message, Exception? inner = null)
            : base(message, inner) { }
    }

    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message) { }
    }

}
