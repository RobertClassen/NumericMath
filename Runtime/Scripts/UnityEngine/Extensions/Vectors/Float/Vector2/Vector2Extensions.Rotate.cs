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
		/// <summary>
		/// Returns the 2D vector perpendicular to this 2D vector.
		/// </summary>
		/// <remarks>
		/// The result is always rotated 90° in a counter-clockwise direction 
		/// for a 2D coordinate system where the positive Y axis goes up.
		/// 
		/// See https://docs.unity3d.com/ScriptReference/Vector2.Perpendicular.html
		/// </remarks>
		[Obsolete("Use 'Rotate90' instead.")]
		public static Vector2 Perpendicular(this Vector2 vector)
		{
			return Vector2.Perpendicular(vector);
		}

		/// <summary>
		/// Rotate the vector in a counter-clockwise direction, 
		/// for a 2D coordinate system where the positive Y axis goes up.
		/// </summary>
		public static Vector2 Rotate(this Vector2 point, float degrees)
		{
			float radians = degrees * Mathf.Deg2Rad;
			float sin = Mathf.Sin(radians);
			float cos = Mathf.Cos(radians);
			return new Vector2(
				point.x * cos - point.y * sin, 
				point.x * sin + point.y * cos);
		}

		/// <summary>
		/// Rotate the vector in a counter-clockwise direction around the <c>center</c>, 
		/// for a 2D coordinate system where the positive Y axis goes up.
		/// </summary>
		public static Vector2 Rotate(this Vector2 point, float degrees, Vector2 center)
		{
			return (point - center).Rotate(degrees) + center;
		}

		/// <summary>
		/// Rotate the vector in a counter-clockwise direction, 
		/// for a 2D coordinate system where the positive Y axis goes up.
		/// </summary>
		public static Vector2 Rotate90(this Vector2 point)
		{
			return new Vector2(-point.y, point.x);
		}

		/// <summary>
		/// Rotate the vector in a counter-clockwise direction around the <c>center</c>, 
		/// for a 2D coordinate system where the positive Y axis goes up.
		/// </summary>
		public static Vector2 Rotate90(this Vector2 point, Vector2 center)
		{
			return (point - center).Rotate90() + center;
		}

		/// <summary>
		/// Rotate the vector in a counter-clockwise direction, 
		/// for a 2D coordinate system where the positive Y axis goes up.
		/// </summary>
		public static Vector2 Rotate180(this Vector2 point)
		{
			return new Vector2(-point.x, -point.y);
		}

		/// <summary>
		/// Rotate the vector in a counter-clockwise direction around the <c>center</c>, 
		/// for a 2D coordinate system where the positive Y axis goes up.
		/// </summary>
		public static Vector2 Rotate180(this Vector2 point, Vector2 center)
		{
			return (point - center).Rotate180() + center;
		}

		/// <summary>
		/// Rotate the vector in a counter-clockwise direction, 
		/// for a 2D coordinate system where the positive Y axis goes up.
		/// </summary>
		public static Vector2 Rotate270(this Vector2 point)
		{
			return new Vector2(point.y, -point.x);
		}

		/// <summary>
		/// Rotate the vector in a counter-clockwise direction around the <c>center</c>, 
		/// for a 2D coordinate system where the positive Y axis goes up.
		/// </summary>
		public static Vector2 Rotate270(this Vector2 point, Vector2 center)
		{
			return (point - center).Rotate270() + center;
		}
		#endregion
	}
}