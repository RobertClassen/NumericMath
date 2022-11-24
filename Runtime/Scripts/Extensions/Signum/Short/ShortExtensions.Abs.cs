namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		/// <summary>
		/// Returns the absolute value of the number.
		/// </summary>
		public static short Abs(this short value)
		{
			return Math.Abs(value);
		}
	}
}