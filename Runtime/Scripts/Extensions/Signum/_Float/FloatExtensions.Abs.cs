namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		/// <summary>
		/// Returns the absolute value of the number.
		/// </summary>
		public static float Abs(this float value)
		{
			return Math.Abs(value);
		}
	}
}