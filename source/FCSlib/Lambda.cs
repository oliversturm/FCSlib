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
    #region Basic Func, none or one parameter

    public static Func<TR> Lambda<TR>(Func<TR> f) => f;

    public static Func<TArg, TR> Lambda<TArg, TR>(Func<TArg, TR> f) => f;

    #endregion

    #region Curried Func, up to 16 parameters

    public static Func<T1, Func<T2, TR>> Lambda<T1, T2, TR>(Func<T1, Func<T2, TR>> f) => f;

    public static Func<T1, Func<T2, Func<T3, TR>>> Lambda<T1, T2, T3, TR>(
      Func<T1, Func<T2, Func<T3, TR>>> f) => f;

    public static Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> Lambda<T1, T2, T3, T4, TR>(
      Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> f) => f;

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>>
      Lambda<T1, T2, T3, T4, T5, TR>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>> f) => f;

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>>
      Lambda<T1, T2, T3, T4, T5, T6, TR>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>> f) => f;

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TR>>>>>>>
      Lambda<T1, T2, T3, T4, T5, T6, T7, TR>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TR>>>>>>> f) => f;

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TR>>>>>>>>
      Lambda<T1, T2, T3, T4, T5, T6, T7, T8, TR>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TR>>>>>>>> f) => f;

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TR>>>>>>>>>
      Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TR>>>>>>>>>
          f) => f;

    public static
      Func<T1, Func<T2, Func<T3,
        Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TR>>>>>>>>>>
      Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TR>(
        Func<T1, Func<T2, Func<T3,
          Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TR>>>>>>>>>> f) => f;

    public static
      Func<T1, Func<T2, Func<T3, Func<T4,
        Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TR>>>>>>>>>>> Lambda<T1,
        T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TR>(
        Func<T1, Func<T2, Func<T3, Func<T4,
          Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TR>>>>>>>>>>> f) => f;

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5,
        Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TR>>>>>>>>>>>> Lambda<T1,
        T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TR>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5,
          Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TR>>>>>>>>>>>> f) => f;

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6,
        Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TR>>>>>>>>>>>>>
      Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TR>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6,
          Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TR>>>>>>>>>>>>> f) =>
      f;

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7,
        Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TR>>>>>>>>>>>>>>
      Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TR>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7,
          Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TR>>>>>>>>>>>>>> f) =>
      f;

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8,
        Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TR>>>>>>>>>>>>>>>
      Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TR>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8,
            Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TR>>>>>>>>>>>>>>>
          f) => f;

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8,
        Func<T9, Func<T10,
          Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TR>>>>>>>>>>>>>>>> Lambda<T1,
        T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TR>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8,
          Func<T9, Func<T10,
            Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TR>>>>>>>>>>>>>>>> f) => f;

    #endregion

    #region Non-curried Func, up to 16 parameters

    public static Func<T1, T2, TR> Lambda<T1, T2, TR>(Func<T1, T2, TR> f) => f;

    public static Func<T1, T2, T3, TR> Lambda<T1, T2, T3, TR>(Func<T1, T2, T3, TR> f) => f;

    public static Func<T1, T2, T3, T4, TR> Lambda<T1, T2, T3, T4, TR>(Func<T1, T2, T3, T4, TR> f) =>
      f;

    public static Func<T1, T2, T3, T4, T5, TR> Lambda<T1, T2, T3, T4, T5, TR>(
      Func<T1, T2, T3, T4, T5, TR> f) => f;

    public static Func<T1, T2, T3, T4, T5, T6, TR> Lambda<T1, T2, T3, T4, T5, T6, TR>(
      Func<T1, T2, T3, T4, T5, T6, TR> f) => f;

    public static Func<T1, T2, T3, T4, T5, T6, T7, TR> Lambda<T1, T2, T3, T4, T5, T6, T7, TR>(
      Func<T1, T2, T3, T4, T5, T6, T7, TR> f) => f;

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TR> Lambda<T1, T2, T3, T4, T5, T6, T7, T8,
      TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TR> f) => f;

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> Lambda<T1, T2, T3, T4, T5, T6, T7,
      T8, T9, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> f) => f;

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TR> Lambda<T1, T2, T3, T4, T5, T6,
      T7, T8, T9, T10, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TR> f) => f;

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TR> Lambda<T1, T2, T3, T4, T5,
      T6, T7, T8, T9, T10, T11, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TR> f) => f;

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TR> Lambda<T1, T2, T3, T4,
      T5, T6, T7, T8, T9, T10, T11, T12, TR>(
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TR> f) => f;

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TR> Lambda<T1, T2,
      T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TR>(
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TR> f) => f;

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TR> Lambda<T1,
      T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TR>(
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TR> f) => f;

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TR> Lambda<
      T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TR>(
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TR> f) => f;

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TR>
      Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TR>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TR> f) => f;

    #endregion

    #region Basic Action, none or one parameter

    public static Action Lambda(Action f) => f;

    public static Action<TArg> Lambda<TArg>(Action<TArg> f) => f;

    #endregion

    #region Curried Action, up to 16 parameters

    public static Func<T1, Action<T2>> Lambda<T1, T2>(Func<T1, Action<T2>> f) => f;

    public static Func<T1, Func<T2, Action<T3>>> Lambda<T1, T2, T3>(
      Func<T1, Func<T2, Action<T3>>> f) => f;

    public static Func<T1, Func<T2, Func<T3, Action<T4>>>> Lambda<T1, T2, T3, T4>(
      Func<T1, Func<T2, Func<T3, Action<T4>>>> f) => f;

    public static Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> Lambda<T1, T2, T3, T4, T5>(
      Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> f) => f;

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>>
      Lambda<T1, T2, T3, T4, T5, T6>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>> f) => f;

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>>
      Lambda<T1, T2, T3, T4, T5, T6, T7>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>> f) => f;

    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>>
      Lambda<T1, T2, T3, T4, T5, T6, T7, T8>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>> f) => f;

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>>
      Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>>
          f) => f;

    public static
      Func<T1, Func<T2,
        Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Action<T10>>>>>>>>>>
      Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        Func<T1, Func<T2, Func<T3,
          Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Action<T10>>>>>>>>>> f) => f;

    public static
      Func<T1, Func<T2, Func<T3,
        Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Action<T11>>>>>>>>>>>
      Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
        Func<T1, Func<T2, Func<T3, Func<T4,
          Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Action<T11>>>>>>>>>>> f) => f;

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5,
        Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Action<T12>>>>>>>>>>>> Lambda<T1,
        T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5,
          Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Action<T12>>>>>>>>>>>> f) => f;

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6,
        Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Action<T13>>>>>>>>>>>>> Lambda<T1,
        T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6,
          Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Action<T13>>>>>>>>>>>>> f) => f;

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7,
        Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Action<T14>>>>>>>>>>>>>>
      Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7,
          Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Action<T14>>>>>>>>>>>>>> f) =>
      f;

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8,
        Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Action<T15>>>>>>>>>>>>>>>
      Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8,
          Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Action<T15>>>>>>>>>>>>>>> f) =>
      f;

    public static
      Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8,
        Func<T9, Func<T10,
          Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Action<T16>>>>>>>>>>>>>>>> Lambda<T1,
        T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8,
          Func<T9, Func<T10,
            Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Action<T16>>>>>>>>>>>>>>>> f) => f;

    #endregion

    #region Non-curried Action, up to 16 parameters

    public static Action<T1, T2> Lambda<T1, T2>(Action<T1, T2> f) => f;

    public static Action<T1, T2, T3> Lambda<T1, T2, T3>(Action<T1, T2, T3> f) => f;

    public static Action<T1, T2, T3, T4> Lambda<T1, T2, T3, T4>(Action<T1, T2, T3, T4> f) => f;

    public static Action<T1, T2, T3, T4, T5> Lambda<T1, T2, T3, T4, T5>(
      Action<T1, T2, T3, T4, T5> f) => f;

    public static Action<T1, T2, T3, T4, T5, T6> Lambda<T1, T2, T3, T4, T5, T6>(
      Action<T1, T2, T3, T4, T5, T6> f) => f;

    public static Action<T1, T2, T3, T4, T5, T6, T7> Lambda<T1, T2, T3, T4, T5, T6, T7>(
      Action<T1, T2, T3, T4, T5, T6, T7> f) => f;

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8> Lambda<T1, T2, T3, T4, T5, T6, T7, T8>(
      Action<T1, T2, T3, T4, T5, T6, T7, T8> f) => f;

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Lambda<T1, T2, T3, T4, T5, T6, T7, T8,
      T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> f) => f;

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Lambda<T1, T2, T3, T4, T5, T6, T7,
      T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> f) => f;

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Lambda<T1, T2, T3, T4, T5,
      T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> f) => f;

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Lambda<T1, T2, T3, T4,
      T5, T6, T7, T8, T9, T10, T11, T12>(
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> f) => f;

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Lambda<T1, T2, T3,
      T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> f) => f;

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Lambda<T1, T2,
      T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> f) => f;

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Lambda<
      T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> f) => f;

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
      Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> f) => f;

    #endregion
  }
}