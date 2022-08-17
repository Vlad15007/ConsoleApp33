using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("уву");
            arrayList.Add((object)2);

            foreach(object obj in arrayList)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();

            List<string> list = new List<string>();

            list.Add("ASD");
            list.Add("ABC");
            list.Add("BBC");
            list.Add("XXX");

            Console.ReadKey();
        }
    }
}
