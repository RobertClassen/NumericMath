namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DecimalExtensions
	{
		public static decimal Acos(this decimal cos, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (decimal)Math.Acos((double)cos).ToDegrees(isDegrees);
		}

		public static decimal Cos(this decimal angle, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (decimal)Math.Cos((double)angle.ToRadians(isDegrees));
		}

		public static decimal Cosh(this decimal hyperbolicAngle)
		{
			return (decimal)Math.Cosh((double)hyperbolicAngle);
		}
	}
}