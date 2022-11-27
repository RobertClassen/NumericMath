namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		/// <summary>
		/// Returns the angle whose cosine is the number.
		/// </summary>
		/// <remarks>
		/// @see https://docs.microsoft.com/en-us/dotnet/api/system.math.acos  
		/// @see https://docs.unity3d.com/ScriptReference/Mathf.Acos.html
		/// </remarks>
		/// <param name="cos">The cosine value to convert to an angle.</param>
		/// <param name="toDegrees">If set to <c>false</c> the <c>angle</c> is returned in <c>radians</c>, else in <c>degrees</c>.</param>
		public static double Acos(this double cos, bool toDegrees = Angle.IsDegreesDefault)
		{
			return Math.Acos(cos).ToDegrees(toDegrees);
		}
	}
}