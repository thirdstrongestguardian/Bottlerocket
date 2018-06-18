using System;

namespace MoonStorm
{
	public class InvalidEmailAddressException : Exception
	{
		public InvalidEmailAddressException()
			: base("Invalid email address!")
		{
			
		}

		public InvalidEmailAddressException(String message)
			: base(message)
		{
			
		}
	}
}