using System;

namespace YarrLib
{
	public static partial class Yarr
	{
		#region InlineNot
		/// <summary>
		/// Performs a logical not inline on an array. Also returns
		/// that array, just because that makes things easier sometimes.
		/// The return value can probably be ignored the rest of the time.
		/// </summary>
		public static bool[] InlineNot(bool[] a)
		{
			int size = a.Length;
			for(int i=0; i<size; i++)
			{
				a[i] = !a[i];
			}
			return a;
		}
		#endregion

		public static void InlineReplace(double[] a, double find, double replace)
		{
			int size = a.Length;
			for(int i=0; i<size; i++)
			{
				if (a[i] == find)
				{
					a[i] = replace;
				}
			}
		}
	}
}

