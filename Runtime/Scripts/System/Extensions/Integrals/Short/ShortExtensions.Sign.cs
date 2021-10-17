namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		/// <summary>
		/// Returns <c>-1</c>, <c>0</c>, or <c>1</c> to indicate the <c>sign</c> of the <c>value</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.sign
		/// </remarks>
		public static short Sign(this short value)
		{
			return (short)Math.Sign(value);
		}
	}
}