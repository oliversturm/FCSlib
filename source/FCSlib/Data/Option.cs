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


namespace FCSlib.Data {
  public sealed class Option {
    private Option() { }

    public static Option<T> Some<T>(T value) => new(value);

    public static readonly Option None = new();

    public static Option<R> Bind<T, R>(Option<T> o, Func<T?, Option<R>> g) => o.Bind(g);

    public static Option<R> Bind<T, R>(Option<T> o, Func<T?, R> g) => o.Bind(g);

    public static Option<R> Bind<T, R>(T value, Func<T?, Option<R>> g) => value.ToNonDefaultOption().Bind(g);

    public static Option<R> Bind<T, R>(T value, Func<T?, R> g) => value.ToNonDefaultOption().Bind(g);


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
    public static Option<T> ToOption<T>(this T val) =>
      Option.Some(val);

    // This method has always existed. It can be used for nullable
    // reference types.
    public static Option<T> ToNotNullOption<T>(this T val) where T : class? =>
      val != null ? val.ToOption() : Option.None;

    // This method supports all types, but it returns None if 
    // the value equals the default, i.e. for ints that equal 0,
    // or for bools that equal false. If you want to use this 
    // with value types, you probably want to make them nullable,
    // i.e. use int? or bool?.
    public static Option<T> ToNonDefaultOption<T>(this T val) {
      T? defaultValue = default(T);
      if (val is IHaveCustomDefaultValue<T> haveCustomDefaultValue) {
        defaultValue = haveCustomDefaultValue.DefaultValue;
      }

      return EqualityComparer<T>.Default.Equals(
          val, defaultValue) ?
          Option.None : val.ToOption();
    }
  }

  public sealed class Option<T> {
    private readonly T? value;
    public T? Value {
      get {
        if (!HasValue)
          throw new InvalidOperationException("Can't return value for None Option");
        return value;
      }
    }
    public bool HasValue { get; init; }

    public bool IsSome => HasValue;
    public bool IsNone => !IsSome;

    public Option(T? value) {
      this.value = value;
      this.HasValue = true;
    }

    private Option() {
    }

    public static readonly Option<T> None = new();

    public static bool operator ==(Option<T> a, Option<T> b) =>
      a.HasValue == b.HasValue &&
        EqualityComparer<T>.Default.Equals(a.Value, b.Value);

    public static bool operator !=(Option<T> a, Option<T> b) =>
      !(a == b);

    public static implicit operator Option<T>(Option option) =>
      Option<T>.None;

    public override int GetHashCode() {
      int hashCode = HasValue.GetHashCode();
      if (HasValue)
        hashCode ^= Value?.GetHashCode() ?? 0;
      return hashCode;
    }

    public override bool Equals(object? obj) =>
      base.Equals(obj);

    public Option<R> Bind<R>(Func<T?, Option<R>> g) =>
      IsNone ? Option.None : g(Value);

    public Option<R> Bind<R>(Func<T?, R> g) {
      Func<T?, Option<R>> f = t => g(t).ToNonDefaultOption();
      return Bind(f);
    }

    // Note the types - the operators work only if the 
    // return type is the same as the input type, since operators
    // can't have extra generic types. Optimally it would be 
    // operator &<R>, to mirror the signature of Bind<R> above.
    public static Option<T?> operator &(Option<T> o, Func<T?, Option<T?>> g) => o.Bind(g);

    public static Option<T?> operator &(Option<T> o, Func<T?, T?> g) => o.Bind(g);

  }
}
