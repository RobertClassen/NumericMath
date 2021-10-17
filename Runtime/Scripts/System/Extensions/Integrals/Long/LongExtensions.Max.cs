namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		/// <summary>
		/// Returns the larger of two specified numbers.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.max
		/// </remarks>
		/// <seealso cref="Min"/>
		public static long Max(this long value, long other)
		{
			return Math.Max(value, other);
		}
	}
}