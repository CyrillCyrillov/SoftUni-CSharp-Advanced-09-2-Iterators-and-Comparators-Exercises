using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task04_Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;
        

        public Lake()
        {
            stones = new List<int>();
        }

        public Lake(List<int> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i <= stones.Count - 1; i += 2)
            {
                yield return stones[i];
            }

            int helpVar = -1;
            if (stones.Count % 2 == 0) helpVar = stones.Count - 1;
            else helpVar = stones.Count - 2;


            for (int i = helpVar; i >= 0; i -= 2)
            {
                yield return stones[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
