using System;

public class BusinessLogicException : Exception
{
	public BusinessLogicException(string msg)
	{
        this.Message = msg;
	}

    public string Message;
}
