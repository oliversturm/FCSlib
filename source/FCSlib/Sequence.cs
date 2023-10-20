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
    public static IEnumerable<T> Sequence<T>(Func<T, T> getNext, T startVal,
      Func<T, bool> endReached) {
      if (getNext == null)
        yield break;
      yield return startVal;
      T val = startVal;
      while (endReached == null || !endReached(val)) {
        val = getNext(val);
        yield return val;
      }
    }

    public static Func<Func<T, T>, T, Func<T, bool>, IEnumerable<T>> SequenceDelegate<T>() =>
      Sequence<T>;
  }
}