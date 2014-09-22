using System;
using System.Collections.Generic;

namespace YarrLib
{
	public class Slice<T> : IEnumerable<T>
	{
		private T[] BackingArray;
		private int StartIndex;
		public int Length { get; private set; }

		public Slice(T[] backingArray, int startIndex, int length)
		{
			if (startIndex + length > backingArray.Length)
			{
				throw new ArgumentException(string.Format(
					"Invalid slice: trying to slice past end of array (start:{0}, len:{1}, backingLength:{2}",
					startIndex, length, backingArray.Length
				));
			}

			this.BackingArray = backingArray;
			this.StartIndex = startIndex;
			this.Length = length;
		}

		public Slice(T[] backingArray)
			: this(backingArray, 0, backingArray.Length)
		{ }

		public T this[int index]
		{
			get { return this.BackingArray[this.StartIndex + index]; }
			set { this.BackingArray[this.StartIndex + index] = value; }
		}

		public Slice<T> MakeSlice(int start, int length)
		{
			return new Slice<T>(
				this.BackingArray,
				this.StartIndex + start,
				length
			);
		}

		#region IEnumerable implementation
		public IEnumerator<T> GetEnumerator()
		{
			for (int i=0; i<this.Length; i++)
			{
				yield return this[i];
			}
		}
		#endregion

		#region IEnumerable implementation
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			for (int i=0; i<this.Length; i++)
			{
				yield return this[i];
			}
		}
		#endregion
	}

	public static partial class ArrayExtensions
	{
		public static Slice<T> MakeSlice<T>(this T[] self, int start, int length)
		{
			return new Slice<T>(
				self,
				start,
				length
			);
		}
		public static Slice<T> MakeSlice<T>(this T[] self)
		{
			return new Slice<T>(
				self,
				0,
				self.Length
			);
		}
	}
}

