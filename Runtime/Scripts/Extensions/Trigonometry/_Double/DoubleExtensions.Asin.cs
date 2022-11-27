namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		/// <summary>
		/// Returns the angle whose sine is the number.
		/// </summary>
		/// <remarks>
		/// @see https://docs.microsoft.com/en-us/dotnet/api/system.math.asin  
		/// @see https://docs.unity3d.com/ScriptReference/Mathf.Asin.html
		/// </remarks>
		/// <param name="sin">The sine value to convert to an angle.</param>
		/// <param name="toDegrees">If set to <c>false</c> the <c>angle</c> is returned in <c>radians</c>, else in <c>degrees</c>.</param>
		public static double Asin(this double sin, bool toDegrees = Angle.IsDegreesDefault)
		{
			return Math.Asin(sin).ToDegrees(toDegrees);
		}
	}
}