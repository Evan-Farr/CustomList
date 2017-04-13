using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T>
    {
        private int count;
        private int capacity;
        public T[] array;

        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } }
        public T this[int i] { get { return array[i]; } set { array[i] = value; } }

        public CustomList()
        {
            count = 0;
            capacity = 5;
            array = new T[capacity];
        }

        public void Add(T item)
        {
            if(count == capacity)
            {
                Grow();
            }
            array[count] = item;
            count++;
        }

        public void Grow()
        {
            T[] tempArray = new T[capacity *= 2];
            for (int i = 0; i < count; i++)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
