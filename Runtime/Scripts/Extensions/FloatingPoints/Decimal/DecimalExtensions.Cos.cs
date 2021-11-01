namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DecimalExtensions
	{
		public static decimal Acos(this decimal value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (decimal)Math.Acos((double)value.ToRadians(isDegrees));
		}

		public static decimal Cos(this decimal value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (decimal)Math.Cos((double)value.ToRadians(isDegrees));
		}

		public static decimal Cosh(this decimal value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (decimal)Math.Cosh((double)value.ToRadians(isDegrees));
		}
	}
}