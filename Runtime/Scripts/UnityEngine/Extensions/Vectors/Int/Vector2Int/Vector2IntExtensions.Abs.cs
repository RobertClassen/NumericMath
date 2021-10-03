namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2IntExtensions
	{
		public static Vector2Int Abs(this Vector2Int vector)
		{
			return new Vector2Int(vector.x.Abs(), vector.y.Abs());
		}
	}
}