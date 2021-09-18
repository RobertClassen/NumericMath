namespace WellDefinedTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
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
		public static Vector2 Abs(this Vector2 vector)
		{
			return new Vector2(vector.x.Abs(), vector.y.Abs());
		}

		public static Vector2 Ceil(this Vector2 vector)
		{
			return new Vector2(vector.x.Ceil(), vector.y.Ceil());
		}

		public static Vector2Int CeilToInt(this Vector2 vector)
		{
			return new Vector2Int(vector.x.CeilToInt(), vector.y.CeilToInt());
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

		public static Vector2 Round(this Vector2 vector)
		{
			return new Vector2(vector.x.Round(), vector.y.Round());
		}

		public static Vector2Int RoundToInt(this Vector2 vector)
		{
			return new Vector2Int(vector.x.RoundToInt(), vector.y.RoundToInt());
		}

		public static Vector2 Sign(this Vector2 vector)
		{
			return new Vector2(vector.x.Sign(), vector.y.Sign());
		}
		#endregion
	}
}