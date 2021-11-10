namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DecimalExtensions
	{
		public static decimal Atan(this decimal tan, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (decimal)Math.Atan((double)tan).ToDegrees(isDegrees);
		}

		public static decimal Atan2(this decimal y, decimal x, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (decimal)Math.Atan2((double)y, (double)x).ToDegrees(isDegrees);
		}

		public static decimal Tan(this decimal angle, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (decimal)Math.Tan((double)angle.ToRadians(isDegrees));
		}

		public static decimal Tanh(this decimal hyperbolicAngle)
		{
			return (decimal)Math.Tanh((double)hyperbolicAngle);
		}
	}
}