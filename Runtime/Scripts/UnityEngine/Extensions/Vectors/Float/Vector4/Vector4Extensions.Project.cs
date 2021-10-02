namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector4Extensions
	{
		public static Vector4 Project(this Vector4 vector, Vector4 other)
		{
			return Vector4.Project(vector, other);
		}
	}
}