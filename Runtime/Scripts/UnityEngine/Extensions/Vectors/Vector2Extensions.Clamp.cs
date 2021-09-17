namespace WellDefined
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
		#endregion
	}
}