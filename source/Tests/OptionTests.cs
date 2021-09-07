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

  [Test]
  public void ToOption() {
    var o = 3.ToOption();

    Assert.IsTrue(o.HasValue);
    Assert.AreEqual(3, o.Value);
    Assert.IsTrue(o.IsSome);
    Assert.IsFalse(o.IsNone);
  }

  [Test]
  public void ValueToNotNullOption() {
    string s = "thing";
    var o = s.ToNotNullOption();

    Assert.IsTrue(o.HasValue);
    Assert.AreEqual("thing", o.Value);
    Assert.IsTrue(o.IsSome);
    Assert.IsFalse(o.IsNone);
  }

}
