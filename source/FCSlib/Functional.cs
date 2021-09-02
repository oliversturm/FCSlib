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
  public static class Functional {
    #region Currying
    public static Func<T1, Func<T2, TR>> Curry<T1, T2, TR>(this Func<T1, T2, TR> func) =>
      p1 => p2 => func(p1, p2);

    public static
    Func<T1, Func<T2, Func<T3, TR>>> Curry<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> func) =>
      p1 => p2 => p3 => func(p1, p2, p3);

    public static
    Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> Curry<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> func) =>
      p1 => p2 => p3 => p4 => func(p1, p2, p3, p4);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>> Curry<T1, T2, T3, T4, T5, TR>(this Func<T1, T2, T3, T4, T5, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => func(p1, p2, p3, p4, p5);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>> Curry<T1, T2, T3, T4, T5, T6, TR>(this Func<T1, T2, T3, T4, T5, T6, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => func(p1, p2, p3, p4, p5, p6);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TR>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, TR>(this Func<T1, T2, T3, T4, T5, T6, T7, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => func(p1, p2, p3, p4, p5, p6, p7);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TR>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TR>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => func(p1, p2, p3, p4, p5, p6, p7, p8);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TR>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TR>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TR>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TR>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TR>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TR>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TR>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TR>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TR>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 => p13 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TR>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TR>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 => p13 => p14 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TR>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TR>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 => p13 => p14 => p15 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TR>>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TR>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TR> func) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 => p13 => p14 => p15 => p16 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);

    public static Func<T1, Action<T2>> Curry<T1, T2>(this Action<T1, T2> action) =>
      p1 => p2 => action(p1, p2);

    public static Func<T1, Func<T2, Action<T3>>> Curry<T1, T2, T3>(this Action<T1, T2, T3> action) =>
      p1 => p2 => p3 => action(p1, p2, p3);

    public static Func<T1, Func<T2, Func<T3, Action<T4>>>> Curry<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action) =>
      p1 => p2 => p3 => p4 => action(p1, p2, p3, p4);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> Curry<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action) =>
      p1 => p2 => p3 => p4 => p5 => action(p1, p2, p3, p4, p5);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>> Curry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => action(p1, p2, p3, p4, p5, p6);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => action(p1, p2, p3, p4, p5, p6, p7);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => action(p1, p2, p3, p4, p5, p6, p7, p8);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => action(p1, p2, p3, p4, p5, p6, p7, p8, p9);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Action<T10>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Action<T11>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Action<T12>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 => action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Action<T13>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 => p13 => action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Action<T14>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 => p13 => p14 => action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Action<T15>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 => p13 => p14 => p15 => action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Action<T16>>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action) =>
      p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 => p13 => p14 => p15 => p16 => action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);


    public static Func<T2, Func<T1, R>> Swap<T1, T2, R>(Func<T1, Func<T2, R>> func) =>
      p2 => p1 => func(p1)(p2);

    #endregion

    #region Uncurrying
    public static Func<T1, T2, TR> Uncurry<T1, T2, TR>(this Func<T1, Func<T2, TR>> func) =>
      (p1, p2) => func(p1)(p2);

    public static Func<T1, T2, T3, TR> Uncurry<T1, T2, T3, TR>(this Func<T1, Func<T2, Func<T3, TR>>> func) =>
      (p1, p2, p3) => func(p1)(p2)(p3);

    public static Func<T1, T2, T3, T4, TR> Uncurry<T1, T2, T3, T4, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> func) =>
      (p1, p2, p3, p4) => func(p1)(p2)(p3)(p4);

    public static Func<T1, T2, T3, T4, T5, TR> Uncurry<T1, T2, T3, T4, T5, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>> func) =>
      (p1, p2, p3, p4, p5) => func(p1)(p2)(p3)(p4)(p5);

    public static Func<T1, T2, T3, T4, T5, T6, TR> Uncurry<T1, T2, T3, T4, T5, T6, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6) => func(p1)(p2)(p3)(p4)(p5)(p6);

    public static Func<T1, T2, T3, T4, T5, T6, T7, TR> Uncurry<T1, T2, T3, T4, T5, T6, T7, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TR>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TR> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TR>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TR>>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TR> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TR>>>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TR> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TR>>>>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TR> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TR>>>>>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TR> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TR>>>>>>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12)(p13);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TR> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TR>>>>>>>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12)(p13)(p14);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TR> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TR>>>>>>>>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12)(p13)(p14)(p15);

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TR> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TR>>>>>>>>>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12)(p13)(p14)(p15)(p16);

    public static Action<T1, T2> Uncurry<T1, T2>(this Func<T1, Action<T2>> func) =>
      (p1, p2) => func(p1)(p2);

    public static Action<T1, T2, T3> Uncurry<T1, T2, T3>(this Func<T1, Func<T2, Action<T3>>> func) =>
      (p1, p2, p3) => func(p1)(p2)(p3);

    public static Action<T1, T2, T3, T4> Uncurry<T1, T2, T3, T4>(this Func<T1, Func<T2, Func<T3, Action<T4>>>> func) =>
      (p1, p2, p3, p4) => func(p1)(p2)(p3)(p4);

    public static Action<T1, T2, T3, T4, T5> Uncurry<T1, T2, T3, T4, T5>(this Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> func) =>
      (p1, p2, p3, p4, p5) => func(p1)(p2)(p3)(p4)(p5);

    public static Action<T1, T2, T3, T4, T5, T6> Uncurry<T1, T2, T3, T4, T5, T6>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6) => func(p1)(p2)(p3)(p4)(p5)(p6);

    public static Action<T1, T2, T3, T4, T5, T6, T7> Uncurry<T1, T2, T3, T4, T5, T6, T7>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Action<T10>>>>>>>>>> func) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => func(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Action<T11>>>>>>>>>>> action) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => action(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Action<T12>>>>>>>>>>>> action) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => action(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Action<T13>>>>>>>>>>>>> action) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => action(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12)(p13);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Action<T14>>>>>>>>>>>>>> action) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => action(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12)(p13)(p14);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Action<T15>>>>>>>>>>>>>>> action) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => action(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12)(p13)(p14)(p15);

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Action<T16>>>>>>>>>>>>>>>> action) =>
      (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => action(p1)(p2)(p3)(p4)(p5)(p6)(p7)(p8)(p9)(p10)(p11)(p12)(p13)(p14)(p15)(p16);

    #endregion

    #region Partial application
    #region Func, 2 params
    public static Func<T2, TR> Apply<T1, T2, TR>(Func<T1, T2, TR> function, T1 arg) {
      return arg2 => function(arg, arg2);
    }
    #endregion

    #region Func, 3 params
    public static Func<T2, T3, TR> Apply<T1, T2, T3, TR>(Func<T1, T2, T3, TR> function, T1 arg) {
      return (arg2, arg3) => function(arg, arg2, arg3);
    }

    public static Func<T3, TR> Apply<T1, T2, T3, TR>(Func<T1, T2, T3, TR> function, T1 arg, T2 arg2) {
      return arg3 => function(arg, arg2, arg3);
    }
    #endregion

    #region Func, 4 params
    public static Func<T2, T3, T4, TR> Apply<T1, T2, T3, T4, TR>(Func<T1, T2, T3, T4, TR> function, T1 arg) {
      return (arg2, arg3, arg4) => function(arg, arg2, arg3, arg4);
    }

    public static Func<T3, T4, TR> Apply<T1, T2, T3, T4, TR>(Func<T1, T2, T3, T4, TR> function, T1 arg, T2 arg2) {
      return (arg3, arg4) => function(arg, arg2, arg3, arg4);
    }

    public static Func<T4, TR> Apply<T1, T2, T3, T4, TR>(Func<T1, T2, T3, T4, TR> function, T1 arg, T2 arg2, T3 arg3) {
      return arg4 => function(arg, arg2, arg3, arg4);
    }
    #endregion

    #region Func, 5 params
    public static Func<T2, T3, T4, T5, TR> Apply<T1, T2, T3, T4, T5, TR>(Func<T1, T2, T3, T4, T5, TR> function, T1 arg) {
      return (arg2, arg3, arg4, arg5) => function(arg, arg2, arg3, arg4, arg5);
    }

    public static Func<T3, T4, T5, TR> Apply<T1, T2, T3, T4, T5, TR>(Func<T1, T2, T3, T4, T5, TR> function, T1 arg, T2 arg2) {
      return (arg3, arg4, arg5) => function(arg, arg2, arg3, arg4, arg5);
    }

    public static Func<T4, T5, TR> Apply<T1, T2, T3, T4, T5, TR>(Func<T1, T2, T3, T4, T5, TR> function, T1 arg, T2 arg2, T3 arg3) {
      return (arg4, arg5) => function(arg, arg2, arg3, arg4, arg5);
    }

    public static Func<T5, TR> Apply<T1, T2, T3, T4, T5, TR>(Func<T1, T2, T3, T4, T5, TR> function, T1 arg, T2 arg2, T3 arg3, T4 arg4) {
      return arg5 => function(arg, arg2, arg3, arg4, arg5);
    }
    #endregion

    #region Func, 6 params
    public static Func<T2, T3, T4, T5, T6, TR> Apply<T1, T2, T3, T4, T5, T6, TR>(Func<T1, T2, T3, T4, T5, T6, TR> function, T1 arg) {
      return (arg2, arg3, arg4, arg5, arg6) => function(arg, arg2, arg3, arg4, arg5, arg6);
    }

    public static Func<T3, T4, T5, T6, TR> Apply<T1, T2, T3, T4, T5, T6, TR>(Func<T1, T2, T3, T4, T5, T6, TR> function, T1 arg, T2 arg2) {
      return (arg3, arg4, arg5, arg6) => function(arg, arg2, arg3, arg4, arg5, arg6);
    }

    public static Func<T4, T5, T6, TR> Apply<T1, T2, T3, T4, T5, T6, TR>(Func<T1, T2, T3, T4, T5, T6, TR> function, T1 arg, T2 arg2, T3 arg3) {
      return (arg4, arg5, arg6) => function(arg, arg2, arg3, arg4, arg5, arg6);
    }

    public static Func<T5, T6, TR> Apply<T1, T2, T3, T4, T5, T6, TR>(Func<T1, T2, T3, T4, T5, T6, TR> function, T1 arg, T2 arg2, T3 arg3, T4 arg4) {
      return (arg5, arg6) => function(arg, arg2, arg3, arg4, arg5, arg6);
    }

    public static Func<T6, TR> Apply<T1, T2, T3, T4, T5, T6, TR>(Func<T1, T2, T3, T4, T5, T6, TR> function, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
      return arg6 => function(arg, arg2, arg3, arg4, arg5, arg6);
    }
    #endregion

    #region Func, 7 params
    public static Func<T2, T3, T4, T5, T6, T7, TR> Apply<T1, T2, T3, T4, T5, T6, T7, TR>(Func<T1, T2, T3, T4, T5, T6, T7, TR> function, T1 arg) {
      return (arg2, arg3, arg4, arg5, arg6, arg7) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    public static Func<T3, T4, T5, T6, T7, TR> Apply<T1, T2, T3, T4, T5, T6, T7, TR>(Func<T1, T2, T3, T4, T5, T6, T7, TR> function, T1 arg, T2 arg2) {
      return (arg3, arg4, arg5, arg6, arg7) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    public static Func<T4, T5, T6, T7, TR> Apply<T1, T2, T3, T4, T5, T6, T7, TR>(Func<T1, T2, T3, T4, T5, T6, T7, TR> function, T1 arg, T2 arg2, T3 arg3) {
      return (arg4, arg5, arg6, arg7) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    public static Func<T5, T6, T7, TR> Apply<T1, T2, T3, T4, T5, T6, T7, TR>(Func<T1, T2, T3, T4, T5, T6, T7, TR> function, T1 arg, T2 arg2, T3 arg3, T4 arg4) {
      return (arg5, arg6, arg7) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    public static Func<T6, T7, TR> Apply<T1, T2, T3, T4, T5, T6, T7, TR>(Func<T1, T2, T3, T4, T5, T6, T7, TR> function, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
      return (arg6, arg7) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    public static Func<T7, TR> Apply<T1, T2, T3, T4, T5, T6, T7, TR>(Func<T1, T2, T3, T4, T5, T6, T7, TR> function, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
      return arg7 => function(arg, arg2, arg3, arg4, arg5, arg6, arg7);
    }
    #endregion

    #region Func, 8 params
    public static Func<T2, T3, T4, T5, T6, T7, T8, TR> Apply<T1, T2, T3, T4, T5, T6, T7, T8, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TR> function, T1 arg) {
      return (arg2, arg3, arg4, arg5, arg6, arg7, arg8) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    public static Func<T3, T4, T5, T6, T7, T8, TR> Apply<T1, T2, T3, T4, T5, T6, T7, T8, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TR> function, T1 arg, T2 arg2) {
      return (arg3, arg4, arg5, arg6, arg7, arg8) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    public static Func<T4, T5, T6, T7, T8, TR> Apply<T1, T2, T3, T4, T5, T6, T7, T8, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TR> function, T1 arg, T2 arg2, T3 arg3) {
      return (arg4, arg5, arg6, arg7, arg8) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    public static Func<T5, T6, T7, T8, TR> Apply<T1, T2, T3, T4, T5, T6, T7, T8, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TR> function, T1 arg, T2 arg2, T3 arg3, T4 arg4) {
      return (arg5, arg6, arg7, arg8) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    public static Func<T6, T7, T8, TR> Apply<T1, T2, T3, T4, T5, T6, T7, T8, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TR> function, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
      return (arg6, arg7, arg8) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    public static Func<T7, T8, TR> Apply<T1, T2, T3, T4, T5, T6, T7, T8, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TR> function, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
      return (arg7, arg8) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    public static Func<T8, TR> Apply<T1, T2, T3, T4, T5, T6, T7, T8, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TR> function, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
      return arg8 => function(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }
    #endregion

    #region Func, 9 params
    public static Func<T2, T3, T4, T5, T6, T7, T8, T9, TR> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> function, T1 arg) {
      return (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    public static Func<T3, T4, T5, T6, T7, T8, T9, TR> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> function, T1 arg, T2 arg2) {
      return (arg3, arg4, arg5, arg6, arg7, arg8, arg9) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    public static Func<T4, T5, T6, T7, T8, T9, TR> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> function, T1 arg, T2 arg2, T3 arg3) {
      return (arg4, arg5, arg6, arg7, arg8, arg9) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    public static Func<T5, T6, T7, T8, T9, TR> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> function, T1 arg, T2 arg2, T3 arg3, T4 arg4) {
      return (arg5, arg6, arg7, arg8, arg9) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    public static Func<T6, T7, T8, T9, TR> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> function, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
      return (arg6, arg7, arg8, arg9) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    public static Func<T7, T8, T9, TR> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> function, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
      return (arg7, arg8, arg9) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    public static Func<T8, T9, TR> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> function, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
      return (arg8, arg9) => function(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    public static Func<T9, TR> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> function, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
      return arg9 => function(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }
    #endregion

    #region Action, 2 params
    public static Action<T2> Apply<T1, T2>(Action<T1, T2> action, T1 arg) {
      return arg2 => action(arg, arg2);
    }
    #endregion

    #region Action, 3 params
    public static Action<T2, T3> Apply<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg) {
      return (arg2, arg3) => action(arg, arg2, arg3);
    }

    public static Action<T3> Apply<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg, T2 arg2) {
      return arg3 => action(arg, arg2, arg3);
    }
    #endregion

    #region Action, 4 params
    public static Action<T2, T3, T4> Apply<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 arg) {
      return (arg2, arg3, arg4) => action(arg, arg2, arg3, arg4);
    }

    public static Action<T3, T4> Apply<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 arg, T2 arg2) {
      return (arg3, arg4) => action(arg, arg2, arg3, arg4);
    }

    public static Action<T4> Apply<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 arg, T2 arg2, T3 arg3) {
      return arg4 => action(arg, arg2, arg3, arg4);
    }
    #endregion

    #region Action, 5 params
    public static Action<T2, T3, T4, T5> Apply<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 arg) {
      return (arg2, arg3, arg4, arg5) => action(arg, arg2, arg3, arg4, arg5);
    }

    public static Action<T3, T4, T5> Apply<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 arg, T2 arg2) {
      return (arg3, arg4, arg5) => action(arg, arg2, arg3, arg4, arg5);
    }

    public static Action<T4, T5> Apply<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 arg, T2 arg2, T3 arg3) {
      return (arg4, arg5) => action(arg, arg2, arg3, arg4, arg5);
    }

    public static Action<T5> Apply<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 arg, T2 arg2, T3 arg3, T4 arg4) {
      return arg5 => action(arg, arg2, arg3, arg4, arg5);
    }
    #endregion

    #region Action, 6 params
    public static Action<T2, T3, T4, T5, T6> Apply<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 arg) {
      return (arg2, arg3, arg4, arg5, arg6) => action(arg, arg2, arg3, arg4, arg5, arg6);
    }

    public static Action<T3, T4, T5, T6> Apply<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 arg, T2 arg2) {
      return (arg3, arg4, arg5, arg6) => action(arg, arg2, arg3, arg4, arg5, arg6);
    }

    public static Action<T4, T5, T6> Apply<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 arg, T2 arg2, T3 arg3) {
      return (arg4, arg5, arg6) => action(arg, arg2, arg3, arg4, arg5, arg6);
    }

    public static Action<T5, T6> Apply<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 arg, T2 arg2, T3 arg3, T4 arg4) {
      return (arg5, arg6) => action(arg, arg2, arg3, arg4, arg5, arg6);
    }

    public static Action<T6> Apply<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
      return arg6 => action(arg, arg2, arg3, arg4, arg5, arg6);
    }
    #endregion

    #region Action, 7 params
    public static Action<T2, T3, T4, T5, T6, T7> Apply<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg) {
      return (arg2, arg3, arg4, arg5, arg6, arg7) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    public static Action<T3, T4, T5, T6, T7> Apply<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg, T2 arg2) {
      return (arg3, arg4, arg5, arg6, arg7) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    public static Action<T4, T5, T6, T7> Apply<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg, T2 arg2, T3 arg3) {
      return (arg4, arg5, arg6, arg7) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    public static Action<T5, T6, T7> Apply<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg, T2 arg2, T3 arg3, T4 arg4) {
      return (arg5, arg6, arg7) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    public static Action<T6, T7> Apply<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
      return (arg6, arg7) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    public static Action<T7> Apply<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
      return arg7 => action(arg, arg2, arg3, arg4, arg5, arg6, arg7);
    }
    #endregion

    #region Action, 8 params
    public static Action<T2, T3, T4, T5, T6, T7, T8> Apply<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg) {
      return (arg2, arg3, arg4, arg5, arg6, arg7, arg8) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    public static Action<T3, T4, T5, T6, T7, T8> Apply<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg, T2 arg2) {
      return (arg3, arg4, arg5, arg6, arg7, arg8) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    public static Action<T4, T5, T6, T7, T8> Apply<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg, T2 arg2, T3 arg3) {
      return (arg4, arg5, arg6, arg7, arg8) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    public static Action<T5, T6, T7, T8> Apply<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg, T2 arg2, T3 arg3, T4 arg4) {
      return (arg5, arg6, arg7, arg8) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    public static Action<T6, T7, T8> Apply<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
      return (arg6, arg7, arg8) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    public static Action<T7, T8> Apply<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
      return (arg7, arg8) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    public static Action<T8> Apply<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
      return arg8 => action(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }
    #endregion

    #region Action, 9 params
    public static Action<T2, T3, T4, T5, T6, T7, T8, T9> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg) {
      return (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    public static Action<T3, T4, T5, T6, T7, T8, T9> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg, T2 arg2) {
      return (arg3, arg4, arg5, arg6, arg7, arg8, arg9) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    public static Action<T4, T5, T6, T7, T8, T9> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg, T2 arg2, T3 arg3) {
      return (arg4, arg5, arg6, arg7, arg8, arg9) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    public static Action<T5, T6, T7, T8, T9> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg, T2 arg2, T3 arg3, T4 arg4) {
      return (arg5, arg6, arg7, arg8, arg9) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    public static Action<T6, T7, T8, T9> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
      return (arg6, arg7, arg8, arg9) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    public static Action<T7, T8, T9> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
      return (arg7, arg8, arg9) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    public static Action<T8, T9> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
      return (arg8, arg9) => action(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    public static Action<T9> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
      return arg9 => action(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }
    #endregion

    #endregion

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

    #region Memoization
    public static Func<P, R?> Memoize<P, R>(this Func<P, R?> f) where P : notnull {
      MethodInfo fInfo = f.Method;
      return Memoize<P, R?>(f, GetDefaultMemoryKey(fInfo));
    }

    public static Func<P, R?> Memoize<P, R>(this Func<P, R?> f, string memoryKey) where P : notnull {
      return arg => {
        var memory = Memoizer<P, R?>.GetMemory(memoryKey);
        if (!memory.HasResultFor(arg))
          memory.Remember(arg, f(arg));
        return memory.ResultFor(arg);
      };
    }

    // We know that this value won't be null after initialization. However, I'm not sure what 
    // the desired pattern is for COD properties like this (make the backing store variable
    // nullable makes sense of course, technically). And even though I am completely sure 
    // that the GetMethod call will always return a non-null value, I'm not aware of a 
    // way of telling C# so. Basically, the property should not need to be nullable,
    // but I don't think that's possible.

    private static MethodInfo? deepMemoizeMethodInfo;
    private static MethodInfo DeepMemoizeMethodInfo {
      get {
        if (deepMemoizeMethodInfo == null) {
          deepMemoizeMethodInfo = typeof(Functional).GetMethod("DeepMemoize", BindingFlags.Public | BindingFlags.Static);
          if (deepMemoizeMethodInfo == null) {
            // Can't really happen - we know this
            throw new InvalidOperationException("Hell has frozen over");
          }
        }
        return deepMemoizeMethodInfo;
      }
    }

    static string GetDefaultMemoryKey(MethodInfo? fInfo) {
      if (fInfo == null) {
        throw new InvalidOperationException("Can't execute GetDefaultMemoryKey with a null method");
      } // else

      // Why does C# still complain about a possible null reference in the following
      // line even though I'm throwing an exception above in the null case?
      // This is still the case even if I add an "else" above. The ?. operator
      // gets rid of the compiler error, but that should really not be necessary.
      return fInfo?.DeclaringType?.FullName + "+" + fInfo?.Name;
    }

    public static Func<P, R?> DeepMemoize<P, R>(this Func<P, R?> f) where P : notnull {
      return arg => {
        MethodInfo fInfo = f.Method;
        string memoryKey = GetDefaultMemoryKey(fInfo);
        var memory = Memoizer<P, R>.GetMemory(memoryKey);
        if (!memory.HasResultFor(arg)) {
          R? result = f(arg);
          Type resultType = typeof(R);
          if (typeof(System.Delegate).IsAssignableFrom(resultType)) {
            Type[] parameterTypes = resultType.GetGenericArguments();

            MethodInfo typedDeepMemoizeMethod = DeepMemoizeMethodInfo.MakeGenericMethod(parameterTypes);
            var memoizedResult = (R?)typedDeepMemoizeMethod.Invoke(null, new object?[] { result });
            memory.Remember(arg, memoizedResult);
          }
          else
            memory.Remember(arg, result);
        }
        return memory.ResultFor(arg);
      };
    }

    #endregion

    #region Lazy
    public static Lazy<T> Lazy<T>(this Func<T> func) {
      return new Lazy<T>(func);
    }

    public static Lazy<T> Lazy<T>(T value) {
      return new Lazy<T>(value);
    }
    #endregion

    #region Lambda construction
    #region Basic Func, none or one parameter
    public static Func<TR> Lambda<TR>(Func<TR> f) {
      return f;
    }

    public static Func<TArg, TR> Lambda<TArg, TR>(Func<TArg, TR> f) {
      return f;
    }
    #endregion

    #region Curried Func, up to 9 parameters
    public static Func<T1, Func<T2, TR>> Lambda<T1, T2, TR>(Func<T1, Func<T2, TR>> f) {
      return f;
    }

    public static Func<T1, Func<T2, Func<T3, TR>>> Lambda<T1, T2, T3, TR>(Func<T1, Func<T2, Func<T3, TR>>> f) {
      return f;
    }

    public static Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> Lambda<T1, T2, T3, T4, TR>(Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> f) {
      return f;
    }

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>> Lambda<T1, T2, T3, T4, T5, TR>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>> f) {
      return f;
    }

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>> Lambda<T1, T2, T3, T4, T5, T6, TR>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>> f) {
      return f;
    }

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TR>>>>>>> Lambda<T1, T2, T3, T4, T5, T6, T7, TR>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TR>>>>>>> f) {
      return f;
    }

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TR>>>>>>>> Lambda<T1, T2, T3, T4, T5, T6, T7, T8, TR>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TR>>>>>>>> f) {
      return f;
    }

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TR>>>>>>>>> Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TR>>>>>>>>> f) {
      return f;
    }

    #endregion

    #region Non-curried Func, up to 9 parameters
    public static Func<T1, T2, TR> Lambda<T1, T2, TR>(Func<T1, T2, TR> f) {
      return f;
    }

    public static Func<T1, T2, T3, TR> Lambda<T1, T2, T3, TR>(Func<T1, T2, T3, TR> f) {
      return f;
    }

    public static Func<T1, T2, T3, T4, TR> Lambda<T1, T2, T3, T4, TR>(Func<T1, T2, T3, T4, TR> f) {
      return f;
    }

    public static Func<T1, T2, T3, T4, T5, TR> Lambda<T1, T2, T3, T4, T5, TR>(Func<T1, T2, T3, T4, T5, TR> f) {
      return f;
    }

    public static Func<T1, T2, T3, T4, T5, T6, TR> Lambda<T1, T2, T3, T4, T5, T6, TR>(Func<T1, T2, T3, T4, T5, T6, TR> f) {
      return f;
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, TR> Lambda<T1, T2, T3, T4, T5, T6, T7, TR>(Func<T1, T2, T3, T4, T5, T6, T7, TR> f) {
      return f;
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TR> Lambda<T1, T2, T3, T4, T5, T6, T7, T8, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TR> f) {
      return f;
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> f) {
      return f;
    }
    #endregion

    #region Basic Action, none or one parameter
    public static Action Lambda(Action f) {
      return f;
    }

    public static Action<TArg> Lambda<TArg>(Action<TArg> f) {
      return f;
    }
    #endregion

    #region Curried Action, up to 9 parameters
    public static Func<T1, Action<T2>> Lambda<T1, T2>(Func<T1, Action<T2>> f) {
      return f;
    }

    public static Func<T1, Func<T2, Action<T3>>> Lambda<T1, T2, T3>(Func<T1, Func<T2, Action<T3>>> f) {
      return f;
    }

    public static Func<T1, Func<T2, Func<T3, Action<T4>>>> Lambda<T1, T2, T3, T4>(Func<T1, Func<T2, Func<T3, Action<T4>>>> f) {
      return f;
    }

    public static Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> Lambda<T1, T2, T3, T4, T5>(Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> f) {
      return f;
    }

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>> Lambda<T1, T2, T3, T4, T5, T6>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>> f) {
      return f;
    }

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>> Lambda<T1, T2, T3, T4, T5, T6, T7>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>> f) {
      return f;
    }

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>> Lambda<T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>> f) {
      return f;
    }

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>> Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>> f) {
      return f;
    }
    #endregion

    #region Non-curried Action, up to 9 parameters
    public static Action<T1, T2> Lambda<T1, T2>(Action<T1, T2> f) {
      return f;
    }

    public static Action<T1, T2, T3> Lambda<T1, T2, T3>(Action<T1, T2, T3> f) {
      return f;
    }

    public static Action<T1, T2, T3, T4> Lambda<T1, T2, T3, T4>(Action<T1, T2, T3, T4> f) {
      return f;
    }

    public static Action<T1, T2, T3, T4, T5> Lambda<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> f) {
      return f;
    }

    public static Action<T1, T2, T3, T4, T5, T6> Lambda<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> f) {
      return f;
    }

    public static Action<T1, T2, T3, T4, T5, T6, T7> Lambda<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> f) {
      return f;
    }

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8> Lambda<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> f) {
      return f;
    }

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> f) {
      return f;
    }
    #endregion
    #endregion

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
