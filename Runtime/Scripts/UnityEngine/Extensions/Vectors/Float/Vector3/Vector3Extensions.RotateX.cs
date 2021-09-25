namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Rotates the point in a counter-clockwise direction around the <c>X axis</c> 
		/// (looking along the <c>X axis</c>).
		/// </summary>
		public static Vector3 RotateX(this Vector3 point, float degrees)
		{
			float radians = degrees * Mathf.Deg2Rad;
			float sin = Mathf.Sin(radians);
			float cos = Mathf.Cos(radians);
			return new Vector3(
				point.x, 
				point.y * cos - point.z * sin, 
				point.y * sin + point.z * cos);
		}

		/// <summary>
		/// Rotates the point in a counter-clockwise direction around the <c>X axis</c> 
		/// (looking along the <c>X axis</c>), around the <c>center</c>.
		/// </summary>
		public static Vector3 RotateX(this Vector3 point, float degrees, Vector3 center)
		{
			return (point - center).RotateX(degrees) + center;
		}

		/// <summary>
		/// Rotates the point by 90° in a counter-clockwise direction around the <c>X axis</c> 
		/// (looking along the <c>X axis</c>).
		/// </summary>
		public static Vector3 RotateX90(this Vector3 point)
		{
			return new Vector3(point.x, -point.z, point.y);
		}

		/// <summary>
		/// Rotates the point by 90° in a counter-clockwise direction around the <c>X axis</c> 
		/// (looking along the <c>X axis</c>), around the <c>center</c>.
		/// </summary>
		public static Vector3 RotateX90(this Vector3 point, Vector3 center)
		{
			return (point - center).RotateX90() + center;
		}

		/// <summary>
		/// Rotates the point by 180° in a counter-clockwise direction around the <c>X axis</c> 
		/// (looking along the <c>X axis</c>).
		/// </summary>
		public static Vector3 RotateX180(this Vector3 point)
		{
			return new Vector3(point.x, -point.y, -point.z);
		}

		/// <summary>
		/// Rotates the point by 180° in a counter-clockwise direction around the <c>X axis</c> 
		/// (looking along the <c>X axis</c>), around the <c>center</c>.
		/// </summary>
		public static Vector3 RotateX180(this Vector3 point, Vector3 center)
		{
			return (point - center).RotateX180() + center;
		}

		/// <summary>
		/// Rotates the point by 270° in a counter-clockwise direction around the <c>X axis</c> 
		/// (looking along the <c>X axis</c>).
		/// </summary>
		public static Vector3 RotateX270(this Vector3 point)
		{
			return new Vector3(point.x, point.z, -point.y);
		}

		/// <summary>
		/// Rotates the point by 270° in a counter-clockwise direction around the <c>X axis</c> 
		/// (looking along the <c>X axis</c>), around the <c>center</c>.
		/// </summary>
		public static Vector3 RotateX270(this Vector3 point, Vector3 center)
		{
			return (point - center).RotateX270() + center;
		}
	}
}