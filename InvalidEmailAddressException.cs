using System;

namespace BottleRocket
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