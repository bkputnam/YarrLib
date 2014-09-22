using System;

namespace YarrLib
{
	public static partial class Yarr
	{
		#region Gtr
		public static bool[] Gtr(int[] a, int[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] > b[i];
			}
			return result;
		}
		public static bool[] Gtr(float[] a, float[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] > b[i];
			}
			return result;
		}
		public static bool[] Gtr(double[] a, double[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] > b[i];
			}
			return result;
		}
		#endregion

		#region Geq
		public static bool[] Geq(int[] a, int[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] >= b[i];
			}
			return result;
		}
		public static bool[] Geq(float[] a, float[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] >= b[i];
			}
			return result;
		}
		public static bool[] Geq(double[] a, double[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] >= b[i];
			}
			return result;
		}
		#endregion

		#region Lss
		public static bool[] Lss(int[] a, int[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] < b[i];
			}
			return result;
		}
		public static bool[] Lss(float[] a, float[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] < b[i];
			}
			return result;
		}
		public static bool[] Lss(double[] a, double[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] < b[i];
			}
			return result;
		}
		#endregion

		#region Geq
		public static bool[] Leq(int[] a, int[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] <= b[i];
			}
			return result;
		}
		public static bool[] Leq(float[] a, float[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] <= b[i];
			}
			return result;
		}
		public static bool[] Leq(double[] a, double[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] <= b[i];
			}
			return result;
		}
		#endregion

		#region Equ
		public static bool Equ(char[] a, char[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			bool result = true;
			for (int i=0; i<size; i++)
			{
				result &= (a[i] == b[i]);
			}
			return result;
		}
		#endregion

		#region Not
		public static bool[] Not(bool[] a)
		{
			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = !a[i];
			}
			return result;
		}
		#endregion

		public static bool[] And(bool[] a, bool[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] && b[i];
			}
			return result;
		}

		public static bool[] Or(bool[] a, bool[] b)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			bool[] result = new bool[size];
			for (int i=0; i<size; i++)
			{
				result[i] = a[i] || b[i];
			}
			return result;
		}
	}
}

