namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Debug
	{
		private const string SeparatorDefault = ", ";

		public static void Log(string value)
		{
			UnityEngine.Debug.Log(value);
		}

		public static void Log(object value)
		{
			UnityEngine.Debug.Log(value);
		}

		public static void Log<T>(IList<T> iList, string separator = SeparatorDefault)
		{
			UnityEngine.Debug.Log(string.Join(separator, iList));
		}

		public static void Log<T>(IEnumerable<T> iEnumerable, string separator = SeparatorDefault)
		{
			UnityEngine.Debug.Log(string.Join(separator, iEnumerable));
		}
	}
}