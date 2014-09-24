using System;

namespace YarrLib
{
	public static partial class Yarr
	{
		#region add
		public static int[] Add(int[] a, int[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			int[] result = new int[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] + b[i];
			}

			return result;
		}

		public static int[] Add(int[] a, int b)
		{
			int size = a.Length;
			var result = new int[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] + b;
			}
			return result;
		}

		public static double[] Add(double[] a, double[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			double[] result = new double[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] + b[i];
			}

			return result;
		}

		public static double[] Add(double[] a, double b)
		{
			int size = a.Length;
			var result = new double[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] + b;
			}
			return result;
		}
		#endregion

		#region sub
		public static int[] Sub(int[] a, int[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			int[] result = new int[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] - b[i];
			}

			return result;
		}

		public static double[] Sub(double[] a, double[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			double[] result = new double[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] - b[i];
			}

			return result;
		}
		#endregion

		#region mul
		public static int[] Mul(int[] a, int[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			int[] result = new int[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] * b[i];
			}

			return result;
		}

		public static double[] Mul(double[] a, double[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			double[] result = new double[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] * b[i];
			}

			return result;
		}
		#endregion

		#region div
		public static int[] Div(int[] a, int[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			int[] result = new int[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] / b[i];
			}

			return result;
		}

		public static double[] Div(double[] a, double[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			double[] result = new double[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] / b[i];
			}

			return result;
		}
		#endregion

		#region CountWhere

		#endregion
	}
}

