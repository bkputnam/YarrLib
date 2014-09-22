using System;

namespace YarrLib
{
	public static partial class Yarr
	{
		#region Log
		public static double[] Log(double[] a)
		{
			int size = a.Length;
			double[] result = new double[a.Length];
			for (int i=0; i<size; i++)
			{
				result[i] = Math.Log(a[i]);
			}
			return result;
		}
		public static double[] Log(double[] a, double newBase)
		{
			int size = a.Length;
			double[] result = new double[a.Length];
			for (int i=0; i<size; i++)
			{
				result[i] = Math.Log(a[i], newBase);
			}
			return result;
		}
		#endregion
	}
}

