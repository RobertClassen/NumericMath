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
		/// Returns the signed magnitude of the area of the parallelogram described by the vectors.
		/// </summary>
		/// <remarks>
		/// This operation is anticommutative, i.e. `a.Cross(b) == b.Cross(-a)`.
		/// </remarks>
		public static float Determinant(this Vector2 vector, Vector2 other)
		{
			return vector.x * other.y - other.x * vector.y;
		}
		#endregion
	}
}