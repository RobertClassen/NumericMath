namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class RectExtensions
	{
		/// <summary>
		/// Converts a relative vector to an absolute vector based on the <c>rect</c>, component-wise.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Rect.NormalizedToPoint.html
		/// </remarks>
		[Obsolete("Use 'normalizedVector.ToAbsoluteXY(rect)' instead.")]
		public static Vector2 NormalizedToPoint(this Rect rect, Vector2 normalizedVector)
		{
			return Rect.NormalizedToPoint(rect, normalizedVector);
		}

		/// <summary>
		/// Converts an absolute vector to a normalized vector relative to the <c>rect</c>, component-wise.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Rect.PointToNormalized.html
		/// </remarks>
		[Obsolete("Use 'absoluteVector.ToRelativeXY(rect)' instead.")]
		public static Vector2 PointToNormalized(this Rect rect, Vector2 absoluteVector)
		{
			return Rect.PointToNormalized(rect, absoluteVector);
		}
	}
}