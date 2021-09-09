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


using FCSlib.Data;

namespace FCSlib {
  public static partial class Functional {
    public static Option<T> Some<T>(T val) => Option.Some(val);
    public static Option None => Option.None;
    public static Option<T> Optional<T>(T val) => OptionHelpers.ToNonDefaultOption(val);
    public static bool IsSome<T>(Option<T> o) => o.IsSome;
    public static bool IsSome(Option o) => o.IsSome;
    public static bool IsNone<T>(Option<T> o) => o.IsNone;
    public static bool IsNone(Option o) => o.IsNone;

    public static Option<R> Bind<T, R>(Option<T> o, Func<T?, Option<R>> g) => Option.Bind(o, g);
    public static Option<R> Bind<T, R>(Option<T> o, Func<T?, R> g) => Option.Bind(o, g);
  }
}
