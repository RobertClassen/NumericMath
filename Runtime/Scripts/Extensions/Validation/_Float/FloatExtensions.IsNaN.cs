namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static bool IsNaN(this float value)
		{
			return float.IsNaN(value);
		}
	}
}