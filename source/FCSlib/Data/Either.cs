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
  public abstract class Either {
    public abstract bool IsLeft { get; }
    public abstract bool IsRight { get; }

    public static Left<T> Left<T>(T value) => new(value);
    public static Right<T> Right<T>(T value) => new(value);

    // These operators are only used in a case where 
    // Left<T> and Right<U> are compared - i.e. impossible
    // cases. All situations that may actually represent
    // equality are handled by the derived generic types.

    public static bool operator ==(Either a, Either b) => false;

    public static bool operator !=(Either a, Either b) =>
      !(a == b);

    public override int GetHashCode() => 0;

    public override bool Equals(object? obj) =>
      base.Equals(obj);


    public Either Bind<T>(Func<T?, Either> g) => this switch
    {
      { IsLeft: true } => this,
      Right<T> r => g(r.Value),
      _ => throw new InvalidOperationException("Either must be Left or Right. You may be passing a delegate with an incompatible input type.")
    };

    // The Chain function is of limited use for Either, because
    // it needs to make assumptions to automatically decide to use 
    // a Right or a Left. For now I just return a Right, assuming
    // that a calculation which does not return Either is always
    // Right - that's likely not the best solution. Bind will be
    // more commonly used with Either, in any case.
    public Either Chain<T, R>(Func<T?, R> g) {
      Func<T?, Either> f = x => Right(g(x));
      return Bind(f);
    }

    // Would love to implement the & operator on this level, so
    // that Either & Func<...> would also work. However, this 
    // is not supported by C# for some reason:

    // public static Either operator &<T>(Either e, Func<T?, Either> g) => e.Bind(g);

    // public static Either operator &<T>(Either e, Func<T?, T?> g) => e.Bind(g);
  }

  public sealed class Left<T> : Either {
    public T? Value { get; init; }
    public Left(T? value) {
      this.Value = value;
    }

    public override bool IsLeft => true;
    public override bool IsRight => false;

    public static bool operator ==(Left<T> a, Left<T> b) =>
      EqualityComparer<T>.Default.Equals(a.Value, b.Value);

    public static bool operator !=(Left<T> a, Left<T> b) =>
      !(a == b);

    public static bool operator ==(Left<T> a, Right<T> b) => false;

    public static bool operator !=(Left<T> a, Right<T> b) =>
      !(a == b);

    public override int GetHashCode() =>
      "left".GetHashCode() & (Value?.GetHashCode() ?? 0);

    public override bool Equals(object? obj) =>
      base.Equals(obj);

    // Leaving in as a reminder - see notes in test file
    // public static Either operator &(Left<T> e, Func<T?, Either> g) => e.Bind(g);

    // public static Either operator &(Left<T> e, Func<T?, T?> g) => e.Bind(g);
  }

  public sealed class Right<T> : Either {
    public T? Value { get; init; }
    public Right(T? value) {
      this.Value = value;
    }

    public override bool IsLeft => false;
    public override bool IsRight => true;

    public static bool operator ==(Right<T> a, Right<T> b) =>
      EqualityComparer<T>.Default.Equals(a.Value, b.Value);

    public static bool operator !=(Right<T> a, Right<T> b) =>
      !(a == b);

    public static bool operator ==(Right<T> a, Left<T> b) => false;

    public static bool operator !=(Right<T> a, Left<T> b) =>
      !(a == b);

    public override int GetHashCode() =>
      "right".GetHashCode() & (Value?.GetHashCode() ?? 0);

    public override bool Equals(object? obj) =>
      base.Equals(obj);

    // Leaving in as a reminder - see notes in test file
    // public static Either operator &(Right<T> e, Func<T?, Either> g) => e.Bind(g);

    // public static Either operator &(Right<T> e, Func<T?, T?> g) => e.Bind(g);

  }
}

