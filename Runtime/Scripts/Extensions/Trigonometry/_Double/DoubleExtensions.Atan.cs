namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		/// <summary>
		/// Returns the angle whose tangent is the number.
		/// </summary>
		/// <remarks>
		/// @see https://docs.microsoft.com/en-us/dotnet/api/system.math.atan  
		/// @see https://docs.unity3d.com/ScriptReference/Mathf.Atan.html
		/// </remarks>
		/// <param name="tan">The tangent value to convert to an angle.</param>
		/// <param name="toDegrees">If set to <c>false</c> the <c>angle</c> is returned in <c>radians</c>, else in <c>degrees</c>.</param>
		public static double Atan(this double tan, bool toDegrees = Angle.IsDegreesDefault)
		{
			return Math.Atan(tan).ToDegrees(toDegrees);
		}
	}
}