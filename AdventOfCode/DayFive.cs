// Copyright 2017 Brian Allred
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

    public class DayFive : Day
    {
        public DayFive(string input) : base(input)
        {
        }

        protected override string PartOne()
        {
            int steps = 0;
            int nextJump = 0;

            int[] jumpList = this.Input.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            while (nextJump < jumpList.Length)
            {
                nextJump += jumpList[nextJump]++;
                steps++;
            }

            return steps.ToString();
        }

        protected override string PartTwo()
        {
            int steps = 0;
            int nextJump = 0;

            int[] jumpList = this.Input.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            while (nextJump < jumpList.Length)
            {
                int currentIndex = nextJump;
                nextJump += jumpList[nextJump];

                if (jumpList[currentIndex] >= 3)
                {
                    jumpList[currentIndex]--;
                }
                else
                {
                    jumpList[currentIndex]++;
                }

                steps++;
            }

            return steps.ToString();
        }
    }
}