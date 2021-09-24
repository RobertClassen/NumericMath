namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

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
		/// Rounds all components of the vector.
		/// </summary>
		public static Vector3 Round(this Vector3 vector)
		{
			return new Vector3(vector.x.Round(), vector.y.Round(), vector.z.Round());
		}

		/// <summary>
		/// Rounds all components of the vector.
		/// </summary>
		public static Vector3Int RoundToInt(this Vector3 vector)
		{
			return new Vector3Int(vector.x.RoundToInt(), vector.y.RoundToInt(), vector.z.RoundToInt());
		}
		#endregion
	}
}