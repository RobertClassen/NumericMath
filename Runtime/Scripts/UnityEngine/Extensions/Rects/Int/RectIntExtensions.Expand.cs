namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class RectIntExtensions
	{
		public static RectInt Expand(this RectInt rect, Vector2Int size)
		{
			return new RectInt(rect.min - size, rect.max + size * 2);
		}
	}
}