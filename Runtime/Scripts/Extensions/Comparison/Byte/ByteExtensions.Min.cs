namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		/// <summary>
		/// Returns the smaller of two specified numbers.
		/// </summary>
		/// <remarks>
		/// @see https://docs.microsoft.com/dotnet/api/system.math.min
		/// </remarks>
		/// <seealso cref="Max"/>
		public static byte Min(this byte value, byte other)
		{
			return value <= other ? value : other;
		}
	}
}