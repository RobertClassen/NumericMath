namespace WellDefinedTypes
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
		public static Vector2 Rotate(this Vector2 point, float angle)
		{
			angle *= Mathf.Deg2Rad;
			float sin = Mathf.Sin(angle);
			float cos = Mathf.Cos(angle);
			return new Vector2(
				point.x * cos - point.y * sin, 
				point.x * sin + point.y * cos);
		}

		public static Vector2 Rotate(this Vector2 point, float angle, Vector2 center)
		{
			return (point - center).Rotate(angle) + center;
		}
		#endregion
	}
}