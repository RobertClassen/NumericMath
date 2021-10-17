namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		/// <summary>
		/// Returns <c>-1L</c>, <c>0L</c>, or <c>1L</c> to indicate the <c>sign</c> of the <c>value</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.sign
		/// </remarks>
		public static long Sign(this long value)
		{
			return (long)Math.Sign(value);
		}
	}
}