namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class ColorExtensions
	{
		public static Color SetAlpha(this Color color, float alpha)
		{
			color.a = alpha;
			return color;
		}
	}
}