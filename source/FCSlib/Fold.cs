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

// ReSharper disable All

namespace FCSlib {
  public static partial class Functional {
    public static R FoldL<T, R>(Func<R, T, R> accumulator, R startVal, IEnumerable<T> list) {
      R result = startVal;
      foreach (T sourceVal in list)
        result = accumulator(result, sourceVal);
      return result;
    }

    public static Func<Func<R, T, R>, R, IEnumerable<T>, R> FoldLDelegate<T, R>() => FoldL<T, R>;

    public static Func<R, Func<IEnumerable<T>, R>> FoldL<T, R>(Func<R, T, R> accumulator) =>
      startVal => list => FoldL(accumulator, startVal, list);

    public static T FoldL1<T>(Func<T, T, T> accumulator, IEnumerable<T> list) =>
      FoldL(accumulator, First(list), Skip(1, list));

    public static Func<Func<T, T, T>, IEnumerable<T>, T> FoldL1Delegate<T>() => FoldL1<T>;

    public static Func<IEnumerable<T>, T> FoldL1<T>(Func<T, T, T> accumulator) =>
      list => FoldL1(accumulator, list);

    public static R FoldR<T, R>(Func<T, R, R> accumulator, R startVal, IEnumerable<T> list) =>
      FoldL((r, x) => accumulator(x, r), startVal, Functional.Reverse(list));

    public static Func<Func<T, R, R>, R, IEnumerable<T>, R> FoldRDelegate<T, R>() => FoldR<T, R>;

    public static Func<R, Func<IEnumerable<T>, R>> FoldR<T, R>(Func<T, R, R> accumulator) =>
      startVal => list => FoldR(accumulator, startVal, list);

    public static T FoldR1<T>(Func<T, T, T> accumulator, IEnumerable<T> list) =>
      FoldL1((r, x) => accumulator(x, r), Functional.Reverse(list));

    public static Func<Func<T, T, T>, IEnumerable<T>, T> FoldR1Delegate<T>() => FoldR1<T>;

    public static Func<IEnumerable<T>, T> FoldR1<T>(Func<T, T, T> accumulator) =>
      list => FoldR1(accumulator, list);
  }
}