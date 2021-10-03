namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2IntExtensions
	{
		public static Vector2Int Remainder(this Vector2Int dividend, Vector2Int divisor)
		{
			return new Vector2Int(dividend.x % divisor.x, dividend.y % divisor.y);
		}
	}
}