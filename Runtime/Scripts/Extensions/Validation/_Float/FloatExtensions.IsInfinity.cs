namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static bool IsInfinity(this float value)
		{
			return float.IsInfinity(value);
		}

		public static bool IsNegativeInfinity(this float value)
		{
			return float.IsNegativeInfinity(value);
		}

		public static bool IsPositiveInfinity(this float value)
		{
			return float.IsPositiveInfinity(value);
		}
	}
}