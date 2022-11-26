namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		/// <summary>
		/// Returns the larger of two specified numbers.
		/// </summary>
		/// <remarks>
		/// @see https://docs.microsoft.com/dotnet/api/system.math.max
		/// </remarks>
		/// <seealso cref="Min"/>
		public static float Max(this float value, float other)
		{
			return value >= other ? value : other;
		}
	}
}