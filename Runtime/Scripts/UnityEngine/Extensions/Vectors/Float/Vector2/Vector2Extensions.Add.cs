namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using Random = UnityEngine.Random;

	public static partial class Vector2Extensions
	{
		public static Vector2 AddRandom(this Vector2 vector, Vector2 min, Vector2 max)
		{
			return new Vector2(vector.x + Random.Range(min.x, max.x), vector.y + Random.Range(min.y, max.y));
		}

		public static Vector2 AddX(this Vector2 vector, float x)
		{
			return new Vector2(vector.x + x, vector.y);
		}

		public static Vector2 AddY(this Vector2 vector, float y)
		{
			return new Vector2(vector.x, vector.y + y);
		}
	}
}