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


// Loosely based on the algorithm described by Chris Okasaki in his book
// "Purely Functional Data Structures", published by Cambridge University Press.
// The algorithm in question is described in Figure 3.6.
// Used with permission, C# code (C) Copyright 2008-2021 Oliver Sturm <oliver@oliversturm.com>


namespace FCSlib.Data.Collections {
  public sealed class RedBlackTree<T> : IEnumerable<T?>, IHaveCustomDefaultValue<RedBlackTree<T>> {
    public enum Color {
      None,
      Red,
      Black
    }

    public bool IsEmpty { get; init; }
    public Color NodeColor { get; init; } = Color.None;

    public RedBlackTree<T> Left { get; init; }
    public RedBlackTree<T> Right { get; init; }
    public T? Value { get; init; }

    public static readonly RedBlackTree<T> Empty = new();

    public RedBlackTree<T> DefaultValue => Empty;

    #region Constructors
    private RedBlackTree() {
      IsEmpty = true;
      Left = Right = RedBlackTree<T>.Empty;
    }

    public RedBlackTree(Color nodeColor, RedBlackTree<T> left, T? value, RedBlackTree<T> right) {
      NodeColor = nodeColor;
      Left = left;
      Right = right;
      Value = value;
    }

    #endregion

    #region Deconstructors

    public void Deconstruct(out Color nodeColor, out RedBlackTree<T> left, out T? value, out RedBlackTree<T> right) {
      nodeColor = NodeColor;
      left = Left;
      value = Value;
      right = Right;
    }

    public void Deconstruct(out RedBlackTree<T> left, out T? value, out RedBlackTree<T> right) {
      left = Left;
      value = Value;
      right = Right;
    }

    #endregion

    public static RedBlackTree<T> Init(T first, params T[] values) {
      var tree = Insert(first, Empty);
      foreach (var v in values) {
        tree = Insert(v, tree);
      }
      return tree;
    }

    public static RedBlackTree<T> Init(IEnumerable<T> source) {
      var sa = source.ToArray();
      if (sa.Length == 0) return Empty;
      var tree = Insert(sa.First(), Empty);
      foreach (var v in sa.Skip(1)) {
        tree = Insert(v, tree);
      }
      return tree;
    }


    #region Balance

    // Haskell:
    //
    // data Color = R | B
    // data RedBlackSet a = E | T Color (RedBlackSet a) a (RedBlackSet a)
    //
    // balance B (T R (T R a x b) y c) z d = T R (T B a x b) y (T B c z d)
    // balance B (T R a x (T R b y c)) z d = T R (T B a x b) y (T B c z d)
    // balance B a x (T R (T R b y c) z d) = T R (T B a x b) y (T B c z d)
    // balance B a x (T R b y (T R c z d)) = T R (T B a x b) y (T B c z d)
    // balance color a x b = T color a x b

    private static RedBlackTree<T> Balance(Color nodeColor,
       RedBlackTree<T> left, T? value, RedBlackTree<T> right) {
      const Color R = Color.Red;
      const Color B = Color.Black;
      Func<Color, RedBlackTree<T>, T?, RedBlackTree<T>, RedBlackTree<T>> TT = (c, l, v, t) => new RedBlackTree<T>(c, l, v, t);

      // Note that in contrast to Haskell, these patterns do not explicitly
      // match T as opposed to E. If we wanted to determine explicitly
      // that the tree is not empty, we'd need a more complex property
      // based pattern. To avoid this, the tree initializes with a 
      // None color, so that the B and R matches only catch trees that 
      // are not empty.
      return (nodeColor, left, value, right) switch
      {
        (B, (R, (R, var a, var x, var b), var y, var c), var z, var d) =>
          TT(R, TT(B, a, x, b), y, TT(B, c, z, d)),
        (B, (R, var a, var x, (R, var b, var y, var c)), var z, var d) =>
          TT(R, TT(B, a, x, b), y, TT(B, c, z, d)),
        (B, var a, var x, (R, (R, var b, var y, var c), var z, var d)) =>
          TT(R, TT(B, a, x, b), y, TT(B, c, z, d)),
        (B, var a, var x, (R, var b, var y, (R, var c, var z, var d))) =>
          TT(R, TT(B, a, x, b), y, TT(B, c, z, d)),
        (var color, var a, var x, var b) => TT(color, a, x, b)
      };
    }

    #endregion

    #region Contains
    public static bool Contains(T value, RedBlackTree<T> tree) {
      if (tree.IsEmpty)
        return false;
      else {
        int compareResult = Comparer<T>.Default.Compare(value, tree.Value);
        if (compareResult < 0)
          return Contains(value, tree.Left);
        else if (compareResult > 0)
          return Contains(value, tree.Right);
        else
          return true;
      }
    }

    public bool Contains(T value) =>
      RedBlackTree<T>.Contains(value, this);

    #endregion

    #region Inserting

    public static RedBlackTree<T> Insert(T? value, RedBlackTree<T> tree) {
      Func<RedBlackTree<T>, RedBlackTree<T>> ins = default!;

      ins = t => {
        return t.IsEmpty ?
          new RedBlackTree<T>(Color.Red, Empty, value, Empty) :
          Comparer<T>.Default.Compare(value, t.Value) switch
          {
            < 0 => Balance(t.NodeColor, ins(t.Left), t.Value, t.Right),
            > 0 => Balance(t.NodeColor, t.Left, t.Value, ins(t.Right)),
            _ => t
          };
      };

      var (l, v, r) = ins(tree);
      return new RedBlackTree<T>(Color.Black, l, v, r);
    }

    public RedBlackTree<T> Insert(T? value) =>
      RedBlackTree<T>.Insert(value, this);


    #endregion

    IEnumerator<T?> System.Collections.Generic.IEnumerable<T?>.GetEnumerator() {
      if (IsEmpty)
        yield break;

      foreach (T? val in Left)
        yield return val;
      yield return Value;
      foreach (T? val in Right)
        yield return val;
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
      ((IEnumerable<T?>)this).GetEnumerator();

    public override string ToString() {
      string colStr = NodeColor == Color.Black ? "B" : "R";
      if (IsEmpty)
        return String.Format("[{0} Empty]", colStr);
      return String.Format("[{0} {1} {2} {3}]", colStr, Left, Value, Right);
    }
  }
}
