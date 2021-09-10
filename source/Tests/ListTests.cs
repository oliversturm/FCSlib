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

public class ListTests {
  [Test]
  public void HeadThenAdd() {
    var l = List(1);
    l = l.Cons(2);
    l = l.Cons(3);
    var expected = new List<int> { 1, 2, 3 };
    var result = l.ToList();
    Assert.That(result, Is.EquivalentTo(expected));
  }

  [Test]
  public void EmptyThenAdd() {
    var l = List<int>();
    l = l.Cons(1);
    l = l.Cons(2);
    l = l.Cons(3);
    var expected = new List<int> { 1, 2, 3 };
    var result = l.ToList();
    Assert.That(result, Is.EquivalentTo(expected));
  }

  [Test]
  public void ThreeVals() {
    var l = List(1, 2, 3);
    var expected = new List<int> { 1, 2, 3 };
    var result = l.ToList();
    Assert.That(result, Is.EquivalentTo(expected));
  }

  [Test]
  public void Append() {
    var l1 = List(1, 2, 3);
    var l2 = List(4, 5, 6);
    var expected = new List<int> { 1, 2, 3, 4, 5, 6 };
    var result = l1.Append(l2).ToList();
    Assert.That(result, Is.EquivalentTo(expected));
  }

  [Test]
  public void AppendWithRecursion() {
    var l1 = List(1, 2, 3);
    var l2 = List(4, 5, 6);
    var expected = new List<int> { 1, 2, 3, 4, 5, 6 };
    var result = l1.AppendWithRecursion(l2).ToList();
    Assert.That(result, Is.EquivalentTo(expected));
  }

  [Test]
  public void Remove() {
    var l = List(1, 2, 3);
    var expected = new List<int> { 1, 3 };
    var result = l.Remove(2).ToList();
    Assert.That(result, Is.EquivalentTo(expected));
  }

}

