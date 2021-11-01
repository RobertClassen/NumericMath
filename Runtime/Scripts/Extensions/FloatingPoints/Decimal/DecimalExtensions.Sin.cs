namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DecimalExtensions
	{
		public static decimal Asin(this decimal value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (decimal)Math.Asin((double)value.ToRadians(isDegrees));
		}

		public static decimal Sin(this decimal value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (decimal)Math.Sin((double)value.ToRadians(isDegrees));
		}

		public static decimal Sinh(this decimal value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (decimal)Math.Sinh((double)value.ToRadians(isDegrees));
		}
	}
}