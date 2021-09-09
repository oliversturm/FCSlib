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
using FCSlib.Data;
using FCSColl = FCSlib.Data.Collections;
using static FCSlib.Functional;

namespace Tests;

public class OptionTests {
  [SetUp]
  public void Setup() {
  }

  [Test]
  public void BasicSome() {
    var o = Option.Some(3);

    Assert.IsTrue(o.HasValue);
    Assert.AreEqual(3, o.Value);
    Assert.IsTrue(o.IsSome);
    Assert.IsFalse(o.IsNone);
  }

  [Test]
  public void BasicNone() {
    var o = Option.None;

    Assert.IsFalse(o.HasValue);
    Assert.IsFalse(o.IsSome);
    Assert.IsTrue(o.IsNone);
  }

  [Test]
  public void CompareGenericEqual() {
    var o1 = Option.Some(3);
    var o2 = Option.Some(3);

    Assert.IsTrue(o1 == o2);
  }

  [Test]
  public void CompareGenericNotEqual() {
    var o1 = Option.Some(3);
    var o2 = Option.Some(4);

    Assert.IsFalse(o1 == o2);
    Assert.IsTrue(o1 != o2);
  }

  [Test]
  public void CompareNones() {
    var o1 = Option.None;
    var o2 = Option.None;

    Assert.IsTrue(o1 == o2);
  }

  [Test]
  public void CompareOneNone() {
    var o1 = Option.Some(3);
    var o2 = Option.None;

    Assert.IsFalse(o1 == o2);
    Assert.IsTrue(o1 != o2);
  }

  [Test]
  public void NoneThrowsOnValueAccess() {
    var o1 = Option<int>.None;
    Assert.Throws<InvalidOperationException>(() => {
      int x = o1.Value + 1;
    });
  }

  [Test]
  public void ListOfOptions() {
    List<Option<int>> os = new();
    os.Add(Option.Some(3));
    os.Add(Option.Some(5));
    os.Add(Option.None);
  }

  static void AssertIsSome<T>(Option<T> o, T? val) {
    Assert.IsTrue(o.HasValue);
    Assert.AreEqual(val, o.Value);
    Assert.IsTrue(o.IsSome);
    Assert.IsFalse(o.IsNone);
  }

  static void AssertIsNone<T>(Option<T> o) {
    Assert.IsFalse(o.HasValue);
    Assert.IsFalse(o.IsSome);
    Assert.IsTrue(o.IsNone);
  }

  static void AssertIsNone(Option o) {
    Assert.IsFalse(o.HasValue);
    Assert.IsFalse(o.IsSome);
    Assert.IsTrue(o.IsNone);
  }

  [Test]
  public void FunctionalSome() {
    var o = Some(3);

    AssertIsSome(o, 3);
  }

  [Test]
  public void FunctionalNone() {
    var o = None;

    AssertIsNone(o);
  }

  [Test]
  public void FunctionalOptionalSome() {
    var o = Optional("this");

    AssertIsSome(o, "this");
  }

  [Test]
  public void FunctionalOptionalNone() {
    int? i = null;
    var o = Optional(i);

    AssertIsNone(o);
  }

  [Test]
  public void ToOption() {
    var o = 3.ToOption();

    AssertIsSome(o, 3);
  }

  [Test]
  public void ValueToNotNullOption() {
    string s = "thing";
    var o = s.ToNotNullOption();

    AssertIsSome(o, "thing");
  }

  [Test]
  public void NoValueToNotNullOption() {
    string? s = null;
    var o = s.ToNotNullOption();

    AssertIsNone(o);
  }


  [Test]
  public void StringValueToNonDefaultOption() {
    string s = "thing";
    var o = s.ToNonDefaultOption();

    AssertIsSome(o, "thing");
  }

  [Test]
  public void NullableStringValueToNonDefaultOption() {
    string? s = "thing";
    var o = s.ToNonDefaultOption();

    AssertIsSome(o, "thing");
  }

  [Test]
  public void NullStringValueToNonDefaultOption() {
    string? s = null;
    var o = s.ToNonDefaultOption();

    AssertIsNone(o);
  }

  [Test]
  public void IntValueToNonDefaultOption() {
    int i = 5;
    var o = i.ToNonDefaultOption();

    AssertIsSome(o, 5);
  }

  [Test]
  public void ZeroIntValueToNonDefaultOption() {
    int i = 0;
    var o = i.ToNonDefaultOption();

    AssertIsNone(o);
  }

  [Test]
  public void NullableIntValueToNonDefaultOption() {
    int? i = 5;
    var o = i.ToNonDefaultOption();

    AssertIsSome(o, 5);
  }

  [Test]
  public void NullableZeroIntValueToNonDefaultOption() {
    int? i = 0;
    var o = i.ToNonDefaultOption();

    AssertIsSome(o, 0);
  }

  [Test]
  public void NullIntValueToNonDefaultOption() {
    int? i = null;
    var o = i.ToNonDefaultOption();

    AssertIsNone(o);
  }



  [Test]
  public void BoolValueToNonDefaultOption() {
    bool b = true;
    var o = b.ToNonDefaultOption();

    AssertIsSome(o, true);
  }

