﻿using System;
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

        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (item.Equals(array[i]))
                {
                    if(array[i].Equals(array[count - 1])) { array[i] = default(T); }
                    Shift(i);
                    count--;
                    return true;
                }
            }
            return false;
        }

        public void Shift(int position)
        {
            for (int j = position; j < count; j++)
            {
                array[j] = array[j + 1];
            }
            array[count - 1] = default(T);
        }

        public CustomList<T> ZipTo(CustomList<T> secondArray)
        {
            CustomList<T> zippedArray = new CustomList<T>();
            int smallest = count <= secondArray.count ? count : secondArray.count;
            for (int i = 0; i < smallest; i++)
            {
                zippedArray.Add(array[i]);
                zippedArray.Add(secondArray[i]);
            }
            return zippedArray;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i < count; i++)
            {
                stringBuilder.Append(array[i].ToString() + "\n");
            }

            return stringBuilder.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //static int GetValueFromArray(T[] array, int i)
        //{
        //    try
        //    {
        //        return array[i];
        //    }
        //    catch (IndexOutOfRangeException ex)
        //    {
        //        ArgumentException argEx = new System.ArgumentException("Index is out of range", "index", ex);
        //        throw argEx;
        //    }
        //}
    }
}
