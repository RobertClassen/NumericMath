namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using Random = UnityEngine.Random;

	public static partial class Vector3Extensions
	{
		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
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

		public static Vector3 Rotate(this Vector3 point, Quaternion quaternion)
		{
			return quaternion * point;
		}

		public static Vector3 Rotate(this Vector3 point, float degrees, Vector3 axis, Vector3 center)
		{
			return (point - center).Rotate(degrees, axis) + center;
		}

		public static Vector3 Rotate(this Vector3 point, Quaternion quaternion, Vector3 center)
		{
			return (point - center).Rotate(quaternion) + center;
		}

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

		public static Vector3 RotateX(this Vector3 point, float degrees, Vector3 center)
		{
			return (point - center).RotateX(degrees) + center;
		}

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

		public static Vector3 RotateY(this Vector3 point, float degrees, Vector3 center)
		{
			return (point - center).RotateY(degrees) + center;
		}

		public static Vector3 RotateZ(this Vector3 point, float degrees)
		{
			float radians = degrees * Mathf.Deg2Rad;
			float sin = Mathf.Sin(radians);
			float cos = Mathf.Cos(radians);
			return new Vector3(
				point.x * cos - point.y * sin, 
				point.x * sin - point.y * cos, 
				point.z);
		}

		public static Vector3 RotateZ(this Vector3 point, float degrees, Vector3 center)
		{
			return (point - center).RotateZ(degrees) + center;
		}
		#endregion
	}
}