namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class QuaternionExtensions
	{
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Quaternion.Normalize.html
		/// </remarks>
		[Obsolete("Use 'normalized' directly instead.")]
		public static Quaternion NormalizeMagnitude(this Quaternion quaternion)
		{
			return quaternion.normalized;
		}
	}
}