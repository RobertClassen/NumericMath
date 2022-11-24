namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		/// <summary>
		/// Returns the absolute value of the number.
		/// </summary>
		public static int Abs(this int value)
		{
			return Math.Abs(value);
		}
	}
}