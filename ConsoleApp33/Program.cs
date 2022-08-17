using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<MyDecodeDochernii> myString = new MyClass<MyDecodeDochernii>();
            myString.Show();
            myString.Set("Aloha");
            myString.Show();
            MyDecode my = myString[0];


            Console.WriteLine(my.Svoistvo);
            Console.ReadKey();
        }
    }
   
    class MyDecode
    {
        public string Svoistvo { get; set; }

        public MyDecode()
        {
            Svoistvo = "null";
        }
    }

    class MyDecodeDochernii : MyDecode
    {

    }


    class MyClass<T> where T : MyDecode, new()
    {
        T[] myList = new T[10];

        public MyClass()
        {
            for(int i = 0; i < myList.Length; i++)
            {
                myList[i] = new T();
                myList[i].Svoistvo = "Привет";
            }
        }

        public void Set(string mystr)
        {
            for (int i = 0; i < myList.Length; i++)
            {
                myList[i].Svoistvo = mystr;
            }
        }

        public void Show()
        {
            for (int i = 0; i < myList.Length; i++)
            {
                Console.WriteLine(myList[i].Svoistvo);
            }
        }

        public T this[int index]
        {
            get
            {
                if(index >= 0 && index < myList.Length)
                {
                    return myList[index];
                }
                else
                {
                    return new T();
                }
            }
        }
    }
}
