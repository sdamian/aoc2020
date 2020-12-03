using System;
using System.Linq;

namespace Aoc2020
{
    public static class Bag
    {
        public static T[] ParseInput<T>(string input)
        {
            return input
                .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => (T)Convert.ChangeType(x, typeof(T)))
                .ToArray();
        }
    }
}