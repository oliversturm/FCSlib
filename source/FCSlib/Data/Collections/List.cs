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
// The algorithm in question is described in Figure 2.2.
// Used with permission, C# code (C) Copyright 2008-2021 Oliver Sturm <oliver@oliversturm.com>

namespace FCSlib.Data.Collections {
  public sealed class List<T> : System.Collections.Generic.IEnumerable<T>,
    IHaveCustomDefaultValue<List<T>> {
    #region Head, Tail and IsEmpty

    private readonly T? head;
    private readonly List<T> tail;
    public bool IsEmpty { get; init; } = false;

    public T Head {
      get {
        if (IsEmpty)
          throw new InvalidOperationException("No head in an empty list");
        return head ?? throw new InvalidOperationException("Head uninitialized");
      }
    }

    public List<T> Tail {
      get {
        if (IsEmpty)
          throw new InvalidOperationException("No tail in an empty list");
        return tail;
      }
    }

    public static readonly List<T> Empty = new();

    public List<T> DefaultValue => Empty;

    #endregion

    #region Cons

    public static List<T> Cons(T element, List<T> list) =>
      list.IsEmpty ? new List<T>(element) : new List<T>(element, list);

    public List<T> Cons(T element) =>
      List<T>.Cons(element, this);

    #endregion

    #region Appending

    // This recursive implementation is of course much more elegant,
    // but can result in stack overflows when the 'one' list is long
    // Wonder if tail recursion is more generally available
    // in C# now than it used to be, and where CPS could make
    // this possible here?
    public static List<T> AppendWithRecursion(List<T> one, List<T> other) =>
      one.IsEmpty ? other : Cons(one.Head, AppendWithRecursion(one.Tail, other));

    public static List<T> Append(List<T> one, List<T> other) {
      if (one.IsEmpty)
        return other;
      List<T> newList = other;

      foreach (var element in one.Reverse())
        newList = newList.Cons(element);

      return newList;
    }

    public List<T> Append(List<T> other) =>
      List<T>.Append(this, other);

    public List<T> AppendWithRecursion(List<T> other) =>
      List<T>.AppendWithRecursion(this, other);

    #endregion

    #region Remove

    public static List<T> Remove(List<T> list, T element) {
      var memory = List<T>.Empty;
      var temp = list;
      while (!temp.IsEmpty &&
             !System.Collections.Generic.EqualityComparer<T>.Default.Equals(temp.Head, element)) {
        memory = memory.Cons(temp.Head);
        temp = temp.Tail;
      }

      if (!temp.IsEmpty) {
        // forget the element itself
        temp = temp.Tail;
        // prepend the items we pushed aside
        foreach (var item in memory) {
          temp = temp.Cons(item);
        }

        return temp;
      }
      else
        // element wasn't found
        return list;
    }

    public List<T> Remove(T element) =>
      List<T>.Remove(this, element);

    #endregion

    #region Constructors

    public List(T head, List<T> tail) {
      this.head = head;
      this.tail = tail.IsEmpty ? List<T>.Empty : tail;
    }

    public List(T head) : this(head, List<T>.Empty) { }

    public List(T firstValue, params T[] values) {
      head = firstValue;
      if (values.Length > 0) {
        List<T> newtail = List<T>.Empty;
        for (int i = values.Length - 1; i >= 0; i--)
          newtail = newtail.Cons(values[i]);
        tail = newtail;
      }
      else
        tail = List<T>.Empty;
    }

    private List() {
      IsEmpty = true;
      // this.head is null in this case
      this.tail = List<T>.Empty;
    }

    public List(System.Collections.Generic.IEnumerable<T> source) {
      T[] sa = source.ToArray();
      int sal = sa.Length;
      if (sal > 0) {
        head = sa[0];
        tail = List<T>.Empty;
        for (int i = sal - 1; i > 0; i--)
          tail = tail.Cons(sa[i]);
      }
      else {
        IsEmpty = true;
        // this.head is null in this case
        this.tail = List<T>.Empty;
      }
    }

    #endregion

    #region IEnumerable support

    public System.Collections.Generic.IEnumerator<T> GetEnumerator() {
      for (var element = this; element != List<T>.Empty; element = element.Tail)
        yield return element.Head;
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
      this.GetEnumerator();

    #endregion

    #region ToString - for debug purposes

    public override string ToString() {
      var result = "[";
      if (!IsEmpty)
        result += Functional.FoldL1((r, x) => r + ", " + x,
          Functional.Map(x => x?.ToString(), this));
      result += "]";
      return result;
    }

    #endregion
  }
}