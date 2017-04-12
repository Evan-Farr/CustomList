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
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(5);
            list.Add(9);
        }
    }
}
