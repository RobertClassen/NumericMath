namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2IntExtensions
	{
		public static Vector2Int Modulo(this Vector2Int dividend, Vector2Int divisor)
		{
			return new Vector2Int(dividend.x.Modulo(divisor.x), dividend.y.Modulo(divisor.y));
		}
	}
}