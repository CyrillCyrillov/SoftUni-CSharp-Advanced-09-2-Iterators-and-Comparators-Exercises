using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> dataList;
        private int index;

        public ListyIterator(List<T> dataList)
        {
            this.dataList  = dataList;
            this.index = 0;

        }

        public ListyIterator(params T[] dataList)
        {
            this.dataList = dataList.ToList();
            this.index = 0;

        }

        public bool HasNext()
        {
            if(index < dataList.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Move()
        {
            if (index < dataList.Count - 1)
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Print()
        {
            if(dataList.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(dataList[index]);
            }

        }

        public void PrintAll()
        {
            if (dataList.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(string.Join(' ', dataList));
            }

        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T element in dataList)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
