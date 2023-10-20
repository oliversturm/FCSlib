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
    public static IEnumerable<T> Filter<T>(Predicate<T> predicate, IEnumerable<T> list) {
      foreach (T val in list)
        if (predicate(val))
          yield return val;
    }

    public static Func<Predicate<T>, IEnumerable<T>, IEnumerable<T>> FilterDelegate<T>() =>
      Filter<T>;

    public static Func<IEnumerable<T>, IEnumerable<T>> Filter<T>(Predicate<T> predicate) =>
      list => Filter(predicate, list);
  }
}