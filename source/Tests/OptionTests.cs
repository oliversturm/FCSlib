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
using FCSlib;
using FCSlib.Data;

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
  public void ListOfOptions() {
    List<Option<int>> os = new();
    os.Add(Option.Some(3));
    os.Add(Option.Some(5));
    os.Add(Option.None);
  }

  static void AssertIsSome<T>(Option<T> o, T val) {
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
  public void StaticBindSomeAutoConversion() {
    var result = Option<int>.Bind(5,
    v => Option<int>.Bind<int>(7, v2 => v + v2));

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

}
