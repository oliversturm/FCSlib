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

namespace Tests;

public class FoldTests {
  [SetUp]
  public void Setup() {
  }

  [Test]
  public void FoldL() {
    var result = Functional.FoldL((r, v) => r + v, 0, new int[] { 1, 2, 3, 4 });

    Assert.AreEqual(10, result);
  }

  [Test]
  public void FoldL1() {
    var result = Functional.FoldL1((r, v) => r + v, new int[] { 1, 2, 3, 4 });

    Assert.AreEqual(10, result);
  }

  [Test]
  public void FoldR() {
    var result = Functional.FoldR((v, r) => r - v, 0, new int[] { 1, 2, 3, 4 });

    Assert.AreEqual(-10, result);
  }

  [Test]
  public void FoldR1() {
    var result = Functional.FoldR1((v, r) => r - v, new int[] { 1, 2, 3, 4 });

    Assert.AreEqual(-2, result);
  }
}

