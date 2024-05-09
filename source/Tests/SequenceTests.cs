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

using NUnit.Framework;
using NUnit.Framework.Legacy;
using static FCSlib.Functional;

namespace Tests;

public class SequenceTests {
  [SetUp]
  public void Setup() {
  }

  [Test]
  public void Basic() {
    var result = Sequence(x => x * x, 2, x => x > 1000).ToList();

    ClassicAssert.AreEqual(5, result.Count);
    ClassicAssert.AreEqual(2, result[0]);
    ClassicAssert.AreEqual(4, result[1]);
    ClassicAssert.AreEqual(16, result[2]);
    ClassicAssert.AreEqual(256, result[3]);
    ClassicAssert.AreEqual(65536, result[4]);
  }

}

