namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		/// <summary>
		/// Returns <c>-1d</c>, <c>0d</c>, or <c>1d</c> to indicate the <c>sign</c> of the <c>value</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.sign
		/// </remarks>
		public static double Sign(this double value)
		{
			return (double)Math.Sign(value);
		}
	}
}