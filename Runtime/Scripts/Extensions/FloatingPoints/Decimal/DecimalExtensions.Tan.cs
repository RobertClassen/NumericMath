namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DecimalExtensions
	{
		public static decimal Atan(this decimal value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (decimal)Math.Atan((double)value.ToRadians(isDegrees));
		}

		public static decimal Atan2(this decimal y, decimal x, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (decimal)Math.Atan2((double)y, (double)x).ToDegrees(isDegrees);
		}

		public static decimal Tan(this decimal value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (decimal)Math.Tan((double)value.ToRadians(isDegrees));
		}

		public static decimal Tanh(this decimal value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (decimal)Math.Tanh((double)value.ToRadians(isDegrees));
		}
	}
}