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
		/// <summary>
		/// Rounds both components of the vector up.
		/// </summary>
		public static Vector2 Ceil(this Vector2 vector)
		{
			return new Vector2(vector.x.Ceil(), vector.y.Ceil());
		}

		/// <summary>
		/// Rounds both components of the vector up.
		/// </summary>
		public static Vector2Int CeilToInt(this Vector2 vector)
		{
			return new Vector2Int(vector.x.CeilToInt(), vector.y.CeilToInt());
		}
		#endregion
	}
}