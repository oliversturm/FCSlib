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
    public static FCSColl::List<T> List<T>(T head) => new(head);
    public static FCSColl::List<T> List<T>() => FCSColl::List<T>.Empty;
    public static FCSColl::List<T> List<T>(T first, params T[] values) => new(first, values);
    public static FCSColl::List<T> List<T>(IEnumerable<T> source) => new(source);
  }
}