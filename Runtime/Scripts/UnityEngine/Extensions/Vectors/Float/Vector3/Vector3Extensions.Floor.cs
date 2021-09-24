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
		/// Rounds all components of the vector down.
		/// </summary>
		public static Vector3 Floor(this Vector3 vector)
		{
			return new Vector3(vector.x.Floor(), vector.y.Floor(), vector.z.Floor());
		}

		/// <summary>
		/// Rounds all components of the vector down.
		/// </summary>
		public static Vector3Int FloorToInt(this Vector3 vector)
		{
			return new Vector3Int(vector.x.FloorToInt(), vector.y.FloorToInt(), vector.z.FloorToInt());
		}
		#endregion
	}
}