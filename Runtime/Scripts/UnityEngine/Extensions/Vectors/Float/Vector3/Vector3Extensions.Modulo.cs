namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		#region Fields
		
		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		
		#endregion

		#region Methods
		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>divisor</c>, component-wise.
		/// </remarks>
		/// <seealso cref="Remainder"/>
		/// <example>
		/// See <see cref ="FloatExtensions.Modulo"/>
		/// </example>
		public static Vector3 Modulo(this Vector3 dividend, Vector3 divisor)
		{
			return new Vector3(dividend.x.Modulo(divisor.x), dividend.y.Modulo(divisor.y), dividend.z.Modulo(divisor.z));
		}

		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>dividend</c>, component-wise.
		/// </remarks>
		/// <seealso cref="Modulo"/>
		/// <example>
		/// See <see cref ="FloatExtensions.Remainder"/>
		/// </example>
		public static Vector3 Remainder(this Vector3 dividend, Vector3 divisor)
		{
			return new Vector3(dividend.x % divisor.x, dividend.y % divisor.y, dividend.z % divisor.z);
		}
		#endregion
	}
}