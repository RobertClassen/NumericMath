namespace WellDefined
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using UnityEngine;
	using Random = UnityEngine.Random;

	public static class Vector3Extensions
	{
		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		public static Vector3 Abs(this Vector3 vector)
		{
			return new Vector3(vector.x.Abs(), vector.y.Abs(), vector.z.Abs());
		}

		public static Vector3 AddRandom(this Vector3 vector, Vector3 min, Vector3 max)
		{
			return new Vector3(vector.x + Random.Range(min.x, max.x), vector.y + Random.Range(min.y, max.y), vector.z + Random.Range(min.x, max.x));
		}

		public static Vector3 AddX(this Vector3 vector, float x)
		{
			return new Vector3(vector.x + x, vector.y, vector.z);
		}

		public static Vector3 AddY(this Vector3 vector, float y)
		{
			return new Vector3(vector.x, vector.y + y, vector.z);
		}

		public static Vector3 AddZ(this Vector3 vector, float z)
		{
			return new Vector3(vector.x, vector.y, vector.z + z);
		}

		public static Vector3 Ceil(this Vector3 vector)
		{
			return new Vector3(vector.x.Ceil(), vector.y.Ceil(), vector.z.Ceil());
		}

		public static Vector3Int CeilToInt(this Vector3 vector)
		{
			return new Vector3Int(vector.x.CeilToInt(), vector.y.CeilToInt(), vector.z.CeilToInt());
		}

		public static Vector3 Clamp01(this Vector3 vector, bool isClamped = Numeric.IsClampClampedDefault)
		{
			return isClamped ? vector.ClampXYZ(Vector3.zero, Vector3.one) : vector;
		}

		public static Vector3 ClampX(this Vector3 vector, float min, float max)
		{
			return new Vector3(vector.x.Clamp(min, max), vector.y, vector.z);
		}

		public static Vector3 ClampXY(this Vector3 vector, Vector3 min, Vector3 max)
		{
			return new Vector3(vector.x.Clamp(min.x, max.x), vector.y.Clamp(min.y, max.y), vector.z);
		}

		public static Vector3 ClampXY(this Vector3 vector, Rect rect)
		{
			return vector.ClampXY(rect.min, rect.max);
		}

		public static Vector3 ClampXYZ(this Vector3 vector, Vector3 min, Vector3 max)
		{
			return new Vector3(vector.x.Clamp(min.x, max.x), vector.y.Clamp(min.y, max.y), vector.z.Clamp(min.z, max.z));
		}

		public static Vector3 ClampXZ(this Vector3 vector, Vector3 min, Vector3 max)
		{
			return new Vector3(vector.x.Clamp(min.x, max.x), vector.y, vector.z.Clamp(min.z, max.z));
		}

		public static Vector3 ClampXZ(this Vector3 vector, Rect rect)
		{
			return vector.ClampXZ(rect.min, rect.max);
		}

		public static Vector3 ClampY(this Vector3 vector, float min, float max)
		{
			return new Vector3(vector.x, vector.y.Clamp(min, max), vector.z);
		}

		public static Vector3 ClampYZ(this Vector3 vector, Vector3 min, Vector3 max)
		{
			return new Vector3(vector.x, vector.y.Clamp(min.y, max.y), vector.z.Clamp(min.z, max.z));
		}

		public static Vector3 ClampYZ(this Vector3 vector, Rect rect)
		{
			return vector.ClampYZ(rect.min, rect.max);
		}

		public static Vector3 ClampZ(this Vector3 vector, float min, float max)
		{
			return new Vector3(vector.x, vector.y, vector.z.Clamp(min, max));
		}

		public static Vector3 Cross(this Vector3 a, Vector3 b)
		{
			return Vector3.Cross(a, b);
		}

		public static float Dot(this Vector3 a, Vector3 b)
		{
			return Vector3.Dot(a, b);
		}

		public static Vector3 Floor(this Vector3 vector)
		{
			return new Vector3(vector.x.Floor(), vector.y.Floor(), vector.z.Floor());
		}

		public static Vector3Int FloorToInt(this Vector3 vector)
		{
			return new Vector3Int(vector.x.FloorToInt(), vector.y.FloorToInt(), vector.z.FloorToInt());
		}

		public static bool IsNormalized(this Vector3 vector)
		{
			return Math.Abs(vector.sqrMagnitude - Float.One) < 1E-05;
		}

		public static Vector3 Modulo(this Vector3 dividend, Vector3 divisor)
		{
			return new Vector3(dividend.x.Modulo(divisor.x), dividend.y.Modulo(divisor.y), dividend.z.Modulo(divisor.z));
		}

		public static Vector3 Rotate(this Vector3 point, float angle, Vector3 axis)
		{
			if(Math.Abs(axis.sqrMagnitude - Float.One) > 1E-05)
			{
				axis.Normalize();
			}
			angle *= Mathf.Deg2Rad;
			float sin = Mathf.Sin(angle);
			float cos = Mathf.Cos(angle);
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

		public static Vector3 Rotate(this Vector3 point, float angle, Vector3 axis, Vector3 center)
		{
			return (point - center).Rotate(angle, axis) + center;
		}

		public static Vector3 Rotate(this Vector3 point, Quaternion quaternion, Vector3 center)
		{
			return (point - center).Rotate(quaternion) + center;
		}

		public static Vector3 RotateX(this Vector3 point, float angle)
		{
			angle *= Mathf.Deg2Rad;
			float sin = Mathf.Sin(angle);
			float cos = Mathf.Cos(angle);
			return new Vector3(
				point.x, 
				point.y * cos - point.z * sin, 
				point.y * sin + point.z * cos);
		}

		public static Vector3 RotateX(this Vector3 point, float angle, Vector3 center)
		{
			return (point - center).RotateX(angle) + center;
		}

		public static Vector3 RotateY(this Vector3 point, float angle)
		{
			angle *= Mathf.Deg2Rad;
			float sin = Mathf.Sin(angle);
			float cos = Mathf.Cos(angle);
			return new Vector3(
				point.x * cos + point.z * sin, 
				point.y, 
				point.x * -sin + point.z * cos);
		}

		public static Vector3 RotateY(this Vector3 point, float angle, Vector3 center)
		{
			return (point - center).RotateY(angle) + center;
		}

		public static Vector3 RotateZ(this Vector3 point, float angle)
		{
			angle *= Mathf.Deg2Rad;
			float sin = Mathf.Sin(angle);
			float cos = Mathf.Cos(angle);
			return new Vector3(
				point.x * cos - point.y * sin, 
				point.x * sin - point.y * cos, 
				point.z);
		}

		public static Vector3 RotateZ(this Vector3 point, float angle, Vector3 center)
		{
			return (point - center).RotateZ(angle) + center;
		}

		public static Vector3 Round(this Vector3 vector)
		{
			return new Vector3(vector.x.Round(), vector.y.Round(), vector.z.Round());
		}

		public static Vector3Int RoundToInt(this Vector3 vector)
		{
			return new Vector3Int(vector.x.RoundToInt(), vector.y.RoundToInt(), vector.z.RoundToInt());
		}

		public static Vector3 ScaleX(this Vector3 vector, float x)
		{
			return new Vector3(vector.x * x, vector.y, vector.z);
		}

		public static Vector3 ScaleXY(this Vector3 vector, Vector3 factor)
		{
			return new Vector3(vector.x * factor.x, vector.y * factor.y, vector.z);
		}

		public static Vector3 ScaleXYZ(this Vector3 vector, Vector3 factor)
		{
			return new Vector3(vector.x * factor.x, vector.y * factor.y, vector.z * factor.z);
		}

		public static Vector3 ScaleXZ(this Vector3 vector, Vector3 factor)
		{
			return new Vector3(vector.x * factor.x, vector.y, vector.z * factor.z);
		}

		public static Vector3 ScaleY(this Vector3 vector, float y)
		{
			return new Vector3(vector.x, vector.y * y, vector.z);
		}

		public static Vector3 ScaleYZ(this Vector3 vector, Vector3 factor)
		{
			return new Vector3(vector.x, vector.y * factor.y, vector.z * factor.z);
		}

		public static Vector3 ScaleZ(this Vector3 vector, float z)
		{
			return new Vector3(vector.x, vector.y, vector.z * z);
		}

		public static Vector3 SetX(this Vector3 vector, float x)
		{
			return new Vector3(x, vector.y, vector.z);
		}

		public static Vector3 SetXY(this Vector3 vector, float x, float y)
		{
			return new Vector3(x, y, vector.z);
		}

		public static Vector3 SetXZ(this Vector3 vector, float x, float z)
		{
			return new Vector3(x, vector.y, z);
		}

		public static Vector3 SetY(this Vector3 vector, float y)
		{
			return new Vector3(vector.x, y, vector.z);
		}

		public static Vector3 SetYZ(this Vector3 vector, float y, float z)
		{
			return new Vector3(vector.x, y, z);
		}

		public static Vector3 SetZ(this Vector3 vector, float z)
		{
			return new Vector3(vector.x, vector.y, z);
		}

		public static Vector3 Sign(this Vector3 vector)
		{
			return new Vector3(vector.x.Sign(), vector.y.Sign(), vector.z.Sign());
		}

		public static Vector2Int ToVector2IntXY(this Vector3 vector)
		{
			return new Vector2Int((int)vector.x, (int)vector.y);
		}

		public static Vector2Int ToVector2IntXZ(this Vector3 vector)
		{
			return new Vector2Int((int)vector.x, (int)vector.z);
		}

		public static Vector2Int ToVector2IntYZ(this Vector3 vector)
		{
			return new Vector2Int((int)vector.y, (int)vector.z);
		}

		public static Vector2 ToVector2XY(this Vector3 vector)
		{
			return new Vector2(vector.x, vector.y);
		}

		public static Vector2 ToVector2XZ(this Vector3 vector)
		{
			return new Vector2(vector.x, vector.z);
		}

		public static Vector2 ToVector2YZ(this Vector3 vector)
		{
			return new Vector2(vector.y, vector.z);
		}

		public static Vector3Int ToVector3Int(this Vector3 vector)
		{
			return new Vector3Int((int)vector.x, (int)vector.y, (int)vector.z);
		}
		#endregion
	}
}