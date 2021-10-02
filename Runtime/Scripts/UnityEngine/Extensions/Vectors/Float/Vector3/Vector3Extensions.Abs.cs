namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		public static Vector3 Abs(this Vector3 vector)
		{
			return new Vector3(vector.x.Abs(), vector.y.Abs(), vector.z.Abs());
		}
	}
}