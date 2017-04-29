using System;

namespace DefiningClasses2
{
    public class GenericList<T>
        where T : IComparable
    {
        private const int initialCapacity = 4;
        private int capacity = initialCapacity;
        private T[] elements;

        public int Count { get; private set; }

        public GenericList()
        {
            Count = 0;
            elements = new T[initialCapacity];
        }

        public void Add(T item)
        {
            if (Count == capacity)
            {
                AutoGrow();
            }
            elements[Count] = item;
            Count++;
        }

        public T Access(int index)
        {
            if (isIndexValid(index) == false)
            {
                InvalidIndex();
            }
            T output = elements[index];
            return output;
        }

        public void Remove(int index)
        {
            if (isIndexValid(index) == false)
            {
                InvalidIndex();
            }
            elements[index] = default(T);
        }

        public void Insert(T item, int index)
        {
            if (isIndexValid(index) == false)
            {
                InvalidIndex();
            }
            elements[index] = item;
        }

        public void Clear()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = default(T);
            }
        }

        public int Find(T item)
        {
            int index = -1;
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (elements[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public override string ToString()
        {
            string output = "";
            foreach (T item in elements)
            {
                output += item;
            }
            return output;
        }

        private bool isIndexValid(int index)
        {
            bool output = true;
            if (index > capacity)
            {
                output = false;
            }
            return output;
        }

        private void InvalidIndex()
        {
            throw new IndexOutOfRangeException("Invalid Index!");
        }

        private void AutoGrow()
        {
            T[] newElements = new T[2 * capacity];
            capacity *= 2;
            for (int i = 0; i < elements.Length; i++)
            {
                newElements[i] = elements[i];
            }
            elements = newElements;
        }

        public T Min()
        {
            T min = this.elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (min.CompareTo(this.elements[i]) > 0)
                {
                    min = this.elements[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = this.elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (max.CompareTo(this.elements[i]) < 0)
                {
                    max = this.elements[i];
                }
            }
            return max;
        }
    }
}
