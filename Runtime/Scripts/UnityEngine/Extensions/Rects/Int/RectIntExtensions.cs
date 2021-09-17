namespace WellDefined
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class RectIntExtensions
	{
		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		public static RectInt Expand(this RectInt rect, Vector2Int size)
		{
			return new RectInt(rect.min - size, rect.max + size * Int.Two);
		}
		#endregion
	}
}