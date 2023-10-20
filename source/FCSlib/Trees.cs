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

using FCSColl = FCSlib.Data.Collections;

namespace FCSlib {
  public static partial class Functional {
    // UnbalancedBinaryTree<T>
    public static FCSColl::UnbalancedBinaryTree<T> UnbalancedBinaryTree<T>() =>
      FCSColl::UnbalancedBinaryTree<T>.Empty;

    public static FCSColl::UnbalancedBinaryTree<T> UnbalancedBinaryTree<T>(T value) =>
      FCSColl::UnbalancedBinaryTree<T>.Insert(value, FCSColl::UnbalancedBinaryTree<T>.Empty);

    public static FCSColl::UnbalancedBinaryTree<T>
      UnbalancedBinaryTree<T>(T first, params T[] values) =>
      FCSColl::UnbalancedBinaryTree<T>.Init(first, values);

    public static FCSColl::UnbalancedBinaryTree<T> UnbalancedBinaryTree<T>(IEnumerable<T> values) =>
      FCSColl::UnbalancedBinaryTree<T>.Init(values);

    // RedBlackTree<T>
    public static FCSColl::RedBlackTree<T> RedBlackTree<T>() => FCSColl::RedBlackTree<T>.Empty;

    public static FCSColl::RedBlackTree<T> RedBlackTree<T>(T value) =>
      FCSColl::RedBlackTree<T>.Insert(value, FCSColl::RedBlackTree<T>.Empty);

    public static FCSColl::RedBlackTree<T> RedBlackTree<T>(T first, params T[] values) =>
      FCSColl::RedBlackTree<T>.Init(first, values);

    public static FCSColl::RedBlackTree<T> RedBlackTree<T>(IEnumerable<T> values) =>
      FCSColl::RedBlackTree<T>.Init(values);

    // Default tree = RedBlackTree<T>
    public static FCSColl::RedBlackTree<T> Tree<T>() => RedBlackTree<T>();
    public static FCSColl::RedBlackTree<T> Tree<T>(T value) => RedBlackTree<T>(value);

    public static FCSColl::RedBlackTree<T> Tree<T>(T first, params T[] values) =>
      RedBlackTree<T>(first, values);

    public static FCSColl::RedBlackTree<T> Tree<T>(IEnumerable<T> values) =>
      RedBlackTree<T>(values);
  }
}