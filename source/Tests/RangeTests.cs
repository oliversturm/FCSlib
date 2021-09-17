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
    int compare(int x, int y) => x - y;
    int getNext(int x) => x + 1;
    var expected = new List<int> { 1, 2, 3, 4, 5 };
    var r = Range(compare, getNext, 1, 5).ToList();
    Assert.That(r, Is.EquivalentTo(expected));
  }

  [Test]
  public void ArbitraryRange() {
    // x is current value, y is end value

    int compare(string x, string y) => (x, y) switch
    {
      ("one", "one") => 0, // values are same, will be included
      ("one", "two") => -1, // "one" < "two"
      ("one", "three") => -1, // "one" < "three"
      ("one", _) => 1, // return 1 to end range immediately
      ("two", "two") => 0, // values are same, will be included
      ("two", "three") => -1, // "two" < "three"
      ("two", _) => 1, // return 1 to end range immediately
      ("three", "three") => 0, // values are same, will be included
      ("three", _) => 1, // return 1 to end range immediately
      (_, _) => 1
    };

    string getNext(string c) => c switch
    {
      "one" => "two",
      "two" => "three",
      _ => "impossible"
    };

    var expected = new List<string> { "one", "two", "three" };
    var r = Range(compare, getNext, "one", "three").ToList();
    Assert.That(r, Is.EquivalentTo(expected));
  }
}
