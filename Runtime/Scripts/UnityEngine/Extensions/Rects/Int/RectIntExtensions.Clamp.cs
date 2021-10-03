namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class RectIntExtensions
	{
		/// <summary>
		/// Clamps the rect to the <c>min</c> and <c>max</c> values of the <c>constrainingRect</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/RectInt.ClampToBounds.html
		/// </remarks>
		public static RectInt Clamp(this RectInt rect, RectInt constrainingRect)
		{
			rect.xMin = rect.xMin.Clamp(constrainingRect.xMin, constrainingRect.xMax);
			rect.xMax = rect.xMax.Clamp(constrainingRect.xMin, constrainingRect.xMax);
			rect.yMin = rect.yMin.Clamp(constrainingRect.yMin, constrainingRect.yMax);
			rect.yMax = rect.yMax.Clamp(constrainingRect.yMin, constrainingRect.yMax);
			return rect;
		}
	}
}