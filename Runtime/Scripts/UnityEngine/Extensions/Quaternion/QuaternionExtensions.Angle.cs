namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class QuaternionExtensions
	{
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Angle.Dot.html
		/// </remarks>
		public static float Angle(this Quaternion quaternion, Quaternion other)
		{
			return Quaternion.Angle(quaternion, other);
		}

		/// <summary>
		/// Creates a <c>Quaternion</c> which rotates <c>angle</c> degrees around <c>axis</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Quaternion.AngleAxis.html
		/// </remarks>
		[Obsolete("Use 'axis.AngleAxis' instead.")]
		public static Quaternion AngleAxis(this Quaternion quaternion, float angle, Vector3 axis)
		{
			return Quaternion.AngleAxis(angle, axis);
		}
	}
}