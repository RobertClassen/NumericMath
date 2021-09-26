namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		/// <summary>
		/// Returns the 2D vector perpendicular to this 2D vector.
		/// </summary>
		/// <remarks>
		/// The result is always rotated 90° in a counter-clockwise direction 
		/// for a 2D coordinate system where the positive Y axis goes up.
		/// 
		/// See https://docs.unity3d.com/ScriptReference/Vector2.Perpendicular.html
		/// </remarks>
		[Obsolete("Use 'Rotate90' instead.")]
		public static Vector2 Perpendicular(this Vector2 vector)
		{
			return Vector2.Perpendicular(vector);
		}
	}
}