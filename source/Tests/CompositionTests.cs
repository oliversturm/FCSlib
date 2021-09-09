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

public class CompositionTests {
  [SetUp]
  public void Setup() {
  }

  public record IntermediateType1(string Value);
  public record IntermediateType2(string Value);
  public record IntermediateType3(string Value);
  public record IntermediateType4(string Value);
  public record FinalResult(string Value);

  #region Compose 2 functions

  [Test]
  public void Compose2Functions1Params() {
    var result = Compose<int, IntermediateType1, FinalResult>((p1) => {
      Assert.AreEqual(1, p1);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new FinalResult("result from final function");
    })(1);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose2Functions2Params() {
    var result = Compose<int, int, IntermediateType1, FinalResult>((p1, p2) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new FinalResult("result from final function");
    })(1, 2);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose2Functions3Params() {
    var result = Compose<int, int, int, IntermediateType1, FinalResult>((p1, p2, p3) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose2Functions4Params() {
    var result = Compose<int, int, int, int, IntermediateType1, FinalResult>((p1, p2, p3, p4) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose2Functions5Params() {
    var result = Compose<int, int, int, int, int, IntermediateType1, FinalResult>((p1, p2, p3, p4, p5) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose2Functions6Params() {
    var result = Compose<int, int, int, int, int, int, IntermediateType1, FinalResult>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5, 6);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose2Functions7Params() {
    var result = Compose<int, int, int, int, int, int, int, IntermediateType1, FinalResult>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5, 6, 7);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose2Functions8Params() {
    var result = Compose<int, int, int, int, int, int, int, int, IntermediateType1, FinalResult>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5, 6, 7, 8);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose2Functions9Params() {
    var result = Compose<int, int, int, int, int, int, int, int, int, IntermediateType1, FinalResult>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5, 6, 7, 8, 9);

    Assert.AreEqual("result from final function", result.Value);
  }

  #endregion

  #region Compose 3 functions

  [Test]
  public void Compose3Functions1Params() {
    var result = Compose<int, IntermediateType1, IntermediateType2, FinalResult>((p1) => {
      Assert.AreEqual(1, p1);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new FinalResult("result from final function");
    })(1);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose3Functions2Params() {
    var result = Compose<int, int, IntermediateType1, IntermediateType2, FinalResult>((p1, p2) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new FinalResult("result from final function");
    })(1, 2);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose3Functions3Params() {
    var result = Compose<int, int, int, IntermediateType1, IntermediateType2, FinalResult>((p1, p2, p3) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose3Functions4Params() {
    var result = Compose<int, int, int, int, IntermediateType1, IntermediateType2, FinalResult>((p1, p2, p3, p4) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose3Functions5Params() {
    var result = Compose<int, int, int, int, int, IntermediateType1, IntermediateType2, FinalResult>((p1, p2, p3, p4, p5) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose3Functions6Params() {
    var result = Compose<int, int, int, int, int, int, IntermediateType1, IntermediateType2, FinalResult>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5, 6);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose3Functions7Params() {
    var result = Compose<int, int, int, int, int, int, int, IntermediateType1, IntermediateType2, FinalResult>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5, 6, 7);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose3Functions8Params() {
    var result = Compose<int, int, int, int, int, int, int, int, IntermediateType1, IntermediateType2, FinalResult>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5, 6, 7, 8);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose3Functions9Params() {
    var result = Compose<int, int, int, int, int, int, int, int, int, IntermediateType1, IntermediateType2, FinalResult>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5, 6, 7, 8, 9);

    Assert.AreEqual("result from final function", result.Value);
  }

  #endregion

  #region Compose 4 functions

  [Test]
  public void Compose4Functions1Params() {
    var result = Compose<int, IntermediateType1, IntermediateType2, IntermediateType3, FinalResult>((p1) => {
      Assert.AreEqual(1, p1);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new FinalResult("result from final function");
    })(1);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose4Functions2Params() {
    var result = Compose<int, int, IntermediateType1, IntermediateType2, IntermediateType3, FinalResult>((p1, p2) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new FinalResult("result from final function");
    })(1, 2);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose4Functions3Params() {
    var result = Compose<int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, FinalResult>((p1, p2, p3) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose4Functions4Params() {
    var result = Compose<int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, FinalResult>((p1, p2, p3, p4) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose4Functions5Params() {
    var result = Compose<int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, FinalResult>((p1, p2, p3, p4, p5) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose4Functions6Params() {
    var result = Compose<int, int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, FinalResult>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5, 6);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose4Functions7Params() {
    var result = Compose<int, int, int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, FinalResult>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5, 6, 7);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose4Functions8Params() {
    var result = Compose<int, int, int, int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, FinalResult>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5, 6, 7, 8);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose4Functions9Params() {
    var result = Compose<int, int, int, int, int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, FinalResult>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5, 6, 7, 8, 9);

    Assert.AreEqual("result from final function", result.Value);
  }

  #endregion

  #region Compose 5 functions

  [Test]
  public void Compose5Functions1Params() {
    var result = Compose<int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4, FinalResult>((p1) => {
      Assert.AreEqual(1, p1);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
      return new FinalResult("result from final function");
    })(1);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose5Functions2Params() {
    var result = Compose<int, int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4, FinalResult>((p1, p2) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
      return new FinalResult("result from final function");
    })(1, 2);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose5Functions3Params() {
    var result = Compose<int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4, FinalResult>((p1, p2, p3) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose5Functions4Params() {
    var result = Compose<int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4, FinalResult>((p1, p2, p3, p4) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose5Functions5Params() {
    var result = Compose<int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4, FinalResult>((p1, p2, p3, p4, p5) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose5Functions6Params() {
    var result = Compose<int, int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4, FinalResult>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5, 6);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose5Functions7Params() {
    var result = Compose<int, int, int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4, FinalResult>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5, 6, 7);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose5Functions8Params() {
    var result = Compose<int, int, int, int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4, FinalResult>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5, 6, 7, 8);

    Assert.AreEqual("result from final function", result.Value);
  }

  [Test]
  public void Compose5Functions9Params() {
    var result = Compose<int, int, int, int, int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4, FinalResult>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
      return new FinalResult("result from final function");
    })(1, 2, 3, 4, 5, 6, 7, 8, 9);

    Assert.AreEqual("result from final function", result.Value);
  }

  #endregion


  #region Compose 1 functions, 1 action

  [Test]
  public void Compose1Functions1Action1Params() {
    Compose<int, IntermediateType1>((p1) => {
      Assert.AreEqual(1, p1);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
    })(1);
  }

  [Test]
  public void Compose1Functions1Action2Params() {
    Compose<int, int, IntermediateType1>((p1, p2) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
    })(1, 2);
  }

  [Test]
  public void Compose1Functions1Action3Params() {
    Compose<int, int, int, IntermediateType1>((p1, p2, p3) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
    })(1, 2, 3);
  }

  [Test]
  public void Compose1Functions1Action4Params() {
    Compose<int, int, int, int, IntermediateType1>((p1, p2, p3, p4) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
    })(1, 2, 3, 4);
  }

  [Test]
  public void Compose1Functions1Action5Params() {
    Compose<int, int, int, int, int, IntermediateType1>((p1, p2, p3, p4, p5) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
    })(1, 2, 3, 4, 5);
  }

  [Test]
  public void Compose1Functions1Action6Params() {
    Compose<int, int, int, int, int, int, IntermediateType1>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
    })(1, 2, 3, 4, 5, 6);
  }

  [Test]
  public void Compose1Functions1Action7Params() {
    Compose<int, int, int, int, int, int, int, IntermediateType1>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
    })(1, 2, 3, 4, 5, 6, 7);
  }

  [Test]
  public void Compose1Functions1Action8Params() {
    Compose<int, int, int, int, int, int, int, int, IntermediateType1>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
    })(1, 2, 3, 4, 5, 6, 7, 8);
  }

  [Test]
  public void Compose1Functions1Action9Params() {
    Compose<int, int, int, int, int, int, int, int, int, IntermediateType1>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9);
  }

  #endregion

  #region Compose 2 functions, 1 action

  [Test]
  public void Compose2Functions1Action1Params() {
    Compose<int, IntermediateType1, IntermediateType2>((p1) => {
      Assert.AreEqual(1, p1);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
    })(1);
  }

  [Test]
  public void Compose2Functions1Action2Params() {
    Compose<int, int, IntermediateType1, IntermediateType2>((p1, p2) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
    })(1, 2);
  }

  [Test]
  public void Compose2Functions1Action3Params() {
    Compose<int, int, int, IntermediateType1, IntermediateType2>((p1, p2, p3) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
    })(1, 2, 3);
  }

  [Test]
  public void Compose2Functions1Action4Params() {
    Compose<int, int, int, int, IntermediateType1, IntermediateType2>((p1, p2, p3, p4) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
    })(1, 2, 3, 4);
  }

  [Test]
  public void Compose2Functions1Action5Params() {
    Compose<int, int, int, int, int, IntermediateType1, IntermediateType2>((p1, p2, p3, p4, p5) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
    })(1, 2, 3, 4, 5);
  }

  [Test]
  public void Compose2Functions1Action6Params() {
    Compose<int, int, int, int, int, int, IntermediateType1, IntermediateType2>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
    })(1, 2, 3, 4, 5, 6);
  }

  [Test]
  public void Compose2Functions1Action7Params() {
    Compose<int, int, int, int, int, int, int, IntermediateType1, IntermediateType2>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
    })(1, 2, 3, 4, 5, 6, 7);
  }

  [Test]
  public void Compose2Functions1Action8Params() {
    Compose<int, int, int, int, int, int, int, int, IntermediateType1, IntermediateType2>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
    })(1, 2, 3, 4, 5, 6, 7, 8);
  }

  [Test]
  public void Compose2Functions1Action9Params() {
    Compose<int, int, int, int, int, int, int, int, int, IntermediateType1, IntermediateType2>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9);
  }

