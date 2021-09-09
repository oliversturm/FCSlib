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

public class SwapTests {
  [SetUp]
  public void Setup() {
  }

  [Test]
  public void SwapSameTypeArgs() {
    var result = Swap<string, string, int>(one => two => {
      Assert.AreEqual("one", two);
      Assert.AreEqual("two", one);
      return 42;
    })("one")("two");

    Assert.AreEqual(42, result);
  }

  [Test]
  public void SwapDifferentTypeArgs() {
    var result = Swap<string, int, bool>(one => two => {
      Assert.AreEqual(42, two);
      Assert.AreEqual("two", one);
      return true;
    })(42)("two");

    Assert.IsTrue(result);
  }

}

