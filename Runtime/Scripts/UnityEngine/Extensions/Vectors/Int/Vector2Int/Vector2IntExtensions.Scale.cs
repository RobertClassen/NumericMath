namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2IntExtensions
	{
		public static Vector2Int ScaleX(this Vector2Int vector, int x)
		{
			return new Vector2Int(vector.x * x, vector.y);
		}

		public static Vector2Int ScaleXY(this Vector2Int vector, int x, int y)
		{
			return new Vector2Int(vector.x * x, vector.y * y);
		}

		/// <summary>
		/// Scales both components of the vector.
		/// </summary>
		/// <remarks>
		/// Similar to Vector2Int.Scale(Vector2 vector, Vector2 factor).  
		/// Similar to vector.Scale(Vector2 factor), but returns the result instead of <c>void</c>.
		/// 
		/// See https://docs.unity3d.com/ScriptReference/Vector2Int.Scale.html
		/// </remarks>
		public static Vector2Int ScaleXY(this Vector2Int vector, Vector2Int factor)
		{
			return vector.ScaleXY(factor.x, factor.y);
		}

		public static Vector2Int ScaleY(this Vector2Int vector, int y)
		{
			return new Vector2Int(vector.x, vector.y * y);
		}
	}
}