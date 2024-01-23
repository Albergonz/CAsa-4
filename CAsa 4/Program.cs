using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAsa_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cerchio cerchio = new Cerchio();
            cerchio.Raggio = int.Parse(Console.ReadLine());
            Console.WriteLine("A:{0}", cerchio.Area());
            Console.WriteLine("A:{0}", cerchio.Circonferenza());



        }
    }
}
