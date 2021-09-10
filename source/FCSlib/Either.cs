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


using FCSlib.Data;

namespace FCSlib {
  public static partial class Functional {
    public static Left<T> Left<T>(T value) =>
      FCSlib.Data.Either.Left(value);
    public static Right<T> Right<T>(T value) =>
      FCSlib.Data.Either.Right(value);
    public static bool IsLeft(Either e) => e.IsLeft;
    public static bool IsRight(Either e) => e.IsRight;

    public static T? FromLeft<T>(T? defaultValue, Either e) => e switch
    {
      Left<T> l => l.Value,
      _ => defaultValue
    };

    public static Func<Either, T?> FromLeft<T>(T? defaultValue) => e => FromLeft(defaultValue, e);

    public static T? FromRight<T>(T? defaultValue, Either e) => e switch
    {
      Right<T> r => r.Value,
      _ => defaultValue
    };

    public static Func<Either, T?> FromRight<T>(T? defaultValue) => e => FromRight(defaultValue, e);

    public static RES Either<R, L, RES>(
      Func<R?, RES> rightHandler,
      Func<L?, RES> leftHandler,
      Either e) => e switch
      {
        Right<R> r => rightHandler(r.Value),
        Left<L> l => leftHandler(l.Value),
        _ => throw new InvalidOperationException("Either must be Left or Light. You may be passing delegates with invalid types.")
      };

    public static Func<Func<L?, RES>, Func<Either, RES>> Either<R, L, RES>(Func<R?, RES> rightHandler) => leftHandler => e => Either(rightHandler, leftHandler, e);

    public static Either Tag<T>(Predicate<T> predicate, T value) => predicate(value) ? Right(value) : Left(value);

    public static Func<T, Either> Tag<T>(Predicate<T> predicate) => value => Tag(predicate, value);

    public static Either Encase<T, R>(Func<T, R> f, T value) {
      try { return Right(f(value)); }
      catch (Exception e) { return Left(e); }
    }

    public static Func<T, Either> Encase<T, R>(Func<T, R> f) => value => Encase(f, value);
  }
}

