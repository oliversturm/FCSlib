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

using NUnit.Framework;
using static FCSlib.Functional;

namespace Tests;

public class EitherTests {
  [SetUp]
  public void Setup() {
  }

  [Test]
  public void BasicLeft() {
    var l1 = Left("things went wrong");

    Assert.IsTrue(IsLeft(l1));
    Assert.IsFalse(IsRight(l1));
  }

  [Test]
  public void BasicRight() {
    var r1 = Right(42);

    Assert.IsTrue(IsRight(r1));
    Assert.IsFalse(IsLeft(r1));
  }

  [Test]
  public void EqualRights() {
    var r1 = Right(42);
    var r2 = Right(42);

    Assert.IsTrue(r1 == r2);
  }

  [Test]
  public void UnequalRights() {
    var r1 = Right(42);
    var r2 = Right(31);

    Assert.IsTrue(r1 != r2);
  }

  [Test]
  public void EqualLefts() {
    var l1 = Left(42);
    var l2 = Left(42);

    Assert.IsTrue(l1 == l2);
  }

  [Test]
  public void UnequalLefts() {
    var l1 = Left(42);
    var l2 = Left(31);

    Assert.IsTrue(l1 != l2);
  }

  [Test]
  public void UnequalLeftAndRightSameValue() {
    var l = Left(42);
    var r = Right(42);

    Assert.IsTrue(l != r);
  }

  [Test]
  public void UnequalRightAndLeftSameValue() {
    var l = Left(42);
    var r = Right(42);

    Assert.IsTrue(r != l);
  }

  [Test]
  public void UnequalLeftAndRightDifferentValues() {
    var l = Left("error!");
    var r = Right(42);

    Assert.IsTrue(l != r);
  }

  [Test]
  public void UnequalRightAndLeftDifferentValues() {
    var l = Left("error!");
    var r = Right(42);

    Assert.IsTrue(r != l);
  }


  [Test]
  public void EitherTestRight() {
    var e = Right(101);
    bool rightHandlerCalled = false;
    bool leftHandlerCalled = false;

    Func<int, int> rightHandler = i => {
      Assert.AreEqual(101, i);
      rightHandlerCalled = true;
      return 42;
    };

    Func<string?, int> leftHandler = s => {
      leftHandlerCalled = true;
      return -1;
    };

    var result = Either(rightHandler, leftHandler, e);
    Assert.AreEqual(42, result);
    Assert.IsTrue(rightHandlerCalled);
    Assert.IsFalse(leftHandlerCalled);
  }

  [Test]
  public void EitherTestLeft() {
    string error = "something went wrong";
    var e = Left(error);
    bool rightHandlerCalled = false;
    bool leftHandlerCalled = false;

    Func<int, int> rightHandler = i => {
      rightHandlerCalled = true;
      return 42;
    };

    Func<string?, int> leftHandler = s => {
      Assert.AreEqual(error, s);
      leftHandlerCalled = true;
      return -1;
    };

    var result = Either(rightHandler, leftHandler, e);
    Assert.AreEqual(-1, result);
    Assert.IsFalse(rightHandlerCalled);
    Assert.IsTrue(leftHandlerCalled);
  }

  [Test]
  public void FromLeftValue() {
    var l = Left(42);
    var result = FromLeft(0, l);
    Assert.AreEqual(42, result);
  }

  [Test]
  public void FromLeftDefault() {
    var r = Right("error");
    var result = FromLeft(0, r);
    Assert.AreEqual(0, result);
  }

  [Test]
  public void FromRightValue() {
    var r = Right("error");
    var result = FromRight("all good", r);
    Assert.AreEqual("error", result);
  }

  [Test]
  public void FromRightDefault() {
    var l = Left(42);
    var result = FromRight("all good", l);
    Assert.AreEqual("all good", result);
  }

  static FCSlib.Data.Either TestOperation(bool fail) => fail ? Left("Operation went wrong") : Right(42);

  [Test]
  public void EitherBindSuccess() {
    Func<int, int> square = x => x * x;
    var opResult = TestOperation(false);
    var squareResult = opResult.Bind(square);
    var result = FromRight(-1, squareResult);
    Assert.AreEqual(42 * 42, result);
  }

  [Test]
  public void EitherBindError() {
    Func<int, int> square = x => x * x;
    var opResult = TestOperation(true);
    var squareResult = opResult.Bind(square);
    var result = FromRight(-1, squareResult);
    Assert.AreEqual(-1, result);
  }

  // Leaving these in place as a reminder. To summarize:
  // With the operator & implementation in the derived types
  // I can run the xxxSuccess test as long as I hold a ref
  // to the derived type, /not/ to the Either base class. Not
  // very realistic, but perhaps potentially useful. However,
  // I still can't run the xxxError test because the types
  // are wrong - this is supposed to be resolved by the 
  // non-generic base class. But I can't implement & in the 
  // non-generic base class, even though that's where Bind
  // lives happily - the reason is that C# does not allow me
  // to specify a generic parameter for the operator static
  // method - a rather random limitation in my eyes, but nothing
  // I can change.
  //
  // [Test]
  // public void EitherOperatorBindSuccess() {
  //   Func<int, int> square = x => x * x;
  //   var opResult = Right(42); //TestOperation(false);

  //   // Note that the operator based Bind only works if the local
  //   // variable is typed as Left<T> or Right<T>, not for the base
  //   // class Either.
  //   var result = FromRight(-1, opResult & square);

  //   Assert.AreEqual(42 * 42, result);
  // }

  // [Test]
  // public void EitherOperatorBindError() {
  //   Func<int, int> square = x => x * x;
  //   var opResult = Left("error"); //TestOperation(true);

  //   // This doesn't work at all because now the either is typed
  //   // and the delegate is not compatible.
  //   var result = FromRight(-1, opResult & square);

  //   Assert.AreEqual(-1, result);
  // }

}
