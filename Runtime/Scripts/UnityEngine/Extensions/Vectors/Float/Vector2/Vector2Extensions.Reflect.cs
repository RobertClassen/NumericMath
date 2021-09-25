namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		/// <summary>
		/// Reflects the vector off the <c>normal</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector2.Reflect.html
		/// </remarks>
		public static Vector2 Reflect(this Vector2 vector, Vector2 normal)
		{
			return Vector2.Reflect(vector, normal);
		}

		/// <summary>
		/// Reflects the vector horizontally.
		/// </summary>
		/// <seealso cref="ReflectY"/>
		public static Vector2 ReflectX(this Vector2 vector)
		{
			return new Vector2(-vector.x, vector.y);
		}

		/// <summary>
		/// Reflects the vector both horizontally and vertically.
		/// </summary>
		public static Vector2 ReflectXY(this Vector2 vector)
		{
			return new Vector2(-vector.x, -vector.y);
		}

		/// <summary>
		/// Reflects the vector vertically.
		/// </summary>
		/// <seealso cref="ReflectX"/>
		public static Vector2 ReflectY(this Vector2 vector)
		{
			return new Vector2(vector.x, -vector.y);
		}
	}
}