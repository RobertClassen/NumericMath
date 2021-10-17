namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		/// <summary>
		/// Returns the larger of two specified numbers.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.max
		/// </remarks>
		/// <seealso cref="Min"/>
		public static decimal Max(this decimal value, decimal other)
		{
			return Math.Max(value, other);
		}
	}
}