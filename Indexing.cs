using System;
using System.Collections.Generic;

namespace YarrLib
{
	public static partial class Yarr
	{
		public static T[] Filter<T>(T[] source, bool[] filter)
		{
			int resultSize = Sum(filter);

			T[] result = new T[resultSize];
			int size = filter.Length;
			int resultIndex = 0;
			for (int i=0; i<size; i++)
			{
				if (filter[i])
				{
					result[resultIndex] = source[i];
					resultIndex++;
				}
			}
			return result;
		}

		/// <summary>
		/// <para>
		/// Given a source array and an array of indexes,
		/// pick those indexes out of the source array.
		/// </para>
		/// <para>
		/// Name from here:
		/// http://wesmckinney.com/blog/?p=215
		/// </para>
		/// </summary>
		public static T[] FancyIndex<T>(T[] source, int[] indices)
		{
			int size = indices.Length;
			var result = new T[size];
			for (int i=0; i<size; i++)
			{
				result[i] = source[indices[i]];
			}
			return result;
		}

		/// <summary>
		/// Returns the positions (indexes) of any values
		/// that were set to 'true'.
		/// </summary>
		public static int[] TruthIndices(bool[] a)
		{
			int resultSize = Sum(a);
			int[] result = new int[resultSize];

			int size = a.Length;
			int resultIndex = 0;
			for(int i=0; i<size; i++)
			{
				if (a[i])
				{
					result[resultIndex] = i;
					resultIndex++;
				}
			}
			return result;
		}
	}
}

