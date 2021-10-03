namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2IntExtensions
	{
		public static RectInt ToRectInt(this Vector2Int size, Vector2Int position = default(Vector2Int))
		{
			return new RectInt(position, size);
		}
	}
}