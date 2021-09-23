namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using Random = UnityEngine.Random;

	public static partial class Vector3Extensions
	{
		#region Fields
		
		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		
		#endregion

		#region Methods
		/// <summary>
		/// Returns the signed magnitude of the area of the parallelogram 
		/// described by the <c>x</c> and <c>y</c> components of the vectors.
		/// </summary>
		/// <remarks>
		/// This operation is anticommutative, i.e. `a.Determinant(b) == b.Determinant(-a)`.
		/// </remarks>
		public static float DeterminantXY(this Vector3 vector, Vector3 other)
		{
			return vector.x * other.y - other.x * vector.y;
		}

		/// <summary>
		/// Returns the signed magnitude of the area of the parallelogram 
		/// described by the <c>x</c> and <c>z</c> components of the vectors.
		/// </summary>
		/// <remarks>
		/// This operation is anticommutative, i.e. `a.Determinant(b) == b.Determinant(-a)`.
		/// </remarks>
		public static float DeterminantXZ(this Vector3 vector, Vector3 other)
		{
			return vector.x * other.z - other.x * vector.z;
		}

		/// <summary>
		/// Returns the signed magnitude of the area of the parallelogram 
		/// described by the <c>y</c> and <c>z</c> components of the vectors.
		/// </summary>
		/// <remarks>
		/// This operation is anticommutative, i.e. `a.Determinant(b) == b.Determinant(-a)`.
		/// </remarks>
		public static float DeterminantYZ(this Vector3 vector, Vector3 other)
		{
			return vector.y * other.z - other.y * vector.z;
		}
		#endregion
	}
}