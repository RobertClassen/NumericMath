namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DecimalExtensions
	{
		public static decimal Asin(this decimal sin, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (decimal)Math.Asin((double)sin.ToRadians(isDegrees));
		}

		public static decimal Sin(this decimal angle, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (decimal)Math.Sin((double)angle.ToRadians(isDegrees));
		}

		public static decimal Sinh(this decimal hyperbolicAngle)
		{
			return (decimal)Math.Sinh((double)hyperbolicAngle);
		}
	}
}