namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		/// <summary>
		/// Returns the smaller of two specified numbers.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.min
		/// </remarks>
		/// <seealso cref="Max"/>
		public static long Min(this long value, long other)
		{
			return Math.Min(value, other);
		}
	}
}