namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		/// <summary>
		/// Returns the sum of both numbers.
		/// </summary>
		public static int Add(this int value, int addend, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? value + addend : value;
		}
	}
}