  [Test]
  public void FalseBoolValueToNonDefaultOption() {
    bool b = false;
    var o = b.ToNonDefaultOption();

    AssertIsNone(o);
  }


  [Test]
  public void NullableBoolValueToNonDefaultOption() {
    bool? b = true;
    var o = b.ToNonDefaultOption();

    AssertIsSome(o, true);
  }

  [Test]
  public void NullableFalseBoolValueToNonDefaultOption() {
    bool? b = false;
    var o = b.ToNonDefaultOption();

    AssertIsSome(o, false);
  }

  [Test]
  public void NullBoolValueToNonDefaultOption() {
    bool? b = null;
    var o = b.ToNonDefaultOption();

    AssertIsNone(o);
  }


  [Test]
  public void BindSome() {
    var result = 5.ToOption().Bind(
      v => 7.ToOption().Bind(
        v2 => (v + v2).ToOption()));
    AssertIsSome(result, 12);
  }

  [Test]
  public void BindNone() {
    var result = 5.ToOption().Bind(
      v => Option<int>.None.Bind(
        v2 => (v + v2).ToOption()));
    AssertIsNone(result);
  }

  [Test]
  public void OperatorBindSome() {
    var result = 5.ToOption() &
      (v => 7.ToOption() &
        (v2 => (v + v2).ToOption()));
    AssertIsSome(result, 12);
  }

  [Test]
  public void SwitchOnOption() {
    var result = 12.ToOption();

    // I considered deconstructing the option in the "some"
    // case - like I would expect to be able to do in JS
    // for instance, but it turns out that
    // * I can't deconstruct just one value - not supported
    // * I can't deconstruct function parameters. I was confused
    //   about that for a moment because there's a syntax
    //   that accepts tuples as method arguments and it looks
    //   rather like deconstruction, but it's not.
    // Huh.

    var testResult = result switch { { IsSome: true } some => $"Result is {some.Value}",
      _ => "No idea what this is"
    };

    Assert.AreEqual("Result is 12", testResult);
  }

  [Test]
  public void OperatorBindNone() {
    var result = 5.ToOption() &
      (v => Option<int>.None &
        (v2 => (v + v2).ToOption()));
    AssertIsNone(result);
  }

  [Test]
  public void BindSomeAutoConversion() {
    var result = 5.ToOption().Bind(
      v => 7.ToOption().Bind<int>(
        v2 => (v + v2)));
    AssertIsSome(result, 12);
  }

  [Test]
  public void StaticOptionBindSomeAutoConversion() {
    var result =
      Option.Bind(5,
        v => Option.Bind(7,
          v2 => v + v2));

    AssertIsSome(result, 12);
  }

  //               Paul
  //          /           \
  //    Adam                Willy
  //         \            /
  //       Bernie       Suzie

  static FCSColl::UnbalancedBinaryTree<string> CreateTestTree() {
    var tree = new FCSColl::UnbalancedBinaryTree<string>();
    tree = tree.Insert("Paul");
    tree = tree.Insert("Adam");
    tree = tree.Insert("Bernie");
    tree = tree.Insert("Willy");
    tree = tree.Insert("Suzie");
    return tree;
  }

  [Test]
  public void GetThirdLeftChild() {
    var tree = CreateTestTree();

    // Following the tree to the left three times should
    // find nothing - so we expect None. Point is, we
    // don't need any explicit checks and conditional
    // execution paths for this.

    var result =
      Option
        .Bind(tree, t => t?.Left)
        .Bind(t => t?.Left)
        .Bind(t => t?.Left);

    AssertIsNone(result);
  }

  [Test]
  public void GetSecondLeftChildOperator() {
    var tree = CreateTestTree();

    // Following the tree to the left three times should
    // find nothing - so we expect None. Point is, we
    // don't need any explicit checks and conditional
    // execution paths for this.

    var result =
      Optional(tree) &
      (t => t?.Left) &
      (t => t?.Left);

    AssertIsNone(result);
  }

  [Test]
  public void GetThirdLeftChildOperator() {
    var tree = CreateTestTree();

    // Following the tree to the left three times should
    // find nothing - so we expect None. Point is, we
    // don't need any explicit checks and conditional
    // execution paths for this.

    var result =
      tree.ToNonDefaultOption() &
      (t => t?.Left) &
      (t => t?.Left) &
      (t => t?.Left);

    AssertIsNone(result);
  }

  [Test]
  public void GetLeftRightChild() {
    var tree = CreateTestTree();

    // Following the tree to the left and then to the right
    // should yield Bernie

    var result =
      Option
        .Bind(tree, t => t?.Left)
        .Bind(t => t?.Right);

    Assert.AreEqual("Bernie", result.Value?.Value);
  }

  [Test]
  public void GetLeftRightChildOperator() {
    var tree = CreateTestTree();

    // Following the tree to the left and then to the right
    // should yield Bernie

    var result =
      tree.ToNonDefaultOption() &
      (t => t?.Left) &
      (t => t?.Right);

    Assert.AreEqual("Bernie", result.Value?.Value);
  }
}
