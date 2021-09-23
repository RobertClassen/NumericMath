namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		public static Vector2 Rotate(this Vector2 point, float degrees)
		{
			float radians = degrees * Mathf.Deg2Rad;
			float sin = Mathf.Sin(radians);
			float cos = Mathf.Cos(radians);
			return new Vector2(
				point.x * cos - point.y * sin, 
				point.x * sin + point.y * cos);
		}

		public static Vector2 Rotate(this Vector2 point, float degrees, Vector2 center)
		{
			return (point - center).Rotate(degrees) + center;
		}
		#endregion
	}
}