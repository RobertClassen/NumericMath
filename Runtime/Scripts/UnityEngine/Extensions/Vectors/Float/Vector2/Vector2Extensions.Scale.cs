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
		public static Vector2 ScaleX(this Vector2 vector, float x)
		{
			return new Vector2(vector.x * x, vector.y);
		}

		public static Vector2 ScaleXY(this Vector2 vector, Vector2 factor)
		{
			return new Vector2(vector.x * factor.x, vector.y * factor.y);
		}

		public static Vector2 ScaleY(this Vector2 vector, float y)
		{
			return new Vector2(vector.x, vector.y * y);
		}
		#endregion
	}
}