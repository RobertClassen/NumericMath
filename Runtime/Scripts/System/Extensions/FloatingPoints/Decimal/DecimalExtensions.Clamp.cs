namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DecimalExtensions
	{
		public static decimal Clamp(this decimal value, decimal min, decimal max)
		{
			return value <= min ? min : value >= max ? max : value;
		}

		public static decimal Clamp01(this decimal value, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled ? value.Clamp(Decimal.Zero, Decimal.One) : value;
		}
	}
}