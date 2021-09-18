namespace WellDefined
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class RectExtensions
	{
		#region Constants
		private const float RectSpace = Float.Two;
		private const int XMin = Int.Zero;
		private const int YMin = Int.Zero;
		#endregion

		#region Fields
		
		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		
		#endregion

		#region Methods
		/// <summary>
		/// Divides the <c>rect</c> into <c>xCount</c> columns and <c>yCount</c> rows 
		/// and returns the <c>Rect</c> for the cell at column <c>x</c>, row <c>y</c>.
		/// </summary>
		/// <param name="rect">The original <c>Rect</c>.</param>
		/// <param name="x">The column index.</param>
		/// <param name="y">The row index.</param>
		/// <param name="xCount">The number of columns.</param>
		/// <param name="yCount">The number of rows.</param>
		/// <param name="isEnabled">Returns the original <c>rect</c> if set to <c>false</c>.</param>
		public static Rect GetCell(this Rect rect, int x, int y, int xCount, int yCount, 
			bool isEnabled = IsEnabledDefault)
		{
			return isEnabled ? rect.GetCell(x, xCount, y, yCount, RectSpace, RectSpace) : rect;
		}

		/// <summary>
		/// Divides the <c>rect</c> into <c>xCount</c> columns and <c>yCount</c> rows 
		/// and returns the <c>Rect</c> for the cell at column <c>x</c>, row <c>y</c>.
		/// </summary>
		/// <param name="rect">The original <c>Rect</c>.</param>
		/// <param name="x">The column index.</param>
		/// <param name="y">The row index.</param>
		/// <param name="xCount">The number of columns.</param>
		/// <param name="yCount">The number of rows.</param>
		/// <param name="space">The space between columns and rows.</param>
		/// <param name="isEnabled">Returns the original <c>rect</c> if set to <c>false</c>.</param>
		public static Rect GetCell(this Rect rect, int x, int y, int xCount, int yCount, float space, 
			bool isEnabled = IsEnabledDefault)
		{
			return isEnabled ? rect.GetCell(x, xCount, y, yCount, space, space) : rect;
		}

		/// <summary>
		/// Divides the <c>rect</c> into <c>xCount</c> columns and <c>yCount</c> rows 
		/// and returns the <c>Rect</c> for the cell at column <c>x</c>, row <c>y</c>.
		/// </summary>
		/// <param name="rect">The original <c>Rect</c>.</param>
		/// <param name="x">The column index.</param>
		/// <param name="y">The row index.</param>
		/// <param name="xCount">The number of columns.</param>
		/// <param name="yCount">The number of rows.</param>
		/// <param name="xSpace">The space between columns.</param>
		/// <param name="ySpace">The space between rows.</param>
		/// <param name="isEnabled">Returns the original <c>rect</c> if set to <c>false</c>.</param>
		public static Rect GetCell(this Rect rect, int x, int y, int xCount, int yCount, float xSpace, float ySpace, 
			bool isEnabled = IsEnabledDefault)
		{
			if(!isEnabled)
			{
				return rect;
			}
			int xMax;
			int yMax;
			ValidateX(x, xCount, out xMax);
			ValidateY(y, yCount, out yMax);
			float width = (rect.width - xMax * xSpace) / (float)xCount;
			float height = (rect.height - yMax * ySpace) / (float)yCount;
			return new Rect(rect.x + (width + xSpace) * x, rect.y + (height + ySpace) * y, width, height); 
		}

		/// <summary>
		/// Divides the <c>rect</c> into <c>xCount</c> columns and returns the <c>Rect</c> for column <c>x</c>.
		/// </summary>
		/// <param name="rect">The original <c>Rect</c>.</param>
		/// <param name="x">The column index.</param>
		/// <param name="xCount">The number of columns.</param>
		/// <param name="xSpace">The space between columns.</param>
		/// <param name="isEnabled">Returns the original <c>rect</c> if set to <c>false</c>.</param>
		public static Rect GetColumn(this Rect rect, int x, int xCount, float xSpace = RectSpace, 
			bool isEnabled = IsEnabledDefault)
		{
			if(!isEnabled)
			{
				return rect;
			}
			int xMax;
			ValidateX(x, xCount, out xMax);
			float width = (rect.width - xMax * xSpace) / (float)xCount;
			return new Rect(rect.x + (width + xSpace) * x, rect.y, width, rect.height); 
		}

		/// <summary>
		/// Divides the <c>rect</c> into <c>yCount</c> rows and returns the <c>Rect</c> for row <c>y</c>.
		/// </summary>
		/// <param name="rect">The original <c>Rect</c>.</param>
		/// <param name="y">The row index.</param>
		/// <param name="yCount">The number of rows.</param>
		/// <param name="ySpace">The space between rows.</param>
		/// <param name="isEnabled">Returns the original <c>rect</c> if set to <c>false</c>.</param>
		public static Rect GetRow(this Rect rect, int y, int yCount, float ySpace = RectSpace, 
			bool isEnabled = IsEnabledDefault)
		{
			if(!isEnabled)
			{
				return rect;
			}
			int yMax;
			ValidateY(y, yCount, out yMax);
			float height = (rect.height - yMax * ySpace) / (float)yCount;
			return new Rect(rect.x, rect.y + (height + ySpace) * y, rect.width, height); 
		}

		private static void ValidateX(int x, int xCount, out int xMax)
		{
			if(xCount <= XMin)
			{
				throw new ArgumentLessEqualsZeroException(nameof(xCount), xCount);
			}
			xMax = xCount - Int.One;
			if(!x.IsClamped(XMin, xMax))
			{
				throw new ArgumentOutOfRangeException(nameof(x), x, 
					string.Format("'{0}' must be non-negative and less than '{1}' ({2})", 
						nameof(x), nameof(xCount), xCount));
			}
		}

		private static void ValidateY(int y, int yCount, out int yMax)
		{
			if(yCount <= XMin)
			{
				throw new ArgumentLessEqualsZeroException(nameof(yCount), yCount);
			}
			yMax = yCount - Int.One;
			if(!y.IsClamped(XMin, yMax))
			{
				throw new ArgumentOutOfRangeException(nameof(y), y, 
					string.Format("'{0}' must be non-negative and less than '{1}' ({2})", 
						nameof(y), nameof(yCount), yCount));
			}
		}
		#endregion
	}
}