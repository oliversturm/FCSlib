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

    public Either Bind<T, R>(Func<T?, R> g) {
      Func<T?, Either> f = x => Right(g(x));
      return Bind(f);
    }
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

    public static Either operator &(Either e, Func)

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
  }

  // public sealed class Either<T> {

  //   readonly T? value;
  //   readonly LeftRight type;

  //   private Either(LeftRight type, T value) {
  //     this.type = type;
  //     this.value = value;
  //   }

  //   public static Either<T> Left(T value) =>
  //     new(LeftRight.Left, value);
  //   public static Either<T> Right(T value) =>
  //     new(LeftRight.Right, value);

  //   public static bool operator ==(Either<T> a, Either<T> b) =>
  //     a.type == b.type &&
  //       EqualityComparer<T>.Default.Equals(a.value, b.value);

  //   public static bool operator !=(Either<T> a, Either<T> b) =>
  //     !(a == b);

  //   public override int GetHashCode() =>
  //     type.GetHashCode() & (value?.GetHashCode() ?? 0);

  //   public override bool Equals(object? obj) =>
  //     base.Equals(obj);

  //   public Either<R> Bind<R>(Func<T?, Either<R>> g) =>
  //     type == LeftRight.Left ? new Either<R>(LeftRight.Left, value) : g(value);
  // }
}

