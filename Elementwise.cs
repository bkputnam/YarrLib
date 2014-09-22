using System;

namespace YarrLib
{
	public static partial class Yarr
	{
		public static T[] Elementwise<A, B, T>(A[] a, B[] b, Func<A, B, T> iter)
		{
			if (a.Length != b.Length)
			{
				throw new ArgumentException("The two arrays must have equal size");
			}

			int size = a.Length;
			var result = new T[size];
			for (int i=0; i<size; i++)
			{
				result[i] = iter(a[i], b[i]);
			}
			return result;
		}
	}
}

