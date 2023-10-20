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
    #region Currying

    public static Func<T1, Func<T2, TR>> Curry<T1, T2, TR>(Func<T1, T2, TR> func) =>
      p1 => p2 => func(p1, p2);

    public static Func<T1, Func<T2, Func<T3, TR>>>
      Curry<T1, T2, T3, TR>(Func<T1, T2, T3, TR> func) =>
      p1 => p2 => p3 => func(p1, p2, p3);

    public static Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> Curry<T1, T2, T3, T4, TR>(
      Func<T1, T2, T3, T4, TR> func) =>
      p1 => p2 => p3 => p4 => func(p1, p2, p3, p4);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>>
      Curry<T1, T2, T3, T4, T5, TR>(Func<T1, T2, T3, T4, T5, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => func(p1, p2, p3, p4, p5);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>> Curry<T1, T2, T3,
      T4, T5, T6, TR>(Func<T1, T2, T3, T4, T5, T6, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => func(p1, p2, p3, p4, p5, p6);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TR>>>>>>> Curry<T1,
      T2, T3, T4, T5, T6, T7, TR>(Func<T1, T2, T3, T4, T5, T6, T7, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => func(p1, p2, p3, p4, p5, p6, p7);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TR>>>>>>>>
      Curry<T1, T2, T3, T4, T5, T6, T7, T8, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => func(p1, p2, p3, p4, p5, p6, p7, p8);

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TR>>>>>>>>>
      Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> func) =>
      p1 => p2 => p3 =>
        p4 => p5 => p6 => p7 => p8 => p9 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9);

    public static
      Func<T1, Func<T2, Func<T3,
        Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TR>>>>>>>>>> Curry<T1, T2,
        T3, T4, T5, T6, T7, T8, T9, T10,
        TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TR> func) =>
      p1 => p2 => p3 => p4 => p5 =>
        p6 => p7 => p8 => p9 => p10 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);

    public static
      Func<T1, Func<T2, Func<T3, Func<T4,
        Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TR>>>>>>>>>>> Curry<T1, T2,
        T3, T4, T5, T6, T7, T8, T9, T10, T11, TR>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 =>
        p8 => p9 => p10 => p11 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5,
        Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TR>>>>>>>>>>>> Curry<T1,
        T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TR>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 =>
        p10 => p11 => p12 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6,
        Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TR>>>>>>>>>>>>> Curry<T1,
        T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TR>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 =>
        p11 => p12 => p13 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7,
        Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TR>>>>>>>>>>>>>> Curry<
        T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TR>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 =>
        p13 => p14 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8,
        Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TR>>>>>>>>>>>>>>>
      Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TR>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 =>
        p13 => p14 => p15 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8,
        Func<T9, Func<T10,
          Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TR>>>>>>>>>>>>>>>> Curry<T1,
        T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TR>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 =>
        p13 => p14 => p15 => p16 =>
          func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);

    public static Func<T1, Action<T2>> Curry<T1, T2>(Action<T1, T2> action) =>
      p1 => p2 => action(p1, p2);

    public static Func<T1, Func<T2, Action<T3>>> Curry<T1, T2, T3>(Action<T1, T2, T3> action) =>
      p1 => p2 => p3 => action(p1, p2, p3);

    public static Func<T1, Func<T2, Func<T3, Action<T4>>>> Curry<T1, T2, T3, T4>(
      Action<T1, T2, T3, T4> action) =>
      p1 => p2 => p3 => p4 => action(p1, p2, p3, p4);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> Curry<T1, T2, T3, T4, T5>(
      Action<T1, T2, T3, T4, T5> action) =>
      p1 => p2 => p3 => p4 => p5 => action(p1, p2, p3, p4, p5);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>> Curry<T1, T2, T3, T4,
      T5, T6>(Action<T1, T2, T3, T4, T5, T6> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => action(p1, p2, p3, p4, p5, p6);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>> Curry<T1,
      T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => action(p1, p2, p3, p4, p5, p6, p7);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>>
      Curry<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => action(p1, p2, p3, p4, p5, p6, p7, p8);

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>>
      Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action) =>
      p1 => p2 => p3 =>
        p4 => p5 => p6 => p7 => p8 => p9 => action(p1, p2, p3, p4, p5, p6, p7, p8, p9);

    public static
      Func<T1, Func<T2,
        Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Action<T10>>>>>>>>>>
      Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action) =>
      p1 => p2 => p3 => p4 => p5 =>
        p6 => p7 => p8 => p9 => p10 => action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);

    public static
      Func<T1, Func<T2, Func<T3,
        Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Action<T11>>>>>>>>>>>
      Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 =>
        p8 => p9 => p10 => p11 => action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5,
        Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Action<T12>>>>>>>>>>>> Curry<T1, T2,
        T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 =>
        p10 => p11 => p12 => action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6,
        Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Action<T13>>>>>>>>>>>>> Curry<T1,
        T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 =>
        p12 => p13 => action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7,
        Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Action<T14>>>>>>>>>>>>>> Curry<T1,
        T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 =>
        p13 => p14 => action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8,
        Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Action<T15>>>>>>>>>>>>>>> Curry<
        T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 =>
        p13 => p14 =>
          p15 => action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8,
        Func<T9, Func<T10,
          Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Action<T16>>>>>>>>>>>>>>>> Curry<T1, T2,
        T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 =>
        p13 => p14 => p15 => p16 =>
          action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);


    public static Func<T2, Func<T1, R>> Swap<T1, T2, R>(Func<T1, Func<T2, R>> func) =>
      p2 => p1 => func(p1)(p2);

    #endregion

    #region Uncurrying

    public static Func<T1, T2, TR> Uncurry<T1, T2, TR>(Func<T1, Func<T2, TR>> func) =>
      (p1, p2) => func(p1)(p2);

    public static Func<T1, T2, T3, TR> Uncurry<T1, T2, T3, TR>(
      Func<T1, Func<T2, Func<T3, TR>>> func) =>
      (p1, p2, p3) => func(p1)(p2)(p3);

    public static Func<T1, T2, T3, T4, TR> Uncurry<T1, T2, T3, T4, TR>(
      Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> func) =>
      (p1, p2, p3, p4) => func(p1)(p2)(p3)(p4);

    public static Func<T1, T2, T3, T4, T5, TR> Uncurry<T1, T2, T3, T4, T5, TR>(
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>> func) =>
      (p1, p2, p3, p4, p5) => func(p1)(p2)(p3)(p4)(p5);

    public static Func<T1, T2, T3, T4, T5, T6, TR> Uncurry<T1, T2, T3, T4, T5, T6, TR>(
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6) => func(p1)(p2)(p3)(p4)(p5)(p6);

    public static Func<T1, T2, T3, T4, T5, T6, T7, TR> Uncurry<T1, T2, T3, T4, T5, T6, T7, TR>(
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TR>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TR>
      Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, TR>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TR>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR>
      Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TR>>>>>>>>>
          func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TR>
      Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TR>(
        Func<T1, Func<T2, Func<T3,
          Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TR>>>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TR>
      Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TR>(
        Func<T1, Func<T2, Func<T3, Func<T4,
          Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TR>>>>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) =>
        func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TR> Uncurry<T1, T2, T3,
      T4, T5, T6, T7, T8, T9, T10, T11, T12, TR>(
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5,
        Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TR>>>>>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) =>
        func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TR> Uncurry<T1, T2,
      T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TR>(
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6,
        Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TR>>>>>>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) =>
        func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12)(p13);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TR> Uncurry<T1,
      T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TR>(
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7,
          Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TR>>>>>>>>>>>>>>
        func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) =>
        func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12)(p13)(p14);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TR>
      Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TR>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8,
            Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TR>>>>>>>>>>>>>>>
          func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) =>
        func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12)(p13)(p14)(p15);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TR>
      Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TR>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8,
          Func<T9, Func<T10,
            Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TR>>>>>>>>>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) =>
        func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12)(p13)(p14)(p15)(p16);

    public static Action<T1, T2> Uncurry<T1, T2>(Func<T1, Action<T2>> func) =>
      (p1, p2) => func(p1)(p2);

    public static Action<T1, T2, T3> Uncurry<T1, T2, T3>(Func<T1, Func<T2, Action<T3>>> func) =>
      (p1, p2, p3) => func(p1)(p2)(p3);

    public static Action<T1, T2, T3, T4> Uncurry<T1, T2, T3, T4>(
      Func<T1, Func<T2, Func<T3, Action<T4>>>> func) =>
      (p1, p2, p3, p4) => func(p1)(p2)(p3)(p4);

    public static Action<T1, T2, T3, T4, T5> Uncurry<T1, T2, T3, T4, T5>(
      Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> func) =>
      (p1, p2, p3, p4, p5) => func(p1)(p2)(p3)(p4)(p5);

    public static Action<T1, T2, T3, T4, T5, T6> Uncurry<T1, T2, T3, T4, T5, T6>(
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6) => func(p1)(p2)(p3)(p4)(p5)(p6);

    public static Action<T1, T2, T3, T4, T5, T6, T7> Uncurry<T1, T2, T3, T4, T5, T6, T7>(
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8>(
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>
      Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>>
          func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
      Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        Func<T1, Func<T2, Func<T3,
          Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Action<T10>>>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
      Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
        Func<T1, Func<T2, Func<T3, Func<T4,
          Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Action<T11>>>>>>>>>>> action) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) =>
        action(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
      Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5,
          Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Action<T12>>>>>>>>>>>> action) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) =>
        action(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Uncurry<T1, T2, T3,
      T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6,
        Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Action<T13>>>>>>>>>>>>> action) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) =>
        action(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12)(p13);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Uncurry<T1,
      T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7,
          Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Action<T14>>>>>>>>>>>>>>
        action) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) =>
        action(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12)(p13)(p14);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
      Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8,
            Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Action<T15>>>>>>>>>>>>>>>
          action) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) =>
        action(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12)(p13)(p14)(p15);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
      Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8,
          Func<T9, Func<T10,
            Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Action<T16>>>>>>>>>>>>>>>> action) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) =>
        action(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12)(p13)(p14)(p15)(p16);

    #endregion
  }
}