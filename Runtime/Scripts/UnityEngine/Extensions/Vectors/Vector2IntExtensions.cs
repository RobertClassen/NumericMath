namespace WellDefined
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static class Vector2IntExtensions
	{
		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		public static Vector2Int ClampXY(this Vector2Int vector, Vector2Int min, Vector2Int max)
		{
			return new Vector2Int(vector.x.Clamp(min.x, max.x), vector.y.Clamp(min.y, max.y));
		}

		public static Vector2Int ClampXY(this Vector2Int vector, RectInt rect)
		{
			return vector.ClampXY(rect.min, rect.max);
		}

		public static Vector2Int DivideBy(this Vector2Int dividend, Vector2Int divisor)
		{
			return new Vector2Int(dividend.x / divisor.x, dividend.y / divisor.y);
		}

		public static Vector2Int Modulo(this Vector2Int dividend, Vector2Int divisor)
		{
			return new Vector2Int(dividend.x.Modulo(divisor.x), dividend.y.Modulo(divisor.y));
		}

		public static Vector2Int Remainder(this Vector2Int dividend, Vector2Int divisor)
		{
			return new Vector2Int(dividend.x % divisor.x, dividend.y % divisor.y);
		}

		public static Vector2Int Sign(this Vector2Int vector)
		{
			return new Vector2Int(vector.x.Sign(), vector.y.Sign());
		}

		public static RectInt ToRectInt(this Vector2Int size, Vector2Int position = default(Vector2Int))
		{
			return new RectInt(position, size);
		}
		#endregion
	}
}