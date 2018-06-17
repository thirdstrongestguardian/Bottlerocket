using System;

namespace BottleRocket
{
	public static class StringExtensions
	{
		public static Boolean IsInteger(this String instance)
		{
			if (instance == null)
				return false;

			Int32 value = 0;
			if (Int32.TryParse(instance, out value))
				return true;

			return false;
		}

		public static Boolean IsNumber(this String instance)
		{
			if (instance == null)
				return false;

			Double value = 0;
			if (Double.TryParse(instance, out value))
				return true;

			return false;
		}
	}
}
