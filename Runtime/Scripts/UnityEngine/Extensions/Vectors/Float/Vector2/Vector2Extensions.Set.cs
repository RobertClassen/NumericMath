namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		public static Vector2 SetMagnitude(this Vector2 vector, float magnitude)
		{
			return vector.normalized * magnitude;
		}

		public static Vector2 SetX(this Vector2 vector, float x)
		{
			return new Vector2(x, vector.y);
		}

		/// <summary>
		/// Returns a new vector with both compoenents set to <c>value</c>.
		/// </summary>
		public static Vector2 SetXY(this Vector2 vector, float value)
		{
			return new Vector2(value, value);
		}

		public static Vector2 SetY(this Vector2 vector, float y)
		{
			return new Vector2(vector.x, y);
		}
	}
}