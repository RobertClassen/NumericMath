namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static bool IsNaN(this double value)
		{
			return double.IsNaN(value);
		}
	}
}