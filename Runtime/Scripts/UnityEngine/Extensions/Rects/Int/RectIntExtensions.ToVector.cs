namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class RectIntExtensions
	{
		/// <summary>
		/// Calculates the position and size of the <c>rect</c> relative to the specified <c>textureSize</c> 
		/// and converts them to a <c>Vector4</c> which can be passed to a shader to be used as uvRect.
		/// </summary>
		public static Vector4 ToUVRect(this RectInt rect, Vector2Int textureSize)
		{
			Vector2 offset = rect.min / (Vector2)textureSize;
			Vector2 size = rect.size / (Vector2)textureSize;
			return new Vector4(size.x, size.y, offset.x, offset.y);
		}

		/// <summary>
		/// Calculates the positions and sizes of the <c>rects</c> relative to the specified <c>textureSize</c> 
		/// and converts them to a <c>Vector4</c>s which can be passed to a shader to be used as uvRects.
		/// </summary>
		public static Vector4[] ToUVRects(this RectInt[] rects, Vector2Int textureSize)
		{
			Vector4[] uvRects = new Vector4[rects.Length];
			for(int i = Int.Zero; i < rects.Length; i++)
			{
				uvRects[i] = rects[i].ToUVRect(textureSize);
			}
			return uvRects;
		}
	}
}