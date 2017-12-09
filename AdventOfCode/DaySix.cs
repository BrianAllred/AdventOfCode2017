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
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DaySix : Day
    {
        public DaySix(string input) : base(input)
        {
        }

        protected override string PartOne()
        {
            int cycles = 0;
            HashSet<string> seenSets = new HashSet<string>();
            int[] blocks = this.Input.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            while (seenSets.Add(string.Join(",", blocks)))
            {
                int slot = 0;
                int redistribute = -1;

                for (int x = 0; x < blocks.Length; x++)
                {
                    if (blocks[x] > redistribute)
                    {
                        slot = x;
                        redistribute = blocks[x];
                    }
                }

                blocks[slot] = 0;
                while (redistribute > 0)
                {
                    if (++slot >= blocks.Length)
                    {
                        slot = 0;
                    }

                    blocks[slot]++;
                    redistribute--;
                }

                cycles++;
            }

            return cycles.ToString();
        }

        protected override string PartTwo()
        {
            int cycles = 0;
            Dictionary<string, int> seenSets = new Dictionary<string, int>();
            int[] blocks = this.Input.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            string set = string.Join(",", blocks);
            while (!seenSets.ContainsKey(set))
            {
                seenSets[set] = cycles;
                int slot = 0;
                int redistribute = -1;

                for (int x = 0; x < blocks.Length; x++)
                {
                    if (blocks[x] > redistribute)
                    {
                        slot = x;
                        redistribute = blocks[x];
                    }
                }

                blocks[slot] = 0;
                while (redistribute > 0)
                {
                    if (++slot >= blocks.Length)
                    {
                        slot = 0;
                    }

                    blocks[slot]++;
                    redistribute--;
                }

                cycles++;
                set = string.Join(",", blocks);
            }

            return (cycles - seenSets[set]).ToString();
        }
    }
}