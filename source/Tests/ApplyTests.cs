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

public class ApplyTests {
  [SetUp]
  public void Setup() {
  }

  #region Apply Func, 2 params

  [Test]
  public void Func2ParamsApply1() {
    var result = Apply<int, int, int>((p1, p2) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      return 42;
    }, 1)(2);

    Assert.AreEqual(42, result);
  }

  #endregion

  #region Apply Func, 3 params

  [Test]
  public void Func3ParamsApply1() {
    var result = Apply<int, int, int, int>((p1, p2, p3) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      return 42;
    }, 1)(2, 3);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func3ParamsApply2() {
    var result = Apply<int, int, int, int>((p1, p2, p3) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      return 42;
    }, 1, 2)(3);

    Assert.AreEqual(42, result);
  }

  #endregion

  #region Apply Func, 4 params

  [Test]
  public void Func4ParamsApply1() {
    var result = Apply<int, int, int, int, int>((p1, p2, p3, p4) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      return 42;
    }, 1)(2, 3, 4);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func4ParamsApply2() {
    var result = Apply<int, int, int, int, int>((p1, p2, p3, p4) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      return 42;
    }, 1, 2)(3, 4);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func4ParamsApply3() {
    var result = Apply<int, int, int, int, int>((p1, p2, p3, p4) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      return 42;
    }, 1, 2, 3)(4);

    Assert.AreEqual(42, result);
  }

  #endregion

  #region Apply Func, 5 params

  [Test]
  public void Func5ParamsApply1() {
    var result = Apply<int, int, int, int, int, int>((p1, p2, p3, p4, p5) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      return 42;
    }, 1)(2, 3, 4, 5);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func5ParamsApply2() {
    var result = Apply<int, int, int, int, int, int>((p1, p2, p3, p4, p5) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      return 42;
    }, 1, 2)(3, 4, 5);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func5ParamsApply3() {
    var result = Apply<int, int, int, int, int, int>((p1, p2, p3, p4, p5) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      return 42;
    }, 1, 2, 3)(4, 5);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func5ParamsApply4() {
    var result = Apply<int, int, int, int, int, int>((p1, p2, p3, p4, p5) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      return 42;
    }, 1, 2, 3, 4)(5);

    Assert.AreEqual(42, result);
  }

  #endregion

  #region Apply Func, 6 params

  [Test]
  public void Func6ParamsApply1() {
    var result = Apply<int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      return 42;
    }, 1)(2, 3, 4, 5, 6);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func6ParamsApply2() {
    var result = Apply<int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      return 42;
    }, 1, 2)(3, 4, 5, 6);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func6ParamsApply3() {
    var result = Apply<int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      return 42;
    }, 1, 2, 3)(4, 5, 6);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func6ParamsApply4() {
    var result = Apply<int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      return 42;
    }, 1, 2, 3, 4)(5, 6);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func6ParamsApply5() {
    var result = Apply<int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      return 42;
    }, 1, 2, 3, 4, 5)(6);

    Assert.AreEqual(42, result);
  }

  #endregion

  #region Apply Func, 7 params

  [Test]
  public void Func7ParamsApply1() {
    var result = Apply<int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      return 42;
    }, 1)(2, 3, 4, 5, 6, 7);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func7ParamsApply2() {
    var result = Apply<int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      return 42;
    }, 1, 2)(3, 4, 5, 6, 7);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func7ParamsApply3() {
    var result = Apply<int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      return 42;
    }, 1, 2, 3)(4, 5, 6, 7);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func7ParamsApply4() {
    var result = Apply<int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      return 42;
    }, 1, 2, 3, 4)(5, 6, 7);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func7ParamsApply5() {
    var result = Apply<int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      return 42;
    }, 1, 2, 3, 4, 5)(6, 7);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func7ParamsApply6() {
    var result = Apply<int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      return 42;
    }, 1, 2, 3, 4, 5, 6)(7);

    Assert.AreEqual(42, result);
  }

  #endregion

  #region Apply Func, 8 params

  [Test]
  public void Func8ParamsApply1() {
    var result = Apply<int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      return 42;
    }, 1)(2, 3, 4, 5, 6, 7, 8);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func8ParamsApply2() {
    var result = Apply<int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      return 42;
    }, 1, 2)(3, 4, 5, 6, 7, 8);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func8ParamsApply3() {
    var result = Apply<int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      return 42;
    }, 1, 2, 3)(4, 5, 6, 7, 8);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func8ParamsApply4() {
    var result = Apply<int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      return 42;
    }, 1, 2, 3, 4)(5, 6, 7, 8);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func8ParamsApply5() {
    var result = Apply<int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      return 42;
    }, 1, 2, 3, 4, 5)(6, 7, 8);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func8ParamsApply6() {
    var result = Apply<int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      return 42;
    }, 1, 2, 3, 4, 5, 6)(7, 8);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func8ParamsApply7() {
    var result = Apply<int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7)(8);

    Assert.AreEqual(42, result);
  }

  #endregion

  #region Apply Func, 9 params

  [Test]
  public void Func9ParamsApply1() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      return 42;
    }, 1)(2, 3, 4, 5, 6, 7, 8, 9);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func9ParamsApply2() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      return 42;
    }, 1, 2)(3, 4, 5, 6, 7, 8, 9);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func9ParamsApply3() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      return 42;
    }, 1, 2, 3)(4, 5, 6, 7, 8, 9);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func9ParamsApply4() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      return 42;
    }, 1, 2, 3, 4)(5, 6, 7, 8, 9);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func9ParamsApply5() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      return 42;
    }, 1, 2, 3, 4, 5)(6, 7, 8, 9);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func9ParamsApply6() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      return 42;
    }, 1, 2, 3, 4, 5, 6)(7, 8, 9);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func9ParamsApply7() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7)(8, 9);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func9ParamsApply8() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8)(9);

    Assert.AreEqual(42, result);
  }

  #endregion

  #region Apply Func, 10 params

  [Test]
  public void Func10ParamsApply1() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      return 42;
    }, 1)(2, 3, 4, 5, 6, 7, 8, 9, 10);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func10ParamsApply2() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      return 42;
    }, 1, 2)(3, 4, 5, 6, 7, 8, 9, 10);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func10ParamsApply3() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      return 42;
    }, 1, 2, 3)(4, 5, 6, 7, 8, 9, 10);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func10ParamsApply4() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      return 42;
    }, 1, 2, 3, 4)(5, 6, 7, 8, 9, 10);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func10ParamsApply5() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      return 42;
    }, 1, 2, 3, 4, 5)(6, 7, 8, 9, 10);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func10ParamsApply6() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      return 42;
    }, 1, 2, 3, 4, 5, 6)(7, 8, 9, 10);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func10ParamsApply7() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7)(8, 9, 10);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func10ParamsApply8() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8)(9, 10);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func10ParamsApply9() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9)(10);

    Assert.AreEqual(42, result);
  }

  #endregion

  #region Apply Func, 11 params

  [Test]
  public void Func11ParamsApply1() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      return 42;
    }, 1)(2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func11ParamsApply2() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      return 42;
    }, 1, 2)(3, 4, 5, 6, 7, 8, 9, 10, 11);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func11ParamsApply3() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      return 42;
    }, 1, 2, 3)(4, 5, 6, 7, 8, 9, 10, 11);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func11ParamsApply4() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      return 42;
    }, 1, 2, 3, 4)(5, 6, 7, 8, 9, 10, 11);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func11ParamsApply5() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      return 42;
    }, 1, 2, 3, 4, 5)(6, 7, 8, 9, 10, 11);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func11ParamsApply6() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      return 42;
    }, 1, 2, 3, 4, 5, 6)(7, 8, 9, 10, 11);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func11ParamsApply7() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7)(8, 9, 10, 11);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func11ParamsApply8() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8)(9, 10, 11);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func11ParamsApply9() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9)(10, 11);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func11ParamsApply10() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)(11);

    Assert.AreEqual(42, result);
  }

  #endregion

  #region Apply Func, 12 params

  [Test]
  public void Func12ParamsApply1() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      return 42;
    }, 1)(2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func12ParamsApply2() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      return 42;
    }, 1, 2)(3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func12ParamsApply3() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      return 42;
    }, 1, 2, 3)(4, 5, 6, 7, 8, 9, 10, 11, 12);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func12ParamsApply4() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      return 42;
    }, 1, 2, 3, 4)(5, 6, 7, 8, 9, 10, 11, 12);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func12ParamsApply5() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      return 42;
    }, 1, 2, 3, 4, 5)(6, 7, 8, 9, 10, 11, 12);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func12ParamsApply6() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      return 42;
    }, 1, 2, 3, 4, 5, 6)(7, 8, 9, 10, 11, 12);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func12ParamsApply7() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7)(8, 9, 10, 11, 12);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func12ParamsApply8() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8)(9, 10, 11, 12);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func12ParamsApply9() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9)(10, 11, 12);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func12ParamsApply10() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)(11, 12);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func12ParamsApply11() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)(12);

    Assert.AreEqual(42, result);
  }

  #endregion

  #region Apply Func, 13 params

  [Test]
  public void Func13ParamsApply1() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      return 42;
    }, 1)(2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func13ParamsApply2() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      return 42;
    }, 1, 2)(3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func13ParamsApply3() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      return 42;
    }, 1, 2, 3)(4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func13ParamsApply4() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      return 42;
    }, 1, 2, 3, 4)(5, 6, 7, 8, 9, 10, 11, 12, 13);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func13ParamsApply5() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      return 42;
    }, 1, 2, 3, 4, 5)(6, 7, 8, 9, 10, 11, 12, 13);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func13ParamsApply6() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      return 42;
    }, 1, 2, 3, 4, 5, 6)(7, 8, 9, 10, 11, 12, 13);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func13ParamsApply7() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7)(8, 9, 10, 11, 12, 13);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func13ParamsApply8() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8)(9, 10, 11, 12, 13);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func13ParamsApply9() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9)(10, 11, 12, 13);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func13ParamsApply10() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)(11, 12, 13);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func13ParamsApply11() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)(12, 13);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func13ParamsApply12() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12)(13);

    Assert.AreEqual(42, result);
  }

  #endregion

  #region Apply Func, 14 params

  [Test]
  public void Func14ParamsApply1() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      return 42;
    }, 1)(2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func14ParamsApply2() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      return 42;
    }, 1, 2)(3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func14ParamsApply3() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      return 42;
    }, 1, 2, 3)(4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func14ParamsApply4() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      return 42;
    }, 1, 2, 3, 4)(5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func14ParamsApply5() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      return 42;
    }, 1, 2, 3, 4, 5)(6, 7, 8, 9, 10, 11, 12, 13, 14);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func14ParamsApply6() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      return 42;
    }, 1, 2, 3, 4, 5, 6)(7, 8, 9, 10, 11, 12, 13, 14);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func14ParamsApply7() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7)(8, 9, 10, 11, 12, 13, 14);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func14ParamsApply8() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8)(9, 10, 11, 12, 13, 14);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func14ParamsApply9() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9)(10, 11, 12, 13, 14);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func14ParamsApply10() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)(11, 12, 13, 14);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func14ParamsApply11() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)(12, 13, 14);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func14ParamsApply12() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12)(13, 14);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func14ParamsApply13() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)(14);

    Assert.AreEqual(42, result);
  }

  #endregion

  #region Apply Func, 15 params

  [Test]
  public void Func15ParamsApply1() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      return 42;
    }, 1)(2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func15ParamsApply2() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      return 42;
    }, 1, 2)(3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func15ParamsApply3() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      return 42;
    }, 1, 2, 3)(4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func15ParamsApply4() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      return 42;
    }, 1, 2, 3, 4)(5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func15ParamsApply5() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      return 42;
    }, 1, 2, 3, 4, 5)(6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func15ParamsApply6() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      return 42;
    }, 1, 2, 3, 4, 5, 6)(7, 8, 9, 10, 11, 12, 13, 14, 15);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func15ParamsApply7() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7)(8, 9, 10, 11, 12, 13, 14, 15);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func15ParamsApply8() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8)(9, 10, 11, 12, 13, 14, 15);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func15ParamsApply9() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9)(10, 11, 12, 13, 14, 15);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func15ParamsApply10() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)(11, 12, 13, 14, 15);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func15ParamsApply11() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)(12, 13, 14, 15);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func15ParamsApply12() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12)(13, 14, 15);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func15ParamsApply13() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)(14, 15);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func15ParamsApply14() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14)(15);

    Assert.AreEqual(42, result);
  }

  #endregion

  #region Apply Func, 16 params

  [Test]
  public void Func16ParamsApply1() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
      return 42;
    }, 1)(2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func16ParamsApply2() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
      return 42;
    }, 1, 2)(3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func16ParamsApply3() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
      return 42;
    }, 1, 2, 3)(4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func16ParamsApply4() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
      return 42;
    }, 1, 2, 3, 4)(5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func16ParamsApply5() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
      return 42;
    }, 1, 2, 3, 4, 5)(6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func16ParamsApply6() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
      return 42;
    }, 1, 2, 3, 4, 5, 6)(7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func16ParamsApply7() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7)(8, 9, 10, 11, 12, 13, 14, 15, 16);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func16ParamsApply8() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8)(9, 10, 11, 12, 13, 14, 15, 16);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func16ParamsApply9() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9)(10, 11, 12, 13, 14, 15, 16);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func16ParamsApply10() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)(11, 12, 13, 14, 15, 16);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func16ParamsApply11() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)(12, 13, 14, 15, 16);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func16ParamsApply12() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12)(13, 14, 15, 16);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func16ParamsApply13() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)(14, 15, 16);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func16ParamsApply14() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14)(15, 16);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void Func16ParamsApply15() {
    var result = Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
      return 42;
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15)(16);

    Assert.AreEqual(42, result);
  }

  #endregion


  #region Apply Action, 2 params

  [Test]
  public void Action2ParamsApply1() {
    Apply<int, int>((p1, p2) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
    }, 1)(2);
  }

  #endregion

  #region Apply Action, 3 params

  [Test]
  public void Action3ParamsApply1() {
    Apply<int, int, int>((p1, p2, p3) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
    }, 1)(2, 3);
  }

  [Test]
  public void Action3ParamsApply2() {
    Apply<int, int, int>((p1, p2, p3) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
    }, 1, 2)(3);
  }

  #endregion

  #region Apply Action, 4 params

  [Test]
  public void Action4ParamsApply1() {
    Apply<int, int, int, int>((p1, p2, p3, p4) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
    }, 1)(2, 3, 4);
  }

  [Test]
  public void Action4ParamsApply2() {
    Apply<int, int, int, int>((p1, p2, p3, p4) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
    }, 1, 2)(3, 4);
  }

  [Test]
  public void Action4ParamsApply3() {
    Apply<int, int, int, int>((p1, p2, p3, p4) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
    }, 1, 2, 3)(4);
  }

  #endregion

  #region Apply Action, 5 params

  [Test]
  public void Action5ParamsApply1() {
    Apply<int, int, int, int, int>((p1, p2, p3, p4, p5) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
    }, 1)(2, 3, 4, 5);
  }

  [Test]
  public void Action5ParamsApply2() {
    Apply<int, int, int, int, int>((p1, p2, p3, p4, p5) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
    }, 1, 2)(3, 4, 5);
  }

  [Test]
  public void Action5ParamsApply3() {
    Apply<int, int, int, int, int>((p1, p2, p3, p4, p5) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
    }, 1, 2, 3)(4, 5);
  }

  [Test]
  public void Action5ParamsApply4() {
    Apply<int, int, int, int, int>((p1, p2, p3, p4, p5) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
    }, 1, 2, 3, 4)(5);
  }

  #endregion

  #region Apply Action, 6 params

  [Test]
  public void Action6ParamsApply1() {
    Apply<int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
    }, 1)(2, 3, 4, 5, 6);
  }

  [Test]
  public void Action6ParamsApply2() {
    Apply<int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
    }, 1, 2)(3, 4, 5, 6);
  }

  [Test]
  public void Action6ParamsApply3() {
    Apply<int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
    }, 1, 2, 3)(4, 5, 6);
  }

  [Test]
  public void Action6ParamsApply4() {
    Apply<int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
    }, 1, 2, 3, 4)(5, 6);
  }

  [Test]
  public void Action6ParamsApply5() {
    Apply<int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
    }, 1, 2, 3, 4, 5)(6);
  }

  #endregion

  #region Apply Action, 7 params

  [Test]
  public void Action7ParamsApply1() {
    Apply<int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
    }, 1)(2, 3, 4, 5, 6, 7);
  }

  [Test]
  public void Action7ParamsApply2() {
    Apply<int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
    }, 1, 2)(3, 4, 5, 6, 7);
  }

  [Test]
  public void Action7ParamsApply3() {
    Apply<int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
    }, 1, 2, 3)(4, 5, 6, 7);
  }

  [Test]
  public void Action7ParamsApply4() {
    Apply<int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
    }, 1, 2, 3, 4)(5, 6, 7);
  }

  [Test]
  public void Action7ParamsApply5() {
    Apply<int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
    }, 1, 2, 3, 4, 5)(6, 7);
  }

  [Test]
  public void Action7ParamsApply6() {
    Apply<int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
    }, 1, 2, 3, 4, 5, 6)(7);
  }

  #endregion

  #region Apply Action, 8 params

  [Test]
  public void Action8ParamsApply1() {
    Apply<int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
    }, 1)(2, 3, 4, 5, 6, 7, 8);
  }

  [Test]
  public void Action8ParamsApply2() {
    Apply<int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
    }, 1, 2)(3, 4, 5, 6, 7, 8);
  }

  [Test]
  public void Action8ParamsApply3() {
    Apply<int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
    }, 1, 2, 3)(4, 5, 6, 7, 8);
  }

  [Test]
  public void Action8ParamsApply4() {
    Apply<int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
    }, 1, 2, 3, 4)(5, 6, 7, 8);
  }

  [Test]
  public void Action8ParamsApply5() {
    Apply<int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
    }, 1, 2, 3, 4, 5)(6, 7, 8);
  }

  [Test]
  public void Action8ParamsApply6() {
    Apply<int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
    }, 1, 2, 3, 4, 5, 6)(7, 8);
  }

  [Test]
  public void Action8ParamsApply7() {
    Apply<int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
    }, 1, 2, 3, 4, 5, 6, 7)(8);
  }

  #endregion

  #region Apply Action, 9 params

  [Test]
  public void Action9ParamsApply1() {
    Apply<int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
    }, 1)(2, 3, 4, 5, 6, 7, 8, 9);
  }

  [Test]
  public void Action9ParamsApply2() {
    Apply<int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
    }, 1, 2)(3, 4, 5, 6, 7, 8, 9);
  }

  [Test]
  public void Action9ParamsApply3() {
    Apply<int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
    }, 1, 2, 3)(4, 5, 6, 7, 8, 9);
  }

  [Test]
  public void Action9ParamsApply4() {
    Apply<int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
    }, 1, 2, 3, 4)(5, 6, 7, 8, 9);
  }

  [Test]
  public void Action9ParamsApply5() {
    Apply<int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
    }, 1, 2, 3, 4, 5)(6, 7, 8, 9);
  }

  [Test]
  public void Action9ParamsApply6() {
    Apply<int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
    }, 1, 2, 3, 4, 5, 6)(7, 8, 9);
  }

  [Test]
  public void Action9ParamsApply7() {
    Apply<int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
    }, 1, 2, 3, 4, 5, 6, 7)(8, 9);
  }

  [Test]
  public void Action9ParamsApply8() {
    Apply<int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
    }, 1, 2, 3, 4, 5, 6, 7, 8)(9);
  }

  #endregion

  #region Apply Action, 10 params

  [Test]
  public void Action10ParamsApply1() {
    Apply<int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
    }, 1)(2, 3, 4, 5, 6, 7, 8, 9, 10);
  }

  [Test]
  public void Action10ParamsApply2() {
    Apply<int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
    }, 1, 2)(3, 4, 5, 6, 7, 8, 9, 10);
  }

  [Test]
  public void Action10ParamsApply3() {
    Apply<int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
    }, 1, 2, 3)(4, 5, 6, 7, 8, 9, 10);
  }

  [Test]
  public void Action10ParamsApply4() {
    Apply<int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
    }, 1, 2, 3, 4)(5, 6, 7, 8, 9, 10);
  }

  [Test]
  public void Action10ParamsApply5() {
    Apply<int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
    }, 1, 2, 3, 4, 5)(6, 7, 8, 9, 10);
  }

  [Test]
  public void Action10ParamsApply6() {
    Apply<int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
    }, 1, 2, 3, 4, 5, 6)(7, 8, 9, 10);
  }

  [Test]
  public void Action10ParamsApply7() {
    Apply<int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
    }, 1, 2, 3, 4, 5, 6, 7)(8, 9, 10);
  }

  [Test]
  public void Action10ParamsApply8() {
    Apply<int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
    }, 1, 2, 3, 4, 5, 6, 7, 8)(9, 10);
  }

  [Test]
  public void Action10ParamsApply9() {
    Apply<int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9)(10);
  }

  #endregion

  #region Apply Action, 11 params

  [Test]
  public void Action11ParamsApply1() {
    Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
    }, 1)(2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
  }

  [Test]
  public void Action11ParamsApply2() {
    Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
    }, 1, 2)(3, 4, 5, 6, 7, 8, 9, 10, 11);
  }

  [Test]
  public void Action11ParamsApply3() {
    Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
    }, 1, 2, 3)(4, 5, 6, 7, 8, 9, 10, 11);
  }

  [Test]
  public void Action11ParamsApply4() {
    Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
    }, 1, 2, 3, 4)(5, 6, 7, 8, 9, 10, 11);
  }

  [Test]
  public void Action11ParamsApply5() {
    Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
    }, 1, 2, 3, 4, 5)(6, 7, 8, 9, 10, 11);
  }

  [Test]
  public void Action11ParamsApply6() {
    Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
    }, 1, 2, 3, 4, 5, 6)(7, 8, 9, 10, 11);
  }

  [Test]
  public void Action11ParamsApply7() {
    Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
    }, 1, 2, 3, 4, 5, 6, 7)(8, 9, 10, 11);
  }

  [Test]
  public void Action11ParamsApply8() {
    Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
    }, 1, 2, 3, 4, 5, 6, 7, 8)(9, 10, 11);
  }

  [Test]
  public void Action11ParamsApply9() {
    Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9)(10, 11);
  }

  [Test]
  public void Action11ParamsApply10() {
    Apply<int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)(11);
  }

  #endregion

  #region Apply Action, 12 params

  [Test]
  public void Action12ParamsApply1() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
    }, 1)(2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
  }

  [Test]
  public void Action12ParamsApply2() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
    }, 1, 2)(3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
  }

  [Test]
  public void Action12ParamsApply3() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
    }, 1, 2, 3)(4, 5, 6, 7, 8, 9, 10, 11, 12);
  }

  [Test]
  public void Action12ParamsApply4() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
    }, 1, 2, 3, 4)(5, 6, 7, 8, 9, 10, 11, 12);
  }

  [Test]
  public void Action12ParamsApply5() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
    }, 1, 2, 3, 4, 5)(6, 7, 8, 9, 10, 11, 12);
  }

  [Test]
  public void Action12ParamsApply6() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
    }, 1, 2, 3, 4, 5, 6)(7, 8, 9, 10, 11, 12);
  }

  [Test]
  public void Action12ParamsApply7() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
    }, 1, 2, 3, 4, 5, 6, 7)(8, 9, 10, 11, 12);
  }

  [Test]
  public void Action12ParamsApply8() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
    }, 1, 2, 3, 4, 5, 6, 7, 8)(9, 10, 11, 12);
  }

  [Test]
  public void Action12ParamsApply9() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9)(10, 11, 12);
  }

  [Test]
  public void Action12ParamsApply10() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)(11, 12);
  }

  [Test]
  public void Action12ParamsApply11() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)(12);
  }

  #endregion

  #region Apply Action, 13 params

  [Test]
  public void Action13ParamsApply1() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
    }, 1)(2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);
  }

  [Test]
  public void Action13ParamsApply2() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
    }, 1, 2)(3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);
  }

  [Test]
  public void Action13ParamsApply3() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
    }, 1, 2, 3)(4, 5, 6, 7, 8, 9, 10, 11, 12, 13);
  }

  [Test]
  public void Action13ParamsApply4() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
    }, 1, 2, 3, 4)(5, 6, 7, 8, 9, 10, 11, 12, 13);
  }

  [Test]
  public void Action13ParamsApply5() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
    }, 1, 2, 3, 4, 5)(6, 7, 8, 9, 10, 11, 12, 13);
  }

  [Test]
  public void Action13ParamsApply6() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
    }, 1, 2, 3, 4, 5, 6)(7, 8, 9, 10, 11, 12, 13);
  }

  [Test]
  public void Action13ParamsApply7() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
    }, 1, 2, 3, 4, 5, 6, 7)(8, 9, 10, 11, 12, 13);
  }

  [Test]
  public void Action13ParamsApply8() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
    }, 1, 2, 3, 4, 5, 6, 7, 8)(9, 10, 11, 12, 13);
  }

  [Test]
  public void Action13ParamsApply9() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9)(10, 11, 12, 13);
  }

  [Test]
  public void Action13ParamsApply10() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)(11, 12, 13);
  }

  [Test]
  public void Action13ParamsApply11() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)(12, 13);
  }

  [Test]
  public void Action13ParamsApply12() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12)(13);
  }

  #endregion

  #region Apply Action, 14 params

  [Test]
  public void Action14ParamsApply1() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
    }, 1)(2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
  }

  [Test]
  public void Action14ParamsApply2() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
    }, 1, 2)(3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
  }

  [Test]
  public void Action14ParamsApply3() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
    }, 1, 2, 3)(4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
  }

  [Test]
  public void Action14ParamsApply4() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
    }, 1, 2, 3, 4)(5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
  }

  [Test]
  public void Action14ParamsApply5() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
    }, 1, 2, 3, 4, 5)(6, 7, 8, 9, 10, 11, 12, 13, 14);
  }

  [Test]
  public void Action14ParamsApply6() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
    }, 1, 2, 3, 4, 5, 6)(7, 8, 9, 10, 11, 12, 13, 14);
  }

  [Test]
  public void Action14ParamsApply7() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
    }, 1, 2, 3, 4, 5, 6, 7)(8, 9, 10, 11, 12, 13, 14);
  }

  [Test]
  public void Action14ParamsApply8() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
    }, 1, 2, 3, 4, 5, 6, 7, 8)(9, 10, 11, 12, 13, 14);
  }

  [Test]
  public void Action14ParamsApply9() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9)(10, 11, 12, 13, 14);
  }

  [Test]
  public void Action14ParamsApply10() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)(11, 12, 13, 14);
  }

  [Test]
  public void Action14ParamsApply11() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)(12, 13, 14);
  }

  [Test]
  public void Action14ParamsApply12() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12)(13, 14);
  }

  [Test]
  public void Action14ParamsApply13() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)(14);
  }

  #endregion

  #region Apply Action, 15 params

  [Test]
  public void Action15ParamsApply1() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
    }, 1)(2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
  }

  [Test]
  public void Action15ParamsApply2() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
    }, 1, 2)(3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
  }

  [Test]
  public void Action15ParamsApply3() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
    }, 1, 2, 3)(4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
  }

  [Test]
  public void Action15ParamsApply4() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
    }, 1, 2, 3, 4)(5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
  }

  [Test]
  public void Action15ParamsApply5() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
    }, 1, 2, 3, 4, 5)(6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
  }

  [Test]
  public void Action15ParamsApply6() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
    }, 1, 2, 3, 4, 5, 6)(7, 8, 9, 10, 11, 12, 13, 14, 15);
  }

  [Test]
  public void Action15ParamsApply7() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
    }, 1, 2, 3, 4, 5, 6, 7)(8, 9, 10, 11, 12, 13, 14, 15);
  }

  [Test]
  public void Action15ParamsApply8() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
    }, 1, 2, 3, 4, 5, 6, 7, 8)(9, 10, 11, 12, 13, 14, 15);
  }

  [Test]
  public void Action15ParamsApply9() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9)(10, 11, 12, 13, 14, 15);
  }

  [Test]
  public void Action15ParamsApply10() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)(11, 12, 13, 14, 15);
  }

  [Test]
  public void Action15ParamsApply11() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)(12, 13, 14, 15);
  }

  [Test]
  public void Action15ParamsApply12() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12)(13, 14, 15);
  }

  [Test]
  public void Action15ParamsApply13() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)(14, 15);
  }

  [Test]
  public void Action15ParamsApply14() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14)(15);
  }

  #endregion

  #region Apply Action, 16 params

  [Test]
  public void Action16ParamsApply1() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
    }, 1)(2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
  }

  [Test]
  public void Action16ParamsApply2() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
    }, 1, 2)(3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
  }

  [Test]
  public void Action16ParamsApply3() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
    }, 1, 2, 3)(4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
  }

  [Test]
  public void Action16ParamsApply4() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
    }, 1, 2, 3, 4)(5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
  }

  [Test]
  public void Action16ParamsApply5() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
    }, 1, 2, 3, 4, 5)(6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
  }

  [Test]
  public void Action16ParamsApply6() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
    }, 1, 2, 3, 4, 5, 6)(7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
  }

  [Test]
  public void Action16ParamsApply7() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
    }, 1, 2, 3, 4, 5, 6, 7)(8, 9, 10, 11, 12, 13, 14, 15, 16);
  }

  [Test]
  public void Action16ParamsApply8() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
    }, 1, 2, 3, 4, 5, 6, 7, 8)(9, 10, 11, 12, 13, 14, 15, 16);
  }

  [Test]
  public void Action16ParamsApply9() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9)(10, 11, 12, 13, 14, 15, 16);
  }

  [Test]
  public void Action16ParamsApply10() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)(11, 12, 13, 14, 15, 16);
  }

  [Test]
  public void Action16ParamsApply11() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)(12, 13, 14, 15, 16);
  }

  [Test]
  public void Action16ParamsApply12() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12)(13, 14, 15, 16);
  }

  [Test]
  public void Action16ParamsApply13() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)(14, 15, 16);
  }

  [Test]
  public void Action16ParamsApply14() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14)(15, 16);
  }

  [Test]
  public void Action16ParamsApply15() {
    Apply<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      Assert.AreEqual(10, p10);
      Assert.AreEqual(11, p11);
      Assert.AreEqual(12, p12);
      Assert.AreEqual(13, p13);
      Assert.AreEqual(14, p14);
      Assert.AreEqual(15, p15);
      Assert.AreEqual(16, p16);
    }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15)(16);
  }

  #endregion



}

