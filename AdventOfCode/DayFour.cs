using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    using System.Linq;

    public class DayFour:Day
    {
        public DayFour(string input) : base(input)
        {
        }

        protected override string PartOne()
        {
            string[] phrases = this.Input.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = phrases.Select(phrase => phrase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList()).Count(words => words.Distinct().Count() == words.Count);

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
