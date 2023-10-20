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

// ReSharper disable All


// Loosely based on the algorithm described by Chris Okasaki in his book
// "Purely Functional Data Structures", published by Cambridge University Press.
// The algorithm in question is described in Figure 5.2.
// Used with permission, C# code (C) Copyright 2008-2021 Oliver Sturm <oliver@oliversturm.com>

namespace FCSlib.Data.Collections {
  public sealed class UnbalancedBinaryTree<T> : IEnumerable<T?>,
    IHaveCustomDefaultValue<UnbalancedBinaryTree<T>> {
    public bool IsEmpty { get; init; }

    public UnbalancedBinaryTree<T> Left { get; init; }
    public UnbalancedBinaryTree<T> Right { get; init; }

    public T? Value { get; init; }

    public static readonly UnbalancedBinaryTree<T> Empty = new();

    public UnbalancedBinaryTree<T> DefaultValue => Empty;

    #region Constructors

    public UnbalancedBinaryTree() {
      IsEmpty = true;
      Left = Right = UnbalancedBinaryTree<T>.Empty;
    }

    public UnbalancedBinaryTree(UnbalancedBinaryTree<T> left, T? value,
      UnbalancedBinaryTree<T> right) {
      Left = left;
      Right = right;
      Value = value;
    }

    #endregion

    public static UnbalancedBinaryTree<T> Init(T first, params T[] values) {
      var tree = Insert(first, Empty);
      foreach (var v in values) {
        tree = Insert(v, tree);
      }

      return tree;
    }

    public static UnbalancedBinaryTree<T> Init(IEnumerable<T> source) {
      var sa = source.ToArray();
      if (sa.Length == 0) return Empty;
      var tree = Insert(sa.First(), Empty);
      foreach (var v in sa.Skip(1)) {
        tree = Insert(v, tree);
      }

      return tree;
    }

    public static bool Contains(T? value, UnbalancedBinaryTree<T> tree) {
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
      UnbalancedBinaryTree<T>.Contains(value, this);

    public static UnbalancedBinaryTree<T> Insert(T? value, UnbalancedBinaryTree<T> tree) {
      if (tree.IsEmpty) {
        return new UnbalancedBinaryTree<T>(Empty, value, Empty);
      }
      else {
        int compareResult = Comparer<T>.Default.Compare(value, tree.Value);
        if (compareResult < 0)
          return new UnbalancedBinaryTree<T>(Insert(value, tree.Left), tree.Value, tree.Right);
        else if (compareResult > 0)
          return new UnbalancedBinaryTree<T>(tree.Left, tree.Value, Insert(value, tree.Right));
        else
          return tree;
      }
    }

    public UnbalancedBinaryTree<T> Insert(T? value) =>
      UnbalancedBinaryTree<T>.Insert(value, this);

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

    public override string ToString() =>
      String.Format("[{0} {1} {2}]", Left, IsEmpty ? "Empty" : Value?.ToString(), Right);
  }
}