namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static class Vector4Extensions
	{
		public static Vector4 InvertUVRectX(this Vector4 vector)
		{
			vector.z = Float.One - vector.z - vector.x;
			return vector;
		}

		public static Vector4 InvertUVRectY(this Vector4 vector)
		{
			vector.w = Float.One - vector.w - vector.y;
			return vector;
		}

		public static Rect ToRect(this Vector4 vector, Vector2 scale, Vector2 offset = default(Vector2))
		{
			return new Rect(
				vector.z * scale.x + offset.x, 
				vector.w * scale.y + offset.y, 
				vector.x * scale.x, 
				vector.y * scale.y);
		}
	}
}