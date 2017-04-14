using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {

            //Customer<int> custom = new Customer<int>();
            //custom.Count;
            //CustomList<int> array = new CustomList<int>();
            //array.Add(1);
            //array.Add(5);
            //array.Add(9);
            //array.Remove(1);
            //array[10] = 5; // this is where the bug is.

            //CustomList<int> arrayTwo = new CustomList<int>();
            //arrayTwo.Add(1);
            //arrayTwo.Add(5);
            //arrayTwo.Add(9);

            //CustomList<int> zippedArray = array.ZipTo(arrayTwo);
            //List<int> list = new List<int>();
            //list[5] = 3;

            //CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            //list.Remove(2);
            //list.Remove(4);

            //CustomList<string> list2 = new CustomList<string>() { "vikings", "bears", "lions", "packers" };
            //list2.Remove("packers");
            //list2.Remove("vikings");

            //CustomList<int> list1 = new CustomList<int>() { 1, 2, 3, 4 };
            //CustomList<int> list2 = new CustomList<int>() { 1, 2, 3, 4 };
            //CustomList<int> thirdList = list1 - list2;

            //CustomList<int> list1 = new CustomList<int>() { 1, 2, 3, 4 };
            //CustomList<int> list2 = new CustomList<int>() { 1, 2, 3, 4 };
            //CustomList<int> thirdList = list1 + list2;

            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3, 4, 4 , 3, 7 };
            list1.Sort();
        }
    }
}
