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
using OmniAPI.Entities;
using OmniAPI.Services.Event;
using UnityEngine;

namespace OmniAPI.Items {
	/// <summary>
	/// Represents an item which may be placed as an entity.
	/// </summary>
    public interface IPlaceableEntity : IItemPlaceable {
        /// <summary>
        /// Check if the entity can be placed into the target holder.
        /// </summary>
        /// <returns><c>true</c>, if holder is acceptable, <c>false</c> otherwise.</returns>
        /// <param name="holder">Holder.</param>
        bool AcceptsHolder(IEntityHolder holder);

		/// <summary>
        /// Spawn this item's entity at the given world vector, as a tile entity.
        /// </summary>
        /// <param name="holder">Holder.</param>
        /// <param name="cause">Cause.</param>
        /// <param name="worldVec">World vec.</param>
		void SpawnEntity(IEntityHolder holder, Cause cause, Vector2 worldVec);
	}
}
