using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private int count;
        private int capacity;
        public T[] array;

        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }

        public CustomList()
        {
            count = 0;
            capacity = 2;
            array = new T[capacity];
        }

        public int GetCount()
        {
            foreach(T item in array)
            {
                count += 1;
            }
            return count;
        }

        public void Add(T item)
        {
            if(count < capacity)
            {
                array[count] = item;
                count += 1;
            }
            else
            {
                T[] tempArray = new T[capacity * 2];
                for(int i = 0; i < count; i++)
                {
                    tempArray[i] = array[i];
                }
                tempArray[count] = item;
                array = tempArray;
            }
        }
    }
}
