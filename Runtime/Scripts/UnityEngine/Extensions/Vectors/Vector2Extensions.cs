namespace WellDefined
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using UnityEngine;
	using Random = UnityEngine.Random;

	public static class Vector2Extensions
	{
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

		public static Vector2 AddRandom(this Vector2 vector, Vector2 min, Vector2 max)
		{
			return new Vector2(vector.x + Random.Range(min.x, max.x), vector.y + Random.Range(min.y, max.y));
		}

		public static Vector2 AddX(this Vector2 vector, float x)
		{
			return new Vector2(vector.x + x, vector.y);
		}

		public static Vector2 AddY(this Vector2 vector, float y)
		{
			return new Vector2(vector.x, vector.y + y);
		}

		public static Vector2 Ceil(this Vector2 vector)
		{
			return new Vector2(vector.x.Ceil(), vector.y.Ceil());
		}

		public static Vector2Int CeilToInt(this Vector2 vector)
		{
			return new Vector2Int(vector.x.CeilToInt(), vector.y.CeilToInt());
		}

		public static Vector2 Clamp01(this Vector2 vector, bool isClamped = Numeric.IsClampClampedDefault)
		{
			return isClamped ? vector.ClampXY(Vector2.zero, Vector2.one) : vector;
		}

		public static Vector2 ClampX(this Vector2 vector, float min, float max)
		{
			return new Vector2(vector.x.Clamp(min, max), vector.y);
		}

		public static Vector2 ClampXY(this Vector2 vector, Vector2 min, Vector2 max)
		{
			return new Vector2(vector.x.Clamp(min.x, max.x), vector.y.Clamp(min.y, max.y));
		}

		public static Vector2 ClampXY(this Vector2 vector, Rect rect)
		{
			return vector.ClampXY(rect.min, rect.max);
		}

		public static Vector2 ClampY(this Vector2 vector, float min, float max)
		{
			return new Vector2(vector.x, vector.y.Clamp(min, max));
		}

		public static float Dot(this Vector2 vector, Vector3 other)
		{
			return vector.x * other.x + vector.y + other.y;
		}

		public static Vector2 Floor(this Vector2 vector)
		{
			return new Vector2(vector.x.Floor(), vector.y.Floor());
		}

		public static Vector2Int FloorToInt(this Vector2 vector)
		{
			return new Vector2Int(vector.x.FloorToInt(), vector.y.FloorToInt());
		}

		public static Vector2 Modulo(this Vector2 dividend, Vector2 divisor)
		{
			return new Vector2(dividend.x.Modulo(divisor.x), dividend.y.Modulo(divisor.y));
		}

		public static Vector2 Rotate(this Vector2 point, float angle)
		{
			angle *= Mathf.Deg2Rad;
			float sin = Mathf.Sin(angle);
			float cos = Mathf.Cos(angle);
			return new Vector2(
				point.x * cos - point.y * sin, 
				point.x * sin + point.y * cos);
		}

		public static Vector2 Rotate(this Vector2 point, float angle, Vector2 center)
		{
			return (point - center).Rotate(angle) + center;
		}

		public static Vector2 Round(this Vector2 vector)
		{
			return new Vector2(vector.x.Round(), vector.y.Round());
		}

		public static Vector2Int RoundToInt(this Vector2 vector)
		{
			return new Vector2Int(vector.x.RoundToInt(), vector.y.RoundToInt());
		}

		public static Vector2 SetX(this Vector2 vector, float x)
		{
			return new Vector2(x, vector.y);
		}

		public static Vector2 SetY(this Vector2 vector, float y)
		{
			return new Vector2(vector.x, y);
		}

		public static Vector2 Sign(this Vector2 vector)
		{
			return new Vector2(vector.x.Sign(), vector.y.Sign());
		}

		public static Rect ToRect(this Vector2 size, Vector2 position = default(Vector2))
		{
			return new Rect(position, size);
		}

		public static Rect ToCenteredRect(this Vector2 size, Vector2 position = default(Vector2))
		{
			return size.ToRect(position - size * Float.OneHalf);
		}

		public static Vector4 ToUVRect(this Vector2 size, float x, float y)
		{
			return new Vector4(size.x, size.y, size.x * x, size.y * y);
		}

		public static Vector4 ToUVRect(this Vector2 size, Vector2 position)
		{
			return size.ToUVRect(position.x, position.y);
		}

		public static Vector2Int ToVector2Int(this Vector2 vector)
		{
			return new Vector2Int((int)vector.x, (int)vector.y);
		}
		#endregion
	}
}