  #endregion

  #region Compose 3 functions, 1 action

  [Test]
  public void Compose3Functions1Action1Params() {
    Compose<int, IntermediateType1, IntermediateType2, IntermediateType3>((p1) => {
      Assert.AreEqual(1, p1);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
    })(1);
  }

  [Test]
  public void Compose3Functions1Action2Params() {
    Compose<int, int, IntermediateType1, IntermediateType2, IntermediateType3>((p1, p2) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
    })(1, 2);
  }

  [Test]
  public void Compose3Functions1Action3Params() {
    Compose<int, int, int, IntermediateType1, IntermediateType2, IntermediateType3>((p1, p2, p3) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
    })(1, 2, 3);
  }

  [Test]
  public void Compose3Functions1Action4Params() {
    Compose<int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3>((p1, p2, p3, p4) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
    })(1, 2, 3, 4);
  }

  [Test]
  public void Compose3Functions1Action5Params() {
    Compose<int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3>((p1, p2, p3, p4, p5) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
    })(1, 2, 3, 4, 5);
  }

  [Test]
  public void Compose3Functions1Action6Params() {
    Compose<int, int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
    })(1, 2, 3, 4, 5, 6);
  }

  [Test]
  public void Compose3Functions1Action7Params() {
    Compose<int, int, int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
    })(1, 2, 3, 4, 5, 6, 7);
  }

  [Test]
  public void Compose3Functions1Action8Params() {
    Compose<int, int, int, int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
    })(1, 2, 3, 4, 5, 6, 7, 8);
  }

  [Test]
  public void Compose3Functions1Action9Params() {
    Compose<int, int, int, int, int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9);
  }

  #endregion

  #region Compose 4 functions, 1 action

  [Test]
  public void Compose4Functions1Action1Params() {
    Compose<int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4>((p1) => {
      Assert.AreEqual(1, p1);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
    })(1);
  }

  [Test]
  public void Compose4Functions1Action2Params() {
    Compose<int, int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4>((p1, p2) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
    })(1, 2);
  }

  [Test]
  public void Compose4Functions1Action3Params() {
    Compose<int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4>((p1, p2, p3) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
    })(1, 2, 3);
  }

  [Test]
  public void Compose4Functions1Action4Params() {
    Compose<int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4>((p1, p2, p3, p4) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
    })(1, 2, 3, 4);
  }

  [Test]
  public void Compose4Functions1Action5Params() {
    Compose<int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4>((p1, p2, p3, p4, p5) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
    })(1, 2, 3, 4, 5);
  }

  [Test]
  public void Compose4Functions1Action6Params() {
    Compose<int, int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4>((p1, p2, p3, p4, p5, p6) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
    })(1, 2, 3, 4, 5, 6);
  }

  [Test]
  public void Compose4Functions1Action7Params() {
    Compose<int, int, int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4>((p1, p2, p3, p4, p5, p6, p7) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
    })(1, 2, 3, 4, 5, 6, 7);
  }

  [Test]
  public void Compose4Functions1Action8Params() {
    Compose<int, int, int, int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4>((p1, p2, p3, p4, p5, p6, p7, p8) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
    })(1, 2, 3, 4, 5, 6, 7, 8);
  }

  [Test]
  public void Compose4Functions1Action9Params() {
    Compose<int, int, int, int, int, int, int, int, int, IntermediateType1, IntermediateType2, IntermediateType3, IntermediateType4>((p1, p2, p3, p4, p5, p6, p7, p8, p9) => {
      Assert.AreEqual(1, p1);
      Assert.AreEqual(2, p2);
      Assert.AreEqual(3, p3);
      Assert.AreEqual(4, p4);
      Assert.AreEqual(5, p5);
      Assert.AreEqual(6, p6);
      Assert.AreEqual(7, p7);
      Assert.AreEqual(8, p8);
      Assert.AreEqual(9, p9);
      return new IntermediateType1("result from function 1");
    },
    p => {
      Assert.AreEqual("result from function 1", p.Value);
      return new IntermediateType2("result from function 2");
    },
    p => {
      Assert.AreEqual("result from function 2", p.Value);
      return new IntermediateType3("result from function 3");
    },
    p => {
      Assert.AreEqual("result from function 3", p.Value);
      return new IntermediateType4("result from function 4");
    },
    p => {
      Assert.AreEqual("result from function 4", p.Value);
    })(1, 2, 3, 4, 5, 6, 7, 8, 9);
  }

  #endregion


}

