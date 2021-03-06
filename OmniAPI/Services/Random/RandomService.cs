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
using UnityEngine;

namespace OmniAPI.Services.Random {
    /// <summary>
    /// Manages seeded random number generators.
    /// </summary>
    public interface IRandomService : IService {
        /// <summary>
        /// Gets the RNG.
        /// 
        /// Note: generators will often use their own RNGs with the current seed.
        /// </summary>
        /// <value>The random.</value>
        System.Random Random { get; }

        /// <summary>
        /// Gets or sets the seed.
        /// </summary>
        /// <value>The seed.</value>
        int Seed { get; set; }

        /// <summary>
        /// Calculates a chunk seed.
        /// </summary>
        /// <returns>The chunk seed.</returns>
        /// <param name="chunkX">Chunk X.</param>
        /// <param name="chunkY">Chunk Y.</param>
        int CalculateChunkSeed(int chunkX, int chunkY);
    }
}
