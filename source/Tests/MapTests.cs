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

public class MapTests {
  [SetUp]
  public void Setup() {
  }

  [Test]
  public void Basic() {
    var result = Map(x => x * x, new int[] { 1, 2, 3, 4 }).ToList();

    Assert.AreEqual(4, result.Count);
    Assert.AreEqual(1, result[0]);
    Assert.AreEqual(4, result[1]);
    Assert.AreEqual(9, result[2]);
    Assert.AreEqual(16, result[3]);
  }

  [Test]
  public void Curried() {
    var square = Map<int, int>(x => x * x);

    var result = square(new int[] { 1, 2, 3, 4 }).ToList();

    Assert.AreEqual(4, result.Count);
    Assert.AreEqual(1, result[0]);
    Assert.AreEqual(4, result[1]);
    Assert.AreEqual(9, result[2]);
    Assert.AreEqual(16, result[3]);
  }

}

