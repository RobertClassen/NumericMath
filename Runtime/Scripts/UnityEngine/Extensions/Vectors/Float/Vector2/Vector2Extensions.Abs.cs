namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		public static Vector2 Abs(this Vector2 vector)
		{
			return new Vector2(vector.x.Abs(), vector.y.Abs());
		}
	}
}