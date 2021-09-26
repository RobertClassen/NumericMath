namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
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
	}
}