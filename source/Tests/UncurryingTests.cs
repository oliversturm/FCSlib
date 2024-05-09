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

public class UncurryingTests {
  [SetUp]
  public void Setup() {
  }

  [Test]
  public void TwoParamsFunc() {
    var result = Uncurry<int, int, int>(one => two => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      return 42;
    })(1, 2);

    ClassicAssert.AreEqual(42, result);
  }

  [Test]
  public void ThreeParamsFunc() {
    var result = Uncurry<int, int, int, int>(one => two => three => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      return 42;
    })(1, 2, 3);

    ClassicAssert.AreEqual(42, result);
  }

  [Test]
  public void FourParamsFunc() {
    var result = Uncurry<int, int, int, int, int>(one => two => three => four => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      return 42;
    })(1, 2, 3, 4);

    ClassicAssert.AreEqual(42, result);
  }

  [Test]
  public void FiveParamsFunc() {
    var result = Uncurry<int, int, int, int, int, int>(one => two => three => four => five => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      return 42;
    })(1, 2, 3, 4, 5);

    ClassicAssert.AreEqual(42, result);
  }

  [Test]
  public void SixParamsFunc() {
    var result = Uncurry<int, int, int, int, int, int, int>(one => two => three => four => five => six => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      return 42;
    })(1, 2, 3, 4, 5, 6);

    ClassicAssert.AreEqual(42, result);
  }

  [Test]
  public void SevenParamsFunc() {
    var result = Uncurry<int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7);

    ClassicAssert.AreEqual(42, result);
  }

  [Test]
  public void EightParamsFunc() {
    var result = Uncurry<int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8);

    ClassicAssert.AreEqual(42, result);
  }

  [Test]
  public void NineParamsFunc() {
    var result = Uncurry<int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
      ClassicAssert.AreEqual(9, nine);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8, 9);

    ClassicAssert.AreEqual(42, result);
  }

  [Test]
  public void TenParamsFunc() {
    var result = Uncurry<int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
      ClassicAssert.AreEqual(9, nine);
      ClassicAssert.AreEqual(10, ten);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

    ClassicAssert.AreEqual(42, result);
  }

  [Test]
  public void ElevenParamsFunc() {
    var result = Uncurry<int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
      ClassicAssert.AreEqual(9, nine);
      ClassicAssert.AreEqual(10, ten);
      ClassicAssert.AreEqual(11, eleven);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

    ClassicAssert.AreEqual(42, result);
  }

  [Test]
  public void TwelveParamsFunc() {
    var result = Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
      ClassicAssert.AreEqual(9, nine);
      ClassicAssert.AreEqual(10, ten);
      ClassicAssert.AreEqual(11, eleven);
      ClassicAssert.AreEqual(12, twelve);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

    ClassicAssert.AreEqual(42, result);
  }

  [Test]
  public void ThirteenParamsFunc() {
    var result = Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => thirteen => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
      ClassicAssert.AreEqual(9, nine);
      ClassicAssert.AreEqual(10, ten);
      ClassicAssert.AreEqual(11, eleven);
      ClassicAssert.AreEqual(12, twelve);
      ClassicAssert.AreEqual(13, thirteen);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

    ClassicAssert.AreEqual(42, result);
  }

  [Test]
  public void FourteenParamsFunc() {
    var result = Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => thirteen => fourteen => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
      ClassicAssert.AreEqual(9, nine);
      ClassicAssert.AreEqual(10, ten);
      ClassicAssert.AreEqual(11, eleven);
      ClassicAssert.AreEqual(12, twelve);
      ClassicAssert.AreEqual(13, thirteen);
      ClassicAssert.AreEqual(14, fourteen);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

    ClassicAssert.AreEqual(42, result);
  }

  [Test]
  public void FifteenParamsFunc() {
    var result = Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => thirteen => fourteen => fifteen => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
      ClassicAssert.AreEqual(9, nine);
      ClassicAssert.AreEqual(10, ten);
      ClassicAssert.AreEqual(11, eleven);
      ClassicAssert.AreEqual(12, twelve);
      ClassicAssert.AreEqual(13, thirteen);
      ClassicAssert.AreEqual(14, fourteen);
      ClassicAssert.AreEqual(15, fifteen);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

    ClassicAssert.AreEqual(42, result);
  }

  [Test]
  public void SixteenParamsFunc() {
    var result = Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => thirteen => fourteen => fifteen => sixteen => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
      ClassicAssert.AreEqual(9, nine);
      ClassicAssert.AreEqual(10, ten);
      ClassicAssert.AreEqual(11, eleven);
      ClassicAssert.AreEqual(12, twelve);
      ClassicAssert.AreEqual(13, thirteen);
      ClassicAssert.AreEqual(14, fourteen);
      ClassicAssert.AreEqual(15, fifteen);
      ClassicAssert.AreEqual(16, sixteen);
      return 42;
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

    ClassicAssert.AreEqual(42, result);
  }

  [Test]
  public void TwoParamsAction() {
    Uncurry<int, int>(one => two => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
    })(1, 2);
  }

  [Test]
  public void ThreeParamsAction() {
    Uncurry<int, int, int>(one => two => three => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
    })(1, 2, 3);
  }

  [Test]
  public void FourParamsAction() {
    Uncurry<int, int, int, int>(one => two => three => four => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
    })(1, 2, 3, 4);
  }

  [Test]
  public void FiveParamsAction() {
    Uncurry<int, int, int, int, int>(one => two => three => four => five => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
    })(1, 2, 3, 4, 5);
  }

  [Test]
  public void SixParamsAction() {
    Uncurry<int, int, int, int, int, int>(one => two => three => four => five => six => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
    })(1, 2, 3, 4, 5, 6);
  }

  [Test]
  public void SevenParamsAction() {
    Uncurry<int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
    })(1, 2, 3, 4, 5, 6, 7);
  }

  [Test]
  public void EightParamsAction() {
    Uncurry<int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
    })(1, 2, 3, 4, 5, 6, 7, 8);
  }

  [Test]
  public void NineParamsAction() {
    Uncurry<int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
      ClassicAssert.AreEqual(9, nine);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9);
  }

  [Test]
  public void TenParamsAction() {
    Uncurry<int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
      ClassicAssert.AreEqual(9, nine);
      ClassicAssert.AreEqual(10, ten);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
  }

  [Test]
  public void ElevenParamsAction() {
    Uncurry<int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
      ClassicAssert.AreEqual(9, nine);
      ClassicAssert.AreEqual(10, ten);
      ClassicAssert.AreEqual(11, eleven);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
  }

  [Test]
  public void TwelveParamsAction() {
    Uncurry<int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
      ClassicAssert.AreEqual(9, nine);
      ClassicAssert.AreEqual(10, ten);
      ClassicAssert.AreEqual(11, eleven);
      ClassicAssert.AreEqual(12, twelve);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
  }

  [Test]
  public void ThirteenParamsAction() {
    Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => thirteen => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
      ClassicAssert.AreEqual(9, nine);
      ClassicAssert.AreEqual(10, ten);
      ClassicAssert.AreEqual(11, eleven);
      ClassicAssert.AreEqual(12, twelve);
      ClassicAssert.AreEqual(13, thirteen);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);
  }

  [Test]
  public void FourteenParamsAction() {
    Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => thirteen => fourteen => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
      ClassicAssert.AreEqual(9, nine);
      ClassicAssert.AreEqual(10, ten);
      ClassicAssert.AreEqual(11, eleven);
      ClassicAssert.AreEqual(12, twelve);
      ClassicAssert.AreEqual(13, thirteen);
      ClassicAssert.AreEqual(14, fourteen);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
  }

  [Test]
  public void FifteenParamsAction() {
    Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => thirteen => fourteen => fifteen => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
      ClassicAssert.AreEqual(9, nine);
      ClassicAssert.AreEqual(10, ten);
      ClassicAssert.AreEqual(11, eleven);
      ClassicAssert.AreEqual(12, twelve);
      ClassicAssert.AreEqual(13, thirteen);
      ClassicAssert.AreEqual(14, fourteen);
      ClassicAssert.AreEqual(15, fifteen);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
  }

  [Test]
  public void SixteenParamsAction() {
    Uncurry<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(one => two => three => four => five => six => seven => eight => nine => ten => eleven => twelve => thirteen => fourteen => fifteen => sixteen => {
      ClassicAssert.AreEqual(1, one);
      ClassicAssert.AreEqual(2, two);
      ClassicAssert.AreEqual(3, three);
      ClassicAssert.AreEqual(4, four);
      ClassicAssert.AreEqual(5, five);
      ClassicAssert.AreEqual(6, six);
      ClassicAssert.AreEqual(7, seven);
      ClassicAssert.AreEqual(8, eight);
      ClassicAssert.AreEqual(9, nine);
      ClassicAssert.AreEqual(10, ten);
      ClassicAssert.AreEqual(11, eleven);
      ClassicAssert.AreEqual(12, twelve);
      ClassicAssert.AreEqual(13, thirteen);
      ClassicAssert.AreEqual(14, fourteen);
      ClassicAssert.AreEqual(15, fifteen);
      ClassicAssert.AreEqual(16, sixteen);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
  }

}

