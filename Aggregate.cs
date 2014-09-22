using System;

namespace YarrLib
{
	public static partial class Yarr
	{
		#region Sum
		public static int Sum(int[] a)
		{
			int result = 0;
			int size = a.Length;
			for (int i=0; i<size; i++)
			{
				result += a[i];
			}
			return result;
		}
		public static long Sum(long[] a)
		{
			long result = 0;
			int size = a.Length;
			for (int i=0; i<size; i++)
			{
				result += a[i];
			}
			return result;
		}
		public static float Sum(float[] a)
		{
			float result = 0;
			int size = a.Length;
			for (int i=0; i<size; i++)
			{
				result += a[i];
			}
			return result;
		}
		public static double Sum(double[] a)
		{
			double result = 0;
			int size = a.Length;
			for (int i=0; i<size; i++)
			{
				result += a[i];
			}
			return result;
		}
		public static int Sum(bool[] a)
		{
			int sum = 0;
			int size = a.Length;
			for (int i=0; i<size; i++)
			{
				if (a[i]) { sum++; }
			}
			return sum;
		}
		#endregion

		#region Mean
		public static float Mean(int[] a)
		{
			return ((float)Sum(a)) / a.Length;
		}
		public static double Mean(long[] a)
		{
			return ((double)Sum(a)) / a.Length;
		}
		public static float Mean(float[] a)
		{
			return Sum(a) / a.Length;
		}
		public static double Mean(double[] a)
		{
			return Sum(a) / a.Length;
		}
		#endregion

		#region GMean
		public static double GMean(double[] a)
		{
			int size = a.Length;

			double sum = 0.0;
			for (int i=0; i<size; i++)
			{
				sum += Math.Log(a[i]);
			}

			return Math.Exp((1.0 / a.Length) * sum);
		}
		#endregion
	}
}

