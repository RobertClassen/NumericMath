namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		/// <summary>
		/// Returns <c>-1M</c>, <c>0M</c>, or <c>1M</c> to indicate the <c>sign</c> of the <c>value</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.sign
		/// </remarks>
		public static decimal Sign(this decimal value)
		{
			return (decimal)Math.Sign(value);
		}
	}
}