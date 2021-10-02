namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector4Extensions
	{
		[Obsolete("Use 'normalized' directly instead.")]
		public static Vector4 NormalizeMagnitude(this Vector4 vector)
		{
			return vector.normalized;
		}
	}
}