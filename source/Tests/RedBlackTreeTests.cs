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

using FCSlib.Data.Collections;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using static FCSlib.Functional;

namespace Tests;

public class RedBlackTreeTests {
  [Test]
  public void TreeThenInsert() {
    var t = RedBlackTree(5);
    t = t.Insert(4);
    t = t.Insert(6);
    var result = t.ToArray();
    var expected = new int[] { 4, 5, 6 };
    Assert.That(result, Is.EqualTo(expected));
  }

  [Test]
  public void FiveValues() {
    var t = RedBlackTree(5, 11, 1, 13, 47);
    var result = t.ToArray();
    var expected = new int[] { 1, 5, 11, 13, 47 };
    Assert.That(result, Is.EqualTo(expected));
  }

  [Test]
  public void FiftyValuesEnumerable() {
    int[] source = {
      67,82,12,978,873,
      8,12,65,345,90,
      45,34,845,89,16,
      64,87,63,58,79,
      14,45,25,38,347,
      74,25,89,64,24,
      83,45,78,96,51,
      71,52,41,57,42,
      78,73,49,67,33,
      79,53,67,83,56
      };
    var t = RedBlackTree((IEnumerable<int>)source);
    var result = t.ToArray();
    // Note Distinct - this is how the implementation behaves
    var expected = source.OrderBy(x => x).Distinct().ToArray();
    Assert.That(result, Is.EqualTo(expected));
  }

  [Test]
  public void DoesContain() {
    var t = RedBlackTree(5, 11, 1, 13, 47);
    ClassicAssert.IsTrue(t.Contains(11));
  }

  [Test]
  public void DoesNotContain() {
    var t = RedBlackTree(5, 11, 1, 13, 47);
    ClassicAssert.IsFalse(t.Contains(33));
  }

  [Test]
  public void NoBalance() {
    var t = RedBlackTree(5);
    t = t.Insert(4);
    t = t.Insert(6);
    Assert.That(t.Value, Is.EqualTo(5));
    Assert.That(t.Left.Value, Is.EqualTo(4));
    Assert.That(t.Right.Value, Is.EqualTo(6));
  }

  // These tests don't aim to cover all balancing cases, but a few basic
  // ones so that a badly broken balance function can be detected.
  [Test]
  public void Balance1() {
    var t = RedBlackTree(2);
    t = t.Insert(3);
    t = t.Insert(4);
    Assert.That(t.Value, Is.EqualTo(3));
    Assert.That(t.Left.Value, Is.EqualTo(2));
    Assert.That(t.Right.Value, Is.EqualTo(4));
  }

  [Test]
  public void Balance2() {
    var t = RedBlackTree(4);
    t = t.Insert(3);
    t = t.Insert(2);
    Assert.That(t.Value, Is.EqualTo(3));
    Assert.That(t.Left.Value, Is.EqualTo(2));
    Assert.That(t.Right.Value, Is.EqualTo(4));
  }

  [Test]
  public void Balance3() {
    var t = RedBlackTree(2);
    t = t.Insert(12);
    t = t.Insert(22);
    t = t.Insert(3);
    t = t.Insert(4);
    Assert.That(t.Value, Is.EqualTo(12));
    Assert.That(t.Left.Value, Is.EqualTo(3));
    Assert.That(t.Right.Value, Is.EqualTo(22));
    Assert.That(t.Left.Left.Value, Is.EqualTo(2));
    Assert.That(t.Left.Right.Value, Is.EqualTo(4));
  }
}