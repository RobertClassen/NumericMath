namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		/// <summary>
		/// Returns the larger of two specified numbers.
		/// </summary>
		/// <remarks>
		/// @see https://docs.microsoft.com/dotnet/api/system.math.max
		/// </remarks>
		/// <seealso cref="Min"/>
		public static int Max(this int value, int other)
		{
			return value >= other ? value : other;
		}
	}
}