namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		/// <summary>
		/// Rounds both components of the vector down.
		/// </summary>
		public static Vector2 Floor(this Vector2 vector)
		{
			return new Vector2(vector.x.Floor(), vector.y.Floor());
		}

		/// <summary>
		/// Rounds both components of the vector down.
		/// </summary>
		public static Vector2Int FloorToInt(this Vector2 vector)
		{
			return new Vector2Int(vector.x.FloorToInt(), vector.y.FloorToInt());
		}
	}
}