namespace WellDefinedTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class BoolExtensions
	{
		#region Fields
		
		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		
		#endregion

		#region Methods
		public static int ToInt(this bool value)
		{
			return value ? Int.One : Int.Zero;
		}

		public static string ToBinaryString(this bool value)
		{
			return value.ToInt().ToString();
		}

		public static string ToInvariantString(this bool value)
		{
			return value.ToString(Culture.Invariant);
		}
		#endregion
	}
}