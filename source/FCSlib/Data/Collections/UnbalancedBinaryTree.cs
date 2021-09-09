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
// The algorithm in question is described in Figure 5.2.
// Used with permission, C# code (C) Copyright 2008-2021 Oliver Sturm <oliver@oliversturm.com>

namespace FCSlib.Data.Collections {
  public sealed class UnbalancedBinaryTree<T> : IEnumerable<T?>, IHaveCustomDefaultValue<UnbalancedBinaryTree<T>> {
    private readonly bool isEmpty;
    public bool IsEmpty { get { return isEmpty; } }

    private readonly UnbalancedBinaryTree<T> left;
    public UnbalancedBinaryTree<T> Left {
      get {
        return left;
      }
    }
    private readonly UnbalancedBinaryTree<T> right;
    public UnbalancedBinaryTree<T> Right {
      get {
        return right;
      }
    }
    private readonly T? value;
    public T? Value {
      get {
        return value;
      }
    }

    public static readonly UnbalancedBinaryTree<T> Empty = new();

    public UnbalancedBinaryTree<T> DefaultValue => Empty;

    #region Constructors
    public UnbalancedBinaryTree() {
      isEmpty = true;
      this.left = this.right = UnbalancedBinaryTree<T>.Empty;
    }

    public UnbalancedBinaryTree(UnbalancedBinaryTree<T> left, T? value, UnbalancedBinaryTree<T> right) {
      this.left = left;
      this.right = right;
      this.value = value;
    }

    #endregion

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

    public bool Contains(T value) {
      return UnbalancedBinaryTree<T>.Contains(value, this);
    }

    public static UnbalancedBinaryTree<T> Insert(T? value, UnbalancedBinaryTree<T> tree) {
      if (tree.IsEmpty) {
        return new UnbalancedBinaryTree<T>(Empty, value, Empty);
      }
      else {
        int compareResult = Comparer<T>.Default.Compare(value, tree.Value);
        if (compareResult < 0)
          return new UnbalancedBinaryTree<T>(
            Insert(value, tree.Left),
            tree.Value,
            tree.Right);
        else if (compareResult > 0)
          return new UnbalancedBinaryTree<T>(
            tree.Left,
            tree.Value,
            Insert(value, tree.Right));
        else
          return tree;
      }
    }

    public UnbalancedBinaryTree<T> Insert(T? value) {
      return UnbalancedBinaryTree<T>.Insert(value, this);
    }

    IEnumerator<T?> System.Collections.Generic.IEnumerable<T?>.GetEnumerator() {
      if (IsEmpty)
        yield break;

      foreach (T? val in Left)
        yield return val;
      yield return Value;
      foreach (T? val in Right)
        yield return val;
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
      return ((IEnumerable<T?>)this).GetEnumerator();
    }

    public override string ToString() {
      return String.Format("[{0} {1} {2}]", Left, IsEmpty ? "Empty" : Value?.ToString(), Right);
    }
  }
}
