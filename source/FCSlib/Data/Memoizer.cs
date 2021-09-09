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


namespace FCSlib.Data {
  public static class Memoizer<P, R> where P : notnull {
    static object memoryListLock = new();
    static Dictionary<string, IMemory<P, R>>? memories;
    static Dictionary<string, IMemory<P, R>> Memories {
      get {
        lock (memoryListLock) {
          if (memories == null)
            memories = new Dictionary<string, IMemory<P, R>>();
          return memories;
        }
      }
    }
    public static T CreateMemory<T>(string key) where T : IMemory<P, R>, new() {
      var mems = Memories;
      if (mems.ContainsKey(key))
        throw new InvalidOperationException("The memory key '" + key + "' is already in use.");
      lock (memoryListLock) {
        T memory = new();
        mems[key] = memory;
        return memory;
      }
    }
    public static IMemory<P, R> CreateMemory(string key) {
      return CreateMemory<Memory<P, R>>(key);
    }
    public static IMemory<P, R> GetMemory(string key) {
      if (!(Memories.ContainsKey(key)))
        return CreateMemory(key);
      return Memories[key];
    }
  }
}