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
    #region Composition
    #region 2 functions
    public static Func<TSource, TEndResult> Compose<TSource, TIntermediateResult, TEndResult>(
      this Func<TSource, TIntermediateResult> func1, Func<TIntermediateResult, TEndResult> func2) {
      return sourceParam => func2(func1(sourceParam));
    }

    public static Func<T1, T2, TEndResult> Compose<T1, T2, TIntermediateResult, TEndResult>(
      this Func<T1, T2, TIntermediateResult> func1, Func<TIntermediateResult, TEndResult> func2) {
      return (p1, p2) => func2(func1(p1, p2));
    }

    public static Func<T1, T2, T3, TEndResult> Compose<T1, T2, T3, TIntermediateResult, TEndResult>(
      this Func<T1, T2, T3, TIntermediateResult> func1, Func<TIntermediateResult, TEndResult> func2) {
      return (p1, p2, p3) => func2(func1(p1, p2, p3));
    }

    public static Func<T1, T2, T3, T4, TEndResult> Compose<T1, T2, T3, T4, TIntermediateResult, TEndResult>(
      this Func<T1, T2, T3, T4, TIntermediateResult> func1, Func<TIntermediateResult, TEndResult> func2) {
      return (p1, p2, p3, p4) => func2(func1(p1, p2, p3, p4));
    }

    public static Func<T1, T2, T3, T4, T5, TEndResult> Compose<T1, T2, T3, T4, T5, TIntermediateResult, TEndResult>(
      this Func<T1, T2, T3, T4, T5, TIntermediateResult> func1, Func<TIntermediateResult, TEndResult> func2) {
      return (p1, p2, p3, p4, p5) => func2(func1(p1, p2, p3, p4, p5));
    }

    public static Func<T1, T2, T3, T4, T5, T6, TEndResult> Compose<T1, T2, T3, T4, T5, T6, TIntermediateResult, TEndResult>(
      this Func<T1, T2, T3, T4, T5, T6, TIntermediateResult> func1, Func<TIntermediateResult, TEndResult> func2) {
      return (p1, p2, p3, p4, p5, p6) => func2(func1(p1, p2, p3, p4, p5, p6));
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, TEndResult> Compose<T1, T2, T3, T4, T5, T6, T7, TIntermediateResult, TEndResult>(
      this Func<T1, T2, T3, T4, T5, T6, T7, TIntermediateResult> func1, Func<TIntermediateResult, TEndResult> func2) {
      return (p1, p2, p3, p4, p5, p6, p7) => func2(func1(p1, p2, p3, p4, p5, p6, p7));
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TEndResult> Compose<T1, T2, T3, T4, T5, T6, T7, T8, TIntermediateResult, TEndResult>(
      this Func<T1, T2, T3, T4, T5, T6, T7, T8, TIntermediateResult> func1, Func<TIntermediateResult, TEndResult> func2) {
      return (p1, p2, p3, p4, p5, p6, p7, p8) => func2(func1(p1, p2, p3, p4, p5, p6, p7, p8));
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TEndResult> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIntermediateResult, TEndResult>(
      this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIntermediateResult> func1, Func<TIntermediateResult, TEndResult> func2) {
      return (p1, p2, p3, p4, p5, p6, p7, p8, p9) => func2(func1(p1, p2, p3, p4, p5, p6, p7, p8, p9));
    }
    #endregion

    #region 3 functions
    public static Func<TSource, TEndResult> Compose<TSource, TIR1, TIR2, TEndResult>(
      Func<TSource, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TEndResult> func3) {
      return sourceParam => func3(func2(func1(sourceParam)));
    }

    public static Func<T1, T2, TEndResult> Compose<T1, T2, TIR1, TIR2, TEndResult>(
      this Func<T1, T2, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TEndResult> func3) {
      return (p1, p2) => func3(func2(func1(p1, p2)));
    }

    public static Func<T1, T2, T3, TEndResult> Compose<T1, T2, T3, TIR1, TIR2, TEndResult>(
      this Func<T1, T2, T3, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TEndResult> func3) {
      return (p1, p2, p3) => func3(func2(func1(p1, p2, p3)));
    }

    public static Func<T1, T2, T3, T4, TEndResult> Compose<T1, T2, T3, T4, TIR1, TIR2, TEndResult>(
      this Func<T1, T2, T3, T4, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TEndResult> func3) {
      return (p1, p2, p3, p4) => func3(func2(func1(p1, p2, p3, p4)));
    }

    public static Func<T1, T2, T3, T4, T5, TEndResult> Compose<T1, T2, T3, T4, T5, TIR1, TIR2, TEndResult>(
      this Func<T1, T2, T3, T4, T5, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TEndResult> func3) {
      return (p1, p2, p3, p4, p5) => func3(func2(func1(p1, p2, p3, p4, p5)));
    }

    public static Func<T1, T2, T3, T4, T5, T6, TEndResult> Compose<T1, T2, T3, T4, T5, T6, TIR1, TIR2, TEndResult>(
      this Func<T1, T2, T3, T4, T5, T6, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TEndResult> func3) {
      return (p1, p2, p3, p4, p5, p6) => func3(func2(func1(p1, p2, p3, p4, p5, p6)));
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, TEndResult> Compose<T1, T2, T3, T4, T5, T6, T7, TIR1, TIR2, TEndResult>(
      this Func<T1, T2, T3, T4, T5, T6, T7, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TEndResult> func3) {
      return (p1, p2, p3, p4, p5, p6, p7) => func3(func2(func1(p1, p2, p3, p4, p5, p6, p7)));
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TEndResult> Compose<T1, T2, T3, T4, T5, T6, T7, T8, TIR1, TIR2, TEndResult>(
      this Func<T1, T2, T3, T4, T5, T6, T7, T8, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TEndResult> func3) {
      return (p1, p2, p3, p4, p5, p6, p7, p8) => func3(func2(func1(p1, p2, p3, p4, p5, p6, p7, p8)));
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TEndResult> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIR1, TIR2, TEndResult>(
      this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TEndResult> func3) {
      return (p1, p2, p3, p4, p5, p6, p7, p8, p9) => func3(func2(func1(p1, p2, p3, p4, p5, p6, p7, p8, p9)));
    }

    #endregion

    #region 4 functions
    public static Func<TSource, TEndResult> Compose<TSource, TIR1, TIR2, TIR3, TEndResult>(
      Func<TSource, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TEndResult> func4) {
      return sourceParam => func4(func3(func2(func1(sourceParam))));
    }

    public static Func<T1, T2, TEndResult> Compose<T1, T2, TIR1, TIR2, TIR3, TEndResult>(
      this Func<T1, T2, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TEndResult> func4) {
      return (p1, p2) => func4(func3(func2(func1(p1, p2))));
    }

    public static Func<T1, T2, T3, TEndResult> Compose<T1, T2, T3, TIR1, TIR2, TIR3, TEndResult>(
      this Func<T1, T2, T3, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TEndResult> func4) {
      return (p1, p2, p3) => func4(func3(func2(func1(p1, p2, p3))));
    }

    public static Func<T1, T2, T3, T4, TEndResult> Compose<T1, T2, T3, T4, TIR1, TIR2, TIR3, TEndResult>(
      this Func<T1, T2, T3, T4, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TEndResult> func4) {
      return (p1, p2, p3, p4) => func4(func3(func2(func1(p1, p2, p3, p4))));
    }

    public static Func<T1, T2, T3, T4, T5, TEndResult> Compose<T1, T2, T3, T4, T5, TIR1, TIR2, TIR3, TEndResult>(
      this Func<T1, T2, T3, T4, T5, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TEndResult> func4) {
      return (p1, p2, p3, p4, p5) => func4(func3(func2(func1(p1, p2, p3, p4, p5))));
    }

    public static Func<T1, T2, T3, T4, T5, T6, TEndResult> Compose<T1, T2, T3, T4, T5, T6, TIR1, TIR2, TIR3, TEndResult>(
      this Func<T1, T2, T3, T4, T5, T6, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TEndResult> func4) {
      return (p1, p2, p3, p4, p5, p6) => func4(func3(func2(func1(p1, p2, p3, p4, p5, p6))));
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, TEndResult> Compose<T1, T2, T3, T4, T5, T6, T7, TIR1, TIR2, TIR3, TEndResult>(
      this Func<T1, T2, T3, T4, T5, T6, T7, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TEndResult> func4) {
      return (p1, p2, p3, p4, p5, p6, p7) => func4(func3(func2(func1(p1, p2, p3, p4, p5, p6, p7))));
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TEndResult> Compose<T1, T2, T3, T4, T5, T6, T7, T8, TIR1, TIR2, TIR3, TEndResult>(
      this Func<T1, T2, T3, T4, T5, T6, T7, T8, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TEndResult> func4) {
      return (p1, p2, p3, p4, p5, p6, p7, p8) => func4(func3(func2(func1(p1, p2, p3, p4, p5, p6, p7, p8))));
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TEndResult> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIR1, TIR2, TIR3, TEndResult>(
      this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TEndResult> func4) {
      return (p1, p2, p3, p4, p5, p6, p7, p8, p9) => func4(func3(func2(func1(p1, p2, p3, p4, p5, p6, p7, p8, p9))));
    }

    #endregion

    #region 5 functions
    public static Func<TSource, TEndResult> Compose<TSource, TIR1, TIR2, TIR3, TIR4, TEndResult>(
      Func<TSource, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Func<TIR4, TEndResult> func5) {
      return sourceParam => func5(func4(func3(func2(func1(sourceParam)))));
    }

    public static Func<T1, T2, TEndResult> Compose<T1, T2, TIR1, TIR2, TIR3, TIR4, TEndResult>(
      this Func<T1, T2, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Func<TIR4, TEndResult> func5) {
      return (p1, p2) => func5(func4(func3(func2(func1(p1, p2)))));
    }

    public static Func<T1, T2, T3, TEndResult> Compose<T1, T2, T3, TIR1, TIR2, TIR3, TIR4, TEndResult>(
      this Func<T1, T2, T3, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Func<TIR4, TEndResult> func5) {
      return (p1, p2, p3) => func5(func4(func3(func2(func1(p1, p2, p3)))));
    }

    public static Func<T1, T2, T3, T4, TEndResult> Compose<T1, T2, T3, T4, TIR1, TIR2, TIR3, TIR4, TEndResult>(
      this Func<T1, T2, T3, T4, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Func<TIR4, TEndResult> func5) {
      return (p1, p2, p3, p4) => func5(func4(func3(func2(func1(p1, p2, p3, p4)))));
    }

    public static Func<T1, T2, T3, T4, T5, TEndResult> Compose<T1, T2, T3, T4, T5, TIR1, TIR2, TIR3, TIR4, TEndResult>(
      this Func<T1, T2, T3, T4, T5, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Func<TIR4, TEndResult> func5) {
      return (p1, p2, p3, p4, p5) => func5(func4(func3(func2(func1(p1, p2, p3, p4, p5)))));
    }

    public static Func<T1, T2, T3, T4, T5, T6, TEndResult> Compose<T1, T2, T3, T4, T5, T6, TIR1, TIR2, TIR3, TIR4, TEndResult>(
      this Func<T1, T2, T3, T4, T5, T6, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Func<TIR4, TEndResult> func5) {
      return (p1, p2, p3, p4, p5, p6) => func5(func4(func3(func2(func1(p1, p2, p3, p4, p5, p6)))));
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, TEndResult> Compose<T1, T2, T3, T4, T5, T6, T7, TIR1, TIR2, TIR3, TIR4, TEndResult>(
      this Func<T1, T2, T3, T4, T5, T6, T7, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Func<TIR4, TEndResult> func5) {
      return (p1, p2, p3, p4, p5, p6, p7) => func5(func4(func3(func2(func1(p1, p2, p3, p4, p5, p6, p7)))));
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TEndResult> Compose<T1, T2, T3, T4, T5, T6, T7, T8, TIR1, TIR2, TIR3, TIR4, TEndResult>(
      this Func<T1, T2, T3, T4, T5, T6, T7, T8, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Func<TIR4, TEndResult> func5) {
      return (p1, p2, p3, p4, p5, p6, p7, p8) => func5(func4(func3(func2(func1(p1, p2, p3, p4, p5, p6, p7, p8)))));
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TEndResult> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIR1, TIR2, TIR3, TIR4, TEndResult>(
      this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Func<TIR4, TEndResult> func5) {
      return (p1, p2, p3, p4, p5, p6, p7, p8, p9) => func5(func4(func3(func2(func1(p1, p2, p3, p4, p5, p6, p7, p8, p9)))));
    }
    #endregion

    #region 1 function, 1 action
    public static Action<TSource> Compose<TSource, TIntermediateResult>(
      this Func<TSource, TIntermediateResult> func1, Action<TIntermediateResult> action) {
      return sourceParam => action(func1(sourceParam));
    }

    public static Action<T1, T2> Compose<T1, T2, TIntermediateResult>(
      this Func<T1, T2, TIntermediateResult> func1, Action<TIntermediateResult> action) {
      return (p1, p2) => action(func1(p1, p2));
    }

    public static Action<T1, T2, T3> Compose<T1, T2, T3, TIntermediateResult>(
      this Func<T1, T2, T3, TIntermediateResult> func1, Action<TIntermediateResult> action) {
      return (p1, p2, p3) => action(func1(p1, p2, p3));
    }

    public static Action<T1, T2, T3, T4> Compose<T1, T2, T3, T4, TIntermediateResult>(
      this Func<T1, T2, T3, T4, TIntermediateResult> func1, Action<TIntermediateResult> action) {
      return (p1, p2, p3, p4) => action(func1(p1, p2, p3, p4));
    }

    public static Action<T1, T2, T3, T4, T5> Compose<T1, T2, T3, T4, T5, TIntermediateResult>(
      this Func<T1, T2, T3, T4, T5, TIntermediateResult> func1, Action<TIntermediateResult> action) {
      return (p1, p2, p3, p4, p5) => action(func1(p1, p2, p3, p4, p5));
    }

    public static Action<T1, T2, T3, T4, T5, T6> Compose<T1, T2, T3, T4, T5, T6, TIntermediateResult>(
      this Func<T1, T2, T3, T4, T5, T6, TIntermediateResult> func1, Action<TIntermediateResult> action) {
      return (p1, p2, p3, p4, p5, p6) => action(func1(p1, p2, p3, p4, p5, p6));
    }

    public static Action<T1, T2, T3, T4, T5, T6, T7> Compose<T1, T2, T3, T4, T5, T6, T7, TIntermediateResult>(
      this Func<T1, T2, T3, T4, T5, T6, T7, TIntermediateResult> func1, Action<TIntermediateResult> action) {
      return (p1, p2, p3, p4, p5, p6, p7) => action(func1(p1, p2, p3, p4, p5, p6, p7));
    }

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8> Compose<T1, T2, T3, T4, T5, T6, T7, T8, TIntermediateResult>(
      this Func<T1, T2, T3, T4, T5, T6, T7, T8, TIntermediateResult> func1, Action<TIntermediateResult> action) {
      return (p1, p2, p3, p4, p5, p6, p7, p8) => action(func1(p1, p2, p3, p4, p5, p6, p7, p8));
    }

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIntermediateResult>(
      this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIntermediateResult> func1, Action<TIntermediateResult> action) {
      return (p1, p2, p3, p4, p5, p6, p7, p8, p9) => action(func1(p1, p2, p3, p4, p5, p6, p7, p8, p9));
    }
    #endregion

    #region 2 functions, 1 action
    public static Action<TSource> Compose<TSource, TIR1, TIR2>(
      Func<TSource, TIR1> func1, Func<TIR1, TIR2> func2, Action<TIR2> action) {
      return sourceParam => action(func2(func1(sourceParam)));
    }

    public static Action<T1, T2> Compose<T1, T2, TIR1, TIR2>(
      this Func<T1, T2, TIR1> func1, Func<TIR1, TIR2> func2, Action<TIR2> action) {
      return (p1, p2) => action(func2(func1(p1, p2)));
    }

    public static Action<T1, T2, T3> Compose<T1, T2, T3, TIR1, TIR2>(
      this Func<T1, T2, T3, TIR1> func1, Func<TIR1, TIR2> func2, Action<TIR2> action) {
      return (p1, p2, p3) => action(func2(func1(p1, p2, p3)));
    }

    public static Action<T1, T2, T3, T4> Compose<T1, T2, T3, T4, TIR1, TIR2>(
      this Func<T1, T2, T3, T4, TIR1> func1, Func<TIR1, TIR2> func2, Action<TIR2> action) {
      return (p1, p2, p3, p4) => action(func2(func1(p1, p2, p3, p4)));
    }

    public static Action<T1, T2, T3, T4, T5> Compose<T1, T2, T3, T4, T5, TIR1, TIR2>(
      this Func<T1, T2, T3, T4, T5, TIR1> func1, Func<TIR1, TIR2> func2, Action<TIR2> action) {
      return (p1, p2, p3, p4, p5) => action(func2(func1(p1, p2, p3, p4, p5)));
    }

    public static Action<T1, T2, T3, T4, T5, T6> Compose<T1, T2, T3, T4, T5, T6, TIR1, TIR2>(
      this Func<T1, T2, T3, T4, T5, T6, TIR1> func1, Func<TIR1, TIR2> func2, Action<TIR2> action) {
      return (p1, p2, p3, p4, p5, p6) => action(func2(func1(p1, p2, p3, p4, p5, p6)));
    }

    public static Action<T1, T2, T3, T4, T5, T6, T7> Compose<T1, T2, T3, T4, T5, T6, T7, TIR1, TIR2>(
      this Func<T1, T2, T3, T4, T5, T6, T7, TIR1> func1, Func<TIR1, TIR2> func2, Action<TIR2> action) {
      return (p1, p2, p3, p4, p5, p6, p7) => action(func2(func1(p1, p2, p3, p4, p5, p6, p7)));
    }

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8> Compose<T1, T2, T3, T4, T5, T6, T7, T8, TIR1, TIR2>(
      this Func<T1, T2, T3, T4, T5, T6, T7, T8, TIR1> func1, Func<TIR1, TIR2> func2, Action<TIR2> action) {
      return (p1, p2, p3, p4, p5, p6, p7, p8) => action(func2(func1(p1, p2, p3, p4, p5, p6, p7, p8)));
    }

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIR1, TIR2>(
      this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIR1> func1, Func<TIR1, TIR2> func2, Action<TIR2> action) {
      return (p1, p2, p3, p4, p5, p6, p7, p8, p9) => action(func2(func1(p1, p2, p3, p4, p5, p6, p7, p8, p9)));
    }

    #endregion

    #region 3 functions, 1 action
    public static Action<TSource> Compose<TSource, TIR1, TIR2, TIR3>(
      Func<TSource, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Action<TIR3> action) {
      return sourceParam => action(func3(func2(func1(sourceParam))));
    }

    public static Action<T1, T2> Compose<T1, T2, TIR1, TIR2, TIR3>(
      this Func<T1, T2, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Action<TIR3> action) {
      return (p1, p2) => action(func3(func2(func1(p1, p2))));
    }

    public static Action<T1, T2, T3> Compose<T1, T2, T3, TIR1, TIR2, TIR3>(
      this Func<T1, T2, T3, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Action<TIR3> action) {
      return (p1, p2, p3) => action(func3(func2(func1(p1, p2, p3))));
    }

    public static Action<T1, T2, T3, T4> Compose<T1, T2, T3, T4, TIR1, TIR2, TIR3>(
      this Func<T1, T2, T3, T4, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Action<TIR3> action) {
      return (p1, p2, p3, p4) => action(func3(func2(func1(p1, p2, p3, p4))));
    }

    public static Action<T1, T2, T3, T4, T5> Compose<T1, T2, T3, T4, T5, TIR1, TIR2, TIR3>(
      this Func<T1, T2, T3, T4, T5, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Action<TIR3> action) {
      return (p1, p2, p3, p4, p5) => action(func3(func2(func1(p1, p2, p3, p4, p5))));
    }

    public static Action<T1, T2, T3, T4, T5, T6> Compose<T1, T2, T3, T4, T5, T6, TIR1, TIR2, TIR3>(
      this Func<T1, T2, T3, T4, T5, T6, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Action<TIR3> action) {
      return (p1, p2, p3, p4, p5, p6) => action(func3(func2(func1(p1, p2, p3, p4, p5, p6))));
    }

    public static Action<T1, T2, T3, T4, T5, T6, T7> Compose<T1, T2, T3, T4, T5, T6, T7, TIR1, TIR2, TIR3>(
      this Func<T1, T2, T3, T4, T5, T6, T7, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Action<TIR3> action) {
      return (p1, p2, p3, p4, p5, p6, p7) => action(func3(func2(func1(p1, p2, p3, p4, p5, p6, p7))));
    }

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8> Compose<T1, T2, T3, T4, T5, T6, T7, T8, TIR1, TIR2, TIR3>(
      this Func<T1, T2, T3, T4, T5, T6, T7, T8, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Action<TIR3> action) {
      return (p1, p2, p3, p4, p5, p6, p7, p8) => action(func3(func2(func1(p1, p2, p3, p4, p5, p6, p7, p8))));
    }

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIR1, TIR2, TIR3>(
      this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Action<TIR3> action) {
      return (p1, p2, p3, p4, p5, p6, p7, p8, p9) => action(func3(func2(func1(p1, p2, p3, p4, p5, p6, p7, p8, p9))));
    }

    #endregion

    #region 4 functions, 1 action
    public static Action<TSource> Compose<TSource, TIR1, TIR2, TIR3, TIR4>(
      Func<TSource, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Action<TIR4> action) {
      return sourceParam => action(func4(func3(func2(func1(sourceParam)))));
    }

    public static Action<T1, T2> Compose<T1, T2, TIR1, TIR2, TIR3, TIR4>(
      this Func<T1, T2, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Action<TIR4> action) {
      return (p1, p2) => action(func4(func3(func2(func1(p1, p2)))));
    }

    public static Action<T1, T2, T3> Compose<T1, T2, T3, TIR1, TIR2, TIR3, TIR4>(
      this Func<T1, T2, T3, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Action<TIR4> action) {
      return (p1, p2, p3) => action(func4(func3(func2(func1(p1, p2, p3)))));
    }

    public static Action<T1, T2, T3, T4> Compose<T1, T2, T3, T4, TIR1, TIR2, TIR3, TIR4>(
      this Func<T1, T2, T3, T4, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Action<TIR4> action) {
      return (p1, p2, p3, p4) => action(func4(func3(func2(func1(p1, p2, p3, p4)))));
    }

    public static Action<T1, T2, T3, T4, T5> Compose<T1, T2, T3, T4, T5, TIR1, TIR2, TIR3, TIR4>(
      this Func<T1, T2, T3, T4, T5, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Action<TIR4> action) {
      return (p1, p2, p3, p4, p5) => action(func4(func3(func2(func1(p1, p2, p3, p4, p5)))));
    }

    public static Action<T1, T2, T3, T4, T5, T6> Compose<T1, T2, T3, T4, T5, T6, TIR1, TIR2, TIR3, TIR4>(
      this Func<T1, T2, T3, T4, T5, T6, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Action<TIR4> action) {
      return (p1, p2, p3, p4, p5, p6) => action(func4(func3(func2(func1(p1, p2, p3, p4, p5, p6)))));
    }

    public static Action<T1, T2, T3, T4, T5, T6, T7> Compose<T1, T2, T3, T4, T5, T6, T7, TIR1, TIR2, TIR3, TIR4>(
      this Func<T1, T2, T3, T4, T5, T6, T7, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Action<TIR4> action) {
      return (p1, p2, p3, p4, p5, p6, p7) => action(func4(func3(func2(func1(p1, p2, p3, p4, p5, p6, p7)))));
    }

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8> Compose<T1, T2, T3, T4, T5, T6, T7, T8, TIR1, TIR2, TIR3, TIR4>(
      this Func<T1, T2, T3, T4, T5, T6, T7, T8, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Action<TIR4> action) {
      return (p1, p2, p3, p4, p5, p6, p7, p8) => action(func4(func3(func2(func1(p1, p2, p3, p4, p5, p6, p7, p8)))));
    }

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIR1, TIR2, TIR3, TIR4>(
      this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIR1> func1, Func<TIR1, TIR2> func2, Func<TIR2, TIR3> func3, Func<TIR3, TIR4> func4, Action<TIR4> action) {
      return (p1, p2, p3, p4, p5, p6, p7, p8, p9) => action(func4(func3(func2(func1(p1, p2, p3, p4, p5, p6, p7, p8, p9)))));
    }
    #endregion

    #endregion
  }
}
