namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		#region Constants
		private const double delta = 1E-05;
		#endregion

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

		/// <summary>
		/// Returns the signed or unsigned acute angle between the two vectors, in degrees.
		/// </summary>
		/// <remarks>
		/// This means the smaller of the two possible angles between the two vectors is used.
		/// 
		/// See https://docs.unity3d.com/ScriptReference/Vector2.SignedAngle.html  
		/// See https://docs.unity3d.com/ScriptReference/Vector2.Angle.html
		/// </remarks>
		/// <param name="isSigned">
		/// If set to <c>true</c> the returned angle is never greater than 180 degrees or smaller than -180 degrees.<br/>
		/// If set to <c>false</c> the returned angle is never greater than 180 degrees.<br/>
		/// </param>
		public static float Angle(this Vector2 from, Vector2 to, bool isSigned = Core.Numeric.IsAngleSignedDefault)
		{
			return isSigned ? Vector2.SignedAngle(from, to) : Vector2.Angle(from, to);
		}

		/// <summary>
		/// Checks if the magnitude of the <c>vector</c> equals <c>1</c>.
		/// </summary>
		public static bool IsNormalized(this Vector2 vector)
		{
			return Math.Abs(vector.sqrMagnitude - Float.One) < delta;
		}

		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>divisor</c>, component-wise.
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
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>dividend</c>, component-wise.
		/// </remarks>
		/// <seealso cref="Modulo"/>
		/// <example>
		/// See <see cref ="FloatExtensions.Remainder"/>
		/// </example>
		public static Vector2 Remainder(this Vector2 dividend, Vector2 divisor)
		{
			return new Vector2(dividend.x % divisor.x, dividend.y % divisor.y);
		}

		/// <summary>
		/// Performs a component-wise `Sign` operation.
		/// </summary>
		public static Vector2 Sign(this Vector2 vector)
		{
			return new Vector2(vector.x.Sign(), vector.y.Sign());
		}
		#endregion
	}
}