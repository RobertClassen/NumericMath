namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Debug
	{
		private const string SeparatorDefault = ", ";

		public static void Log<T>(IEnumerable<T> iEnumerable, string separator = SeparatorDefault)
		{
			UnityEngine.Debug.Log(string.Join(separator, iEnumerable));
		}
	}
}