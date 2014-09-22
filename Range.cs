using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace YarrLib
{
	public static partial class Yarr
	{
		#region XRange
		public static IEnumerable<int> XRange(int start, int stop, int inc)
		{
			for (int i=start; i<stop; i+=inc)
			{
				yield return i;
			}
		}
		public static IEnumerable<int> XRange(int start, int stop)
		{
			return XRange(start, stop, 1);
		}
		public static IEnumerable<int> XRange(int stop)
		{
			return XRange(0, stop);
		}

		public static IEnumerable<double> XRange(double start, double stop, double inc)
		{
			for (double i=start; i<stop; i+=inc)
			{
				yield return i;
			}
		}
		public static IEnumerable<double> XRange(double start, double stop)
		{
			return XRange(start, stop, 1.0);
		}
		public static IEnumerable<double> XRange(double stop)
		{
			return XRange(0.0, stop);
		}
		#endregion

		#region Range
		public static int[] Range(int start, int stop, int inc)
		{
			return XRange(start, stop, inc).ToArray();
		}
		public static int[] Range(int start, int stop)
		{
			return XRange(start, stop).ToArray();
		}
		public static int[] Range(int stop)
		{
			return XRange(stop).ToArray();
		}
		public static double[] Range(double start, double stop, double inc)
		{
			return XRange(start, stop, inc).ToArray();
		}
		public static double[] Range(double start, double stop)
		{
			return XRange(start, stop).ToArray();
		}
		public static double[] Range(double stop)
		{
			return XRange(stop).ToArray();
		}
		#endregion
	}
}

