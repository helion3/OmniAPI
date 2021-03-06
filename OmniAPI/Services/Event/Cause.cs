﻿/**
 * This file is part of OmniAPI, licensed under the MIT License (MIT).
 *
 * Copyright (c) 2017 Helion3 http://helion3.com/
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */
using OmniAPI.Util;
using System.Collections.Generic;

namespace OmniAPI.Services.Event {
	/// <summary>
	/// Represents the cause chain of an event.
	/// </summary>
	public class Cause {
		readonly List<object> causes = new List<object>();

		/// <summary>
		/// Initializes a new instance of the <see cref="T:OmniAPI.Cause"/> class.
		/// </summary>
		/// <param name="cause">Cause.</param>
		public Cause(object cause) {
			Add(cause);
		}

		/// <summary>
		/// Add a new cause entry.
		/// </summary>
		/// <returns>The cause.</returns>
		/// <param name="cause">Cause.</param>
		public Cause Add(object cause) {
			causes.Add(cause);

			return this;
		}

		/// <summary>
		/// Get the entire cause chain.
		/// </summary>
		/// <returns>All causing objects.</returns>
		public List<object> All() {
			return causes;
		}

		/// <summary>
		/// Get the first cause matching the given type.
		/// </summary>
		/// <returns>The first.</returns>
		/// <typeparam name="T">Cause type.</typeparam>
		public Optional<T> First<T>() {
			var t = typeof(T);
			foreach (object c in causes) {
				if (t.IsAssignableFrom(c.GetType())) {
					return Optional<T>.From((T) c);
				}
			}

			return Optional<T>.Empty();
		}

		/// <summary>
		/// Create a new cause from the specified object.
		/// </summary>
		/// <returns>The cause.</returns>
		/// <param name="cause">Object.</param>
		public static Cause Of(object cause) {
			return new Cause(cause);
		}
	}
}
