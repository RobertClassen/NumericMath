namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class RectIntExtensions
	{
		/// <summary>
		/// Sets the bounds of the rect to the <c>min</c> and <c>max</c> values.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/RectInt.SetMinMax.html
		/// </remarks>
		public static RectInt Set(this RectInt rect, Vector2Int min, Vector2Int max)
		{
			rect.min = min;
			rect.max = max;
			return rect;
		}

		public static RectInt SetMax(this RectInt rect, Vector2Int max)
		{
			rect.max = max;
			return rect;
		}

		public static RectInt SetMin(this RectInt rect, Vector2Int min)
		{
			rect.min = min;
			return rect;
		}
	}
}