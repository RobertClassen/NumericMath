namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector4Extensions
	{
		public static Vector4 InvertUVRectX(this Vector4 vector)
		{
			vector.z = Float.One - vector.z - vector.x;
			return vector;
		}

		public static Vector4 InvertUVRectY(this Vector4 vector)
		{
			vector.w = Float.One - vector.w - vector.y;
			return vector;
		}
	}
}