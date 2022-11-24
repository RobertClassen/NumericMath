namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		/// <summary>
		/// Returns the absolute value of the number.
		/// </summary>
		public static double Abs(this double value)
		{
			return Math.Abs(value);
		}
	}
}