using System;
using System.Linq;

namespace Aoc2020
{
    public static class Toolbox
    {
        public static T[] ParseInput<T>(string input)
        {
            var items = input
                .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => (T)Convert.ChangeType(x, typeof(T)))
                .ToArray();

            return items;
        }
    }
}