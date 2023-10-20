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

using FCSColl = FCSlib.Data.Collections;

namespace FCSlib {
  public static partial class Functional {
    public static IEnumerable<T> Reverse<T>(IEnumerable<T> source) {
      FCSColl::List<T> stack = FCSColl::List<T>.Empty;
      foreach (T item in source)
        stack = stack.Cons(item);
      while (stack != FCSColl.List<T>.Empty) {
        yield return stack.Head;
        stack = stack.Tail;
      }
    }

    public static Func<IEnumerable<T>, IEnumerable<T>> ReverseDelegate<T>() => Reverse<T>;

    public static T First<T>(IEnumerable<T> source) {
      var enumerator = source.GetEnumerator();
      enumerator.MoveNext();
      return enumerator.Current;
    }

    public static Func<IEnumerable<T>, T> FirstDelegate<T>() => First<T>;

    public static IEnumerable<T> Take<T>(int count, IEnumerable<T> source) {
      int returned = 0;
      foreach (T item in source) {
        if (returned++ < count)
          yield return item;
        else
          yield break;
      }
    }

    public static Func<int, IEnumerable<T>, IEnumerable<T>> TakeDelegate<T>() => Take<T>;

    public static IEnumerable<T> TakeWhile<T>(Predicate<T> condition, IEnumerable<T> source) {
      foreach (T item in source) {
        if (condition(item))
          yield return item;
        else
          yield break;
      }
    }

    public static Func<Predicate<T>, IEnumerable<T>, IEnumerable<T>> TakeWhileDelegate<T>() =>
      TakeWhile<T>;

    public static IEnumerable<T> Skip<T>(int count, IEnumerable<T> source) {
      int skipped = 0;
      foreach (T item in source) {
        if (skipped < count) {
          skipped++;
          continue;
        }

        yield return item;
      }
    }

    public static Func<int, IEnumerable<T>, IEnumerable<T>> SkipDelegate<T>() => Skip<T>;

    public static void Each<T>(IEnumerable<T> source, Action<T> action) {
      foreach (var item in source)
        action(item);
    }

    public static Action<IEnumerable<T>, Action<T>> EachDelegate<T>() => Each<T>;

    public static void Each<T>(IEnumerable<T> source, Action action) {
      foreach (var item in source)
        action();
    }

    public static IEnumerable<T> Concat<T>(IEnumerable<IEnumerable<T>> sequences) {
      foreach (IEnumerable<T> sequence in sequences)
      foreach (T item in sequence)
        yield return item;
    }

    public static IEnumerable<R> Collect<T, R>(Converter<T, IEnumerable<R>> converter,
      IEnumerable<T> list) {
      var listOfLists = Map(converter, list);
      return Concat(listOfLists);
    }
  }
}