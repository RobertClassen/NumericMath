namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		public static Vector2 ScaleX(this Vector2 vector, float x)
		{
			return new Vector2(vector.x * x, vector.y);
		}

		public static Vector2 ScaleXY(this Vector2 vector, float x, float y)
		{
			return new Vector2(vector.x * x, vector.y * y);
		}

		/// <summary>
		/// Scales both components of the vector.
		/// </summary>
		/// <remarks>
		/// Similar to Vector2.Scale(Vector2 vector, Vector2 factor).  
		/// Similar to vector.Scale(Vector2 factor), but returns the result instead of <c>void</c>.
		/// 
		/// See https://docs.unity3d.com/ScriptReference/Vector2.Scale.html
		/// </remarks>
		public static Vector2 ScaleXY(this Vector2 vector, Vector2 factor)
		{
			return vector.ScaleXY(factor.x, factor.y);
		}

		public static Vector2 ScaleY(this Vector2 vector, float y)
		{
			return new Vector2(vector.x, vector.y * y);
		}
	}
}