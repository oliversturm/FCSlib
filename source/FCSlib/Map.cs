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
    public static IEnumerable<R> Map<T, R>(Converter<T, R> function, IEnumerable<T> list) {
      foreach (T sourceVal in list)
        yield return function(sourceVal);
    }

    public static Func<Converter<T, R>, IEnumerable<T>, IEnumerable<R>> MapDelegate<T, R>() =>
      Map<T, R>;

    public static Func<IEnumerable<T>, IEnumerable<R>> Map<T, R>(Converter<T, R> f) =>
      list => Map(f, list);
  }
}