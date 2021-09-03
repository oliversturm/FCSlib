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
    public static T?[] InitArray<T>(int length, Func<int, T> elementInit) {
      var array = Array.CreateInstance(typeof(T), length) as T?[];
      // Somehow C# thinks that array could be null at this point. Don't know how but let's catch it.
      if (array == null)
        throw new InvalidOperationException("Pray for your array!");
      for (int i = 0; i < length; i++)
        array[i] = elementInit(i);
      return array;
    }
  }
}
