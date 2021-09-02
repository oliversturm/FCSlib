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

public class UncurryingTests {
  [SetUp]
  public void Setup() {
  }

  [Test]
  public void TwoParamsFunc() {
    var result = Functional.Uncurry<int, int, int>(one => two => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      return 42;
    })(1, 2);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void ThreeParamsFunc() {
    var result = Functional.Uncurry<int, int, int, int>(one => two => three => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      return 42;
    })(1, 2, 3);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void FourParamsFunc() {
    var result = Functional.Uncurry<int, int, int, int, int>(one => two => three => four => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      return 42;
    })(1, 2, 3, 4);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void FiveParamsFunc() {
    var result = Functional.Uncurry<int, int, int, int, int, int>(one => two => three => four => five => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      return 42;
    })(1, 2, 3, 4, 5);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void SixParamsFunc() {
    var result = Functional.Uncurry<int, int, int, int, int, int, int>(one => two => three => four => five => six => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      return 42;
    })(1, 2, 3, 4, 5, 6);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void SevenParamsFunc() {
    var result = Functional.Uncurry<int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void EightParamsFunc() {
    var result = Functional.Uncurry<int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void NineParamsFunc() {
    var result = Functional.Uncurry<int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
      Assert.AreEqual(9, nine);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8, 9);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void TenParamsFunc() {
    var result = Functional.Uncurry<int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
      Assert.AreEqual(9, nine);
      Assert.AreEqual(10, ten);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void ElevenParamsFunc() {
    var result = Functional.Uncurry<int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
      Assert.AreEqual(9, nine);
      Assert.AreEqual(10, ten);
      Assert.AreEqual(11, eleven);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void TwelveParamsFunc() {
    var result = Functional.Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
      Assert.AreEqual(9, nine);
      Assert.AreEqual(10, ten);
      Assert.AreEqual(11, eleven);
      Assert.AreEqual(12, twelve);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void ThirteenParamsFunc() {
    var result = Functional.Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => thirteen => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
      Assert.AreEqual(9, nine);
      Assert.AreEqual(10, ten);
      Assert.AreEqual(11, eleven);
      Assert.AreEqual(12, twelve);
      Assert.AreEqual(13, thirteen);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void FourteenParamsFunc() {
    var result = Functional.Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => thirteen => fourteen => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
      Assert.AreEqual(9, nine);
      Assert.AreEqual(10, ten);
      Assert.AreEqual(11, eleven);
      Assert.AreEqual(12, twelve);
      Assert.AreEqual(13, thirteen);
      Assert.AreEqual(14, fourteen);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void FifteenParamsFunc() {
    var result = Functional.Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => thirteen => fourteen => fifteen => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
      Assert.AreEqual(9, nine);
      Assert.AreEqual(10, ten);
      Assert.AreEqual(11, eleven);
      Assert.AreEqual(12, twelve);
      Assert.AreEqual(13, thirteen);
      Assert.AreEqual(14, fourteen);
      Assert.AreEqual(15, fifteen);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void SixteenParamsFunc() {
    var result = Functional.Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => thirteen => fourteen => fifteen => sixteen => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
      Assert.AreEqual(9, nine);
      Assert.AreEqual(10, ten);
      Assert.AreEqual(11, eleven);
      Assert.AreEqual(12, twelve);
      Assert.AreEqual(13, thirteen);
      Assert.AreEqual(14, fourteen);
      Assert.AreEqual(15, fifteen);
      Assert.AreEqual(16, sixteen);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

    Assert.AreEqual(42, result);
  }

  [Test]
  public void TwoParamsAction() {
    Functional.Uncurry<int, int>(one => two => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
    })(1, 2);
  }

  [Test]
  public void ThreeParamsAction() {
    Functional.Uncurry<int, int, int>(one => two => three => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
    })(1, 2, 3);
  }

  [Test]
  public void FourParamsAction() {
    Functional.Uncurry<int, int, int, int>(one => two => three => four => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
    })(1, 2, 3, 4);
  }

  [Test]
  public void FiveParamsAction() {
    Functional.Uncurry<int, int, int, int, int>(one => two => three => four => five => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
    })(1, 2, 3, 4, 5);
  }

  [Test]
  public void SixParamsAction() {
    Functional.Uncurry<int, int, int, int, int, int>(one => two => three => four => five => six => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
    })(1, 2, 3, 4, 5, 6);
  }

  [Test]
  public void SevenParamsAction() {
    Functional.Uncurry<int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
    })(1, 2, 3, 4, 5, 6, 7);
  }

  [Test]
  public void EightParamsAction() {
    Functional.Uncurry<int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
    })(1, 2, 3, 4, 5, 6, 7, 8);
  }

  [Test]
  public void NineParamsAction() {
    Functional.Uncurry<int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
      Assert.AreEqual(9, nine);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9);
  }

  [Test]
  public void TenParamsAction() {
    Functional.Uncurry<int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
      Assert.AreEqual(9, nine);
      Assert.AreEqual(10, ten);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
  }

  [Test]
  public void ElevenParamsAction() {
    Functional.Uncurry<int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
      Assert.AreEqual(9, nine);
      Assert.AreEqual(10, ten);
      Assert.AreEqual(11, eleven);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
  }

  [Test]
  public void TwelveParamsAction() {
    Functional.Uncurry<int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
      Assert.AreEqual(9, nine);
      Assert.AreEqual(10, ten);
      Assert.AreEqual(11, eleven);
      Assert.AreEqual(12, twelve);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
  }

  [Test]
  public void ThirteenParamsAction() {
    Functional.Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => thirteen => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
      Assert.AreEqual(9, nine);
      Assert.AreEqual(10, ten);
      Assert.AreEqual(11, eleven);
      Assert.AreEqual(12, twelve);
      Assert.AreEqual(13, thirteen);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);
  }

  [Test]
  public void FourteenParamsAction() {
    Functional.Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => thirteen => fourteen => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
      Assert.AreEqual(9, nine);
      Assert.AreEqual(10, ten);
      Assert.AreEqual(11, eleven);
      Assert.AreEqual(12, twelve);
      Assert.AreEqual(13, thirteen);
      Assert.AreEqual(14, fourteen);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
  }

  [Test]
  public void FifteenParamsAction() {
    Functional.Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => thirteen => fourteen => fifteen => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
      Assert.AreEqual(9, nine);
      Assert.AreEqual(10, ten);
      Assert.AreEqual(11, eleven);
      Assert.AreEqual(12, twelve);
      Assert.AreEqual(13, thirteen);
      Assert.AreEqual(14, fourteen);
      Assert.AreEqual(15, fifteen);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
  }

  [Test]
  public void SixteenParamsAction() {
    Functional.Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => thirteen => fourteen => fifteen => sixteen => {
      Assert.AreEqual(1, one);
      Assert.AreEqual(2, two);
      Assert.AreEqual(3, three);
      Assert.AreEqual(4, four);
      Assert.AreEqual(5, five);
      Assert.AreEqual(6, six);
      Assert.AreEqual(7, seven);
      Assert.AreEqual(8, eight);
      Assert.AreEqual(9, nine);
      Assert.AreEqual(10, ten);
      Assert.AreEqual(11, eleven);
      Assert.AreEqual(12, twelve);
      Assert.AreEqual(13, thirteen);
      Assert.AreEqual(14, fourteen);
      Assert.AreEqual(15, fifteen);
      Assert.AreEqual(16, sixteen);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
  }

}

