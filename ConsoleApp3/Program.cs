using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("Привет", "Нихао");
            dic.Add("Пока", "Сайонара");

            Console.WriteLine(dic.ContainsKey("Привет"));


            KeyValuePair<string, string> myRes = dic.FirstOrDefault(x => x.Key == "Привет");
            Console.WriteLine(myRes.Value);

            Console.ReadKey();
        }
    }
}
