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
    public class DayOne : Day
    {
        public DayOne(string input) : base(input)
        {
        }

        protected override string PartOne()
        {
            int sum = 0;
            int index;

            for (index = 0; index < this.Input.Length - 1; index++)
            {
                if (this.Input[index] == this.Input[index + 1])
                {
                    sum += int.Parse(this.Input[index].ToString());
                }
            }

            if (this.Input[index - 1] == this.Input[0])
            {
                sum += int.Parse(this.Input[0].ToString());
            }

            return sum.ToString();
        }

        protected override string PartTwo()
        {
            int sum = 0;
            int stepSize = this.Input.Length / 2;
            int index;

            for (index = 0; index < this.Input.Length; index++)
            {
                if (this.Input[index] == this.Input[(index + stepSize) % this.Input.Length])
                {
                    sum += int.Parse(this.Input[index].ToString());
                }
            }

            return sum.ToString();
        }
    }
}