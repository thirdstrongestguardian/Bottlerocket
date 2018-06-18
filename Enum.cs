using System;
using System.Linq;
using System.Reflection;

namespace MoonStorm
{
	public class EnumModelAttribute
	: Attribute
	{
		public String Description { get; set; } = null;
		public String Name { get; set; } = null;
		public Int32 Position { get; set; } = 0;
		public String Value { get; set; } = null;
	}

	public static class EnumExtensions
	{
		public static String GetDescription(this Enum e)
		{
			if (e == null)
				return null;

			MemberInfo[] memberInfo = e.GetType().GetMember(e.ToString());
			if (memberInfo.Length == 0)
				return null;

			EnumModelAttribute attr = memberInfo[0].GetCustomAttributes(false).OfType<EnumModelAttribute>().FirstOrDefault();
			if (attr != null && attr.Name != null)
			{
				return attr.Description;
			}

			return null;
		}

		public static String GetName(this Enum e)
		{
			if (e == null)
				return null;

			MemberInfo[] memberInfo = e.GetType().GetMember(e.ToString());
			if (memberInfo.Length == 0)
				return null;

			EnumModelAttribute attr = memberInfo[0].GetCustomAttributes(false).OfType<EnumModelAttribute>().FirstOrDefault();
			if (attr != null && attr.Name != null)
			{
				return attr.Name;
			}

			return e.ToString();
		}

		public static Int32 GetPosition(this Enum e)
		{
			if (e == null)
				return -1;

			MemberInfo[] memberInfo = e.GetType().GetMember(e.ToString());
			if (memberInfo.Length == 0)
				return -1;

			EnumModelAttribute attr = memberInfo[0].GetCustomAttributes(false).OfType<EnumModelAttribute>().FirstOrDefault();
			if (attr != null && attr.Name != null)
			{
				return attr.Position;
			}

			return -1;
		}

		public static String GetValue(this Enum e)
		{
			if (e == null)
				return null;

			MemberInfo[] memberInfo = e.GetType().GetMember(e.ToString());
			if (memberInfo.Length == 0)
				return null;

			EnumModelAttribute attr = memberInfo[0].GetCustomAttributes(false).OfType<EnumModelAttribute>().FirstOrDefault();
			if (attr != null && attr.Value != null)
			{
				return attr.Value;
			}

			return Convert.ToInt32(e).ToString();
		}
	}
}
