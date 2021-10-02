namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector4Extensions
	{
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