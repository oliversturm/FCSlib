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

namespace FCSlib.Data {
  public sealed class Option {
    private Option() { }

    public static Option<T> Some<T>(T value) {
      return new Option<T>(value);
    }

    public static readonly Option None = new();

    // Just for consistency - this type is only used to 
    // temporarily represent a None
    // C# thinks these three should be static, so deactivate
    // the warnings first.

#pragma warning disable CA1822
    public bool HasValue => false;
    public bool IsSome => false;
    public bool IsNone => true;
#pragma warning restore CA1822
  }

  public static class OptionHelpers {
    public static Option<T> ToOption<T>(this T val) {
      return Option.Some(val);
    }

    // I'm reminded that C# doesn't support a generic constraint
    // for "nullable", i.e. "class?" but also "int?". Wonder
    // if there are any news about this.
    public static Option<T> ToNotNullOption<T>(this T val) where T : class? {
      return val != null ? val.ToOption() : Option.None;
    }
  }

  // Type T can be nullable - depending on actual instance values, it may be
  // desirable to make the option Some or None so it could be argued that
  // Some(null) shouldn't be possible - then again, if we assume that null
  // is a valid value in some scenarios of a null-enabled programming language
  // then even Some(null) could be a valid construct.

  public sealed class Option<T> {
    private readonly T? value;
    public T? Value {
      get { return value; }
    }
    private readonly bool hasValue;
    public bool HasValue {
      get { return hasValue; }
    }
    public bool IsSome {
      get { return hasValue; }
    }
    public bool IsNone {
      get { return !hasValue; }
    }

    public Option(T? value) {
      this.value = value;
      this.hasValue = true;
    }

    private Option() {
    }

    private static readonly Option<T> None = new();

    public static bool operator ==(Option<T> a, Option<T> b) {
      return a.HasValue == b.HasValue &&
        EqualityComparer<T>.Default.Equals(a.Value, b.Value);
    }
    public static bool operator !=(Option<T> a, Option<T> b) {
      return !(a == b);
    }

    public static implicit operator Option<T>(Option option) {
      return Option<T>.None;
    }

    public override int GetHashCode() {
      int hashCode = hasValue.GetHashCode();
      if (hasValue)
        hashCode ^= value?.GetHashCode() ?? 0;
      return hashCode;
    }

    public override bool Equals(object? obj) {
      return base.Equals(obj);
    }

    public Option<R> Bind<R>(Func<T?, Option<R>> g) {
      if (IsNone)
        return Option.None;
      return g(Value);
    }
  }

}
