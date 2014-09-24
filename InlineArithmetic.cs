using System;

namespace YarrLib
{
	public static partial class Yarr
	{
		public static int[] InlineAdd(int[] a, int b)
		{
			int size = a.Length;
			for (int i=0; i<size; i++)
			{
				a[i] += b;
			}
			return a; // for method chaining
		}

		public static double[] InlineAdd(double[] a, double b)
		{
			int size = a.Length;
			for (int i=0; i<size; i++)
			{
				a[i] += b;
			}
			return a; // for method chaining
		}
	}
}

