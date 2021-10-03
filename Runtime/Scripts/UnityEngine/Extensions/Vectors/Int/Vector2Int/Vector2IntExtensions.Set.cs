namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2IntExtensions
	{
		public static Vector2Int SetX(this Vector2Int vector, int x)
		{
			vector.x = x;
			return vector;
		}

		public static Vector2Int SetXY(this Vector2Int vector, int x, int y)
		{
			vector.x = x;
			vector.y = y;
			return vector;
		}

		public static Vector2Int SetY(this Vector2Int vector, int y)
		{
			vector.y = y;
			return vector;
		}
	}
}