namespace department_system.Business.Exceptions;

public class UnprocessableRequestException : Exception
{
	public UnprocessableRequestException(string message) : base(message) { }
}
