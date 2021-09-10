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

public class RangeTests {
  [SetUp]
  public void Setup() {
  }

  [Test]
  public void IntRange() {
    var expected = new List<int> { 10, 11, 12, 13, 14, 15 };
    var r = Range(10, 15).ToList();
    Assert.That(r, Is.EquivalentTo(expected));
  }

  [Test]
  public void CustomIntRange() {
    Comparison<int> compare = (x, y) => x - y;
    Func<int, int> getNext = x => x + 1;
    var expected = new List<int> { 1, 2, 3, 4, 5 };
    var r = Range(compare, getNext, 1, 5).ToList();
    Assert.That(r, Is.EquivalentTo(expected));
  }

  [Test]
  public void ArbitraryRange() {
    // x is current value, y is end value
    Comparison<string> compare = (x, y) => x switch {
      "one" => y switch
      {
        "one" => 0, // values are same, will be included
        "two" => -1, // "one" < "two"
        "three" => -1, // "one" < "three"
        _ => 1 // return 1 to end range immediately
      },
      "two" => y switch
      {
        "two" => 0, // values are same, will be included
        "three" => -1, // "two" < "three"
        _ => 1 // return 1 to end range immediately
      },
      "three" => y switch
      {
        "three" => 0, // values are same, will be included
        _ => 1 // return 1 to end range immediately
      },
      _ => 1 // return 1 to end range immediately
    };
    Func<string, string> getNext = c => c switch {
      "one" => "two",
      "two" => "three",
      _ => "impossible"
    };

    var expected = new List<string> { "one", "two", "three" };
    var r = Range(compare, getNext, "one", "three").ToList();
    Assert.That(r, Is.EquivalentTo(expected));
  }
}
