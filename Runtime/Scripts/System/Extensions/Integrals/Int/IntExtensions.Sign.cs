namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		/// <summary>
		/// Returns <c>-1</c>, <c>0</c>, or <c>1</c> to indicate the <c>sign</c> of the <c>value</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.sign
		/// </remarks>
		public static int Sign(this int value)
		{
			return Math.Sign(value);
		}
	}
}