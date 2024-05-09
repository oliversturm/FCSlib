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

public class FoldTests {
  [SetUp]
  public void Setup() {
  }

  [Test]
  public void FoldLeft() {
    var result = FoldL((r, v) => r + v, 0, new int[] { 1, 2, 3, 4 });

    ClassicAssert.AreEqual(10, result);
  }

  [Test]
  public void FoldLeft1() {
    var result = FoldL1((r, v) => r + v, new int[] { 1, 2, 3, 4 });

    ClassicAssert.AreEqual(10, result);
  }

  [Test]
  public void FoldRight() {
    var result = FoldR((v, r) => r - v, 0, new int[] { 1, 2, 3, 4 });

    ClassicAssert.AreEqual(-10, result);
  }

  [Test]
  public void FoldRight1() {
    var result = FoldR1((v, r) => r - v, new int[] { 1, 2, 3, 4 });

    ClassicAssert.AreEqual(-2, result);
  }
}

