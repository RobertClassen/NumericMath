namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2IntExtensions
	{
		public static Vector2Int ClampXY(this Vector2Int vector, Vector2Int min, Vector2Int max)
		{
			return new Vector2Int(vector.x.Clamp(min.x, max.x), vector.y.Clamp(min.y, max.y));
		}

		public static Vector2Int ClampXY(this Vector2Int vector, RectInt rect)
		{
			return vector.ClampXY(rect.min, rect.max);
		}
	}
}