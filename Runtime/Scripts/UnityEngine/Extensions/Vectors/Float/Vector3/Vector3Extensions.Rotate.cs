namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Rotates the point in a counter-clockwise direction around the <c>axis</c> 
		/// (looking along the <c>axis</c>).
		/// </summary>
		/// <remarks>
		/// If possible use one of the other <see cref ="Rotate"/> methods for improved performance.
		/// </remarks>
		public static Vector3 Rotate(this Vector3 point, float degrees, Vector3 axis)
		{
			if(!axis.IsNormalized())
			{
				axis.Normalize();
			}
			float radians = degrees * Mathf.Deg2Rad;
			float sin = Mathf.Sin(radians);
			float cos = Mathf.Cos(radians);
			float cosX = (Float.One - cos) * axis.x;
			float cosY = (Float.One - cos) * axis.y;
			float cosZ = (Float.One - cos) * axis.z;
			float sinX = sin * axis.x;
			float sinY = sin * axis.y;
			float sinZ = sin * axis.z;
			return new Vector3(
				point.x * (cosX * axis.x + cos) +
				point.y * (cosX * axis.y - sinZ) +
				point.z * (cosX * axis.z + sinY), 
				point.x * (cosY * axis.x + sinZ) +
				point.y * (cosY * axis.y + cos) +
				point.z * (cosY * axis.z - sinX), 
				point.x * (cosZ * axis.x - sinY) +
				point.y * (cosZ * axis.y + sinX) +
				point.z * (cosZ * axis.z + cos));
		}

		/// <summary>
		/// Rotates the point in a counter-clockwise direction around the <c>axis</c> 
		/// (looking along the <c>axis</c>), around the <c>center</c>.
		/// </summary>
		/// <remarks>
		/// If possible use one of the other <see cref ="Rotate"/> methods for improved performance.
		/// </remarks>
		public static Vector3 Rotate(this Vector3 point, float degrees, Vector3 axis, Vector3 center)
		{
			return (point - center).Rotate(degrees, axis) + center;
		}

		/// <summary>
		/// Rotates the point by the rotation described by the <c>quaternion</c>.
		/// </summary>
		public static Vector3 Rotate(this Vector3 point, Quaternion quaternion)
		{
			return quaternion * point;
		}

		/// <summary>
		/// Rotates the point by the rotation described by the <c>quaternion</c> around the <c>center</c>.
		/// </summary>
		public static Vector3 Rotate(this Vector3 point, Quaternion quaternion, Vector3 center)
		{
			return (point - center).Rotate(quaternion) + center;
		}
	}
}