namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3IntExtensions
	{
		/// <summary>
		/// Performs a component-wise `Sign` operation.
		/// </summary>
		public static Vector3Int Sign(this Vector3Int vector)
		{
			return new Vector3Int(vector.x.Sign(), vector.y.Sign(), vector.z.Sign());
		}
	}
}