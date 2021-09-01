// Copyright (C) 2008-2016 Oliver Sturm <oliver@oliversturm.com>
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
  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FCSlib {
  public sealed class Lazy<T> {
    public Lazy(Func<T?> function) {
      this.function = function;
    }

    public Lazy(T value) {
      this.value = value;
    }

    readonly Func<T?>? function;
    T? value;
    bool forced;
    object forceLock = new object( );
    Exception? exception;

    public T? Force( ) {
      lock (forceLock) {
        return UnsynchronizedForce( );
      }
    }

    public T? UnsynchronizedForce( ) {
      if (exception != null)
        throw exception;
      if (function != null && !forced) {
        try {
          value = function( );
          forced = true;
        }
        catch (Exception ex) {
          this.exception = ex;
          throw;
        }
      }
      return value;
    }

    public T? Value {
      get { return Force( ); }
    }

    public bool IsForced {
      get { return forced; }
    }

    public bool IsException {
      get { return exception != null; }
    }

    public Exception? Exception {
      get { return exception; }
    }
  }
}
