namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		/// <summary>
		/// Clamps the magnitude of the <c>vector</c> between <c>min</c> and <c>max</c>.
		/// </summary>
		public static Vector2 Clamp(this Vector2 vector, float min, float max)
		{
			float sqrMagnitude = vector.sqrMagnitude;
			if(sqrMagnitude < min * min)
			{
				float magnitude = (float)Math.Sqrt((double)sqrMagnitude);
				return new Vector2(vector.x / magnitude * min, vector.y / magnitude * min);
			}
			if(sqrMagnitude > max * max)
			{
				float magnitude = (float)Math.Sqrt((double)sqrMagnitude);
				return new Vector2(vector.x / magnitude * max, vector.y / magnitude * max);
			}
			return vector;
		}

		/// <summary>
		/// Scales the vector down to the specified magnitude if it is longer than that.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector2.ClampMagnitude.html
		/// </remarks>
		[Obsolete("Use 'ClampMax' instead.")]
		public static Vector2 ClampMagnitude(this Vector2 vector, float magnitude)
		{
			return Vector2.ClampMagnitude(vector, magnitude);
		}

		/// <summary>
		/// Scales the vector down to the specified magnitude if it is longer than that.
		/// </summary>
		public static Vector2 ClampMax(this Vector2 vector, float max)
		{
			float sqrMagnitude = vector.sqrMagnitude;
			if(sqrMagnitude > max * max)
			{
				float magnitude = (float)Math.Sqrt((double)sqrMagnitude);
				return new Vector2(vector.x / magnitude * max, vector.y / magnitude * max);
			}
			return vector;
		}

		/// <summary>
		/// Scales the vector up to the specified magnitude if it is shorter than that.
		/// </summary>
		public static Vector2 ClampMin(this Vector2 vector, float min)
		{
			float sqrMagnitude = vector.sqrMagnitude;
			if(sqrMagnitude < min * min)
			{
				float magnitude = (float)Math.Sqrt((double)sqrMagnitude);
				return new Vector2(vector.x / magnitude * min, vector.y / magnitude * min);
			}
			return vector;
		}

		/// <summary>
		/// Clamps the <c>x</c> component of the <c>vector</c>.
		/// </summary>
		public static Vector2 ClampX(this Vector2 vector, float min, float max)
		{
			return new Vector2(vector.x.Clamp(min, max), vector.y);
		}

		/// <summary>
		/// Clamps the <c>x</c> and <c>y</c> components of the <c>vector</c> individually.
		/// </summary>
		public static Vector2 ClampXY(this Vector2 vector, Vector2 min, Vector2 max)
		{
			return new Vector2(vector.x.Clamp(min.x, max.x), vector.y.Clamp(min.y, max.y));
		}

		/// <summary>
		/// Clamps the <c>x</c> and <c>y</c> components of the <c>vector</c> individually.
		/// </summary>
		public static Vector2 ClampXY(this Vector2 vector, Rect rect)
		{
			return vector.ClampXY(rect.min, rect.max);
		}

		/// <summary>
		/// Clamps the <c>x</c> and <c>y</c> components of the <c>vector</c> individually, 
		/// between <c>0</c> and <c>1</c>.
		/// </summary>
		public static Vector2 ClampXY01(this Vector2 vector, bool isEnabled = Core.Numeric.IsClampEnabledDefault)
		{
			return isEnabled ? vector.ClampXY(Vector2.zero, Vector2.one) : vector;
		}

		/// <summary>
		/// Clamps the <c>y</c> component of the <c>vector</c>.
		/// </summary>
		public static Vector2 ClampY(this Vector2 vector, float min, float max)
		{
			return new Vector2(vector.x, vector.y.Clamp(min, max));
		}
	}
}