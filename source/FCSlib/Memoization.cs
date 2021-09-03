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
  }
}
