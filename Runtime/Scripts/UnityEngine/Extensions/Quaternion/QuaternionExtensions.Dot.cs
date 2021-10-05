namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class QuaternionExtensions
	{
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Quaternion.Dot.html
		/// </remarks>
		public static float Dot(this Quaternion quaternion, Quaternion other)
		{
			return Quaternion.Dot(quaternion, other);
		}
	}
}