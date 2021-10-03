namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2IntExtensions
	{
		/// <summary>
		/// Performs a component-wise `Sign` operation.
		/// </summary>
		public static Vector2Int Sign(this Vector2Int vector)
		{
			return new Vector2Int(vector.x.Sign(), vector.y.Sign());
		}
	}
}