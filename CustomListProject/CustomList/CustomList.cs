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
        public T[] list;

        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }

        public CustomList()
        {
            count = 0;
            capacity = 10;
            list = new T[capacity];
        }

        public int GetCount()
        {
            foreach(T item in list)
            {
                count += 1;
            }
            return count;
        }

        public void Add(T item)
        {
            if(count < capacity)
            {

                count += 1;
            }
            else
            {
                list = new T[capacity + 1];
                
            }
        }
    }
}
