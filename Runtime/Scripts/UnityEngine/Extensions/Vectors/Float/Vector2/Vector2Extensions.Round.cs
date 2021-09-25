namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		/// <summary>
		/// Rounds both components of the vector.
		/// </summary>
		public static Vector2 Round(this Vector2 vector)
		{
			return new Vector2(vector.x.Round(), vector.y.Round());
		}

		/// <summary>
		/// Rounds both components of the vector.
		/// </summary>
		public static Vector2Int RoundToInt(this Vector2 vector)
		{
			return new Vector2Int(vector.x.RoundToInt(), vector.y.RoundToInt());
		}
	}
}