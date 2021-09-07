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

    // Need to remind myself why I implemented
    // None in both the generic and the non-generic type,
    // and why I didn't include the properties 
    // in both types.

    // Assert.IsTrue(o.HasValue);
    // Assert.AreEqual(3, o.Value);
    // Assert.IsTrue(o.IsSome);
    // Assert.IsFalse(o.IsNone);
  }
}
