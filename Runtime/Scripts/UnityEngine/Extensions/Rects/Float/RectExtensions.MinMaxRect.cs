namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class RectExtensions
	{
		/// <summary>
		/// Returns a rect matching the specified coordinates.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Rect.MinMaxRect.html
		/// </remarks>
		[Obsolete("Use 'rect.Set' instead.")]
		public static Rect MinMaxRect(this Rect rect, float xMin, float yMin, float xMax, float yMax)
		{
			return Rect.MinMaxRect(xMin, yMin, xMax, yMax);
		}
	}
}