namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using Random = UnityEngine.Random;

	public static partial class Vector3Extensions
	{
		#region Constants
		private const double delta = 1E-05;
		#endregion

		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		public static Vector3 Abs(this Vector3 vector)
		{
			return new Vector3(vector.x.Abs(), vector.y.Abs(), vector.z.Abs());
		}

		public static Vector3 Ceil(this Vector3 vector)
		{
			return new Vector3(vector.x.Ceil(), vector.y.Ceil(), vector.z.Ceil());
		}

		public static Vector3Int CeilToInt(this Vector3 vector)
		{
			return new Vector3Int(vector.x.CeilToInt(), vector.y.CeilToInt(), vector.z.CeilToInt());
		}

		public static Vector3 Floor(this Vector3 vector)
		{
			return new Vector3(vector.x.Floor(), vector.y.Floor(), vector.z.Floor());
		}

		public static Vector3Int FloorToInt(this Vector3 vector)
		{
			return new Vector3Int(vector.x.FloorToInt(), vector.y.FloorToInt(), vector.z.FloorToInt());
		}

		/// <summary>
		/// Checks if the magnitude of the <c>vector</c> equals <c>1</c>.
		/// </summary>
		public static bool IsNormalized(this Vector3 vector)
		{
			return Math.Abs(vector.sqrMagnitude - Float.One) < delta;
		}

		public static Vector3 Modulo(this Vector3 dividend, Vector3 divisor)
		{
			return new Vector3(dividend.x.Modulo(divisor.x), dividend.y.Modulo(divisor.y), dividend.z.Modulo(divisor.z));
		}

		public static Vector3 Round(this Vector3 vector)
		{
			return new Vector3(vector.x.Round(), vector.y.Round(), vector.z.Round());
		}

		public static Vector3Int RoundToInt(this Vector3 vector)
		{
			return new Vector3Int(vector.x.RoundToInt(), vector.y.RoundToInt(), vector.z.RoundToInt());
		}

		public static Vector3 Sign(this Vector3 vector)
		{
			return new Vector3(vector.x.Sign(), vector.y.Sign(), vector.z.Sign());
		}
		#endregion
	}
}