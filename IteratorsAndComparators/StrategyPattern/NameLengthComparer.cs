using System.Collections.Generic;

namespace StrategyPattern
{
    public class NameLengthComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var xLength = x.Name.Length;
            var yLength = y.Name.Length;
            if (xLength != yLength)
            {
                return xLength.CompareTo(yLength);
            }
            var xFirstLetter = x.Name.Substring(0, 1).ToLower();
            var yFirstLetter = y.Name.Substring(0, 1).ToLower();
            return xFirstLetter.CompareTo(yFirstLetter);
        }
    }
}
