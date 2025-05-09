// Copyright (C) 2008-2024 Oliver Sturm <oliver@oliversturm.com>
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
using NUnit.Framework.Legacy;
using static FCSlib.Functional;

namespace Tests;

public class EitherTests {
  [SetUp]
  public void Setup() {
  }

  [Test]
  public void BasicLeft() {
    var l1 = Left("things went wrong");

    ClassicAssert.IsTrue(IsLeft(l1));
    ClassicAssert.IsFalse(IsRight(l1));
  }

  [Test]
  public void BasicRight() {
    var r1 = Right(42);

    ClassicAssert.IsTrue(IsRight(r1));
    ClassicAssert.IsFalse(IsLeft(r1));
  }

  [Test]
  public void EqualRights() {
    var r1 = Right(42);
    var r2 = Right(42);

    ClassicAssert.IsTrue(r1 == r2);
  }

  [Test]
  public void UnequalRights() {
    var r1 = Right(42);
    var r2 = Right(31);

    ClassicAssert.IsTrue(r1 != r2);
  }

  [Test]
  public void EqualLefts() {
    var l1 = Left(42);
    var l2 = Left(42);

    ClassicAssert.IsTrue(l1 == l2);
  }

  [Test]
  public void UnequalLefts() {
    var l1 = Left(42);
    var l2 = Left(31);

    ClassicAssert.IsTrue(l1 != l2);
  }

  [Test]
  public void UnequalLeftAndRightSameValue() {
    var l = Left(42);
    var r = Right(42);

    ClassicAssert.IsTrue(l != r);
  }

  [Test]
  public void UnequalRightAndLeftSameValue() {
    var l = Left(42);
    var r = Right(42);

    ClassicAssert.IsTrue(r != l);
  }

  [Test]
  public void UnequalLeftAndRightDifferentValues() {
    var l = Left("error!");
    var r = Right(42);

    ClassicAssert.IsTrue(l != r);
  }

  [Test]
  public void UnequalRightAndLeftDifferentValues() {
    var l = Left("error!");
    var r = Right(42);

    ClassicAssert.IsTrue(r != l);
  }


  [Test]
  public void EitherTestRight() {
    var e = Right(101);
    bool rightHandlerCalled = false;
    bool leftHandlerCalled = false;

    Func<int, int> rightHandler = i => {
      ClassicAssert.AreEqual(101, i);
      rightHandlerCalled = true;
      return 42;
    };

    Func<string?, int> leftHandler = s => {
      leftHandlerCalled = true;
      return -1;
    };

    var result = Either(rightHandler, leftHandler, e);
    ClassicAssert.AreEqual(42, result);
    ClassicAssert.IsTrue(rightHandlerCalled);
    ClassicAssert.IsFalse(leftHandlerCalled);
  }

  [Test]
  public void EitherTestRightCurried() {
    var e = Right(101);
    bool rightHandlerCalled = false;
    bool leftHandlerCalled = false;

    Func<int, int> rightHandler = i => {
      ClassicAssert.AreEqual(101, i);
      rightHandlerCalled = true;
      return 42;
    };

    Func<string?, int> leftHandler = s => {
      leftHandlerCalled = true;
      return -1;
    };

    var result = Either<int, string, int>(rightHandler)(leftHandler)(e);
    ClassicAssert.AreEqual(42, result);
    ClassicAssert.IsTrue(rightHandlerCalled);
    ClassicAssert.IsFalse(leftHandlerCalled);
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
      ClassicAssert.AreEqual(error, s);
      leftHandlerCalled = true;
      return -1;
    };

