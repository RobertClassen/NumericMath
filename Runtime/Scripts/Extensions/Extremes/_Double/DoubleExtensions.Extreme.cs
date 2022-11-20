namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		/// <summary>
		/// Returns the extreme value with the same sign.
		/// </summary>
		public static double Extreme(this double value)
		{
			return value < Double.Zero ? double.MinValue : double.MaxValue;
		}
	}
}