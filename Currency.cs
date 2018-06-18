using System;

namespace MoonStorm
{
    public class Currency
    {
        // Declaration

        #region Properties

        public Decimal Value = 0;

        #endregion

        #region Constructors

        public Currency()
        {

        }

        public Currency(Decimal value)
        {
            this.Value = value;
        }

        public Currency(String value)
        {
            this.Value = Convert.ToDecimal(value.Replace("$", ""));
        }

        #endregion 

        // Implementation

        #region Equals

        public Boolean Equals(Currency currency)
        {
            return this.Value == currency.Value;
        }

        #endregion 

        #region Operators

        public static implicit operator Currency(Decimal value)
		{
			return new Currency(value);
		}

		public static implicit operator Decimal(Currency value)
		{
			return value.Value;
		}

        #endregion

        #region Parse

        public static Currency Parse(String value)
        {
            return new Currency(value);
        }

        public static Boolean TryParse(String value, out Currency result)
        {
            try
            {
                result = new Currency(value);
                return true;
            }
            catch
            {
                result = new Currency();
                return false;
            }
        }

        #endregion

        #region To

        public new String ToString()
        {
            return this.Value.ToString("$0.00");
        }

        #endregion To
    }
}
