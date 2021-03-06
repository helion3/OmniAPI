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
using OmniAPI.Items;

namespace OmniAPI.Services.Economy {
    /// <summary>
    /// Merchandise builder.
    /// </summary>
    public interface IMerchandiseBuilder : IBuilder {
        /// <summary>
        /// Build the final merchandise object.
        /// </summary>
        Merchandise Build();

        /// <summary>
        /// Sets the buy cost.
        /// (The cost paid *TO* someone selling this item to this merchant.)
        /// </summary>
        /// <returns>The merchandise builder.</returns>
        /// <param name="cost">The cost.</param>
        IMerchandiseBuilder Buy(float cost);

        /// <summary>
        /// Sell the sell cost.
        /// (The price paid *BY* someone buying this item from this merchant.)
        /// </summary>
        /// <returns>The sell.</returns>
        /// <param name="cost">Cost.</param>
        IMerchandiseBuilder Sell(float cost);

        /// <summary>
        /// Set the merchandise item.
        /// </summary>
        /// <returns>The merchandise builder.</returns>
		/// <param name="id">Item id.</param>
        IMerchandiseBuilder SetItem(string id);

		/// <summary>
		/// Sets the merchandise item.
		/// </summary>
		/// <returns>The item.</returns>
		/// <param name="item">Item.</param>
		IMerchandiseBuilder SetItem(IItem item);

        /// <summary>
        /// Sets the quantity.
        /// </summary>
        /// <returns>The merchandise builder.</returns>
        /// <param name="quantity">Quantity.</param>
        IMerchandiseBuilder SetQuantity(int quantity);
    }
}
