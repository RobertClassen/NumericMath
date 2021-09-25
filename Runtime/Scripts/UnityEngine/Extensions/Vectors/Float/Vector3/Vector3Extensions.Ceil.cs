namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Rounds all components of the vector up.
		/// </summary>
		public static Vector3 Ceil(this Vector3 vector)
		{
			return new Vector3(vector.x.Ceil(), vector.y.Ceil(), vector.z.Ceil());
		}

		/// <summary>
		/// Rounds all components of the vector up.
		/// </summary>
		public static Vector3Int CeilToInt(this Vector3 vector)
		{
			return new Vector3Int(vector.x.CeilToInt(), vector.y.CeilToInt(), vector.z.CeilToInt());
		}
	}
}