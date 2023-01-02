namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Debug
	{
		private const string SeparatorDefault = ", ";
		private static readonly string[] Tabs = { "\t\t", "\t" };
		private const int LengthPerTab = 8;

		public static void Log(string value, string name = null)
		{
			UnityEngine.Debug.Log(string.IsNullOrEmpty(name)
				? value
				: string.Format("{0}:{1}{2}", name, Tabs[(name.Length / LengthPerTab).Clamp(Tabs)], value));
		}

		public static void Log(object value, string name = null)
		{
			Log(value.ToString(), name);
		}

		public static void Log<T>(IList<T> iList, string name = null)
		{
			Log(string.Join(SeparatorDefault, iList), name);
		}

		public static void Log<T>(IEnumerable<T> iEnumerable, string name = null)
		{
			Log(string.Join(SeparatorDefault, iEnumerable), name);
		}
	}
}