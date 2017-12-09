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

    #endregion

    internal class Program
    {
        private static void Main(string[] args)
        {
            DayOne dayOne = new DayOne(Constants.DAY_ONE_INPUT);
            
            // Part one: 1049
            // Part two: 1508
            Console.WriteLine($"Day one: \n{dayOne.Output}\n");

            DayTwo dayTwo = new DayTwo(Constants.DAY_TWO_INPUT);

            // Part one: 42299
            // Part two: 277
            Console.WriteLine($"Day two: \n{dayTwo.Output}\n");

            DayThree dayThree = new DayThree(Constants.DAY_THREE_INPUT);

            // Part one: 438
            // Part two: 266330
            Console.WriteLine($"Day three: \n{dayThree.Output}\n");

            DayFour dayFour = new DayFour(Constants.DAY_FOUR_INPUT);

            // Part one: 386
            // Part two: 208
            Console.WriteLine($"Day four: \n{dayFour.Output}\n");

            DayFive dayFive = new DayFive(Constants.DAY_FIVE_INPUT);

            // Part one: 343364
            // Part two: 25071947
            Console.WriteLine($"Day five: \n{dayFive.Output}\n");

            DaySix daySix = new DaySix(Constants.DAY_SIX_INPUT);

            // Part one: 12841
            // Part two: 8038
            Console.WriteLine($"Day six: \n{daySix.Output}\n");

            Console.ReadKey();
        }
    }
}