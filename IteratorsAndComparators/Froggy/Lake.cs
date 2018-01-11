using System.Collections;
using System.Collections.Generic;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> Stones { get; set; }

        public Lake(List<int> stones)
        {
            this.Stones = new List<int>();
            this.Stones = stones;

        }

        public IEnumerator<int> GetEnumerator()
        {
            int length = this.Stones.Count;
            for (int i = 0; i < length; i+=2)
            {
                yield return this.Stones[i];
            }
            var reverseCount = length % 2 == 0 ? length : length - 1;
            for (int i = reverseCount - 1; i >= 0; i -= 2)
            {
                yield return this.Stones[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(", ", this.Stones);
        }
    }
}
