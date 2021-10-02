namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class ColorExtensions
	{
		public static void ToHSV(this Color color, out float hue, out float saturation, out float value)
		{
			Color.RGBToHSV(color, out hue, out saturation, out value);
		}
	}
}