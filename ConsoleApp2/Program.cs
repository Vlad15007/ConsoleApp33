using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Child<X1, x, X2, y> where X1 : X2, y
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Child<int, string, int, int> child = new Child<int, string, int, int>();

        }
    }
}
