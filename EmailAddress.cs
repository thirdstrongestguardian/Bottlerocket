using System;
using System.Net.Mail;

namespace Bottlerocket
{
	public class EmailAddress
	{
		// Declaration

		#region Properties
			
		public String Value = null;

		#endregion

		#region Constructors

		public EmailAddress()
		{

		}

		public EmailAddress(String value)
		{
			this.Value = value;
			
			if (!this.IsValid())
				throw new InvalidEmailAddressException();
		}

		#endregion

		// Implementation

		#region Equals

		public Boolean Equals(EmailAddress emailAddress)
		{
				return this.Value == emailAddress.Value;
		}

		#endregion 

		#region Operators
			
		public static implicit operator EmailAddress(String value)
		{
			return new EmailAddress(value);
		}

		public static implicit operator String(EmailAddress value)
		{
			return value.Value;
		}

		#endregion

		#region Parse

		public static EmailAddress Parse(String value)
		{
			return new EmailAddress(value);
		}

		public static Boolean TryParse(String value, out EmailAddress result)
		{
			try
			{
				result = new EmailAddress(value);
				return true;
			}
			catch
			{
				result = new EmailAddress();
				return false;
			}
		}

		#endregion

		#region To

		public new String ToString()
		{
			return this.Value;
		}

		#endregion

		#region Validate

		public Boolean IsValid()
		{
			try
			{
				MailAddress m = new MailAddress(this.Value);

				return true;
			}
			catch
			{
				return false;
			}
		}

		#endregion
	}
}
