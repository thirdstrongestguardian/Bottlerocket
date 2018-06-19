using System;

namespace Bottlerocket
{
	public class Percent
	{
		// Declaration

		#region Properties

		public Double Value = 0;

		#endregion

		#region Constructors

		public Percent()
		{
			this.Value = 0;
		}

		public Percent(Double value)
		{
			this.Value = value;
		}

		public Percent(String value)
		{
			this.Value = Convert.ToDouble(value.Replace("%", "")) / 100.0;
		}

		#endregion

		// Declaration

		#region Operators

		public static implicit operator Percent(Double value)
		{
			return new Percent { Value = value };
		}

		public static implicit operator Double(Percent value)
		{
			return value.Value;
		}

		#endregion

		#region Parse

		public static Percent Parse(String value)
		{
			return new Percent(value);
		}

		public static Boolean TryParse(String value, out Percent result)
		{
			try
			{
				result = new Percent(value);
				return true;
			}
			catch
			{
				result = new Percent();
				return false;
			}
		}

		#endregion

		#region To

		public new String ToString()
		{
			return (this.Value * 100.0).ToString() + "%";
		}

		#endregion
	}
}
