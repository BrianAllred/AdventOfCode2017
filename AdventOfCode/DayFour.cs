﻿// Copyright 2017 Brian Allred
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

namespace AdventOfCode
{
    #region Using

    using System;
    using System.Linq;

    #endregion

    public class DayFour : Day
    {
        public DayFour(string input) : base(input)
        {
        }

        protected override string PartOne()
        {
            string[] phrases = this.Input.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = phrases.
                Select(phrase => phrase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList()).
                Count(words => words.Distinct().Count() == words.Count);

            return sum.ToString();
        }

        protected override string PartTwo()
        {
            // This one is backwards. Count invalid, then subtract it from total.
            int sum = 0;

            string[] phrases = this.Input.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string phrase in phrases)
            {
                string[] words = phrase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int x = 0; x < words.Length - 1; x++)
                {
                    for (int y = x + 1; y < words.Length; y++)
                    {
                        string strX = string.Concat(words[x].OrderBy(c => c));
                        string strY = string.Concat(words[y].OrderBy(c => c));

                        if (strX == strY)
                        {
                            sum++;
                            x += words.Length;
                            break;
                        }
                    }
                }
            }

            return (phrases.Length - sum).ToString();
        }
    }
}