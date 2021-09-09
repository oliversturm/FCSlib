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

public class FilterTests {
  [SetUp]
  public void Setup() {
  }

  [Test]
  public void Basic() {
    var result = Filter(x => x >= 3, new int[] { 1, 2, 3, 4 }).ToList();

    Assert.AreEqual(2, result.Count);
    Assert.AreEqual(3, result[0]);
    Assert.AreEqual(4, result[1]);
  }

  [Test]
  public void Curried() {
    var greater3 = Filter<int>(x => x > 3);
    var result = greater3(new int[] { 1, 2, 3, 4 }).ToList();

    Assert.AreEqual(1, result.Count);
    Assert.AreEqual(4, result[0]);
  }
}

