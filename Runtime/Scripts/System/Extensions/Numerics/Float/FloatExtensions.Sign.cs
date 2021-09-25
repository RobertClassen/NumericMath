namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		/// <summary>
		/// Returns <c>-1f</c>, <c>0f</c>, or <c>1f</c> to indicate the <c>sign</c> of the <c>value</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.sign
		/// </remarks>
		public static float Sign(this float value)
		{
			return (float)Math.Sign(value);
		}
	}
}