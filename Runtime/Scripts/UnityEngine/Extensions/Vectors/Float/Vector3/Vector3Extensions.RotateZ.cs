namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Rotates the point in a counter-clockwise direction around the <c>Z axis</c> 
		/// (looking along the <c>Z axis</c>).
		/// </summary>
		public static Vector3 RotateZ(this Vector3 point, float degrees)
		{
			float radians = degrees * Mathf.Deg2Rad;
			float sin = Mathf.Sin(radians);
			float cos = Mathf.Cos(radians);
			return new Vector3(
				point.x * cos - point.y * sin, 
				point.x * sin + point.y * cos, 
				point.z);
		}

		/// <summary>
		/// Rotates the point in a counter-clockwise direction around the <c>Z axis</c> 
		/// (looking along the <c>Z axis</c>), around the <c>center</c>.
		/// </summary>
		public static Vector3 RotateZ(this Vector3 point, float degrees, Vector3 center)
		{
			return (point - center).RotateZ(degrees) + center;
		}

		/// <summary>
		/// Rotates the point by 90° in a counter-clockwise direction around the <c>Z axis</c> 
		/// (looking along the <c>Z axis</c>).
		/// </summary>
		public static Vector3 RotateZ90(this Vector3 point)
		{
			return new Vector3(-point.y, point.x, point.z);
		}

		/// <summary>
		/// Rotates the point by 90° in a counter-clockwise direction around the <c>Z axis</c> 
		/// (looking along the <c>Z axis</c>), around the <c>center</c>.
		/// </summary>
		public static Vector3 RotateZ90(this Vector3 point, Vector3 center)
		{
			return (point - center).RotateZ90() + center;
		}

		/// <summary>
		/// Rotates the point by 180° in a counter-clockwise direction around the <c>Z axis</c> 
		/// (looking along the <c>Z axis</c>).
		/// </summary>
		public static Vector3 RotateZ180(this Vector3 point)
		{
			return new Vector3(-point.x, -point.y, point.z);
		}

		/// <summary>
		/// Rotates the point by 180° in a counter-clockwise direction around the <c>Z axis</c> 
		/// (looking along the <c>Z axis</c>), around the <c>center</c>.
		/// </summary>
		public static Vector3 RotateZ180(this Vector3 point, Vector3 center)
		{
			return (point - center).RotateZ180() + center;
		}

		/// <summary>
		/// Rotates the point by 270° in a counter-clockwise direction around the <c>Z axis</c> 
		/// (looking along the <c>Z axis</c>).
		/// </summary>
		public static Vector3 RotateZ270(this Vector3 point)
		{
			return new Vector3(point.y, -point.x, point.z);
		}

		/// <summary>
		/// Rotates the point by 270° in a counter-clockwise direction around the <c>Z axis</c> 
		/// (looking along the <c>Z axis</c>), around the <c>center</c>.
		/// </summary>
		public static Vector3 RotateZ270(this Vector3 point, Vector3 center)
		{
			return (point - center).RotateZ270() + center;
		}
	}
}