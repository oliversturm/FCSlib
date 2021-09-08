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

    // This method has always existed. It can be used for nullable
    // reference types.
    public static Option<T> ToNotNullOption<T>(this T val) where T : class? {
      return val != null ? val.ToOption() : Option.None;
    }

    // This method supports all types, but it returns None if 
    // the value equals the default, i.e. for ints that equal 0,
    // or for bools that equal false. If you want to use this 
    // with value types, you probably want to make them nullable,
    // i.e. use int? or bool?.
    public static Option<T> ToNonDefaultOption<T>(this T val) {
      return EqualityComparer<T>.Default.Equals(val, default(T)) ? Option.None : val.ToOption();
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

    public static readonly Option<T> None = new();

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

    public static Option<T> operator &(Option<T> x, Func<T?, Option<T>> g) =>
      x.Bind(g);

    // For future reference: I considered a structure like this,
    // to automatically bring back a new result from Bind into
    // the monadic system. However, this doesn't work for structural
    // reasons. For instance, based on the simply & operator 
    // above, I can do this:
    //
    //  var result = 5.ToOption() &
    //     (v => 7.ToOption() &
    //       (v2 => (v + v2).ToOption()));
    //
    // However, with the hypothetical operator below, the structure
    // of the call would change to this:
    //
    // var result = (5.ToOption() & (x => 7)) & (y => PROBLEM);
    //
    // The issue is that the second step that should perform
    // the calculation can't access the second value - only one
    // of the two values is available because the nesting is
    // different. So I abandoned this approach.

    // public static Option<T> operator &(Option<T> x, Func<T?, T> g) {
    //   Func<T?, Option<T>> f = t => g(t).ToNonDefaultOption();
    //   return x.Bind(f);
    // }
  }

}
