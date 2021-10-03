namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3IntExtensions
	{
		public static Vector3Int Remainder(this Vector3Int dividend, Vector3Int divisor)
		{
			return new Vector3Int(dividend.x % divisor.x, dividend.y % divisor.y, dividend.z % divisor.z);
		}
	}
}