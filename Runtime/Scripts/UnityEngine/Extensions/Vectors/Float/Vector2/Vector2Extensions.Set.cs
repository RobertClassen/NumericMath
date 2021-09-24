namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
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
		public static Vector2 SetMagnitude(this Vector2 vector, float magnitude)
		{
			return vector.normalized * magnitude;
		}

		public static Vector2 SetX(this Vector2 vector, float x)
		{
			return new Vector2(x, vector.y);
		}

		public static Vector2 SetY(this Vector2 vector, float y)
		{
			return new Vector2(vector.x, y);
		}
		#endregion
	}
}