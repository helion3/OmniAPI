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
using OmniAPI.Services.Save;

namespace OmniAPI.Services.Mission {
	/// <summary>
	/// Represents the mission manager.
	/// </summary>
    public interface IMissionService : IService, IPersistanceTarget {
		/// <summary>
		/// Activate the specified mission.
		/// </summary>
		/// <returns>The activate.</returns>
		/// <param name="mission">Mission.</param>
		void Activate(IMission mission);

		/// <summary>
		/// Offer the specified mission.
		/// </summary>
		/// <returns>The offer.</returns>
		/// <param name="mission">Mission.</param>
		void Offer(IMission mission);

        /// <summary>
        /// Offer the specified mission with a delay.
        /// </summary>
        /// <returns>The offer.</returns>
        /// <param name="mission">Mission.</param>
        /// <param name="delay">Delay.</param>
        void Offer(IMission mission, float delay);

		/// <summary>
		/// Register a mission type for the given ID. 
		/// </summary>
		/// <param name="missionId">Mission identifier.</param>
		/// <typeparam name="T">The mission type parameter.</typeparam>
		void Register<T>(string missionId) where T : IMission;
	}
}