    var result = Either(rightHandler, leftHandler, e);
    ClassicAssert.AreEqual(-1, result);
    ClassicAssert.IsFalse(rightHandlerCalled);
    ClassicAssert.IsTrue(leftHandlerCalled);
  }

  [Test]
  public void EitherTestLeftCurried() {
    string error = "something went wrong";
    var e = Left(error);
    bool rightHandlerCalled = false;
    bool leftHandlerCalled = false;

    Func<int, int> rightHandler = i => {
      rightHandlerCalled = true;
      return 42;
    };

    Func<string?, int> leftHandler = s => {
      ClassicAssert.AreEqual(error, s);
      leftHandlerCalled = true;
      return -1;
    };

    var result = Either<int, string, int>(rightHandler)(leftHandler)(e);
    ClassicAssert.AreEqual(-1, result);
    ClassicAssert.IsFalse(rightHandlerCalled);
    ClassicAssert.IsTrue(leftHandlerCalled);
  }

  [Test]
  public void FromLeftValue() {
    var l = Left(42);
    var result = FromLeft(0, l);
    ClassicAssert.AreEqual(42, result);
  }

  [Test]
  public void FromLeftDefault() {
    var r = Right("error");
    var result = FromLeft(0, r);
    ClassicAssert.AreEqual(0, result);
  }

  [Test]
  public void FromLeftValueCurried() {
    var l = Left(42);
    var result = FromLeft(0)(l);
    ClassicAssert.AreEqual(42, result);
  }

  [Test]
  public void FromLeftDefaultCurried() {
    var r = Right("error");
    var result = FromLeft(0)(r);
    ClassicAssert.AreEqual(0, result);
  }

  [Test]
  public void FromRightValue() {
    var r = Right("error");
    var result = FromRight("all good", r);
    ClassicAssert.AreEqual("error", result);
  }

  [Test]
  public void FromRightDefault() {
    var l = Left(42);
    var result = FromRight("all good", l);
    ClassicAssert.AreEqual("all good", result);
  }

  [Test]
  public void FromRightValueCurried() {
    var r = Right("error");
    var result = FromRight("all good")(r);
    ClassicAssert.AreEqual("error", result);
  }

  [Test]
  public void FromRightDefaultCurried() {
    var l = Left(42);
    var result = FromRight("all good")(l);
    ClassicAssert.AreEqual("all good", result);
  }

  static FCSlib.Data.Either TestOperation(bool fail) => fail ? Left("Operation went wrong") : Right(42);

  // The following two tests combine an initial operation
  // (TestOperation) which can fail or succeed, with a 
  // second step that would always succeed (since Chain
  // always returns a Right at this time).
  [Test]
  public void EitherChainSuccess() {
    Func<int, int> square = x => x * x;
    var opResult = TestOperation(false);
    var squareResult = opResult.Chain(square);
    var result = FromRight(-1, squareResult);
    ClassicAssert.AreEqual(42 * 42, result);
  }

  [Test]
  public void EitherChainError() {
    Func<int, int> square = x => x * x;
    var opResult = TestOperation(true);
    var squareResult = opResult.Chain(square);
    ClassicAssert.IsTrue(IsLeft(squareResult));
  }

  [Test]
  public void EitherChainErrorIllustration() {
    // This is where the value comes from.

    Func<int> loadFromDiskBasic = () => {
      // This could go wrong, like
      // if (!File.Exists("data")) throw new FileNotFoundException();
      // ...and so on...
      // Let's be optimistic and assume it works.
      return 42;
    };

    // If we decide to work with Either directly, we can return Left or Right values:
    Func<FCSlib.Data.Either> loadFromDiskEither = () => {
      // If things go wrong, we return a Left value:
      // if (!File.Exists("data")) return Left("File not found");
      // ...and so on...
      // But if all is good, we return a Right value. Get it? A Right value!
      return Right(42);
    };

    // If we want to automatically handle the results from a function
    // that may throw an exception, there's a helper for that: Encase
    Func<FCSlib.Data.Either> loadFromDisk = FCSlib.Functional.Encase(loadFromDiskBasic);

    // We have various processing functions that may fail
    Func<int,int> parseValue = x => x switch
    {

      42 => x,
      _ => throw new Exception("Couldn't parse")
    };
    Func<int, int> square = x => x * x;
    Func<int,int> doSecretMagic = x => x < 42 ? 101: throw new Exception("No magic today");

    // Now we execute a chain of operations. Any of these steps could fail,
    // but with Monad magic we don't need to stop all the time and double-check.
    var resultOfChain = loadFromDisk().Chain(parseValue).Chain(doSecretMagic).Chain(square);

    // We expect a Left result here
    ClassicAssert.IsTrue(IsLeft(resultOfChain));

    // But in reality, we might just process the result further. Let's say we have an error handler:
    Func<Exception?, int> errorHandler = ex => {
      Console.WriteLine($"(EitherChainErrorIllustration) Error in chain: {ex?.Message}");
      // Fall back to 42, what can we do.
      return 42;
    };

    // And this is, hypothetically, where we go if all is good:
    Func<int, int> successHandler = x => {
      Console.WriteLine($"(EitherChainErrorIllustration) Now saving the world with {x}");
      return x;
    };

    // This would be the functional way - we're ignoring the result here,
    // but this approach would make sure that in error cases we do what we must to
    // fall back to some valid state and then go from there.
    Either(successHandler, errorHandler, resultOfChain);

    // Or of course we could be imperative now and simply check what the result is:
    if (IsLeft(resultOfChain)) {
      // Bad luck, things went wrong, check out the error result, handle it, or simply do nothing?
    }
    else if (IsRight(resultOfChain)) {
      // All good, save the world
    }
  }

  // The following two tests use a Right starting value
  // with a division operation that is encased to 
  // convert a divide-by-zero exception to a Left.
  [Test]
  public void EitherBindSuccess() {
    Func<int, int> divide = x => 240 / x;
    var safeDivide = Encase(divide);
    var divideResult = Right(10).Bind(safeDivide);
    ClassicAssert.IsTrue(IsRight(divideResult));
    var result = FromRight(-1, divideResult);
    ClassicAssert.AreEqual(24, result);
  }

  [Test]
  public void EitherBindError() {
    Func<int, int> divide = x => 240 / x;
    var safeDivide = Encase(divide);
    var divideResult = Right(0).Bind(safeDivide);
    ClassicAssert.IsTrue(IsLeft(divideResult));
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

  //   ClassicAssert.AreEqual(42 * 42, result);
  // }

  // [Test]
  // public void EitherOperatorBindError() {
  //   Func<int, int> square = x => x * x;
  //   var opResult = Left("error"); //TestOperation(true);

  //   // This doesn't work at all because now the either is typed
  //   // and the delegate is not compatible.
  //   var result = FromRight(-1, opResult & square);

  //   ClassicAssert.AreEqual(-1, result);
  // }

  [Test]
  public void TagRight() {
    var result = FromRight(-1, Tag(x => x > 3, 5));
    ClassicAssert.AreEqual(5, result);
  }

  [Test]
  public void TagRightCurried() {
    var result = FromRight(-1, Tag<int>(x => x > 3)(5));
    ClassicAssert.AreEqual(5, result);
  }

  [Test]
  public void TagLeft() {
    var result = FromLeft(-1, Tag(x => x > 10, 5));
    ClassicAssert.AreEqual(5, result);
  }

  [Test]
  public void TagLeftCurried() {
    var result = FromLeft(-1, Tag<int>(x => x > 10)(5));
    ClassicAssert.AreEqual(5, result);
  }

  static int ReturningFunction(int x) {
    return x * x;
  }

  static int ThrowingFunction(int x) {
    throw new InvalidOperationException("something went wrong");
  }

  [Test]
  public void EncaseSuccess() {
    var e = Encase(ReturningFunction, 11);
    var result = FromRight(-1, e);
    ClassicAssert.AreEqual(121, result);
  }

  [Test]
  public void EncaseFailure() {
    var e = Encase(ThrowingFunction, 11);
    var result = FromRight(-1, e);
    ClassicAssert.AreEqual(-1, result);

    var ex = FromLeft<Exception>(null, e);
    ClassicAssert.AreEqual("something went wrong", ex?.Message);
  }

  [Test]
  public void EncaseSuccessCurried() {
    // Even in 2021, C# compiler nonsense. Why should it not 
    // be possible to automatically detect the type parameters
    // in this case?
    var returningFunction = Encase<int, int>(ReturningFunction);
    var e = returningFunction(11);
    var result = FromRight(-1, e);
    ClassicAssert.AreEqual(121, result);
  }

  [Test]
  public void EncaseFailureCurried() {
    var throwingFunction = Encase<int, int>(ThrowingFunction);
    var e = throwingFunction(11);
    var result = FromRight(-1, e);
    ClassicAssert.AreEqual(-1, result);

    var ex = FromLeft<Exception>(null, e);
    ClassicAssert.AreEqual("something went wrong", ex?.Message);
  }
}
