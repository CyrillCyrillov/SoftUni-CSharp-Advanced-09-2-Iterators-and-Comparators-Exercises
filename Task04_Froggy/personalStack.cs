using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task03_Stack
{
    public class personalStack<T> : IEnumerable<T>
    {
        private List<T> elements;

        public personalStack()
        {
            elements = new List<T>();
        }

        public personalStack(List<T> elements)
        {
            this.elements = elements;
        }

        public void Push(T element)
        {
            this.elements.Add(element);
        }

        public T Pop()
        {
            int lastIndex = elements.Count - 1;
            T removedElement = elements[lastIndex];
            this.elements.RemoveAt(lastIndex);
            return removedElement;
        }

        public int NumbersOfElements()
        {
            return elements.Count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = elements.Count - 1; i >= 0; i--)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
