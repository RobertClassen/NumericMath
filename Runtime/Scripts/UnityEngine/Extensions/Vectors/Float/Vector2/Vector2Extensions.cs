namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		public static Vector2 Abs(this Vector2 vector)
		{
			return new Vector2(vector.x.Abs(), vector.y.Abs());
		}

		/// <remarks>
		/// Returns correct results both for positive and negative values.
		/// </remarks>
		/// <seealso cref="Remainder"/>
		/// <example>
		/// See <see cref ="FloatExtensions.Modulo"/>
		/// </example>
		public static Vector2 Modulo(this Vector2 dividend, Vector2 divisor)
		{
			return new Vector2(dividend.x.Modulo(divisor.x), dividend.y.Modulo(divisor.y));
		}

		/// <remarks>
		/// Works for positive values but may return incorrect results for negative values.
		/// </remarks>
		/// <seealso cref="Modulo"/>
		/// <example>
		/// See <see cref ="FloatExtensions.Remainder"/>
		/// </example>
		public static Vector2 Remainder(this Vector2 dividend, Vector2 divisor)
		{
			return new Vector2(dividend.x % divisor.x, dividend.y % divisor.y);
		}

		public static Vector2 Sign(this Vector2 vector)
		{
			return new Vector2(vector.x.Sign(), vector.y.Sign());
		}
		#endregion
	}
}