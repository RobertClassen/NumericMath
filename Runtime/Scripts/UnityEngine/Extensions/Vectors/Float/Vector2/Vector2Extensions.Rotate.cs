namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		/// <summary>
		/// Rotates the point in a counter-clockwise direction around the <c>Z axis</c>.
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
		/// Rotates the point in a counter-clockwise direction around the <c>Z axis</c>, around the <c>center</c>.
		/// </summary>
		public static Vector2 Rotate(this Vector2 point, float degrees, Vector2 center)
		{
			return (point - center).Rotate(degrees) + center;
		}

		/// <summary>
		/// Rotates the point by 90° in a counter-clockwise direction around the <c>Z axis</c>.
		/// </summary>
		public static Vector2 Rotate90(this Vector2 point)
		{
			return new Vector2(-point.y, point.x);
		}

		/// <summary>
		/// Rotates the point by 90° in a counter-clockwise direction around the <c>Z axis</c>, around the <c>center</c>.
		/// </summary>
		public static Vector2 Rotate90(this Vector2 point, Vector2 center)
		{
			return (point - center).Rotate90() + center;
		}

		/// <summary>
		/// Rotates the point by 180° in a counter-clockwise direction around the <c>Z axis</c>.
		/// </summary>
		public static Vector2 Rotate180(this Vector2 point)
		{
			return new Vector2(-point.x, -point.y);
		}

		/// <summary>
		/// Rotates the point by 180° in a counter-clockwise direction around the <c>Z axis</c>, around the <c>center</c>.
		/// </summary>
		public static Vector2 Rotate180(this Vector2 point, Vector2 center)
		{
			return (point - center).Rotate180() + center;
		}

		/// <summary>
		/// Rotates the point by 270° in a counter-clockwise direction around the <c>Z axis</c>.
		/// </summary>
		public static Vector2 Rotate270(this Vector2 point)
		{
			return new Vector2(point.y, -point.x);
		}

		/// <summary>
		/// Rotates the point by 270° in a counter-clockwise direction around the <c>Z axis</c>, around the <c>center</c>.
		/// </summary>
		public static Vector2 Rotate270(this Vector2 point, Vector2 center)
		{
			return (point - center).Rotate270() + center;
		}
	}
}