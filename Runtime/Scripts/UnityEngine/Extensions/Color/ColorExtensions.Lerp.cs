namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using UnityEngine;

	public static partial class ColorExtensions
	{
		/// <summary>
		/// Linearly interpolates between colors <c>a</c> and <c>b</c> by <c>t</c>.
		/// </summary>
		/// <remarks>
		/// When <c>t</c> is <c>0</c> returns <c>a</c>. When <c>t</c> is <c>1</c> returns <c>b</c>.
		/// 
		/// See https://docs.unity3d.com/ScriptReference/Color.Lerp.html  
		/// See https://docs.unity3d.com/ScriptReference/Color.LerpUnclamped.html
		/// </remarks>
		public static Color Lerp(this Color a, Color b, float t, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return isClamped ? Color.Lerp(a, b, t) : Color.LerpUnclamped(a, b, t);
		}
	}
}