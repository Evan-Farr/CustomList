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
            //mike's comments:
            //List<int> x = new List<int>();
            //x.Count;

            //Customer<int> custom = new Customer<int>();
            //custom.Count;
            CustomList<int> array = new CustomList<int>();
            array.Add(1);
            array.Add(5);
            array.Add(9);
            array.Remove(1);
            //array[10] = 5; // this is where the bug is.

            //CustomList<int> arrayTwo = new CustomList<int>();
            //arrayTwo.Add(1);
            //arrayTwo.Add(5);
            //arrayTwo.Add(9);

            //CustomList<int> zippedArray = array.ZipTo(arrayTwo);
            //List<int> list = new List<int>();
            //list[5] = 3;
        }
    }
}
