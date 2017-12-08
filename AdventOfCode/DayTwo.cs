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
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    public class DayTwo : Day
    {
        public DayTwo(string input) : base(input)
        {
        }

        protected override string PartOne()
        {
            string[] lines = this.Input.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = lines.
                Select(line =>
                    line.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList()).
                Select(nums => nums.Max() - nums.Min()).
                Sum();

            return sum.ToString();
        }

        protected override string PartTwo()
        {
            int sum = 0;

            string[] lines = this.Input.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                int[] nums = line.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).
                    ToArray();

                for (int x = 0; x < nums.Length; x++)
                {
                    for (int y = 0; y < nums.Length; y++)
                    {
                        if (x == y)
                        {
                            continue;
                        }

                        if (nums[x] % nums[y] == 0)
                        {
                            sum += nums[x] / nums[y];

                            // break inner and outer loops
                            x += nums.Length;
                            break;
                        }
                    }
                }
            }

            return sum.ToString();
        }
    }
}