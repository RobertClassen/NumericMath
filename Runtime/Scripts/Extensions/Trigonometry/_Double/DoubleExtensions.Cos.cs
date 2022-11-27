namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		/// <summary>
		/// Returns the cosine of the angle.
		/// </summary>
		/// <remarks>
		/// @see https://docs.microsoft.com/en-us/dotnet/api/system.math.cos  
		/// @see https://docs.unity3d.com/ScriptReference/Mathf.Cos.html
		/// </remarks>
		/// <param name="angle">The angle to convert to a cosine value.</param>
		/// <param name="fromDegrees">If set to <c>false</c> the <c>angle</c> is assumed to be in <c>radians</c>, else in <c>degrees</c>.</param>
		public static double Cos(this double angle, bool fromDegrees = Angle.IsDegreesDefault)
		{
			return Math.Cos(angle.ToRadians(fromDegrees));
		}
	}
}