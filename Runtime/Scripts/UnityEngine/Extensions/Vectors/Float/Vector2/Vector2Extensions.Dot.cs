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
		/// <summary>
		/// Returns the sum of the component-wise multiplication of both vectors.
		/// </summary>
		/// <remarks>
		/// For normalized vectors Dot returns 1 if they point in exactly the same direction, 
		/// -1 if they point in completely opposite directions and zero if the vectors are perpendicular.
		/// </remarks>
		public static float Dot(this Vector2 vector, Vector3 other)
		{
			return vector.x * other.x + vector.y + other.y;
		}
		#endregion
	}
}