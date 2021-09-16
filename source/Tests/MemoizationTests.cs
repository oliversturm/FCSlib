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
using FCSlib.Data;

using static FCSlib.Functional;

namespace Tests;

public class MemoizationTests {
  [SetUp]
  public void Setup() {
  }

  [Test]
  public void MemoizeStandard() {
    // "Always" return a new value, regardless of the argument
    Func<int, Guid> getUniqueValue = _ => Guid.NewGuid();

    // Btw, C# - surely this declaration would be regarded the same
    // by pretty much anybody - but then I can't call Memoize
    // without explicit type arguments when I use it.
    // I haven't checked it out in detail, but clearly even C# 10.0
    // still has differences in type recognition between functions
    // and delegates.
    // Guid getUniqueValue(int x) => Guid.NewGuid();

    var getValue = Memoize(getUniqueValue);
    var firstValue = getValue(10);
    var secondValue = getValue(10);

    Assert.AreEqual(firstValue, secondValue);
  }

  [Test]
  public void MemoizeCustomMemory() {
    // "Always" return a new value, regardless of the argument
    Func<int, Guid> getUniqueValue = _ => Guid.NewGuid();

    var getValue = Memoize(getUniqueValue);
    var getValueCustom = Memoize(getUniqueValue, "customKey");
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

    var getValue = DeepMemoize(getUniqueValue);
    // Using "null-forgiving" operator on the first part of the
    // function call - obviously we expect this to be non-null
    // if the memoization works correctly.
    var firstValue = getValue(10)!(20);
    var secondValue = getValue(10)!(20);

    Assert.AreEqual(firstValue, secondValue);
  }

  [Test]
  public void CreateMemoryUsingKey() {
    var memory = Memoizer<int, int>.CreateMemory("creatememoryusingkey_testkey");
    Assert.IsNotNull(memory);
  }

  [Test]
  public void CreateExistingMemory() {
    var memory = Memoizer<int, int>.CreateMemory("createexistingmemory_testkey");
    Assert.Throws<InvalidOperationException>(() => {
      var memory2 = Memoizer<int, int>.CreateMemory("createexistingmemory_testkey");
    });
  }

  [Test]
  public void GetNewMemory() {
    var memory = Memoizer<int, int>.GetMemory("getnewmemory_testkey");
    Assert.IsNotNull(memory);
  }

  [Test]
  public void GetExistingMemory() {
    var memory = Memoizer<int, int>.GetMemory("getexistingmemory_testkey");
    var memory2 = Memoizer<int, int>.GetMemory("getexistingmemory_testkey");
    Assert.IsNotNull(memory2);
    Assert.AreSame(memory, memory2);
  }

  [Test]
  public void MemoryRemember() {
    var memory = Memoizer<int, int>.GetMemory("memoryremember_testkey");
    memory.Remember(1, 42);
    memory.Remember(2, 52);
    memory.Remember(2, 104);
  }

  [Test]
  public void MemoryHasResultFor() {
    var memory = Memoizer<int, int>.GetMemory("memoryhasresultfor_testkey");
    memory.Remember(1, 42);
    Assert.IsTrue(memory.HasResultFor(1));
    Assert.IsFalse(memory.HasResultFor(2));
  }

  [Test]
  public void MemoryResultFor() {
    var memory = Memoizer<int, int>.GetMemory("memoryresultfor_testkey");
    memory.Remember(1, 42);
    memory.Remember(2, 52);
    memory.Remember(2, 104);

    Assert.AreEqual(42, memory.ResultFor(1));
    Assert.AreEqual(104, memory.ResultFor(2));
  }

  [Test]
  public void MemoryNoResultFor() {
    var memory = Memoizer<int, int>.GetMemory("memorynoresultfor_testkey");
    memory.Remember(1, 42);
    memory.Remember(2, 52);
    memory.Remember(2, 104);

    Assert.Throws<KeyNotFoundException>(() => {
      memory.ResultFor(3);
    });
  }

}

