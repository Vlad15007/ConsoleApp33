using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IMyjsoiXY 
    {
        void Math();
    }
    interface IJenskiXX 
    {
        void Draw();
    }


    class DNA: IMyjsoiXY, IJenskiXX
    {
        public string Svoistva { get; set; }

        public void Math()
        {

        }

        public void Draw()
        {

        }
    }

    class DnaClone : DNA
    {

    }


    class Child<XxXy> where XxXy : IMyjsoiXY, IJenskiXX, new()
    {
        XxXy dna;
        public Child()
        {
            this.dna = new XxXy();
        }
    }

    class Child2<X> where X : IMyjsoiXY
    {
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Child<DnaClone> myChado = new Child<DnaClone>();


        }
    }
}
