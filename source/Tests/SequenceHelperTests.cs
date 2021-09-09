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
using FCSColl = FCSlib.Data.Collections;

namespace Tests;

public class SequenceHelperTests {
  [SetUp]
  public void Setup() {
  }

  [Test]
  public void ReverseTest() {
    var result = Reverse(new int[] { 1, 2, 3, 4 }).ToList();

    Assert.AreEqual(4, result.Count);
    Assert.AreEqual(4, result[0]);
    Assert.AreEqual(3, result[1]);
    Assert.AreEqual(2, result[2]);
    Assert.AreEqual(1, result[3]);
  }

  [Test]
  public void FirstTest() {
    var result = First(new int[] { 1, 2, 3, 4 });

    Assert.AreEqual(1, result);
  }

  [Test]
  public void TakeTest() {
    var result = Take(2, new int[] { 1, 2, 3, 4 }).ToList();

    Assert.AreEqual(2, result.Count);
    Assert.AreEqual(1, result[0]);
    Assert.AreEqual(2, result[1]);
  }

  [Test]
  public void TakeWhileTest() {
    var result = TakeWhile(x => x < 3, new int[] { 1, 2, 3, 4 }).ToList();

    Assert.AreEqual(2, result.Count);
    Assert.AreEqual(1, result[0]);
    Assert.AreEqual(2, result[1]);
  }

  [Test]
  public void SkipTest() {
    var result = Skip(2, new int[] { 1, 2, 3, 4 }).ToList();

    Assert.AreEqual(2, result.Count);
    Assert.AreEqual(3, result[0]);
    Assert.AreEqual(4, result[1]);
  }

  [Test]
  public void EachWithParam() {
    var target = FCSColl::List<int>.Empty;
    Each(new int[] { 1, 2, 3, 4 }, x => {
      target = target.Cons(x);
    });
    var result = target.ToList();

    Assert.AreEqual(4, result.Count);
    Assert.AreEqual(4, result[0]);
    Assert.AreEqual(3, result[1]);
    Assert.AreEqual(2, result[2]);
    Assert.AreEqual(1, result[3]);
  }

  [Test]
  public void EachWithoutParam() {
    var calls = 0;
    Each(new int[] { 1, 2, 3, 4 }, () => {
      calls++;
    });

    Assert.AreEqual(4, calls);
  }

  [Test]
  public void ConcatTest() {
    var result = Concat(new IEnumerable<int>[] {
      new int[] { 1, 2 },
      new int[] { 3, 4 },
      new int[] { 5, 6 } }).ToList();

    Assert.AreEqual(6, result.Count);
    Assert.AreEqual(1, result[0]);
    Assert.AreEqual(2, result[1]);
    Assert.AreEqual(3, result[2]);
    Assert.AreEqual(4, result[3]);
    Assert.AreEqual(5, result[4]);
    Assert.AreEqual(6, result[5]);
  }

  [Test]
  public void CollectTest() {
    Converter<string, int> toInt = s => Convert.ToInt32(s);
    var result = Collect(
      s => Map(toInt, s.Split(',')),
       new string[] { "1,2", "3,4,5" }).ToList();

    Assert.AreEqual(5, result.Count);
    Assert.AreEqual(1, result[0]);
    Assert.AreEqual(2, result[1]);
    Assert.AreEqual(3, result[2]);
    Assert.AreEqual(4, result[3]);
    Assert.AreEqual(5, result[4]);
  }

}

