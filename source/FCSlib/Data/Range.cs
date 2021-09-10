// Copyright (C) 2008-2021 Oliver Sturm <oliver@oliversturm.com>
//
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 3 of the License, or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, see <http://www.gnu.org/licenses/>.

using System.Collections;

namespace FCSlib.Data {
  public static class Range {
    private static byte GetNext(byte val) => (byte)(val + 1);
    private static short GetNext(short val) => (short)(val + 1);
    private static int GetNext(int val) => val + 1;
    private static long GetNext(long val) => val + 1;
    private static sbyte GetNext(sbyte val) => (sbyte)(val + 1);
    private static ushort GetNext(ushort val) => (ushort)(val + 1);
    private static uint GetNext(uint val) => val + 1;
    private static ulong GetNext(ulong val) => val + 1;
    private static double GetNext(double val) => val + 1;
    private static float GetNext(float val) => val + 1;
    private static decimal GetNext(decimal val) => val + 1;
    private static DateTime GetNext(DateTime val) => val.AddDays(1);
    private static char GetNext(char val) => (char)(val + 1);

    public static Range<byte> Create(byte start, byte end) =>
      new(start, end, GetNext);

    public static Range<short> Create(short start, short end) =>
      new(start, end, GetNext);

    public static Range<int> Create(int start, int end) =>
      new(start, end, GetNext);

    public static Range<long> Create(long start, long end) =>
      new(start, end, GetNext);

    public static Range<sbyte> Create(sbyte start, sbyte end) =>
      new(start, end, GetNext);

    public static Range<ushort> Create(ushort start, ushort end) =>
      new(start, end, GetNext);

    public static Range<uint> Create(uint start, uint end) =>
      new(start, end, GetNext);

    public static Range<ulong> Create(ulong start, ulong end) =>
      new(start, end, GetNext);

    public static Range<double> Create(double start, double end) =>
      new(start, end, GetNext);

    public static Range<float> Create(float start, float end) =>
      new(start, end, GetNext);

    public static Range<decimal> Create(decimal start, decimal end) =>
      new(start, end, GetNext);

    public static Range<char> Create(char start, char end) =>
      new(start, end, GetNext);

    public static Range<DateTime> Create(DateTime start, DateTime end) =>
      new(start, end, GetNext);

    public static Range<T> Create<T>(T start, T end, Func<T, T> getNext, Comparison<T> compare) =>
      new(start, end, getNext, compare);

    public static Range<T> Create<T>(T start, T end, Func<T, T> getNext) =>
      new(start, end, getNext);

  }

  public class Range<T> : IRange<T> {
    public Range(T start, T end, Func<T, T> getNext, Comparison<T> compare) {
      this.Start = start;
      this.End = end;
      this.compare = compare;
      this.sequence = Functional.Sequence<T>(getNext, start, v => compare(getNext(v), end) > 0);
    }

    public Range(T start, T end, Func<T, T> getNext) : this(start, end, getNext, Compare) { }

    private static int Compare<U>(U one, U other) =>
      Comparer<U>.Default.Compare(one, other);

    readonly Comparison<T> compare;
    readonly IEnumerable<T> sequence;

    public T Start { get; init; }
    public T End { get; init; }

    public bool Contains(T value) =>
      compare(value, Start) >= 0 && compare(End, value) >= 0;

    IEnumerator<T> IEnumerable<T>.GetEnumerator() => sequence.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<T>)this).GetEnumerator();
  }
}
