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

public class MemoizationTests {
  [SetUp]
  public void Setup() {
  }

  [Test]
  public void MemoizeStandard() {
    // "Always" return a new value, regardless of the argument
    Func<int, Guid> getUniqueValue = _ => Guid.NewGuid();

    var getValue = Functional.Memoize(getUniqueValue);
    var firstValue = getValue(10);
    var secondValue = getValue(10);

    Assert.AreEqual(firstValue, secondValue);
  }

  [Test]
  public void MemoizeCustomMemory() {
    // "Always" return a new value, regardless of the argument
    Func<int, Guid> getUniqueValue = _ => Guid.NewGuid();

    var getValue = Functional.Memoize(getUniqueValue);
    var getValueCustom = Functional.Memoize(getUniqueValue, "customKey");
    var standardKeyValue = getValue(10);
    var standardKeyValue2 = getValue(10);
    var customKeyValue = getValueCustom(10);
    var customKeyValue2 = getValueCustom(10);

    Assert.AreNotEqual(standardKeyValue, customKeyValue);

    Assert.AreEqual(standardKeyValue, standardKeyValue2);
    Assert.AreEqual(customKeyValue, customKeyValue2);
  }

  [Test]
  public void DeepMemoize2Levels() {
    // "Always" return a new value, regardless of the arguments
    Func<int, Func<int, Guid>> getUniqueValue = _ => __ => Guid.NewGuid();

    var getValue = Functional.DeepMemoize(getUniqueValue);
    // Using "null-forgiving" operator on the first part of the
    // function call - obviously we expect this to be non-null
    // if the memoization works correctly.
    var firstValue = getValue(10)!(20);
    var secondValue = getValue(10)!(20);

    Assert.AreEqual(firstValue, secondValue);
  }
}

