using System;

namespace BottleRocket
{
	public enum State
	{
		[EnumModel(Name = "Alaska", Value = "AK")]
		AK = 1,

		[EnumModel(Name = "Alabama", Value = "AL")]
		AL = 2,

		[EnumModel(Name = "Arkansas", Value = "AR")]
		AR = 3,

		[EnumModel(Name = "Arizona", Value = "AZ")]
		AZ = 4,

		[EnumModel(Name = "California", Value = "CA")]
		CA = 5,

		[EnumModel(Name = "Colorado", Value = "CO")]
		CO = 6,

		[EnumModel(Name = "Connecticut", Value = "CT")]
		CT = 7,

		[EnumModel(Name = "District of Columbia", Value = "DC")]
		DC = 8,

		[EnumModel(Name = "Delaware", Value = "DE")]
		DE = 9,

		[EnumModel(Name = "Florida", Value = "FL")]
		FL = 10,

		[EnumModel(Name = "Georgia", Value = "GA")]
		GA = 11,

		[EnumModel(Name = "Hawaii", Value = "HI")]
		HI = 12,

		[EnumModel(Name = "Iowa", Value = "IA")]
		IA = 13,

		[EnumModel(Name = "Idaho", Value = "ID")]
		ID = 14,

		[EnumModel(Name = "Illinois", Value = "IL")]
		IL = 15,

		[EnumModel(Name = "Indiana", Value = "IN")]
		IN = 16,

		[EnumModel(Name = "Kansas", Value = "KS")]
		KS = 17,

		[EnumModel(Name = "Kentucky", Value = "KT")]
		KT = 18,

		[EnumModel(Name = "Louisiana", Value = "LA")]
		LA = 19,

		[EnumModel(Name = "Massachusetts", Value = "MA")]
		MA = 20,

		[EnumModel(Name = "Maryland", Value = "MD")]
		MD = 21,

		[EnumModel(Name = "Maine", Value = "ME")]
		ME = 22,

		[EnumModel(Name = "Michigan", Value = "MI")]
		MI = 23,

		[EnumModel(Name = "Minnesota", Value = "MN")]
		MN = 24,

		[EnumModel(Name = "Missouri", Value = "MO")]
		MO = 25,

		[EnumModel(Name = "Mississippi", Value = "MS")]
		MS = 26,

		[EnumModel(Name = "Montana", Value = "MT")]
		MT = 27,

		[EnumModel(Name = "North Carolina", Value = "NC")]
		NC = 28,

		[EnumModel(Name = "North Dakota", Value = "ND")]
		ND = 29,

		[EnumModel(Name = "Nebraska", Value = "NE")]
		NE = 30,

		[EnumModel(Name = "New Hampshire", Value = "NH")]
		NH = 31,

		[EnumModel(Name = "New Jersey", Value = "NJ")]
		NJ = 32,

		[EnumModel(Name = "New Mexico", Value = "NM")]
		NM = 33,

		[EnumModel(Name = "Nevada", Value = "NV")]
		NV = 34,

		[EnumModel(Name = "New York", Value = "NY")]
		NY = 35,

		[EnumModel(Name = "Ohio", Value = "OH")]
		OH = 36,

		[EnumModel(Name = "Oklahoma", Value = "OK")]
		OK = 37,

		[EnumModel(Name = "Oregon", Value = "OR")]
		OR = 38,

		[EnumModel(Name = "Pennsylvania", Value = "PA")]
		PA = 39,

		[EnumModel(Name = "Puerto Rico", Value = "PR")]
		PR = 40,

		[EnumModel(Name = "Rhode Island", Value = "RI")]
		RI = 41,

		[EnumModel(Name = "South Carolina", Value = "SC")]
		SC = 42,

		[EnumModel(Name = "South Dakota", Value = "SD")]
		SD = 43,

		[EnumModel(Name = "Tennessee", Value = "TN")]
		TN = 44,

		[EnumModel(Name = "Texas", Value = "TX")]
		TX = 45,

		[EnumModel(Name = "Utah", Value = "UT")]
		UT = 46,

		[EnumModel(Name = "Virginia", Value = "VA")]
		VA = 47,

		[EnumModel(Name = "Vermont", Value = "VT")]
		VT = 48,

		[EnumModel(Name = "Washington", Value = "WA")]
		WA = 49,

		[EnumModel(Name = "Wisconsin", Value = "WI")]
		WI = 50,

		[EnumModel(Name = "West Virginia", Value = "WV")]
		WV = 51,

		[EnumModel(Name = "Wyoming", Value = "WY")]
		WY = 52
	}

	public static class StateExtensions
	{
		public static String GetAbbreviation(this State state)
		{
			String abbreviation = state.GetValue();

			if (abbreviation == null || abbreviation.IsNumber())
				return null;

			return abbreviation;
		}
	}
}
