﻿// Copyright (C) 2008-2021 Oliver Sturm <oliver@oliversturm.com>
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using FCSlib.Data;
using FCSColl = FCSlib.Data.Collections;
using System.Linq.Expressions;

namespace FCSlib {
  public static partial class Functional {

    public static T?[] InitArray<T>(int length, Func<int, T> elementInit) {
      var array = Array.CreateInstance(typeof(T), length) as T?[];
      // Somehow C# thinks that array could be null at this point. Don't know how but let's catch it.
      if (array == null)
        throw new InvalidOperationException("Pray for your array!");
      for (int i = 0; i < length; i++)
        array[i] = elementInit(i);
      return array;
    }

    #region Standard higher order functions
    public static IEnumerable<R> Map<T, R>(Converter<T, R> function, IEnumerable<T> list) {
      foreach (T sourceVal in list)
        yield return function(sourceVal);
    }

    public static Func<Converter<T, R>, IEnumerable<T>, IEnumerable<R>> MapDelegate<T, R>() {
      return Map<T, R>;
    }

    public static IEnumerable<T> Filter<T>(Predicate<T> predicate, IEnumerable<T> list) {
      foreach (T val in list)
        if (predicate(val))
          yield return val;
    }

    public static Func<Predicate<T>, IEnumerable<T>, IEnumerable<T>> FilterDelegate<T>() {
      return Filter<T>;
    }

    public static R FoldL<T, R>(Func<R, T, R> accumulator, R startVal, IEnumerable<T> list) {
      R result = startVal;
      foreach (T sourceVal in list)
        result = accumulator(result, sourceVal);
      return result;
    }

    public static Func<Func<R, T, R>, R, IEnumerable<T>, R> FoldLDelegate<T, R>() {
      return FoldL<T, R>;
    }

    public static T FoldL1<T>(Func<T, T, T> accumulator, IEnumerable<T> list) {
      return FoldL(accumulator, First(list), Skip(1, list));
    }

    public static Func<Func<T, T, T>, IEnumerable<T>, T> FoldL1Delegate<T>() {
      return FoldL1<T>;
    }

    public static R FoldR<T, R>(Func<T, R, R> accumulator, R startVal, IEnumerable<T> list) {
      return FoldL((r, x) => accumulator(x, r), startVal, Functional.Reverse(list));
    }

    public static Func<Func<T, R, R>, R, IEnumerable<T>, R> FoldRDelegate<T, R>() {
      return FoldR<T, R>;
    }

    public static T FoldR1<T>(Func<T, T, T> accumulator, IEnumerable<T> list) {
      return FoldL1((r, x) => accumulator(x, r), Functional.Reverse(list));
    }

    public static Func<Func<T, T, T>, IEnumerable<T>, T> FoldR1Delegate<T>() {
      return FoldR1<T>;
    }
    #endregion

    #region Sequence helpers 
    public static IEnumerable<T> Reverse<T>(IEnumerable<T> source) {
      FCSColl::List<T> stack = FCSColl::List<T>.Empty;
      foreach (T item in source)
        stack = stack.Cons(item);
      while (stack != FCSColl.List<T>.Empty) {
        yield return stack.Head;
        stack = stack.Tail;
      }
    }

    public static Func<IEnumerable<T>, IEnumerable<T>> ReverseDelegate<T>() {
      return Reverse<T>;
    }

    public static T First<T>(this IEnumerable<T> source) {
      var enumerator = source.GetEnumerator();
      enumerator.MoveNext();
      return enumerator.Current;
    }

    public static Func<IEnumerable<T>, T> FirstDelegate<T>() {
      return First<T>;
    }

    public static IEnumerable<T> Take<T>(int count, IEnumerable<T> source) {
      int returned = 0;
      foreach (T item in source) {
        if (returned++ < count)
          yield return item;
        else
          yield break;
      }
    }

    public static Func<int, IEnumerable<T>, IEnumerable<T>> TakeDelegate<T>() {
      return Take<T>;
    }

    public static IEnumerable<T> TakeWhile<T>(Predicate<T> condition, IEnumerable<T> source) {
      foreach (T item in source) {
        if (condition(item))
          yield return item;
        else
          yield break;
      }
    }

    public static Func<Predicate<T>, IEnumerable<T>, IEnumerable<T>> TakeWhileDelegate<T>() {
      return TakeWhile<T>;
    }

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

    public static Func<int, IEnumerable<T>, IEnumerable<T>> SkipDelegate<T>() {
      return Skip<T>;
    }

    public static void Each<T>(this IEnumerable<T> source, Action<T> action) {
      foreach (var item in source)
        action(item);
    }

    public static Action<IEnumerable<T>, Action<T>> EachDelegate<T>() {
      return Each<T>;
    }

    public static void Each<T>(this IEnumerable<T> source, Action action) {
      foreach (var item in source)
        action();
    }

    public static IEnumerable<T> Concat<T>(IEnumerable<IEnumerable<T>> sequences) {
      foreach (IEnumerable<T> sequence in sequences)
        foreach (T item in sequence)
          yield return item;
    }

    public static IEnumerable<R> Collect<T, R>(Converter<T, IEnumerable<R>> converter, IEnumerable<T> list) {
      var listOfLists = Map(converter, list);
      return Concat(listOfLists);
    }
    #endregion

    #region Sequence function
    public static IEnumerable<T> Sequence<T>(Func<T, T> getNext, T startVal, Func<T, bool> endReached) {
      if (getNext == null)
        yield break;
      yield return startVal;
      T val = startVal;
      while (endReached == null || !endReached(val)) {
        val = getNext(val);
        yield return val;
      }
    }

    public static Func<Func<T, T>, T, Func<T, bool>, IEnumerable<T>> SequenceDelegate<T>() {
      return Sequence<T>;
    }
    #endregion

  }
}
