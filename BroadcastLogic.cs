using System;

namespace YarrLib
{
	public static partial class Yarr
	{
		#region Equ
		public static bool[] Equ(double[] a, double b)
		{
			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] == b;
			}
			return result;
		}
		public static bool[] Equ(char[] a, char b)
		{
			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] == b;
			}
			return result;
		}
		#endregion

		#region Geq
		public static bool[] Geq(int[] a, int b)
		{
			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] > b;
			}
			return result;
		}
		public static bool[] Geq(long[] a, long b)
		{
			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] > b;
			}
			return result;
		}
		public static bool[] Geq(float[] a, float b)
		{
			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] > b;
			}
			return result;
		}
		public static bool[] Geq(double[] a, double b)
		{
			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] > b;
			}
			return result;
		}
		#endregion
	}
}

