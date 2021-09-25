namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Rotates the point in a counter-clockwise direction around the <c>Y axis</c> 
		/// (looking along the <c>Y axis</c>).
		/// </summary>
		public static Vector3 RotateY(this Vector3 point, float degrees)
		{
			float radians = degrees * Mathf.Deg2Rad;
			float sin = Mathf.Sin(radians);
			float cos = Mathf.Cos(radians);
			return new Vector3(
				point.x * cos + point.z * sin, 
				point.y, 
				point.x * -sin + point.z * cos);
		}

		/// <summary>
		/// Rotates the point in a counter-clockwise direction around the <c>Y axis</c> 
		/// (looking along the <c>Y axis</c>), around the <c>center</c>.
		/// </summary>
		public static Vector3 RotateY(this Vector3 point, float degrees, Vector3 center)
		{
			return (point - center).RotateY(degrees) + center;
		}

		/// <summary>
		/// Rotates the point by 90° in a counter-clockwise direction around the <c>Y axis</c> 
		/// (looking along the <c>Y axis</c>).
		/// </summary>
		public static Vector3 RotateY90(this Vector3 point)
		{
			return new Vector3(point.z, point.y, -point.x);
		}

		/// <summary>
		/// Rotates the point by 90° in a counter-clockwise direction around the <c>Y axis</c> 
		/// (looking along the <c>Y axis</c>), around the <c>center</c>.
		/// </summary>
		public static Vector3 RotateY90(this Vector3 point, Vector3 center)
		{
			return (point - center).RotateY90() + center;
		}

		/// <summary>
		/// Rotates the point by 180° in a counter-clockwise direction around the <c>Y axis</c> 
		/// (looking along the <c>Y axis</c>).
		/// </summary>
		public static Vector3 RotateY180(this Vector3 point)
		{
			return new Vector3(-point.x, point.y, -point.z);
		}

		/// <summary>
		/// Rotates the point by 180° in a counter-clockwise direction around the <c>Y axis</c> 
		/// (looking along the <c>Y axis</c>), around the <c>center</c>.
		/// </summary>
		public static Vector3 RotateY180(this Vector3 point, Vector3 center)
		{
			return (point - center).RotateY180() + center;
		}

		/// <summary>
		/// Rotates the point by 270° in a counter-clockwise direction around the <c>Y axis</c> 
		/// (looking along the <c>Y axis</c>).
		/// </summary>
		public static Vector3 RotateY270(this Vector3 point)
		{
			return new Vector3(-point.z, point.y, point.x);
		}

		/// <summary>
		/// Rotates the point by 270° in a counter-clockwise direction around the <c>Y axis</c> 
		/// (looking along the <c>Y axis</c>), around the <c>center</c>.
		/// </summary>
		public static Vector3 RotateY270(this Vector3 point, Vector3 center)
		{
			return (point - center).RotateY270() + center;
		}
	}
}