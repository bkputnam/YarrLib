using System;
using System.Collections.Generic;

namespace YarrLib
{
	public static partial class Yarr
	{
		public static Random RNG = new Random();

		public static T[] Repeat<T>(T val, int repetitions)
		{
			var result = new T[repetitions];
			for (int i=0; i<repetitions; i++)
			{
				result[i] = val;
			}
			return result;
		}

		public static int[] Ones(int repetitions)
		{
			return Repeat<int>(1, repetitions);
		}

		public static int[] Zeros(int repetitions)
		{
			return Repeat<int>(0, repetitions);
		}

		public static int[] RandInts(int low, int high, int num)
		{
			int[] result = new int[num];
			for (int i=0; i<num; i++)
			{
				result[i] = RNG.Next(low, high);
			}
			return result;
		}

		public static double[] RandDoubles(int howMany)
		{
			double[] result = new double[howMany];
			for (int i=0; i<howMany; i++)
			{
				result[i] = RNG.NextDouble();
			}
			return result;
		}

		private static string PrintBytes(byte[] b)
		{
			string[] results = new string[b.Length];
			for(int i=0; i<b.Length; i++)
			{
				results[i] = Convert.ToString(b[i], 2).PadLeft(8, '0');
			}

			return string.Join(",", results);
		}

		public static bool[] RandBools(int num)
		{
			bool[] result = new bool[num];

			int numBytes = (int)Math.Ceiling(num / 8.0);
			byte[] randBytes = new byte[numBytes];
			RNG.NextBytes(randBytes);

			const byte ONE = 0x1;
			int resultIndex = 0;
			byte b;
			for(int byteIndex=0; byteIndex<numBytes-1; byteIndex++)
			{
				b = randBytes[byteIndex];
				for (int bitIndex=0; bitIndex<8; bitIndex++)
				{
					result[resultIndex] = (b & (ONE << bitIndex)) > 0x0;
					resultIndex++;
				}
			}

			int leftOverBits = num - (8 * (numBytes-1));
			b = randBytes[numBytes - 1];
			for (int bitIndex=0; bitIndex<leftOverBits; bitIndex++)
			{
				result[resultIndex] = (b & (ONE << bitIndex)) > 0x0;
				resultIndex++;
			}

			return result;
		}
	}
}

