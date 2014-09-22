using System;

namespace YarrLib
{
	public static partial class Yarr
	{
		public static double Min(double[] a)
		{
			double min = double.PositiveInfinity;
			int size = a.Length;
			for (int i=0; i<size; i++)
			{
				if (a[i] < min)
				{
					min = a[i];
				}
			}
			return min;
		}

		public static double Max(double[] a)
		{
			double max = double.NegativeInfinity;
			int size = a.Length;
			for (int i=0; i<size; i++)
			{
				if (a[i] > max)
				{
					max = a[i];
				}
			}
			return max;
		}
	}
}

