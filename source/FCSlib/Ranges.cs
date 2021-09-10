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


using FCSdata = FCSlib.Data;

namespace FCSlib {
  public static partial class Functional {
    public static FCSdata::Range<byte> Range(byte start, byte end) => FCSdata::Range.Create(start, end);

    public static Func<byte, FCSdata::Range<byte>> Range(byte start) => end => Range(start, end);

    public static FCSdata::Range<short> Range(short start, short end) => FCSdata::Range.Create(start, end);

    public static Func<short, FCSdata::Range<short>> Range(short start) => end => Range(start, end);

    public static FCSdata::Range<int> Range(int start, int end) => FCSdata::Range.Create(start, end);

    public static Func<int, FCSdata::Range<int>> Range(int start) => end => Range(start, end);

    public static FCSdata::Range<long> Range(long start, long end) => FCSdata::Range.Create(start, end);

    public static Func<long, FCSdata::Range<long>> Range(long start) => end => Range(start, end);

    public static FCSdata::Range<sbyte> Range(sbyte start, sbyte end) => FCSdata::Range.Create(start, end);

    public static Func<sbyte, FCSdata::Range<sbyte>> Range(sbyte start) => end => Range(start, end);

    public static FCSdata::Range<ushort> Range(ushort start, ushort end) => FCSdata::Range.Create(start, end);

    public static Func<ushort, FCSdata::Range<ushort>> Range(ushort start) => end => Range(start, end);

    public static FCSdata::Range<uint> Range(uint start, uint end) => FCSdata::Range.Create(start, end);

    public static Func<uint, FCSdata::Range<uint>> Range(uint start) => end => Range(start, end);

    public static FCSdata::Range<ulong> Range(ulong start, ulong end) => FCSdata::Range.Create(start, end);

    public static Func<ulong, FCSdata::Range<ulong>> Range(ulong start) => end => Range(start, end);

    public static FCSdata::Range<double> Range(double start, double end) => FCSdata::Range.Create(start, end);

    public static Func<double, FCSdata::Range<double>> Range(double start) => end => Range(start, end);

    public static FCSdata::Range<float> Range(float start, float end) => FCSdata::Range.Create(start, end);

    public static Func<float, FCSdata::Range<float>> Range(float start) => end => Range(start, end);

    public static FCSdata::Range<decimal> Range(decimal start, decimal end) => FCSdata::Range.Create(start, end);

    public static Func<decimal, FCSdata::Range<decimal>> Range(decimal start) => end => Range(start, end);

    public static FCSdata::Range<char> Range(char start, char end) => FCSdata::Range.Create(start, end);

    public static Func<char, FCSdata::Range<char>> Range(char start) => end => Range(start, end);

    public static FCSdata::Range<DateTime> Range(DateTime start, DateTime end) => FCSdata::Range.Create(start, end);

    public static Func<DateTime, FCSdata::Range<DateTime>> Range(DateTime start) => end => Range(start, end);

    public static FCSdata::Range<T> Range<T>(Comparison<T> compare, Func<T, T> getNext, T start, T end) => FCSdata::Range.Create(start, end, getNext, compare);

    public static Func<Func<T, T>, Func<T, Func<T, FCSdata::Range<T>>>> Range<T>(Comparison<T> compare) => getNext => start => end => Range(compare, getNext, start, end);

    public static FCSdata::Range<T> Range<T>(Func<T, T> getNext, T start, T end) => FCSdata::Range.Create(start, end, getNext);

    public static Func<T, Func<T, FCSdata::Range<T>>> Range<T>(Func<T, T> getNext) => start => end => Range(getNext, start, end);
  }
}
