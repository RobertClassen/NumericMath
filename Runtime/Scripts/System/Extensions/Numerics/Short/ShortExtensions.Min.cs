namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		/// <summary>
		/// Returns the smaller of two specified numbers.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.min
		/// </remarks>
		/// <seealso cref="Max"/>
		public static short Min(this short value, short other)
		{
			return Math.Min(value, other);
		}
	}
}